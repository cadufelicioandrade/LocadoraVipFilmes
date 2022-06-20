using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public CadastroController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUsuarioDTO createUsuario)
        {
            Result result = _usuarioRepository.CadastrarUsuario(createUsuario);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok();
        }
    }
}