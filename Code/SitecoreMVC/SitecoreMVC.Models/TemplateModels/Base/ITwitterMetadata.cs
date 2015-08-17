using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.TemplateModels.Base
{
    public interface ITwitterMetadata
    {
        string TwitterCard { get; set; }

        string TwitterTitle { get; set; }

        string TwitterDescription { get; set; }

        Image TwitterImage { get; set; }
    }
}
