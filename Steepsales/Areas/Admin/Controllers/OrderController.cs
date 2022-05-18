using Microsoft.AspNetCore.Mvc;
using Steepsales.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Steepsales.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        AppDbContext db;
        public OrderController(AppDbContext db)
        {
            this.db = db;
        }
        public class ViewModel
        {
            public IEnumerable<Order> Orders { get; set; }
            public IEnumerable<OrderDetail> Details { get; set; }
        }

        public IActionResult Show()
        {
            var model = new ViewModel()
            {
                Orders = db.Orders.ToList(),
                Details = db.OrderDetails.ToList()
            };
            return View(model);
        }
    }
}
