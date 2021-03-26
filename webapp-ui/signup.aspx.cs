using System;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class SignUp : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Register(object sender, EventArgs e)
        {
           
            var register = new User
            {
                Name = id_fullname.Value,
                LastName = LastName.Value,
                Email = id_email.Value,
                Password = id_password.Value
            };
         
            var regValue = client.Register(register);
           
            if(regValue == 1)
            {
                Response.Redirect("SignIn.aspx");
            }
            else if(regValue == 0)
            {
                Response.Redirect("Home.aspx");
            }
           
        }
    }
}