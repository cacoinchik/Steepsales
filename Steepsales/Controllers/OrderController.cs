using Microsoft.AspNetCore.Mvc;
using Steepsales.Models.EntityFramework;

namespace Steepsales.Controllers
{
    public class OrderController : Controller 
    {
        private readonly IAllOrders allOrders;
        private readonly Cart cart;
        public OrderController(IAllOrders allOrders,Cart cart)
        {
            this.allOrders = allOrders;
            this.cart = cart;
        }
        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Order(Order order)
        {
            cart.CartItems = cart.GetCartItems();
            if (cart.CartItems.Count == 0)
            {
                ModelState.AddModelError("","Ваша корзина пуста!");
            }
            if (ModelState.IsValid)
            {
                 allOrders.newOrder(order);
                 return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ принят в обработку";
            return  View(); 
        }
    }
}
