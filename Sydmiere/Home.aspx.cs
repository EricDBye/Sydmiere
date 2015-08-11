using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sydmiere
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void myDayRenderMethod(object sener, DayRenderEventArgs e)
        {
            if (!Database.getDate((DateTime)e.Day.Date, Session["Username"].ToString()))
            {
                e.Day.IsSelectable = false;
                e.Cell.Font.Strikeout = true;
                e.Cell.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Day.IsSelectable = true;
                e.Cell.Font.Strikeout = false;
                e.Cell.BackColor = System.Drawing.Color.PowderBlue;
            }
        }

        protected void lnkCreateNotes_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("CreateNotes.aspx");
        }
    }
}