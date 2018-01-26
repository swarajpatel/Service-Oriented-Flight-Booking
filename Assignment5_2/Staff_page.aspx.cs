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
    public partial class Staff_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["staff_username"] != null)
            {
                Label1.Text = Session["staff_username"].ToString();
            }
            else
                Response.Redirect("Staff_login.aspx");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string name = UserName.Text;
            string enc_psw = Enc_dec.Encrypt(Password.Text);

            string fileName = HttpContext.Current.Server.MapPath("../page4/Staff.xml");

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

                    xmlWriter.WriteElementString("name", name);
                    xmlWriter.WriteElementString("password", enc_psw);


                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
                Output.Text = "Account added."
                    ; //Account created Sucessfully
            }
            //Else check if the file contains the user already based on email and insert into the xml file if it doesnt exist.
            else
            {
                int flag = 0;

                XDocument xPlatformXml = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/Staff.xml"));

                XElement xel = xPlatformXml.Element("AccRoot")
                                           .Elements("account")
                                           .Where(x => x.Element("name").Value == name)
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
                    XDocument xDocument = XDocument.Load(HttpContext.Current.Server.MapPath("../page4/Staff.xml"));
                    XElement accRoot = xDocument.Root;
                    accRoot.Add(new XElement("account",
                               new XElement("name", name),
                               new XElement("password", enc_psw)
                               ));
                    xDocument.Save(HttpContext.Current.Server.MapPath("../page4/Staff.xml"));

                    Output.Text = "Account created."; //Account created successfully
                }
            }
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}