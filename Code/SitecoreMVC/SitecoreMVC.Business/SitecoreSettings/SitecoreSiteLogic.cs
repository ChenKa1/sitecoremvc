using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMVC.Models;
using System.Xml;
using Sitecore.Configuration;
using Sitecore.Xml;
using Glass.Mapper.Sc;
using Sitecore.Sites;
using SitecoreMVC.Models.TemplateModels.Social;

namespace SitecoreMVC.Business.SitecoreSettings
{
    public class SitecoreSiteLogic : ISitecoreSiteLogic
    {
        private readonly SiteContext _siteContext;
        private readonly ISitecoreContext _currentContext;

        private Hashtable _settings = new Hashtable();

        public SitecoreSiteLogic(ISitecoreContext currentContext)
        {
            _siteContext = Sitecore.Context.Site;
            _currentContext = currentContext;

            LoadSettings();
        }

        public IGlassBase RootItem
        {
            get
            {
                return _currentContext.GetItem<IGlassBase>(_siteContext.RootPath);
            }
        }

        public string SiteName
        {
            get { return _siteContext.Name; }
        }

        public string TargetHostName
        {
            get
            {
                return _siteContext.TargetHostName;
            }
        }

        public string HostName
        {
            get
            {
                return _siteContext.HostName;
            }
        }

        public Hashtable Settings
        {
            get
            {
                return _settings;
            }
        }

        public ISocialSettings SocialSettings
        {
            get
            {
                if (!string.IsNullOrEmpty(_siteContext.Properties[SiteConstants.Strings.SocialSettingsAttribute]))
                    return _currentContext.GetItem<ISocialSettings>(_siteContext.Properties[SiteConstants.Strings.SocialSettingsAttribute]);
                else
                    return null;
            }
        }

        private void LoadSettings()
        {
            //load settings
            XmlNodeList configNodes = Factory.GetConfigNodes("settings/setting");
            if (configNodes != null)
            {
                foreach (XmlNode configNode in configNodes)
                {
                    string attribute = XmlUtil.GetAttribute("name", configNode);
                    string str = XmlUtil.GetAttribute("value", configNode);
                    if (attribute.Length <= 0)
                    {
                        continue;
                    }
                    _settings[attribute] = str;
                }
            }
        }
    }
}
