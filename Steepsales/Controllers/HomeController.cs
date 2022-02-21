using Microsoft.AspNetCore.Mvc;

namespace Steepsales.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
    }
}
