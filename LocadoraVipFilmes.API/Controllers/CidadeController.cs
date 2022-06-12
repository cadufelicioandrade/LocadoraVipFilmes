using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
