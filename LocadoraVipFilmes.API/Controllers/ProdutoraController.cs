using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class ProdutoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
