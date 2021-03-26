using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class searchresults : System.Web.UI.Page
    {
		ServiceClient client = new ServiceClient();
		protected void Page_Load(object sender, EventArgs e)
		{
			var list = (List<Product>)Session["sessionList"];
			var display = "";
			var disp = "";
			var disp4 = "";
			
			disp4 += "<span>" + list.Count() + "</span> products found";

			foreach (var cp in list)
			{

				display += "<div class='col-xl-3 col-lg-4 col-md-6'>";
				display += "<a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>";
				display += "<div class='fcrse_1 mt-30'>";
				display += "<div class='viewed_item d-flex flex-column align-items-center justify-content-center text-center'>";
				display += "<div class='viewed_image'><img src=" + cp.ImageUrl + ">";
				display += "</div>";
				display += "<div class='viewed_content text-center'>";
				display += "<div class='viewed_price'>R" + Math.Round(cp.Price, 2);
				display += "</div>";
				display += "<div class='viewed_name'><a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>" + cp.Name + "</a>";
				display += "</div>";
				display += "</div>";
				display += "</div>";
				display += "</div>";
				display += "</a>";
				display += "</div>";

			}

			Div1.InnerHtml = display;
			prodcount.InnerHtml = disp4;

		}

	}
}
