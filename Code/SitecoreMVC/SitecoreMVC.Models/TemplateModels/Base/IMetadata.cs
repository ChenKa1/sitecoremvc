using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface IMetadata
    {
        string BrowserTitle { get; set; }

        string MetaKeywords { get; set; }

        string MetaDescription { get; set; }

        bool NoIndex { get; set; }

        bool NoYdir { get; set; }

        bool NoODP { get; set; }
    }
}
