using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Portfolio_Umbraco_Site.Code.Models
{
    public class UmbracoCustomHelper
    {
        public string GetImageUrl(int umbracoPageId, string propertyName)
        {
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);

            IPublishedContent content = umbracoHelper.TypedContent(umbracoPageId);
            var imageId = content.GetPropertyValue(propertyName);
            var lull = content.GetProperty(propertyName);
            var aosdj = imageId.GetType();
            var imageUrl = umbracoHelper.Media(imageId);
            var lpalspl = imageUrl.Content.Url;
            return imageUrl;
        }
    }
}