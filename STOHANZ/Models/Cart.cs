using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Cart
    {
        public Cart CartId { get; set; }
        public string SessionKey { get; set; }
        public decimal Price { get; set; }
        public Service Service_ServiceId { get; set; }

        public Cart(Cart CartId_, string SessionKey_, decimal Price_, Service Service_ServiceId_)
        {
            this.CartId = CartId_;
            this.SessionKey = SessionKey_;
            this.Price = Price_;
            this.Service_ServiceId = Service_ServiceId_;
        }
    }
}