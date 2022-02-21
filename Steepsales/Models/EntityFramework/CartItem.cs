using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steepsales.Models.EntityFramework
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public ProductItem productItem { get; set; }
        public decimal price { get; set; }
        public string ShopCartId { get; set; }

    }
}
