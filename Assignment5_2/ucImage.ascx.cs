using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class ucImage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private static Random random = new Random();
        string rand = "";
        public string outputz
        {
            get { return Label1.Text; }
            set { Label1.Text = value; }
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void loadCapchaImage()
        {
            rand = RandomString(5);
            Session["generatedStr"] = rand;
            Image1.Visible = true;
            Image1.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + rand;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loadCapchaImage();
            Button1.Text = "Reload";
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["generatedStr"].Equals(TextBox1.Text))
            {
                Label1.Text = "Verified.";
            }
            else
            {
                Label1.Text = "Try again.";
            }
        }
    }
}