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
    public partial class Member_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member_username"] != null)
            {
                Response.Redirect("Member_page.aspx");
            }
        }

        protected void LoginFunc(object sender, EventArgs e)
        {
            
            XDocument xPlatformXml = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/members.xml"));
            string enc_psw = Enc_dec.Encrypt(Password.Text);
            string id = UserName.Text;
            string output = "";

            XElement xel = xPlatformXml.Element("AccRoot")
                                           .Elements("account")
                                           .Where(x => x.Element("email").Value == id)
                                           .Where(x => x.Element("password").Value == enc_psw)
                                           .SingleOrDefault();
            if (xel != null)
            {
                output = "Login Successful";
                if (Session["staff_username"] != null)
                {
                    Session.Clear();
                }
                Session["member_username"] = UserName.Text;
                if (Persistent.Checked)
                {
                    HttpCookie mycookie = new HttpCookie("member_login");
                    mycookie["username"] = UserName.Text;
                    mycookie.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(mycookie);
                }
                

                Response.Redirect("Member_page.aspx");
            }
            else
                output = "Wrong username or password!s";

            Output.Text = output;
        }
    }
}