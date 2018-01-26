using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class Weather_tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            URL.Text = "Localhost URL : " + HttpContext.Current.Request.Url.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Swaraj_ref.Service1Client client = new Swaraj_ref.Service1Client();
            String output = client.GetData(Convert.ToString(TextBox1.Text),DateTime.Now);
            String[] arr = output.Split('|');
            val1.Text = "Latitude of Zipcode = " + arr[0];
            val2.Text = "Longitude of Zipcode = " + arr[1];

            String st = arr[2];

            int f1 = st.IndexOf("Temperature");
            String st1 = st.Substring(f1 + 11);
            int f2 = st1.IndexOf("Daily");
            String st2 = st1.Substring(0, f2);
            st2 = st2.Trim();
            val3.Text = "Maximum Temperature = " + st2;

            String st3 = st1.Substring(f2 + 25);
            int f3 = st3.IndexOf("12");
            String st4 = st3.Substring(0, f3);
            st4 = st4.Trim();
            val4.Text = "Minimum Temperature = " + st4;
        }
    }
}