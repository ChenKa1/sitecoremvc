using SitecoreMVC.Models.TemplateModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Shared
{
    public interface ISettingsLogic
    {
        IScripts SiteSettings { get; }
    }
}
