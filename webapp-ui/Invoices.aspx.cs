using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ListItem = System.Web.UI.WebControls.ListItem;
using System.IO;
using iTextSharp.text.html;
using System.Text;
using iTextSharp.text.html.simpleparser;

namespace webapp_ui
{
    public partial class Invoices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            ServiceClient client = new ServiceClient();
            if (Session["Email"] == null)
            {
                Response.Redirect("signin.aspx");
            }

            string displayUser = "";
           // string display = "";
            string counter = "";

            if (Session["cartSessionId"] != null)
            {
                //  var _cart = (List<CartItem>)Session["Cart"];
                counter += "<a href='shoppingcart.aspx' class='option_links' style='font-size: 120%;'><i class='fas fa-cart-plus'></i><span class='noti_count'>" + client.cartCount(Session["cartSessionId"].ToString()) + "</span></a>";
            }
            if (Session["cartSessionId"] == null)
                counter += "<a href='shoppingcart.aspx' class='option_links' style='font-size: 120%;'><i class='fas fa-cart-plus'></i><span class='noti_count'>0</span></a>";

            if (Session["Email"] != null)
            {
                displayUser += "<div class='channel_my'>";
                displayUser += "<div class='profile_link'>";
                displayUser += "<img src='assets/images/hd_dp.jpg'>";
                displayUser += "<div class='pd_content'>";
                displayUser += "<div class='rhte85'>";
                displayUser += "<h6><a href='dashboard.aspx'>My Account</a></h6>";
                displayUser += "</div>";
                displayUser += "<h6>" + Session["Email"].ToString() + "</h6>";
                displayUser += "</div>";
                displayUser += "</div>";
                displayUser += "</div>";
                displayUser += "<a href='signout.aspx' class='item channel_item'><i class='fas fa-sign-out-alt'></i>Sign Out</a>";
                signId.Visible = false;
            }
            else
            {
                AuthenUser.Visible = false;
                logout.Visible = false;
            }
            AuthenUser.InnerHtml = displayUser;
            count.InnerHtml = counter;
            var user = client.getUserbyEmail(Session["Email"].ToString());

            var listOrders = client.getOrders(user.Id);



            if (!IsPostBack)
            {
              
                foreach (var o in listOrders)
                {
                    display += "<tr>";
                    display += "<td>" + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "</td>";
                    display += "<td>" + o.Id + "</td>";
                    display += "<td> purchase </td>";
                    display += "<td><a href='inv.aspx?id=" + user.Id + "'>" + "View" + "</a></td>";
                    display += "</tr>";
                }

            }

            bodyid.InnerHtml = display;

        }

    }
}   