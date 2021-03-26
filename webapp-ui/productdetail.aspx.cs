using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class productdetail : System.Web.UI.Page
    {
		ServiceClient client = new ServiceClient();

		string idprod="";
		protected void Page_Load(object sender, EventArgs e)
        {
			    idprod = Request.QueryString["id"];
				Session["prodid"] = idprod;
			    int prodid = Convert.ToInt32(idprod);
				var display = "";
				var disp = "";
				var dis = "";
				var prices = "";

					
					display += "<ul class='image_list'>";
					display += "<li data-image='" + client.getProduct(prodid).ImageUrlThumbnail1 + "'>";
					display += "<img src=" + client.getProduct(prodid).ImageUrlThumbnail1 + ">";
					display += "</li>";
					display += "<li data-image=" + client.getProduct(prodid).ImageUrlThumbnail2 + "'>";
					display += "<img src=" + client.getProduct(prodid).ImageUrlThumbnail2 + ">";
					display += "</li>";
					display += "<li data-image=" + client.getProduct(prodid).ImageUrlThumbnail3 + "'>";
					display += "<img src=" + client.getProduct(prodid).ImageUrlThumbnail3 + ">";
					display += "</li>";
					display += "</ul>";
					disp += "<div class='product_category'>" + client.getCategory(client.getProduct(prodid).CategoryId).Name + "</div>";
					disp += "<div class='product_name'>" + client.getProduct(prodid).Name + "</div>";
					disp += "<div class='product_text'><p>" + client.getProduct(prodid).description + "</p></div>";
					dis += "<img src=" + client.getProduct(prodid).ImageUrl + ">";
					prices += "<div class='product_price'>R" + Math.Round(client.getProduct(prodid).Price, 2) + "</div>";
			
		    	imglist.InnerHtml = display;
				descrptid.InnerHtml = disp;
		    	imgselect.InnerHtml = dis;
				price.InnerHtml = prices;
			    
		}
		protected void addtocart(object sender, EventArgs e)
        {
			if(Session["Email"] == null)
            {
				Response.Redirect("signin.aspx");
            }

			//if(Session["cartSessionId"] == null)
			//{
			//	// Generate a new random GUID using System.Guid class.
			//	Guid tempCartId = Guid.NewGuid();
			//	Session["cartSessionId"] = tempCartId.ToString();
			//} 

			int prodid = Convert.ToInt32(idprod);

			var cartItem = client.getCartItems(Convert.ToString(Session["cartSessionId"]), prodid);

			string quantity = quantity_input.Value;
			string createddate = DateTime.Now.ToString();

			if (cartItem == null)
            {
				var cart = new CartItem
				{
					cartId = Convert.ToString(Session["cartSessionId"]),
					qty = Convert.ToInt32(quantity),
					datecreated = createddate
				};

				client.AddToCart(cart,prodid); 
            }

		}

	}
}