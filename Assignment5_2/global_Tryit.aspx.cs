using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class global_Tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member_username"] != null)
            {
                sessioncheck.Text = Session["member_username"].ToString();
            }
            else {
                sessioncheck.Text = "No cookie present!";
            }
        }
    }
}