using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business
{
    public static class SiteConstants
    {
        public static class Strings
        {
            public const string SocialSettingsAttribute = "socialSettingsPath";
        }

        public static class Metadata
        {
            public const string MetaTitleTag = "<title>{0}</title>\n";
            public const string MetaName = "<meta name=\"{0}\" content=\"{1}\"  />\n";
            public const string MetaProperty = "<meta property=\"{0}\" content=\"{1}\"  />\n";

            public const string NoIndex = "noindex";
            public const string NoYdir = "noydir";
            public const string NoODP = "noodp";

            public const string Robots = "robots";

            public const string Keywords = "keywords";
            public const string Description = "description";

            public const string OGSiteName = "og::site_name";
            public const string FBAdmins = "fb:admins";
            public const string OGImage = "og:image";
            public const string OGType = "og:type";
            public const string OGTitle = "og:title";
            public const string OGDescription = "og:description";
            public const string OGUrl = "og:url";
            public const string TwitterSite = "twitter:site";
            public const string TwitterImage = "twitter:image:src";
            public const string TwitterCard = "twitter:card";
            public const string TwitterTitle = "twitter:title";
            public const string TwitterDescription = "twitter:description";
            public const string TwitterUrl = "twitter:url";

        }
    }
}
