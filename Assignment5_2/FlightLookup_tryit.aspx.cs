using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class FlightLookup_tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            URL.Text = "URL : " + HttpContext.Current.Request.Url.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Santosh_ref.Service1Client cl = new Santosh_ref.Service1Client();
            string pass = TextBox1.Text + TextBox2.Text;
            string result = cl.Flight_Lookup(pass);
            string[] arr = result.Split('|');
            string output = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                string[] words = arr[i].Split(',');
                output += "Serial no:" + words[0] + "<br/>" + "Flight no:" + words[1] + "<br/>" + "Cost:" + words[2] + "<br/>" + "Airlines:" + words[3] + "<br/><br/>";
            }
            Label3.Text = output;
        }
    }
}