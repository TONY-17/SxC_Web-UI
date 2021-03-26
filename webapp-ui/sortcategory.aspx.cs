using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class sortcategory : System.Web.UI.Page
    {
		ServiceClient client = new ServiceClient();
		protected void Page_Load(object sender, EventArgs e)
		{
			string id = Request.QueryString["id"];
			//string idcat = Session["cid"].ToString();
			int categoryid = Convert.ToInt32(Convert.ToInt32(Session["cid"]));
			var display3 = "";
			var display4 = "";
			var disp = "";
			var disp4 = "";
			var display2 = "";
			var dis = "";
			disp += "<h2 class='home_title'>" + client.getCategory(categoryid).Name + "</h2>";
			disp4 += "<span>" + client.getCategoryProducts(categoryid).Count() + "</span> products found";

			display2 += "<li class='brand'><a href='category.aspx?id=1'>" + client.getCategory(1).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=2'>" + client.getCategory(2).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=3'>" + client.getCategory(3).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=4'>" + client.getCategory(4).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=5'>" + client.getCategory(5).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=6'>" + client.getCategory(6).Name + "</a></li>";
			display2 += "<li class='brand'><a href='category.aspx?id=7'>" + client.getCategory(7).Name + "</a></li>";

            if(Convert.ToInt32(id)==1)
            {
				foreach (var cp in client.getCategoryProductsLowhigh(categoryid))
				{

					display4 += "<div class='col-xl-3 col-lg-4 col-md-6'>";
					display4 += "<a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>";
					display4 += "<div class='fcrse_1 mt-30'>";
					display4 += "<div class='viewed_item d-flex flex-column align-items-center justify-content-center text-center'>";
					display4 += "<div class='viewed_image'><img src=" + cp.ImageUrl + ">";
					display4 += "</div>";
					display4 += "<div class='viewed_content text-center'>";
					display4 += "<div class='viewed_price'>R" + Math.Round(cp.Price, 2);
					display4 += "</div>";
					display4 += "<div class='viewed_name'><a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>" + cp.Name + "</a>";
					display4 += "</div>";
					display4 += "</div>";
					display4 += "</div>";
					display4 += "</div>";
					display4 += "</a>";
					display4 += "</div>";

				}
				Divv1.InnerHtml = display4;
			}

			if(Convert.ToInt32(id)==2)
			{
				foreach (var cp in client.getCategoryProductsHighlow(categoryid))
				{

					display3 += "<div class='col-xl-3 col-lg-4 col-md-6'>";
					display3 += "<a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>";
					display3 += "<div class='fcrse_1 mt-30'>";
					display3 += "<div class='viewed_item d-flex flex-column align-items-center justify-content-center text-center'>";
					display3 += "<div class='viewed_image'><img src=" + cp.ImageUrl + ">";
					display3 += "</div>";
					display3 += "<div class='viewed_content text-center'>";
					display3 += "<div class='viewed_price'>R" + Math.Round(cp.Price, 2);
					display3 += "</div>";
					display3 += "<div class='viewed_name'><a href='productdetail.aspx?id=" + cp.Id + "' style='color:black !important;'>" + cp.Name + "</a>";
					display3 += "</div>";
					display3 += "</div>";
					display3 += "</div>";
					display3 += "</div>";
					display3 += "</a>";
					display3 += "</div>";
					
				}
				Divv1.InnerHtml = display3;
			}


			title.InnerHtml = disp;
			div2.InnerHtml = disp;
			div3.InnerHtml = display2;
			prodcount.InnerHtml = disp4;

		}
	}
}