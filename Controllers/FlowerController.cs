using FlowerShop_Management.Data;
using FlowerShop_Management.Models.Flowers;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop_Management.Controllers
{
    public class FlowerController : Controller
    {
        private readonly FlowerDbContext _context;
        public FlowerController(FlowerDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddFlowerViewModel model)
        {
            return View();
        }
    }
}
