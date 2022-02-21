using Microsoft.AspNetCore.Mvc;
using Steepsales.Models.EntityFramework;
using Steepsales.Models;
using System;

namespace Steepsales.Controllers
{
    public class ShopController : Controller 
    {
        private readonly DataManager dataManager;
        public ShopController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Catalog(Guid id)
        {
            if (id != default)
            {
                return View("ShowTovar", dataManager.ProductItem.GetProductItemById(id));
            }
            return View(dataManager.ProductItem.GetProductItems());
        }
    }
}
