using SitecoreMVC.Models;
using SitecoreMVC.Models.TemplateModels.Social;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.SitecoreSettings
{
    public interface ISitecoreSiteLogic
    {
        IGlassBase RootItem { get; }
        string SiteName { get; }
        string TargetHostName { get; }
        string HostName { get; }
        Hashtable Settings { get; }
        ISocialSettings SocialSettings { get; }
    }
}
