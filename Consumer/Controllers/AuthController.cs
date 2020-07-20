using System.Threading.Tasks;
using Gkdr.Consumer.Data;
using Gkdr.Consumer.Data.AppModel;
using Gkdr.Consumer.Helpers;
using Gkdr.Consumer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gkdr.Consumer.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _appDbContext;

        public AuthController(IUserService userService, AppDbContext appDbContext)
        {
            _userService = userService;
            _appDbContext = appDbContext;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.UserName, model.Password);

            if (user == null)
                return new ErrorResponse("Username or password is incorrect");

            GDKRLog log = new GDKRLog();
            log.Username = user.UserName;
            log.ActionType = ActionType.Login;
            log.DateTime = System.DateTime.Now;
            _appDbContext.GDKRLogs.AddAsync(log);
            _appDbContext.SaveChanges();

            return Ok(user);
        }
        
        [HttpGet("user/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost("users")]
        public IActionResult Get(Datatable datatable)
        {
            return Ok(_userService.GetAll(datatable));
        }
        
        [HttpPost("user/create")]
        public async Task<IActionResult> Create(UserDto user)
        {
            if(_userService.Create(user))
                return new SuccessResponse(ApplicationConstants.SuccessRecordInserted);
            return new ErrorResponse(ApplicationConstants.ErrorUserExist);
        }

        [HttpPost("user/edit/{id}")]
        public async Task<IActionResult> UserEdit(UserDto user)
        {
            if(_userService.Edit(user))
                return new SuccessResponse(ApplicationConstants.SuccessRecordUpdates);
            return new ErrorResponse(ApplicationConstants.ErrorUserError);
        }
        
        [HttpPost("changePassword")]
        public IActionResult ChangePassword(PasswordDto passwordDto)
        {
            if (_userService.ChangePassword(passwordDto, User.Identity.Name))
            {
                return new SuccessResponse(ApplicationConstants.SuccessPasswordChanged);
            }
            
            return new ErrorResponse(ApplicationConstants.ErrorPasswordChanged);
        }
    }
}