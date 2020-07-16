using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using STOHANZ.Models.Repository;

namespace STOHANZ.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string SessionKey { get; set; }
        public decimal Price { get; set; }
        public Service Service_ServiceId { get; set; }
        public Cart() { }
        public Cart(int CartId_, string SessionKey_, decimal Price_, Service Service_ServiceId_)
        {
            this.CartId = CartId_;
            this.SessionKey = SessionKey_;
            this.Price = Price_;
            this.Service_ServiceId = Service_ServiceId_;
        }
        private List<CartLine> lineCollection;

        public void AddItem(Service service, int quantity)
        {
            CartLine cartLine = lineCollection.Where(p => p.Service.ServiceId == service.ServiceId).FirstOrDefault();
            if (cartLine == null) { lineCollection.Add(new CartLine() { Service = service, Quantity = quantity }); }
            else { cartLine.Quantity += quantity; }
        }
        public void RemoveLine(Service service) { lineCollection.RemoveAll(l => l.Service.ServiceId == service.ServiceId); }
        public void Clear() { lineCollection.Clear(); }
        public decimal ComputeTotalPrice() { return lineCollection.Sum(e => e.Service.Price * e.Quantity); }
        public IEnumerable<CartLine> Lines { get { return lineCollection; } }
    }
    public class CartLine
    {
        public Service Service { get; set; }
        public int Quantity { get; set; }
    }
}