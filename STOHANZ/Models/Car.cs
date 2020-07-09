using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Car
    {
        public Car CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }

        public Car(Car CarId_, string CarName_, string CarType_, string CarColor_)
        {
            this.CarId = CarId_;
            this.CarName = CarName_;
            this.CarType = CarType_;
            this.CarColor = CarColor_;
        }
    }
}