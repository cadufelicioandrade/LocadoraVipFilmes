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
                return Unauthorized(result.Errors[0]);

            return Ok(result.Successes[0]);
        }

        [HttpPost("/recupera-senha")]
        public IActionResult RecuperarSenha([FromBody] RecuperaSenhaRequest request)
        {
            Result result = _loginRepository.RecuperarSenha(request);

            if (result.IsFailed)
                return Unauthorized(result.Errors[0]);

            return Ok(result.Successes[0]);
        }

        [HttpPost("/reset-senha")]
        public IActionResult EfetuarResetSenha([FromBody] ResetSenhaRequest request)
        {
            Result result = _loginRepository.EfetuarResetSenha(request);

            if (result.IsFailed)
                return Unauthorized(result.Errors[0]);

            return Ok(result.Successes[0]);
        }
    }
}
