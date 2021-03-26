using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class discount : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        string display = "";
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
            var userProducts = client.getUserProducts(user.Id);
            var priceDiscounts = client.getPriceOffers();

            if (!IsPostBack)
            {
                ListItem productListItem = new ListItem("Select Product", "-1");
                ProductDropDownList.Items.Add(productListItem);
                foreach (var u in userProducts)
                {
                    ListItem productListItems = new ListItem(u.Name, Convert.ToString(u.Id));
                    ProductDropDownList.Items.Add(productListItems);
                }

                foreach(var d in priceDiscounts)
                {
                    display += "<tr>";
                    display += "<td class='text-center'>"+d.Id+"</td>";
                    display += "<td class='cell-ta'>"+client.getProduct(d.ProductId).Name+"</td>";
                    display += "<td class='text-center'>"+d.StartDate+"</td>";
                    display += "<td class='text-center'>"+d.EndDate+"</td>";
                    display += "<td class='text-center'>"+d.Discount+"%</td>";
                    display += "<td class='text-center'><b class='course_active'>active</b></td>";
                    display += "<td class='text-center'>";
                    display += "<a href='prodDiscount.aspx?id=" + d.Id + "'title='Edit' class='gray-s'><i class='far fa-edit'></i></a>";
                    display += "<a href='deletepriceoffer.aspx?id=" + d.Id + "'title ='Delete' class='gray-s'><i class='fas fa-trash-alt'></i></a>";
                    display += "</td>";
                    display += "</tr>";
                }
                bodyid.InnerHtml = display;  
            }
        }

        protected void SaveDiscount(object sender, EventArgs e)
        {
            var _priceoffer = new PriceOffer
            {
                StartDate = startdate.Value,
                EndDate = endDate.Value,
                Discount = Convert.ToInt32(discountId.Value),
            };
            client.createPriceOffer(_priceoffer, Convert.ToInt32(ProductDropDownList.SelectedItem.Value));
        }
    }
}