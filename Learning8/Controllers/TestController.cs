using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learning8.Models;

namespace Learning8.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            Entity testEntity = new Entity();
            //ViewBag.HtmlStr = "<table border=\"1\" style=\"width:300px\"><tr><td>Allen</td><td>Donald</td> <td>50</td></tr><tr><td>Steve</td><td>Waugh</td><td>94</td></tr></table></br></br>";
            
            ViewBag.HtmlStr = "<table border=\"1\" style=\"width:500px\"><tr><td colspan=\"2\">Registration Form</td></tr><tr><td>Enter Name </td><td><input type=\"text\" name=\"Custname\"></td></tr> <tr><td>Enter Address</td><td><input type=\"text\" name=\"CustAddr\"></td></tr><tr><td>Enter Email</td><td><input type=\"text\" name=\"CustEmail\"></td></tr><tr><td>Enter Phone</td><td><input type=\"text\" name=\"CustPhone\"></td></tr><tr><td colspan=\"2\"><input type=\"submit\" onclick=\"myFunction()\" value=\"Proceed\"></td></tr></table></br></br>";
            return View(testEntity.GetEntity(0));
        }

        public ActionResult Index2()
        {
            Entity testEntity = new Entity();
            //ViewBag.HtmlStr = "<table  border=\"1\" style=\"width:500px\"><tr><td>Rahul</td><td>Dravid</td> <td>50</td></tr><tr><td>Sachin</td><td>Tendulkar</td><td>94</td></tr></table>";

            ViewBag.HtmlStr = "<table border=\"1\" style=\"width:500px\"><tr><td colspan=\"2\">Welcome Mr. Ashish U. </td></tr> <tr><td>Emergency Contact</td><td><input type=\"text\" name=\"CustContact\"></td></tr><tr><td>Blood Group</td><td><input type=\"text\" name=\"CustBldGrp\"></td></tr><tr><td>Monthly Income</td><td><input type=\"text\" name=\"CustEmail\"></td></tr><tr><td>Family Size</td><td><input type=\"text\" name=\"CustPhone\"></td></tr><tr><td colspan=\"2\"><input type=\"submit\" value=\"Submit\"></td></tr></table></br></br>";
            return View("Index", testEntity.GetEntity(1));
        }

        public ActionResult TestAjax(string jsonData)
        {
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }


        
    }
}