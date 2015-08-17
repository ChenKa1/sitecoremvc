using Glass.Mapper.Sc.Maps;
using SitecoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.ModelMaps
{
    public class GlassBaseIMap : SitecoreGlassMap<IGlassBase>
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
