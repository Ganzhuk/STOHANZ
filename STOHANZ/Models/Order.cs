using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Order
    {
        public Order OrderId { get; set; }
        public int Good_Id { get; set; }
        public decimal Price { get; set; }

        public Order(Order OrderId_, int Good_Id_, decimal Price_)
        {
            this.OrderId = OrderId_;
            this.Good_Id = Good_Id_;
        }
    }
}