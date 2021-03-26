using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class prodDiscount : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        string prodId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            prodId = Request.QueryString["id"];
            var product = client.getPriceOffer(Convert.ToInt32(prodId));
            if (!IsPostBack)
            {
                discountId.Value = product.Discount.ToString();
                startdate.Value = product.StartDate;
                endDate.Value = product.EndDate;  
            }
          
        }

        protected void EditDiscount(object sender, EventArgs e)
        {
            var discount = new PriceOffer
            {
                Id = Convert.ToInt32(prodId),
                Discount = Convert.ToDecimal(discountId.Value),
                StartDate = startdate.Value,
                EndDate = endDate.Value,
               
            };

            client.EditPriceOffer(discount);
        }
    }
}