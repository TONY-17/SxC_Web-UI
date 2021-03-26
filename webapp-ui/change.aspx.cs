using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class change : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var o in client.getOrdersUserIsBought(Convert.ToInt32(Session["userid"].ToString())))
            {
                client.updateOrderIsAlreadyBought(Convert.ToInt32(Session["userid"].ToString()), o.ProductId);
            }
             Response.Redirect("thankyou.aspx");
        }
    }
}