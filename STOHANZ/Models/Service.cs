﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category CategoryId { get; set; }
        public Master MasterId { get; set; }
        public Car CarId { get; set; }
        public decimal Price { get; set; }

        public Service()
        {
        }

        public Service(int ServiceId_, string Name_, string Description_, Category CategoryId_, Master MasterId_, Car CarId_, decimal Price_)
        {
            this.ServiceId = ServiceId_;
            this.Name = Name_;
            this.Description = Description_;
            this.CategoryId = CategoryId_;
            this.MasterId = MasterId_;
            this.CarId = CarId_;
        }
    }
}