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
        public ShopController(DataManager dataManager,AppDbContext db)
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
    }
}
