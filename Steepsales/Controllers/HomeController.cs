using Microsoft.AspNetCore.Mvc;
using Steepsales.Models.EntityFramework;
using System.IO;
using System.Linq;

namespace Steepsales.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db= db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Choice()
        {
            return View(db.ProductItems.ToList());
        }
    }
}
