using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreMVC.Models.TemplateModels.Base;
using Glass.Mapper.Sc;
using SitecoreMVC.Models;

namespace SitecoreMVC.Business.Shared
{
    public class SettingsLogic : ISettingsLogic
    {
        private readonly ISitecoreContext _currentContext;

        private Lazy<IScripts> _siteSettings;

        // make sure we use singleton and lazy load
        public SettingsLogic(ISitecoreContext currentContext)
        {
            _currentContext = currentContext;

            _siteSettings = new Lazy<IScripts>(() =>
            {
                return _currentContext.GetItem<IScripts>(Ids.Content.SiteSettings.Id); //this is a different way to do it compared to the social settings
            });
        }

        public IScripts SiteSettings
        {
            get
            {
                return _siteSettings.Value;
            }
        }
    }
}
