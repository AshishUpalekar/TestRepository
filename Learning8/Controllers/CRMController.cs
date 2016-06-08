using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Learning8.Controllers
{
    public class CRMController : Controller
    {
        // GET: CRM
        public void Index()
        {
            string domainUser = Sitecore.Context.Domain.GetFullName("abc.test.com");
            Membership.CreateUser(domainUser, "Password", "abc.test.com");
            try
            {
                if (Sitecore.Security.Authentication.AuthenticationManager.Login(domainUser))
                {
                    var userProfile = Sitecore.Context.User.Profile;
                    userProfile["FirstName"] = "Ashish";
                    userProfile["LastName"] = "U";
                    userProfile["Country"] = "India";
                    userProfile["City"] = "Solapur";
                    userProfile["EmailAddress"] = "abc.test.com";
                    userProfile["Money"] = "20";
                    userProfile["BirthDate"] = DateTime.Now.ToShortDateString();
                    userProfile.Save();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}