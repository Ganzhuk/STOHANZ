using STOHANZ.Models;
using STOHANZ.Models.Repository;
using STOHANZ.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Web.ModelBinding;

namespace STOHANZ.Pages.Helpers
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkoutForm.Visible = true;
            checkoutMessage.Visible = false;

            if (IsPostBack)
            {
                Client client = new Client();
                if (TryUpdateModel(client, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    client.OrderLines = new List<OrderLine>();

                    Cart cart = SessionHelper.GetCart(Session);

                    foreach (CartLine line in cart.Lines)
                    {
                        client.OrderLines.Add(new OrderLine()
                        {
                            Client = client,
                            Service = line.Service,
                            Quantity = line.Quantity
                        });
                    }

                    new Repository().SaveOrder(client);
                    cart.Clear();

                    checkoutForm.Visible = false;
                    checkoutMessage.Visible = true;
                }
            }
        }
    }
}