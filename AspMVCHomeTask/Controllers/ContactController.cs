using Microsoft.AspNetCore.Mvc;

namespace AspMVCHomeTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
