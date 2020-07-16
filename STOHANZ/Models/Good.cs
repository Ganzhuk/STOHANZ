using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Good
    {
        public int GoodId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Good()
        {
        }
        public Good(int GoodId_, string Name_, decimal Price_)
        {
            this.GoodId = GoodId_;
            this.Name = Name_;
        }
    }
}