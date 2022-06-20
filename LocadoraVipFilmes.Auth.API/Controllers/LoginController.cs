using FluentResults;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpPost]
        public IActionResult Index([FromBody] LoginRequest request)
        {
            Result result = _loginRepository.Login(request);

            if (result.IsFailed)
                return Unauthorized(result.Errors);

            return Ok(result.Successes[0].Message);
        }

    }
}
