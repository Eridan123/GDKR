using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Gkdr.Consumer.Data;
using Gkdr.Consumer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Consumer.Controllers
{
    [Authorize]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;

        public LogController(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }
        
        [HttpPost("loglist")]
        public async Task<ActionResult> List(Datatable datatable)
        {
            var currentUserName = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            var currentUser = _userService.GetByUserName(currentUserName);
            
            // var currentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value;
            // var currentUser = _userService.GetById(Convert.ToInt32(currentUserId));
            
            var logs = _appDbContext.GDKRLogs.AsQueryable();
            var resp = new DataTableResponce {filter = new List<string>()};
            
            if (currentUser.IsAdmin)
            {
                var users = _appDbContext.Users
                    .Select(p => new {Username = p.UserName, Name = p.FirstName + " " + p.LastName})
                    .ToDictionary(x => x.Username, x => x.Name);

                var query = (from log in logs
                        orderby log.Id descending 
                        select new
                        {
                            Id = log.Id,
                            EntityId = log.EntityId,
                            EntityName = log.EntityName ?? "Login",
                            DateTime = log.DateTime.ToString("dd.MM.yyyy HH:mm:ss"),
                            Username = users[log.Username],
                            ActionType = log.ActionType,
                            Details = log.Details
                        }
                    );
                var dir = datatable.order[0].dir.Equals("asc");
                var prop = datatable.columns[datatable.order[0].column].name;

                resp.draw = datatable.draw;
                resp.recordsTotal = query.Count();
                resp.recordsFiltered = query.Count();
                resp.data = query.Skip(datatable.start).Take(datatable.length).ToList();
                return Ok(resp);

            }
            else
            {
                var query =
                    from log in logs
                        .Where(s => s.Username.Equals(currentUser.UserName))
                    orderby log.Id descending
                    select new
                    {
                        Id = log.Id,
                        EntityId = log.EntityId,
                        EntityName = log.EntityName ?? "Login",
                        DateTime = log.DateTime.ToString("dd.MM.yyyy HH:mm:ss"),
                        Username = currentUser.FirstName + " " + currentUser.LastName,
                        ActionType = log.ActionType
                    };
                resp.draw = datatable.draw;
                resp.recordsTotal = query.Count();
                resp.recordsFiltered = query.Count();
                resp.data = query.Skip(datatable.start).Take(datatable.length).ToList();

                return Ok(resp);
            }
        }
    }
}