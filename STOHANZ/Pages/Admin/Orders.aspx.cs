using STOHANZ.Models;
using STOHANZ.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;

namespace STOHANZ.Pages.Admin
{
    public partial class Orders : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int statusID;
                if (int.TryParse(Request.Form["dispatch"], out statusID))
                {
                    Client myClient = repository.Clients.Where(x => x.ClientId == statusID).FirstOrDefault();
                    if (myClient != null)
                    {
                        myClient.Status = true;
                        repository.SaveOrder(myClient);
                    }
                }
            }
        }
        public IEnumerable<Client> GetOrders([Control] bool showDispatched)
        {
            if (showDispatched)  return repository.Clients;
            else return repository.Clients.Where(o => !o.Status);
        }
        public decimal Total(IEnumerable<OrderLine> orderLines)
        {
            decimal total = 0;
            foreach (OrderLine ol in orderLines)
            {
                total += ol.Good.Price * ol.Quantity;
            }
            return total;
        }
    }
}