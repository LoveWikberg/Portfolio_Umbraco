using Portfolio_Umbraco_Site.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Portfolio_Umbraco_Site.Code.Controllers
{
    public class HomeController : SurfaceController, IRenderMvcController
    {
        public ActionResult Index(RenderModel model)
        {
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            var umbracoPageId = (int)PageIds.Home;
            IPublishedContent content = umbracoHelper.TypedContent(umbracoPageId);
            var lol = content.GetPropertyValue<string>("TestOne");
            HomeViewModel test = new HomeViewModel
            {
                Beeees = "LALLE",
                Kuuus = "ASDASD",
                Laaaang = "ÖPPPPP",
                Jalla = lol
            };

            return View(test);
        }

        enum PageIds
        {
            Home = 1065,
        }

    }
}