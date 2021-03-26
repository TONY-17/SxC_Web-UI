using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class thankyou : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(var o in client.getOrders(Convert.ToInt32(Session["userid"].ToString())))
            {
                client.deleteCartItem(client.getCartItems(Session["userid"].ToString(), o.ProductId).ItemId);
                client.updateOrderIsBought(Convert.ToInt32(Session["userid"].ToString()), o.ProductId);
            }
            var disp = "";
            disp += "To Print Your Booking Order No.<span> #ABE-ME-12345678</span> (Invoice) -"+"<a href='inv.aspx?id="+Session["userid"].ToString()+"'>"+"Click Here"+"</a>";
            thid.InnerHtml = disp;
        }
    }
}