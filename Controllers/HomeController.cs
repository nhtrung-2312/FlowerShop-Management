﻿using Microsoft.AspNetCore.Mvc;

namespace FlowerShop_Management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
