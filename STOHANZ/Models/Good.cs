using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Good
    {
        public Good GoodId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Good(Good GoodId_, string Name_, decimal Price_)
        {
            this.GoodId = GoodId_;
            this.Name = Name_;
        }
    }
}