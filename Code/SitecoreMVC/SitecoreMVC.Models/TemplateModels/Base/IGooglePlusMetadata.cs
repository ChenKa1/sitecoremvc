using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface IGooglePlusMetadata
    {
        string GoogleTitle { get; set; }

        string GoogleDescription { get; set; }

        Image GoogleImage { get; set; }

        string GoogleType { get; set; }
    }
}
