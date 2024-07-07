using JWTImplementation.Interfaces;
using JWTImplementation.Models;
using JWTImplementation.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authServices;

        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;
        }
        [HttpPost]
        public string Login([FromBody]LoginRequest loginRequest)
        {
            var result=_authServices.Login(loginRequest);

            return result;
        }

        [HttpPost("AddUser")]
        public User AddUser([FromBody] User user)
        {
            var users=_authServices.AddUser(user);

            return users;
        }
    }
}
