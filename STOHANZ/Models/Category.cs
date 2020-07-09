using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Category
    {
        public Category CategoryId { get; set; }
        public string Name { get; set; }

        public Category(Category CategoryId_, string Name_)
        {
            this.CategoryId = CategoryId_;
            this.Name = Name_;
        }
    }
}