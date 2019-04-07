using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RbPrinters.Api.Common.Constants;
using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.Contracts.Models.Request;
using RbPrinters.Api.Interfaces.Repositories;
using RbPrinters.Api.Interfaces.Services;
using RbPrinters.Api.Services.Abstracts;
using RbPrinters.Api.Services.JWTServices;
using RbPrinters.Api.Services.Utilities;

namespace RbPrinters.Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        #region globle objects
        private readonly IBaseRepository<User> _user;
        private readonly IAuthenticationServices _authenticationServices;
        #endregion

        #region Constructor
        public AccountController(IBaseRepository<User> user, IAuthenticationServices authenticationServices)
        {
            _user = user;
            _authenticationServices = authenticationServices;
        }
        #endregion

        #region Web API's
        /// <summary>
        /// User Authentication
        /// </summary>
        /// <param name="login">Username(Phone number only) and password</param>
        /// <returns>Token</returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] Login login)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var oUser = _authenticationServices.ValidateUser(login.UserName.Trim(), login.Password);
            if (oUser != null)
            {
                var token = _authenticationServices.GetToken(oUser);
                return new JsonResult(token);
            }
            else
            {
                return BadRequest(CommonMessage.INVALID_USERNAME_PASSWORD);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return Ok("Hello !");
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok("Users");
        }
        #endregion

        #region helpers
        #endregion
    }
}