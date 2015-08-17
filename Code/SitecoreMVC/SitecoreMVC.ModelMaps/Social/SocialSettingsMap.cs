using Glass.Mapper.Sc.Maps;
using SitecoreMVC.Models.TemplateModels.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.ModelMaps.Social
{
    //
    public class SocialSettingsMap : SitecoreGlassMap<ISocialSettings>
    {
        public override void Configure()
        {
            Map(x =>
            {
                x.AutoMap();
            });
        }
    }
}
