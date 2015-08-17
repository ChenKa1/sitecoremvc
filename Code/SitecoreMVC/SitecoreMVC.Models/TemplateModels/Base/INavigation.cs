using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface INavigation
    {
        string NavigationTitle { get; set; }

        bool ExcludeFromNavigation { get; set; }
    }
}
