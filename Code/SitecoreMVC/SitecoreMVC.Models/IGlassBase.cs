using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models
{
    public interface IGlassBase
    {
        Guid Id { get; set; }

        Guid TemplateId { get; set; }

        string Url { get; set; }
    }
}
