using AspMVCHomeTask.Data;
using AspMVCHomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspMVCHomeTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<SliderImage> slidersimages = await _context.SliderImages.ToListAsync();
            return View();
        }

    }
}

