using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sydmiere
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                lblUsername.Visible = true;
                txtUsername.Visible = true;
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                btnLogin.Visible = true;
                lnkRegister.Visible = true;
                lblAccount.Visible = false;
            }
            else
            {
                lblUsername.Visible = false;
                txtUsername.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
                lnkRegister.Visible = false;
                lblAccount.Visible = true;
                lblAccount.Text = Session["Username"].ToString();
            }
            lblIncorrect.Visible = false;
        }
        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            String correctHash = Database.getDBHash(txtUsername.Text);
            if (PasswordHash.ValidatePassword(txtPassword.Text, correctHash) == true)
            {
                Session["Username"] = txtUsername.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblIncorrect.Visible = true;
            }
        }

        protected void lnkRegister_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}