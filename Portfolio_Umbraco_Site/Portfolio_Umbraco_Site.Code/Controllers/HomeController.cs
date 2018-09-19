using Portfolio_Umbraco_Site.Code.Models;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Portfolio_Umbraco_Site.Code.Controllers
{
    public class HomeController : BaseController, IRenderMvcController
    {
        private UmbracoHelper _umbracoHelper;
        private UmbracoCustomHelper _umbracoCustomHelper;

        public HomeController() : this(new UmbracoCustomHelper()) { }

        public HomeController(UmbracoCustomHelper umbracoCustomHelper)
        {
            _umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            _umbracoCustomHelper = umbracoCustomHelper;
        }

        public ActionResult Index(RenderModel model)
        {
            HomeViewModel test = new HomeViewModel
            {
                Beeees = "LALLE",
                Kuuus = "ASDASD",
                Laaaang = "ÖPPPPP",
                ParalaxImageUrl = _umbracoCustomHelper.GetImageUrl((int)PageIds.Home, "ProfileImage")
            };

            return View(test);
        }



    }
}