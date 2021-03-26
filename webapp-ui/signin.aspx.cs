using System;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class SignIn : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login(object sender, EventArgs e)
        {
            var isLogin = client.Login(id_email.Value,id_password.Value);

            Session["Email"] = id_email.Value;
            
            if (isLogin == true)
            {
                Session["cartSessionId"] = client.getUserbyEmail(id_email.Value).Id;
                Response.Redirect("Index.aspx");
            }
            
        }
    }
}