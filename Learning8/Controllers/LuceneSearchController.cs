using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning8.Controllers
{
    public class LuceneSearchController : Controller
    {
        // GET: LuceneSearch
        public void Index()
        {
            //var index = ContentSearchManager.GetIndex("sitecore_web_index");
            //using (var context = index.CreateSearchContext())
            //{
            //    var results = context.GetQueryable<SearchResultItem>()
            //            .Where(item => item.TemplateName == "Sample Item")
            //            .Where(item => item.Language == "en")
            //            .Take(10)
            //            .ToList();
            //}
        }
    }
}