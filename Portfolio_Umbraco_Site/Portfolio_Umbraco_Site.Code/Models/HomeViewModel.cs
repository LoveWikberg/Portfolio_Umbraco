using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Portfolio_Umbraco_Site.Code.Models
{
    public class HomeViewModel : RenderModel
    {
        public HomeViewModel() : this(UmbracoContext.Current.PublishedContentRequest.PublishedContent) { }

        public HomeViewModel(IPublishedContent content) : base(content)
        {

        }
        public string Kuuus { get; set; }
        public string Beeees { get; set; }
        public string Laaaang { get; set; }
        public string Jalla { get; set; }
    }
}