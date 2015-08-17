using Glass.Mapper.Sc;
using Sitecore.Text;
using SitecoreMVC.Business.SitecoreSettings;
using SitecoreMVC.Models.TemplateModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Metadata
{
    public class CanonicalLink : ICanonicalLink
    {
        private readonly ISitecoreContext _currentContext;
        private readonly ISitecoreSiteLogic _sitecoreSiteLogic;

        public CanonicalLink(ISitecoreContext currentContext, ISitecoreSiteLogic sitecoreSiteLogic)
        {
            _currentContext = currentContext;
            _sitecoreSiteLogic = sitecoreSiteLogic;
        }

        public string GetCanonicalLink()
        {
            string canonicalLink = "";

            ICanonical currentPage = _currentContext.GetCurrentItem<ICanonical>();

            if (currentPage != null && currentPage.CanonicalLink != null && !string.IsNullOrEmpty(currentPage.CanonicalLink.Url))
            {
                UrlString url = new UrlString(currentPage.CanonicalLink.Url);
                url.HostName = _sitecoreSiteLogic.TargetHostName;

                canonicalLink = "<link rel=\"canonical\" href=\"" + url.ToString() + "\"/>";
            }
            return canonicalLink;
        }
    }
}
