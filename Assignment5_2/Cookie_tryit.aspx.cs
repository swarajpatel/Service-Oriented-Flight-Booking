using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class Cookie_tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["member_login"] != null)
            {
                sessioncheck.Text = Request.Cookies["member_login"]["username"];
            }
            else
            {
                sessioncheck.Text = "No cookie present!";
            }
        }
    }
}