using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class Checkout : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            string display2 = "";
            var user = client.getUserbyEmail(Session["Email"].ToString());

            id_name.Value = user.Name;
            id_surname.Value = user.LastName;

            if (!IsPostBack)
            {
                var useraddress = client.getUserAddress(user.Id);
                if (useraddress != null)
                {
                    display += user.Name + " " + user.LastName + "<br>";
                    display += client.getUserAddress(user.Id).Address + "," + client.getUserAddress(user.Id).Address2 + " ";
                    display += client.getUserAddress(user.Id).Province + "," + client.getUserAddress(user.Id).PostalCode + "<br>";
                    display += client.getUserAddress(user.Id).City;
                    id_state.Value = client.getUserAddress(user.Id).PostalCode.ToString();
                    id_address1.Value = client.getUserAddress(user.Id).Address;
                    id_address2.Value = client.getUserAddress(user.Id).Address2;
                    id_city.Value = id_address1.Value = client.getUserAddress(user.Id).City;
                }
             
                    decimal Sum = 0;
                    foreach (var o in client.getOrders(user.Id))
                    {
                        Sum += client.getProduct(o.ProductId).Price;
                        display2 += "<div class='order_title'>";
                        display2 += "<h4>" + client.getProduct(o.ProductId).Name + "</h4>";
                        display2 += "<div class='order_price'>R" + Math.Round(client.getProduct(o.ProductId).Price, 2) + "</div>";
                        display2 += "</div>";

                    }
                    if (Sum < 500)
                    {
                        Sum = Sum + 100;
                        display2 += "<div class='order_title'>";
                        display2 += "<h2>Total</h2>";
                        display2 += "<div class='order_price5'>R" + Math.Round(Sum, 2) + "</div>";
                        display2 += "</div>";
                        display2 += "<div class='order_title'>";
                        display2 += "<h6>TAX 15%</h6>";
                        display2 += "<div class='order_price'>R" + Math.Round(Convert.ToDouble(Sum) * 0.15, 2) + "</div>";
                        display2 += "</div>";
                        display2 += "<div class='order_title'>";
                        display2 += "<h6>DELIVERY FEE</h6>";
                        display2 += "<div class='order_price'>R100.00</div>";
                        display2 += "</div>";
                    }
                    if (Sum >= 1000)
                    {
                        Sum = Sum + 50;
                        display2 += "<div class='order_title'>";
                        display2 += "<h2>Total</h2>";
                        display2 += "<div class='order_price5'>R" + Math.Round(Sum, 2) + "</div>";
                        display2 += "</div>";
                        display2 += "<div class='order_title'>";
                        display2 += "<h6>TAX 15%</h6>";
                        display2 += "<div class='order_price'>R" + Math.Round(Convert.ToDouble(Sum) * 0.15, 2) + "</div>";
                        display2 += "</div>";
                        display2 += "<div class='order_title'>";
                        display2 += "<h6>DELIVERY FEE</h6>";
                        display2 += "<div class='order_price'>R50.00</div>";
                        display2 += "</div>";
                    }
                
               
            }

            Session["userid"] = user.Id;

            orderid.InnerHtml = display2;
            address.InnerHtml = display;
        }

        protected void save_changes(object sender, EventArgs e)
        {
            var billingAddress = new BillingAddress
            {
                Address = id_address1.Value,
                Address2 = id_address2.Value,
                City = id_city.Value,
                Province = id_state.Value,
                PostalCode = Convert.ToInt32(id_zip.Value)
            };
            var user = client.getUserbyEmail(Session["Email"].ToString());
            client.CreateUserAddress(billingAddress, user.Id);
        }
       
    }
}