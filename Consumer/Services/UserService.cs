using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Gkdr.Consumer.Data;
using Gkdr.Consumer.Data.AppModel;
using Gkdr.Consumer.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Gkdr.Consumer.Services
{
    public interface IUserService
    {
        UserDto Authenticate(string username, string password);
        public DataTableResponce GetAll(Datatable datatable);
        bool ChangePassword(PasswordDto passwordDto, string user);

        User GetById(int id);
        User GetByUserName(string userName);
        bool Create(UserDto user);
        bool Edit(UserDto user);
    }

    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly AppDbContext _context;

        public UserService(IOptions<AppSettings> appSettings, AppDbContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public UserDto Authenticate(string username, string password)
        {
            var cryptedPassword = Crypto.MD5_hash(password);

            var user = _context.Users
                .AsNoTracking()
                .Where(x => x.UserName == username && x.Password == cryptedPassword)
                .Select(s => new UserDto
                {
                    UserName = s.UserName,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    IsAdmin = s.IsAdmin
                })
                .FirstOrDefault();

            if (user == null)
                return null;

            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var key = _appSettings.Secret;
            var now = DateTime.UtcNow;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                notBefore: now,
                claims: claimsIdentity.Claims,
                expires: now.Add(TimeSpan.FromDays(AuthOptions.Lifetime)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256));
            var userToken = new JwtSecurityTokenHandler().WriteToken(jwt);

            user.Token = userToken;

            return user;
        }
        
        public User GetById(int id)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Id == id);
            return user;
        }
        
        public User GetByUserName(string userName)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.UserName.Equals(userName));
            return user;
        }

        public DataTableResponce GetAll(Datatable datatable)
        {
            return _context.Users
                .AsNoTracking()
                .CreateDataTable(datatable);
        }

        public bool Create(UserDto user)
        {
            if (_context.Users.Count(usr => usr.UserName == user.UserName) != 0)
                return false;

            var u = new User
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = Crypto.MD5_hash("user123"),
                IsAdmin = false
            };
            _context.Add(u);
            _context.SaveChanges();
            
            return true;
        }

        public bool Edit(UserDto user)
        {
            var usr = _context.Users.FirstOrDefault(u => u.UserName.Equals(user.UserName));
            
            if (usr == null) return false;
            
            usr.FirstName = user.FirstName;
            usr.LastName = user.LastName;
            _context.SaveChanges();
            return true;
        }
        
        public bool ChangePassword(PasswordDto passwordDto, string usr)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.UserName == usr);

            if (user != null && Crypto.MD5_hash(passwordDto.OldPassword).Equals(user.Password))
            {
                user.Password = Crypto.MD5_hash(passwordDto.NewPassword);
                _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
