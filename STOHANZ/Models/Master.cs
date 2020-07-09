using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class Master
    {
        public Master MasterId { get; set; }
        public string Name { get; set; }

        public Master(Master MasterId_, string Name_)
        {
            this.MasterId = MasterId_;
            this.Name = Name_;
        }
    }
}