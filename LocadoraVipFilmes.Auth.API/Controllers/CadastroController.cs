using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Enums;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly ICreateUserRepository _createUserRepository;

        public CadastroController(ICreateUserRepository usuarioRepository)
        {
            _createUserRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUsuarioDTO createUsuario)
        {
            Result result = _createUserRepository.CadastrarUsuario(createUsuario);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok(result.Successes[0]);
        }

        [HttpGet("/Valida/{username}")]
        public async Task<IActionResult> ValidarUsuarioExistente(string username)
        {
            Result result = await _createUserRepository.GetUserByName(username);

            if(result.IsFailed)
                return Ok(result.Errors[0]);

            return Ok(result.Successes[0]);
        }

        [HttpGet("/Ativa")]
        public IActionResult AtivarContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result result = _createUserRepository.AtivarContaUsuario(request);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok(result.Successes[0]);
        }

    }
}