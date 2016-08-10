using Lucene.Net.Search;
using Sitecore.Data.Items;
using Sitecore.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning8.Controllers
{
    public class LuceneController : Controller
    {
        // GET: Lucene
        public void Index()
        {
            SearchManager.GetIndex("app_custom_master_index").Rebuild();
            //SearchManager.GetIndex("sitecore_master_index");

            using (IndexSearchContext indexSearchContext = SearchManager.GetIndex("app_custom_master_index").CreateSearchContext())
            {
                // MatchAllDocsQuery will return everything. Use proper query from the link below
                SearchHits hits = indexSearchContext.Search(new MatchAllDocsQuery(), int.MaxValue);
                // Get Sitecore items from the results of the query
                List<Item> items = hits.FetchResults(0, int.MaxValue).Select(result => result.GetObject<Item>()).Where(item => item != null).ToList();
            }
        }
    }
}