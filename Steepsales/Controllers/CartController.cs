using Microsoft.AspNetCore.Mvc;
using Steepsales.Models;
using Steepsales.Models.EntityFramework;
using System;

namespace Steepsales.Controllers
{
    public class CartController : Controller 
    {
        private readonly IProductItemRepository productItemRepository;
        private readonly Cart cart;
        public CartController(IProductItemRepository productItemRepository,Cart cart)
        {
            this.cart = cart;
            this.productItemRepository = productItemRepository;
        }
        public IActionResult Index()
        {
            var items=cart.GetCartItems();
            cart.CartItems = items;
            var obj = new CartViewModel { cart = cart };
            return View(obj);
        }
        public RedirectToActionResult addToCart(Guid id)
        {
            var item = productItemRepository.GetProductItemById(id);
            if (item != null)
            {
                cart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
