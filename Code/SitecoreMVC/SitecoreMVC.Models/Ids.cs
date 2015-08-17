using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Models
{
    public static class Ids
    {
        public static class Content
        {
            public static class SiteSettings
            {
                public static Guid Id { get { return new Guid("{FDFE906F-90BE-4AF8-AF67-332E3AC68E52}"); } }
            }
        }

        public static class Templates
        {
            public static class Base
            {
                public static class BasePage
                {
                    public static Guid Id { get { return new Guid("{14E15AE0-CFB0-4567-909E-4ED183BF2CFD}"); } }
                }
            }
        }
    }
}
