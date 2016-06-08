using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace Learning8.Controllers
{
    public class WebServiceController : Controller
    {

        // GET: WebService
        public ActionResult Index()
        {

            var visualSitecoreService = new SitecoreWS.VisualSitecoreServiceSoapClient();
            string database = "master";
            SitecoreWS.Credentials credentials = new SitecoreWS.Credentials();
            credentials.UserName = @"sitecore\admin";
            credentials.Password = "b";

            string homeItem = "{641783AA-0EF2-4117-9503-C5CEA36E32F3}";
            string homeItem2 = "{180A9978-A7F5-4AF3-AEA3-7E4062177DAA}";
            //string parentItem = "{C5384188-D4B4-4C09-A053-094271353190}";


            var children = visualSitecoreService.GetChildren(homeItem2, database, credentials);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(children.ToString());

            string xpath = "sitecore/item/@id";
            var nodes = xmlDoc.SelectNodes(xpath);

            foreach (XmlNode childrenNode in nodes) 
            {
                //childrenNode.Value
                var item = visualSitecoreService.GetItemFields(childrenNode.Value, "en", "1", true, database, credentials);
                    //var getItem = sitecoreService.GetItemFields(getChildren.ChildNodes[i].Attributes[0].Value, "en", "1", true, database, myCred);

            }

            using (XmlReader reader = XmlReader.Create((new StringReader(children.ToString()))))
            {
                XDocument loaded = XDocument.Load(reader);

                var q = from c in loaded.Descendants("id")
                        select (string)c.Value;

                
                foreach (string name in q)
                    Console.WriteLine("Item name = {0}", name);
            }

            DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart")
    .SetXAxis(new XAxis
    {
        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
    })
    .SetSeries(new Series
    {
        Data = new Data(new object[] { 29.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 })
    });

            return View(chart);


            //string parentId = "{37F01BDF-AAF4-4C0C-87A0-CD26220F783D}";
            //string templateId = "{1D7ADB59-3AB0-4131-93AB-AADE26297D65}";


            //while (true)
            //{
            //    Console.WriteLine("Sitecore Terminal Web Service Integration");
            //    Console.WriteLine("=========================================");
            //    var children = visualSitecoreService.GetChildren(parentId, database, credentials);
            //    using (System.Xml.XmlReader reader =
            //    XmlReader.Create((new System.IO.StringReader(children.ToString()))))
            //    {
            //        XDocument loaded = XDocument.Load(reader);
            //        var q = from c in loaded.Descendants("item")
            //                select (string)c.Value;
            //        Console.WriteLine("Number of added items in Sitecore = " + q.Count().ToString() + "" + Environment.NewLine);
            //        foreach (string name in q)
            //            Console.WriteLine("Item name = {0}", name);
            //        Console.WriteLine(Environment.NewLine);
            //    }
            //    Console.WriteLine("=========================================" +
            //    Environment.NewLine);
            //    Console.WriteLine("Enter a name for the new Item:" +
            //    Environment.NewLine);
            //    string itemName = Console.ReadLine();
            //    var result = visualSitecoreService.AddFromTemplate(parentId, templateId, itemName, database, credentials);
            //    Console.WriteLine("Item '" + itemName + "' is added.");
            //    Console.WriteLine("Press key to continue");
            //    Console.ReadKey();
            //    Console.Clear();

            //    return View();
            //}
            //}
        }
    }
}