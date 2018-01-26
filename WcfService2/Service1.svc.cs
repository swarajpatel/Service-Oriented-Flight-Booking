using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(String Zipcode, DateTime date)
        {
            weather.ndfdXML myWeather = new weather.ndfdXML();
            String xml = myWeather.LatLonListZipCode(Zipcode);
            //service that retunrs latitude and longitude in an XML string
            String s = "";
            //to extract required data in string format from XML string
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                reader.ReadToFollowing("latLonList");
                s = reader.ReadElementContentAsString();
            }
            //Separating latitude and longitude
            String[] arr = s.Split(',');
            String lati = arr[0];
            String longi = arr[1];

            Decimal lat = Convert.ToDecimal(arr[0]);
            Decimal lon = Convert.ToDecimal(arr[1]);
            //the funtion returns a string with Weather data we are appending latitude and longitude
            String st = lati + "|" + longi + "|" + myWeather.NDFDgenByDay(lat, lon, date, "6", "e", "24 hourly");
            System.Threading.Thread.Sleep(2000);
            return st;
        }
    }
}
