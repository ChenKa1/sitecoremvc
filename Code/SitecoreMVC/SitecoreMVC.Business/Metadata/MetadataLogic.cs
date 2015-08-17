using Glass.Mapper.Sc;
using Sitecore.Text;
using SitecoreMVC.Business.SitecoreSettings;
using SitecoreMVC.Models;
using SitecoreMVC.Models.ViewModels.SEO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Metadata
{
    public class MetadataLogic : IMetadataLogic
    {
        private readonly ISitecoreContext _currentContext;
        private readonly ISitecoreSiteLogic _sitecoreSiteLogic;

        public MetadataLogic(ISitecoreContext currentContext, ISitecoreSiteLogic sitecoreSiteLogic)
        {
            _currentContext = currentContext;
            _sitecoreSiteLogic = sitecoreSiteLogic;
        }

        public string GetMetatags()
        {
            StringBuilder metaTags = new StringBuilder();

            string ogTitle = String.Empty;
            string metaDescription = String.Empty;

            IPageMetadata metadata = _currentContext.GetCurrentItem<IPageMetadata>();

            if (metadata != null)
            {
                if (metadata.NoIndex)
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaName, SiteConstants.Metadata.Robots, SiteConstants.Metadata.NoIndex);

                if (metadata.NoODP)
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaName, SiteConstants.Metadata.Robots, SiteConstants.Metadata.NoODP);

                if (metadata.NoYdir)
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaName, SiteConstants.Metadata.Robots, SiteConstants.Metadata.NoYdir);

                string metaTitle = String.Empty;
                if (!string.IsNullOrEmpty(metadata.BrowserTitle))
                {
                    metaTitle = metadata.BrowserTitle;
                    ogTitle = metadata.BrowserTitle;
                }
                else
                {
                    metaTitle = metadata.Title;
                    ogTitle = metadata.Title;
                }

                metaDescription = metadata.MetaDescription;

                UrlString url = new UrlString(metadata.Url);
                url.HostName = _sitecoreSiteLogic.TargetHostName;

                metaTags.AppendFormat(SiteConstants.Metadata.MetaTitleTag, metaTitle);

                if (!string.IsNullOrEmpty(metadata.MetaKeywords))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaName, SiteConstants.Metadata.Keywords, metadata.MetaKeywords);

                if (!string.IsNullOrEmpty(metadata.MetaDescription))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaName, SiteConstants.Metadata.Description, metadata.MetaDescription);

                //Facebook Global
                if (_sitecoreSiteLogic.SocialSettings != null)
                {
                    if (!string.IsNullOrEmpty(_sitecoreSiteLogic.SocialSettings.OGSiteName))
                        metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGSiteName, _sitecoreSiteLogic.SocialSettings.OGSiteName);

                    if (!string.IsNullOrEmpty(_sitecoreSiteLogic.SocialSettings.FBAdmins))
                        metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.FBAdmins, _sitecoreSiteLogic.SocialSettings.FBAdmins);

                }

                if (metadata.OGImage != null)
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGImage, metadata.OGImage.Src);

                if (!string.IsNullOrEmpty(metadata.OGType))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGType, metadata.OGType);


                //Facebook
                if (!string.IsNullOrEmpty(metadata.OGTitle))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGTitle, metadata.OGTitle);
                else if (!String.IsNullOrEmpty(ogTitle))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGTitle, ogTitle);

                if (!string.IsNullOrEmpty(metadata.OGDescription))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGDescription, metadata.OGDescription);
                else if (!String.IsNullOrEmpty(metaDescription))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGDescription, metaDescription);

                metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.OGUrl, url.ToString());

                //twitter
                if (_sitecoreSiteLogic.SocialSettings != null)
                {
                    if (!string.IsNullOrEmpty(_sitecoreSiteLogic.SocialSettings.TwitterSite))
                        metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterSite, _sitecoreSiteLogic.SocialSettings.TwitterSite);

                }

                if (metadata.TwitterImage != null)
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterImage, metadata.TwitterImage.Src);

                if (!string.IsNullOrEmpty(metadata.TwitterCard))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterCard, metadata.TwitterCard);

                if (!string.IsNullOrEmpty(metadata.TwitterTitle))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterTitle, metadata.TwitterTitle);
                else if (!String.IsNullOrEmpty(ogTitle))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterTitle, ogTitle);

                if (!string.IsNullOrEmpty(metadata.TwitterDescription))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterDescription, metadata.TwitterDescription);
                else if (!String.IsNullOrEmpty(metaDescription))
                    metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterDescription, metaDescription);

                metaTags.AppendFormat(SiteConstants.Metadata.MetaProperty, SiteConstants.Metadata.TwitterUrl, url.ToString());
            }
            
            return metaTags.ToString();
        }
    }
}
