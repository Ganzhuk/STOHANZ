using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual Good Good_Id { get; set; }
        public decimal Price { get; set; }

        public Order()
        {
        }       
        public Order(int OrderId_, Good Good_Id_, decimal Price_)
        {
            this.OrderId = OrderId_;
            this.Good_Id = Good_Id_;
        }
    }
}