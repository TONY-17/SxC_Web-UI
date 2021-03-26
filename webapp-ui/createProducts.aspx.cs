using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class createProducts : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {
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

            var listCategories = client.getCategories();

            if (!IsPostBack)
            {
                ListItem categoryListItem = new ListItem("Select Category","-1");
                ListItem statusListItem = new ListItem("pending", "0");
                ListItem statusListItem2 = new ListItem("active", "1");
                StatusDropDownList.Items.Add(statusListItem);
                StatusDropDownList.Items.Add(statusListItem2);
                CategoryDropDownList.Items.Add(categoryListItem);
                foreach (var c in listCategories)
                {
                    ListItem categoryListItems = new ListItem(c.Name, Convert.ToString(c.Id));
                    CategoryDropDownList.Items.Add(categoryListItems);
                }
               
            }
            warning.Visible = false;
          
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            dynamic images = new List<string>();

            var savePath = Server.MapPath("~/uploadedImages/");
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            //store image to physical disk
            StoreFile(FileUpload1, savePath, images);
            StoreFile(FileUpload2, savePath, images);
            StoreFile(FileUpload3, savePath, images);
            StoreFile(FileUpload3, savePath, images);
            StoreFile(FileUpload4, savePath, images);
            try
            {
                Image1.ImageUrl = "~/uploadedImages/" + images[0];
                Image2.ImageUrl = "~/uploadedImages/" + images[1];
                Image3.ImageUrl = "~/uploadedImages/" + images[2];
                Image4.ImageUrl = "~/uploadedImages/" + images[3];

            }
            catch(ArgumentOutOfRangeException ex)
            {
                ex.GetBaseException();
                warning.Visible = true;
            }
          
        }

        private void StoreFile(FileUpload fileUpload, string savePath, List<string> images)
        {
            if (!fileUpload.HasFile)
            {
                return;
            }
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(fileUpload.FileName);
            fileUpload.SaveAs(Path.Combine(savePath, fileName));
            images.Add(fileName);

        }

        protected void createProduct(object sender, EventArgs e)
        {
            int  categoryId = Convert.ToInt32(CategoryDropDownList.SelectedItem.Value);
            var product = new Product
            {
                Name = inputName.Value,
                description = id_part_description.Value,
                Price = Convert.ToDecimal(price.Value),
                ImageUrl = Image1.ImageUrl,
                ImageUrlThumbnail1 = Image2.ImageUrl,
                ImageUrlThumbnail2 = Image3.ImageUrl,
                ImageUrlThumbnail3 = Image4.ImageUrl,
                DateCreated = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                Status = Convert.ToInt32(StatusDropDownList.SelectedItem.Value)
            };
            client.createProduct(product,categoryId,1);
            Response.Redirect("createdProducts.aspx");
        }

    }
}