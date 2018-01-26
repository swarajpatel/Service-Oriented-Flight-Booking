using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using enc_dec_lib;

namespace Assignment5_2
{
    public partial class Staff_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["staff_username"] != null)
            {
                Response.Redirect("Staff_page.aspx");
            }
        }

        protected void LoginFunc(object sender, EventArgs e)
        {
            XDocument xPlatformXml = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/Staff.xml"));
            string enc_psw = Enc_dec.Encrypt(Password.Text);
            string id = UserName.Text;
            string output = "";

            XElement xel = xPlatformXml.Element("AccRoot")
                                           .Elements("account")
                                           .Where(x => x.Element("name").Value == id)
                                           .Where(x => x.Element("password").Value == enc_psw)
                                           .SingleOrDefault();
            if (xel != null)
            {
                output = "true";
                if (Session["member_username"] != null)
                {
                    Session.Clear();
                    if(Request.Cookies["member_login"] != null)
                    {
                        Request.Cookies["member_login"].Expires = DateTime.Now.AddDays(-1d);
                    }
                }
                Session["staff_username"] = UserName.Text;
                Response.Redirect("Staff_page.aspx");
            }
            else
                output = "Wrong username or password!s";

            Output.Text = output;
        }
    }
}