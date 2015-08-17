using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models
{
    public class GlassBase : IGlassBase
    {
        public virtual Guid Id { get; set; }
        public virtual Guid TemplateId { get; set; }
        public virtual string Url { get; set; }
    }
}
