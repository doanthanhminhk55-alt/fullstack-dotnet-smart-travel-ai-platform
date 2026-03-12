using Microsoft.AspNetCore.Mvc;
using UserService.Services;

namespace UserService.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllersBase
    {
        private readonly JwtService jwt;

        public AuthController()
        {
            _jwt = new JwtService();
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            var token = _jwt.GenerateToken("123");

            return Ok(new
            {
                token = token
            });
        }
    }
}