using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
	public partial class Index : System.Web.UI.Page
	{
		ServiceClient client = new ServiceClient();
		protected void Page_Load(object sender, EventArgs e)
		{
			var display = "";
			var disp = "";

			int counter = 0;

			for (int i = 0; i < 1; i++)
			{
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=1'>" + client.getCategory(1).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=2'>" + client.getCategory(2).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=3'>" + client.getCategory(3).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=4'>" + client.getCategory(4).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=5'>" + client.getCategory(5).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=6'>" + client.getCategory(6).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=7'>" + client.getCategory(7).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=8'>" + client.getCategory(8).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=9'>" + client.getCategory(9).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=10'>" + client.getCategory(10).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";
				disp += "<a style='color:dimgrey;' href='category.aspx?id=11'>" + client.getCategory(11).Name + "&nbsp" + "</a>";
				disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp"; disp += "&nbsp";

				//d += "<span> " + c.Name + "</span>";
				//disp += "<a href='category.aspx?id=" + c.Id +" > " + c.Name + "&nbsp"+"&nbsp" + "&nbsp" + "</a>";



			}
			Div1.InnerHtml = disp;



			foreach (var p in client.getProducts())
			{
				if (counter < 1000)
				{
					display += "<div class='col-xl-3 col-lg-4 col-md-6'>";
					display += "<a href='productdetail.aspx?id="+p.Id+ "' style='color:black !important;'>";
					display += "<div class='fcrse_1 mt-30'>";
					display += "<div class='viewed_item d-flex flex-column align-items-center justify-content-center text-center'>";
					display += "<div class='viewed_image'><img src=" + p.ImageUrl + " width='130px' height='115px'>";
					display += "</div>";
					display += "<div class='viewed_content text-center'>";
					display += "<div class='viewed_price'  style='color:black !important; font:15px;font-weight:400;'>R" + Math.Round(p.Price,2);
					display += "</div>";
					display += "<div class='viewed_name'><a href='productdetail.aspx?id=" + p.Id + "' style='color:black !important;font-size:17px;font-weight:800;'>" + p.Name + "</a>";
					display += "</div>";
					display += "</div>";
					display += "</div>";
					display += "</div>";
					display += "</a>";
					display += "</div>";

					counter++;
				}

			}

			carid.InnerHtml = display;
			catid.InnerHtml = disp;
		}
	}
}