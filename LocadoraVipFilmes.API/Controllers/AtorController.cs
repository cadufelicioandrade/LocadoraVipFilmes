﻿using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class AtorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
