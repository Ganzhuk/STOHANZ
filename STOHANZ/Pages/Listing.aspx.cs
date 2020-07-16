using STOHANZ.Models;
using STOHANZ.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STOHANZ.Pages.Helpers
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize = 4;

        protected int MaxPage
        {
            get
            {
                int prodCount = FilterServices().Count();
                return (int)Math.Ceiling((decimal)prodCount / pageSize);
            }
        }
        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ?? Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
        protected int CurrentPage
        {
            get
            {
                int page;
                page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }
        public IEnumerable<Service> GetServices() { return FilterServices().OrderBy(g => g.ServiceId).Skip((CurrentPage - 1) * pageSize).Take(pageSize); }
        //метод фильтрации по каттегории
        private IEnumerable<Service> FilterServices()
        {
            IEnumerable<Service> Services = repository.Services;
            string currentCategory = (string)RouteData.Values["category"] ?? Request.QueryString["category"];
            return currentCategory == null ? Services : Services.Where(p => p.CategoryId.Name == currentCategory);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedServiceId;
                if (int.TryParse(Request.Form["add"], out selectedServiceId))
                {
                    Models.Service selectedGood = repository.Services.Where(g => g.ServiceId == selectedServiceId).FirstOrDefault();
                    if (selectedGood != null)
                    {
                        SessionHelper.GetCart(Session).AddItem(selectedGood, 1);
                        SessionHelper.Set(Session, SessionKey.RETURN_URL, Request.RawUrl);
                        Response.Redirect(RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath);
                    }
                }
            }
        }
    }
}