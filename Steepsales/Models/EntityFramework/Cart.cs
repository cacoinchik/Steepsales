using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Steepsales.Models.EntityFramework
{
    public class Cart
    {
        private readonly AppDbContext appDbContext;
        public Cart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public string ShopCartId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);
            return new Cart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(ProductItem productItem)
        {
            this.appDbContext.CartItems.Add(new CartItem { ShopCartId = ShopCartId, productItem = productItem, price = productItem.Price });

            appDbContext.SaveChanges();
        }
        public List<CartItem> GetCartItems()
        {
            return appDbContext.CartItems.Where(c=>c.ShopCartId==ShopCartId).Include(s=>s.productItem).ToList();
        }
    }
}
