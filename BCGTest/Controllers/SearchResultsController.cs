using Examine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace BCGTest.Controllers
{
    public class SearchResultsController : RenderMvcController
    {
        // GET: Search
        //public ActionResult Index(RenderModel model, string searchTerm)
        //{
        //    var searcher = ExamineManager.Instance.SearchProviderCollection["SiteSearcher"];
        //    var searchResults = searcher.Search(searchTerm, true).OrderByDescending(x => x.Score).TakeWhile(x => x.Score > 0.05f);

        //    return CurrentTemplate();
        //}

        public override ActionResult Index(RenderModel model)
        {

            // Do some stuff here, then return the base method
            return base.Index(model);
        }
    }
}