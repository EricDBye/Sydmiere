using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sydmiere
{
    public partial class CreateNotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveNote_OnClick(object sender, EventArgs e)
        {
            Database.SaveNotes(txtNotes.Text, Session["Username"].ToString());
            Response.Redirect("Home.aspx");
        }
    }
}