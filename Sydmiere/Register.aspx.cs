using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sydmiere
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_OnClick(object sender, EventArgs e)
        {
            bool success = true;
            if (txtPassword.Text != txtConfirmPassword.Text)
                success = false;
            if (Database.existsUsername(txtUsername.Text))
            {
                success = false;
            }
            if(txtUsername.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "")
            {
                success = false;
            }
            if (success == true)
            {
                Database.register(txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text);
            }
            Response.Redirect("Default.aspx");
        }
    }
}