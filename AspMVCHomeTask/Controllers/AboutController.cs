using Microsoft.AspNetCore.Mvc;

namespace AspMVCHomeTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
