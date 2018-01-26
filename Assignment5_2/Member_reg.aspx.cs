using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using enc_dec_lib;

namespace Assignment5_2
{
    public partial class Member_reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member_username"] != null)
            {
                Response.Redirect("Member_page.aspx");
            }

            string password = Password.Text;
            Password.Attributes.Add("value", password);
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
                Label2.Text = control.outputz;


            string username = UserName.Text;
            string enc_psw = Enc_dec.Encrypt(Password.Text);
            string email = Email.Text;

            if ((Label2.Text) == ("Verified."))
            {
                string fileName = HttpContext.Current.Server.MapPath("../page4/members.xml");

                //If the file does not exist then create a new xml file
                if (!File.Exists(fileName))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("AccRoot");
                        xmlWriter.WriteStartElement("account");

                        xmlWriter.WriteElementString("name", username);
                        xmlWriter.WriteElementString("email", email);
                        xmlWriter.WriteElementString("password", enc_psw);


                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                    Response.Redirect("Member_login.aspx");
                    Output.Text = "Account created."; //Account created Sucessfully
                }
                //Else check if the file contains the user already based on email and insert into the xml file if it doesnt exist.
                else
                {
                    int flag = 0;

                    XDocument xPlatformXml = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/members.xml"));

                    XElement xel = xPlatformXml.Element("AccRoot")
                                               .Elements("account")
                                               .Where(x => x.Element("email").Value == email)
                                               .SingleOrDefault();
                    if (xel != null)
                    {
                        flag = 1;
                    }

                    if (flag == 1)
                    {
                        Output.Text = "Account already exists.";   //Account already exists
                    }
                    else
                    {
                        XDocument xDocument = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/members.xml"));
                        XElement accRoot = xDocument.Root;
                        accRoot.Add(new XElement("account",
                                   new XElement("name", username),
                                   new XElement("email", email),
                                   new XElement("password", enc_psw)
                                   ));
                        xDocument.Save(HttpContext.Current.Server.MapPath("../page4/members.xml"));

                        Response.Redirect("Member_login.aspx");
                        Output.Text = "Account created."; //Account created successfully
                    }
                }
            }
            else
            {
                Output.Text = "Captcha not verified.";
            }
        }
    }
}