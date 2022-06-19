using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        public CadastroController()
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult CreateUser()
        {

            return Ok();
        }
    }
}