using FluentResults;
using LocadoraVipFilmes.Auth.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;

        public LogoutController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpPost]
        public IActionResult Logout()
        {
            Result result = _loginRepository.Logout();

            if (result.IsFailed)
                return Unauthorized(result.Errors);

            return Ok();
        }
    }
}
