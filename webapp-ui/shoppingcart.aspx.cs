using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class shoppingcart : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        int prodid = 0;
        string cartid = "";
        int countt = 1;
        List<CartItem> cartItems = new List<CartItem>();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Session["cartSessionId"] == null)
            {
                Response.Redirect("index.aspx");
            }

            string displayUser = "";
            string display = "";
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

            var display3 = "";
            var display2 = "";
            prodid = Convert.ToInt32(Session["prodid"]);
            cartid = Session["cartSessionId"].ToString();

            decimal sum = 0;

            foreach (var p in client.getCartListItems(cartid, prodid))
            {

                //TextBox textBox = new TextBox();
                //textBox.ID = "p"+countt.ToString();
               // textBox.Text = "";
                //pnlTextBoxes.Controls.Add(textBox);
               

                display3 += "<div class='fcrse_1' style='margin-top:15px'>";
                display3 += "<a href='course_detail_view.html' class='hf_img'>";
                display3 += "<img class='cart_img' src=" + client.getProduct(p.productId).ImageUrl + ">";
                display3 += "</a>";
                display3 += "<div class='hs_content'>";
                display3 += "<div class='eps_dots eps_dots10 more_dropdown'>";
                display3 += "<a href='delete.aspx?id=" + p.ItemId + "'class='btnremove'><i class='uil uil-times'></i></a>";
                display3 += "</div>";
                display3 += "<a href='course_detail_view.html' class='crse14s title900 pt-2'>" + client.getProduct(p.productId).Name + "</a>";
                display3 += "<a href='#' class='crse-cate'>" + client.getCategory(client.getProduct(p.productId).CategoryId).Name + "</a>";
                display3 += "<div class='auth1lnkprce'>";
               
                display3 += "<div class='input-group mb-3' style='max-width: 120px;'>";
                display3 += "<input type='text' class='form-control text-center' aria-label='Example text with button addon' name='Field' aria-describedby='button-addon1'>";
                display3 += "</div>";
                display3 += "</div>";
               
                display3 += "<div class='auth1lnkprce'>";
                display3 += "<div class='prce142'>R" + Math.Round((client.getProduct(p.productId).Price) * p.qty, 2) + "</div>";
                display3 += "</div>";
                display3 += "</div>";
                display3 += "</div>";
                sum += (client.getProduct(p.productId).Price) * p.qty;
                cartItems.Add(p);
                countt++;
            }
            //  display3 += "<input id='Submit1' type='submit' value='submit'/>";
          //  display3 += "</form>";

            display2 += "<h2>Total</h2>";
            display2 += "<div class='order_price5'>R" + Math.Round(sum, 2) + "</div>";

            carttid.InnerHtml = display3;
            ordertotal.InnerHtml = display2;
        }

        protected void checkout(object sender, EventArgs e)
        {

            if(Session["Email"] == null)
            {
                Response.Redirect("signin.aspx");
            }
            else
            {
                client.createOrder(cartid);
                Response.Redirect("checkout.aspx");
            }
               
        }

        protected void search(object sender, EventArgs e)
        {
            var searchList = new List<Product>();
            foreach (var r in client.searchresults(id_search.Value))
            {
                var result = new Product
                {
                    Id = r.Id,
                    Name = r.Name,
                    description = r.description,
                    Price = r.Price,
                    ImageUrl = r.ImageUrl,
                    ImageUrlThumbnail1 = r.ImageUrlThumbnail1,
                    ImageUrlThumbnail2 = r.ImageUrlThumbnail2,
                    ImageUrlThumbnail3 = r.ImageUrlThumbnail3,
                    UserId = r.UserId,
                    Status = r.Status,
                    DateCreated = r.DateCreated,
                    CategoryId = r.CategoryId
                };
                searchList.Add(result);
            }
            Session["sessionList"] = searchList;
            Response.Redirect("searchresults.aspx");
        }

        protected void Update_Cart(object sender, EventArgs e)
        {
                string[] fieldArr = Request.Form.GetValues("Field");

                     int i = 0;
                    foreach(var p in cartItems)
                    {
                        if (i <= cartItems.Count())
                        {
                            client.updateQty(cartid,p.productId, Convert.ToInt32(fieldArr[i]));
                            i++;
                        }
                     
                    }
        }
               
    } 
}
