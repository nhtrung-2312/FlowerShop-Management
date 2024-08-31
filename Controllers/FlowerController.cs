using FlowerShop_Management.Data;
using FlowerShop_Management.Models.Flowers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop_Management.Controllers
{
    public class FlowerController : Controller
    {
        private readonly FlowerDbContext _context;
        public FlowerController(FlowerDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var flowers = await _context.Flowers.ToListAsync();

            return View(flowers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Flower model)
        {
            model.Flower_ID = FlowerIDGenerated();

            await _context.Flowers.AddAsync(model);
            await _context.SaveChangesAsync();

            return Redirect("./Index");
        }
        [HttpGet]
        public IActionResult Edit(string ID)
        {
            var flower = _context.Flowers.Where(f => f.Flower_ID == ID);
            if(flower == null)
            {
                return Redirect("./Index");
            }
            return View(flower);
        }
        public string FlowerIDGenerated()
        {
            Random rd = new Random();
            string id;
            do
            {
                int number = rd.Next(1, 99999);
                id = $"F{number:D5}";
            } while (_context.Flowers.Any(f => f.Flower_ID == id));

            return id;
        }
    }
}
