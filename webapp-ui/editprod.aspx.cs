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
    public partial class editprod : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        string prodId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            prodId = Request.QueryString["id"];
            var listCategories = client.getCategories();
            var product = client.getProduct(Convert.ToInt32(prodId));

            if (!IsPostBack)
            {
                ListItem categoryListItem = new ListItem("Select Category", "-1");
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

                inputName.Value = product.Name;
                price.Value = Convert.ToString(product.Price);
                id_part_description.Value = product.description;
                Image1.ImageUrl = product.ImageUrl;
                Image2.ImageUrl = product.ImageUrlThumbnail1;
                Image3.ImageUrl = product.ImageUrlThumbnail2;
                Image4.ImageUrl = product.ImageUrlThumbnail3;
                StatusDropDownList.Items.FindByValue(product.Status.ToString()).Selected = true;
                CategoryDropDownList.Items.FindByValue(product.CategoryId.ToString()).Selected = true;
            }
          
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
            catch (ArgumentOutOfRangeException ex)
            {
                ex.GetBaseException();
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

        protected void EditProduct(object sender, EventArgs e)
        {
            var product = new Product
            {   Id = Convert.ToInt32(prodId),
                Name = inputName.Value,
                Price = Convert.ToDecimal(price.Value),
                Status = Convert.ToInt32(StatusDropDownList.SelectedItem.Value),
                ImageUrl = Image1.ImageUrl,
                ImageUrlThumbnail1 = Image2.ImageUrl,
                ImageUrlThumbnail2 = Image3.ImageUrl,
                ImageUrlThumbnail3 = Image4.ImageUrl
            };

            client.EditProduct(product);
            Response.Redirect("createdProducts.aspx");
        }
    }
}