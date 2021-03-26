using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class PaymentSettings : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            var getAddress = client.getUserAddress(user.Id);
            if (!IsPostBack)
            {
                inputAddress.Value = getAddress.Address;
                inputAddress2.Value = getAddress.Address2;
                inputCity.Value = getAddress.City;
                inputState.Value = getAddress.Province;
                inputZip.Value = getAddress.PostalCode.ToString();
          
            }
        }

        protected void EditAddress(object sender, EventArgs e)
        {
            var editedAddress = new BillingAddress
            {
                Address = inputAddress.Value,
                Address2 = inputAddress2.Value,
                City = inputCity.Value,
                Province = inputState.Value,
                PostalCode = Convert.ToInt32(inputZip.Value)
            };
            client.EditAddress(editedAddress);
        }
    }
}