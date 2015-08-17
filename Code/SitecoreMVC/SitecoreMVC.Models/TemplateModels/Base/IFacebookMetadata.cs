using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface IFacebookMetadata
    {
        string OGTitle { get; set; }

        string OGType { get; set; }

        Image OGImage { get; set; }

        string OGDescription { get; set; }
    }
}
