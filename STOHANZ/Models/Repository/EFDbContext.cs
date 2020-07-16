using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace STOHANZ.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}