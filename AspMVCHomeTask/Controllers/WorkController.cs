using Microsoft.AspNetCore.Mvc;

namespace AspMVCHomeTask.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
