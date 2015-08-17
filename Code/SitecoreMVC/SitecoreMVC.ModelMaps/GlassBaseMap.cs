using Glass.Mapper.Sc.Maps;
using SitecoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.ModelMaps
{
    public class GlassBaseMap : SitecoreGlassMap<GlassBase>
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
