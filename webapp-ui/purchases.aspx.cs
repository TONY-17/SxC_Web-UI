using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class purchases : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
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
            var list = client.getOrders(user.Id);

            if (!IsPostBack)
            {
                foreach(var o in list)
                {
                    display += "<tr>";
                    display += "<td class='text-center'>"+o.Id+"</td>";
                    display += "<td class='cell-ta'>"+client.getProduct(o.ProductId).Name+"</td>";
                    display += "<td class='cell-ta'><a href='#'>"+client.getUser(user.Id).Name+" "+ client.getUser(user.Id).LastName + "</a></td>";
                    display += "<td class='cell-ta'><a href='#'>"+client.getCategory(client.getProduct(o.ProductId).CategoryId).Name+"</a></td>";
                    display += "<td class='text-center'>"+Math.Round(client.getProduct(o.ProductId).Price,2)+ "</td>";
                    display += "<td class='text-center'>25 March 2020</td>";
                    display += "<td class='text-center'>";
                    display += "<a href='deleteorder.aspx?id=" + o.Id + "'title='Delete' class='gray-s'><i class='fas fa-trash-alt'></i></a>";
                    display += "</td>";
                    display += "</tr>";
                }
                bodyid.InnerHtml += display;
            }
        }
    }
}