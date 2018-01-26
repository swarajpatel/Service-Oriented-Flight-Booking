using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_2
{
    public partial class Member_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member_username"] != null)
                Label1.Text =  Session["member_username"].ToString();
            else
                Response.Redirect("Member_login.aspx");
        }

        protected void Logoutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (HttpContext.Current.Request.Cookies["member_login"] != null)
                {
                    HttpCookie myCookie = Request.Cookies["member_login"];
                    myCookie.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Add(myCookie);
                }
            }
            catch (Exception)
            {
                Session.Clear();
            }
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
        String msg = "";
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Santosh_ref.Service1Client cl1 = new Santosh_ref.Service1Client();
            string pass = DropDownList1.SelectedValue + DropDownList2.SelectedValue;
            string result = cl1.Flight_Lookup(pass);
            if (result.Length == 0)
                Label4.Text = "No flights available!";
            string[] arr = result.Split('|');
            CheckBoxList1.Items.Clear();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                string[] words = arr[i].Split(',');

                CheckBoxList1.Items.Add("Serial no:" + words[0] + ", " + "Flight no:" + words[1] + ", " + "Cost:" + words[2] + ", " + "Airlines:" + words[3]);

            }

            String zip = "";
            switch (DropDownList2.SelectedValue)
            {
                case "AZ":
                    zip = "85281";
                    break;
                case "NY":
                    zip = "10007";
                    break;
                case "BO":
                    zip = "02116";
                    break;
            }
            Random r = new Random();
            int ran = r.Next(1, 3);

            DateTime date = Convert.ToDateTime(TextBox1.Text);
            //date = (DateTime.Now).AddDays(ran);
            
            Swaraj_ref.Service1Client cl2 = new Swaraj_ref.Service1Client();
            String output = cl2.GetData(zip, date);
            String[] arr2 = output.Split('|');

            string st = arr2[2];

            int f1 = st.IndexOf("Temperature");
            String st1 = st.Substring(f1 + 11);
            int f2 = st1.IndexOf("Daily");
            String st2 = st1.Substring(0, f2);
            st2 = st2.Trim();

            String st3 = st1.Substring(f2 + 25);
            int f3 = st3.IndexOf("12");
            String st4 = st3.Substring(0, f3);
            st4 = st4.Trim();

            //Label3.Text = "Date selected = " + date;
            Label2.Text = "Maximum Temperature = " + st2.Substring(0, st2.Length - 1);
            Label3.Text = "Minimum Temperature = " + st4.Substring(0,st4.Length-1);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            msg = "Selected Item(s):<br /><br />";

            // Iterate through the Items collection of the CheckBoxList 
            // control and display the selected items.
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {

                if (CheckBoxList1.Items[i].Selected)
                {

                    msg += CheckBoxList1.Items[i].Text + "<br />";

                }

            }

            Santosh_ref.Service1Client client = new Santosh_ref.Service1Client();
            client.sendEmail(Session["member_username"].ToString(), msg);
            Label5.Text = "Email of selected flight details sent to " + Session["member_username"].ToString();
        }
    }
}