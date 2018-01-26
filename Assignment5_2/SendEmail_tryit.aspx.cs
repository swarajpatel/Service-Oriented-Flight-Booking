using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class SendEmail_tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            URL.Text = "URL : " + HttpContext.Current.Request.Url.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = "Sent!";
            string rec = TextBox1.Text;
           Santosh_ref.Service1Client cl = new Santosh_ref.Service1Client();
            cl.sendEmail(TextBox1.Text, TextBox2.Text);
        }
    }
}