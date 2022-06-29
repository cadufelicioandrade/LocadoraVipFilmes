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
        private readonly ICreateUserRepository _usuarioRepository;

        public CadastroController(ICreateUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUsuarioDTO createUsuario)
        {
            Result result = _usuarioRepository.CadastrarUsuario(createUsuario);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok(result.Successes[0]);
        }

        [HttpGet("/Ativa")]
        public IActionResult AtivarContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result result = _usuarioRepository.AtivarContaUsuario(request);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok(result.Successes[0]);
        }

    }
}