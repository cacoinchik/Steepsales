using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace Steepsales.Models.EntityFramework
{
    public class Order
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime ordertime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
