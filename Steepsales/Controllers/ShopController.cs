using Microsoft.AspNetCore.Mvc;
using Steepsales.Models.EntityFramework;
using Steepsales.Models;
using System;
using System.Linq;

namespace Steepsales.Controllers
{
    public class ShopController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext db;
        public ShopController(DataManager dataManager, AppDbContext db)
        {
            this.dataManager = dataManager;
            this.db = db;
        }
        public IActionResult Catalog(Guid id)
        {
            if (id != default)
            {
                return View("ShowTovar", dataManager.ProductItem.GetProductItemById(id));
            }
            return View(db.ProductItems.ToList());
        }
        [HttpPost]
        public IActionResult Select(int param)
        {
            if (param == 1)
            {
                return View("Catalog", db.ProductItems.Where(x => x.FirmId == 1).ToList());
            }
            else if (param == 2)
            {
                return View("Catalog", db.ProductItems.Where(x => x.FirmId == 2).ToList());
            }
            else if (param == 3)
            {
                return View("Catalog", db.ProductItems.Where(x => x.FirmId == 3).ToList());
            }
            else if (param == 4)
            {
                return View("Catalog", db.ProductItems.Where(x => x.TypeId == 1).ToList());
            }
            else if (param == 5)
            {
                return View("Catalog", db.ProductItems.Where(x => x.TypeId == 2).ToList());
            }
            else if (param == 6)
            {
                return View("Catalog", db.ProductItems.Where(x => x.TypeId == 3).ToList());
            }
            return View("Catalog", db.ProductItems.ToList());
        }
    }
}
