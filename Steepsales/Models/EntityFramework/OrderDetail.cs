using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steepsales.Models.EntityFramework
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal price { get; set; }
        public virtual ProductItem ProductItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
