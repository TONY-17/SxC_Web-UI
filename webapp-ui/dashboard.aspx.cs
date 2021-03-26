using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class dashboard : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var display = "";
            var display2 = "";
            var display3 = "";
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
            decimal Sum = 0;
            foreach (var o in client.getOrders(user.Id))
            {
                Sum += client.getProduct(o.ProductId).Price;
            }
          
            display += "<h5>Total Sales</h5>";
            display += "<h2>R" + Math.Round(Sum,2) + "</h2>";
            display += "<span class='crdbg_1'>New</span>";

           
            display2 += "<h5>Total Products</h5>";
            display2 += "<h2>"+ client.getUserProducts(user.Id).Length+ "</h2>";
            display2 += "<span class='crdbg_3'>New</span>";

            display3 += "<h5>Total Buyers</h5>";
            display3 += "<h2>"+ client.getOrders(user.Id).Length+ "</h2>";
            display3 += "<span class='crdbg_4'>New</span>";

            totsales.InnerHtml=display;
            totprod.InnerHtml=display2;
            totbuy.InnerHtml = display3;

            var disp = "";

            disp += "<script>";
            disp += "Highcharts.chart('container', {";
            disp += "chart:";
            disp += "{";
            disp += "type: 'line'";
            disp += "},";
            disp += "title:";
            disp += "{";
            disp += "text: 'Monthly  Sales'";
            disp += "},";
            disp += "subtitle:";
            disp += "{";
            disp += "text: 'Source: studentXchange.com'";
            disp += "},";
            disp += "xAxis:";
            disp += "{";
            disp += "categories:[";
            foreach(var o in client.getOrders(user.Id))
            {
               disp+= "'"+client.getProduct(o.ProductId).Name+"',";
            }
            disp +="]";
            disp += "},";
            disp += "yAxis:";
            disp += "{";
            disp += "title:";
            disp += "{";
            disp += "text: 'Price (ZAR)'";
            disp += "}";
            disp += "},";
            disp += "plotOptions:";
            disp += "{";
            disp += "line:";
            disp += "{";
            disp += "dataLabels:";
            disp += "{";
            disp += "enabled: true";
            disp += "},";
            disp += "enableMouseTracking: true";
            disp += "}";
            disp += "},";
            disp += "series:";
            disp += "[{";
            disp += "name: 'Monthly Sales',";
            disp += "data:[";
            foreach (var o in client.getOrders(user.Id))
            {
                disp +=  Math.Round(client.getProduct(o.ProductId).Price,0) + ",";
            }
            disp += "]";
            disp += "}]";
            disp += "});";
            disp += "</script>";
            script.InnerHtml = disp;
        }  
       
    }
        
          
}
    