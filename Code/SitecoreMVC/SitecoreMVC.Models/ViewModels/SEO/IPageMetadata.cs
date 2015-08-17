using SitecoreMVC.Models.TemplateModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models.ViewModels.SEO
{
    public interface IPageMetadata : IGlassBase, IMetadata, IFacebookMetadata, ITwitterMetadata
    {
        string Title { get; set; }
    }
}
