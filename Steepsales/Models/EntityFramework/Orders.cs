using System;

namespace Steepsales.Models.EntityFramework
{
    public class Orders : IAllOrders
    {
        private readonly AppDbContext appDbContext;
        private readonly Cart cart;
        public Orders(AppDbContext appDbContext,Cart cart)
        {
            this.appDbContext = appDbContext;
            this.cart = cart;
        }
        public void newOrder(Order order)
        {
            order.ordertime=DateTime.Now;
            appDbContext.Orders.Add(order);
            appDbContext.SaveChanges();
            var items = cart.CartItems;
            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductId = el.productItem.Id,
                    orderName = el.productItem.Name,
                    orderFirm = el.productItem.Firm,
                    orderId = order.id,
                    price = el.productItem.Price
                };
                appDbContext.OrderDetails.Add(orderDetail);
            }
            appDbContext.CartItems.RemoveRange(appDbContext.CartItems);
            appDbContext.SaveChanges();
        }
    }
}
