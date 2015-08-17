using Glass.Mapper.Sc.Maps;
using SitecoreMVC.Models.TemplateModels.Base;
using SitecoreMVC.Models.ViewModels.SEO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.ModelMaps.ViewModels
{
    //
    public class PageMetadataMap : SitecoreGlassMap<IPageMetadata>
    {
        public override void Configure()
        {
            Map(x =>
            {
                x.AutoMap();
                ImportMap<IMetadata>();
                ImportMap<IFacebookMetadata>();
                ImportMap<ITwitterMetadata>();
            });
        }
    }
}
