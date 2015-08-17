using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Social
{
    public interface ISocialSettings
    {
        string OGSiteName { get; set; }

        string FBAdmins { get; set; }

        string TwitterSite { get; set; }
    }
}
