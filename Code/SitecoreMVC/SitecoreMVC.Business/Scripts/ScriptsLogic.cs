using Glass.Mapper.Sc;
using SitecoreMVC.Business.Shared;
using SitecoreMVC.Models.TemplateModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Scripts
{
    public class ScriptsLogic : IScriptsLogic
    {
        private readonly ISitecoreContext _currentContext;
        private readonly ISettingsLogic _settings;

        public ScriptsLogic(ISitecoreContext currentContext, ISettingsLogic settings)
        {
            _currentContext = currentContext;
            _settings = settings;
        }

        public string GetEndBodyScripts()
        {
            StringBuilder endBodyScripts = new StringBuilder();

            endBodyScripts.Append(_settings.SiteSettings.EndBodyScripts);

            /* page specific */
            IScripts pageScripts = _currentContext.GetCurrentItem<IScripts>();

            endBodyScripts.Append(pageScripts.EndBodyScripts);
            return endBodyScripts.ToString();
        }

        public string GetHeaderScripts()
        {
            StringBuilder headerScripts = new StringBuilder();

            headerScripts.Append(_settings.SiteSettings.HeaderScripts);

            /* page specific */
            IScripts pageScripts = _currentContext.GetCurrentItem<IScripts>();

            headerScripts.Append(pageScripts.HeaderScripts);
            return headerScripts.ToString();
        }

        public string GetStartBodyScripts()
        {
            StringBuilder startBodyScripts = new StringBuilder();

            startBodyScripts.Append(_settings.SiteSettings.StartBodyScripts);

            /* page specific */
            IScripts pageScripts = _currentContext.GetCurrentItem<IScripts>();

            startBodyScripts.Append(pageScripts.StartBodyScripts);
            return startBodyScripts.ToString();
        }
        
    }
}
