using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string flights = "";
        string e_no;
        string e_flightno;
        string e_cost;
        string e_airlines;

        public string Flight_Lookup(string ToFrom)
        {
            //location of xml file in server
            XDocument doc1 = XDocument.Load("http://webstrar13.fulton.asu.edu/page4/flights1.xml");

            //gives a set of nodes with ToFrom as parent
            var selectors = from elements in doc1.Elements("FlightRoot").Elements("flight").Elements(ToFrom) select elements;
            foreach (var element in selectors)
            {
                e_flightno = element.Element("serialno").Value;
                e_no = element.Element("no").Value;
                e_cost = element.Element("cost").Value;
                e_airlines = element.Element("airlines").Value;
                flights += e_flightno + "," + e_no + "," + e_cost + "," + e_airlines + "|";
            }
            return flights;
        }

        public void sendEmail(string rece, string msg1)
        {
            //Emails will be sent by this email ID
            string sender = "rrandom890@gmail.com";
            string password = "1-203e4R";

            //creating new credentials
            NetworkCredential login = new NetworkCredential(sender, password);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            MailMessage msg = new MailMessage();

            //setting attributes of EMail
            msg.From = new MailAddress(sender);
            msg.To.Add(new MailAddress(rece));
            msg.Subject = "Ticket Confirmation";
            msg.Body = msg1;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            client.Send(msg);
        }
    }
}
