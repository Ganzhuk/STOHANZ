using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace STOHANZ.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Client> Clients { get{ return context.Clients.Include(c => c.OrderLines.Select(ol => ol.Good)); } }
        public IEnumerable<Car> Cars { get{ return context.Cars; } }
        public IEnumerable<Cart> Carts { get{ return context.Carts; } }
        public IEnumerable<Category> Categoryes { get{ return context.Categoryes; } }
        public IEnumerable<Good> Goods { get{ return context.Goods; } }
        public IEnumerable<Order> Orders { get{ return context.Orders; } }
        public IEnumerable<Service> Services { get{ return context.Services; } }
        public IEnumerable<Master> Masters { get { return context.Masters; } }
        public void SaveOrder(Client client)
        {
            if (client.ClientId == 0)
            {
                client = context.Clients.Add(client);
                foreach (OrderLine line in client.OrderLines)
                { context.Entry(line.Good).State = EntityState.Modified; }
            }
            else
            {
                Client dbOrder = context.Clients.Find(client.ClientId);
                if (dbOrder != null)
                {
                    dbOrder.Fio = client.Fio;
                    dbOrder.Phone = client.Phone;
                    dbOrder.Adress = client.Adress;
                    dbOrder.Status = client.Status;
                }
            }
            context.SaveChanges();
        }
    }
}