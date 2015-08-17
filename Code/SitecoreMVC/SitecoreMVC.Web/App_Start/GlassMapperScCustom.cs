using Glass.Mapper.Configuration;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Sc.IoC;
using SitecoreMVC.ModelMaps;
using SitecoreMVC.ModelMaps.Base;
using SitecoreMVC.ModelMaps.Social;
using SitecoreMVC.ModelMaps.ViewModels;
using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace SitecoreMVC.Web.App_Start
{
    public static  class GlassMapperScCustom
    {
		public static IDependencyResolver CreateResolver(){
			var config = new Glass.Mapper.Sc.Config();

			return new DependencyResolver(config);
		}

		public static IConfigurationLoader[] GlassLoaders(){			
			
			/* USE THIS AREA TO ADD FLUENT CONFIGURATION LOADERS
             * 
             * If you are using Attribute Configuration or automapping/on-demand mapping you don't need to do anything!
             * 
             */

			return new IConfigurationLoader[]{};
		}
		public static void PostLoad(){
			//Remove the comments to activate CodeFist
			/* CODE FIRST START
            var dbs = Sitecore.Configuration.Factory.GetDatabases();
            foreach (var db in dbs)
            {
                var provider = db.GetDataProviders().FirstOrDefault(x => x is GlassDataProvider) as GlassDataProvider;
                if (provider != null)
                {
                    using (new SecurityDisabler())
                    {
                        provider.Initialise(db);
                    }
                }
            }
             * CODE FIRST END
             */
		}
		public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
            // Add maps here
            // mapsConfigFactory.Add(() => new SeoMap());
            mapsConfigFactory.Add(() => new BreadcrumbMap());
            mapsConfigFactory.Add(() => new CanonicalMap());
            mapsConfigFactory.Add(() => new FacebookMetadataMap());
            mapsConfigFactory.Add(() => new GooglePlusMetadataMap());
            mapsConfigFactory.Add(() => new MetadataMap());
            mapsConfigFactory.Add(() => new NavigationMap());
            mapsConfigFactory.Add(() => new ScriptsMap());
            mapsConfigFactory.Add(() => new SearchMap());
            mapsConfigFactory.Add(() => new SitemapMap());
            mapsConfigFactory.Add(() => new TwitterMetadataMap());
            mapsConfigFactory.Add(() => new SocialSettingsMap());
            mapsConfigFactory.Add(() => new PageMetadataMap());
            mapsConfigFactory.Add(() => new GlassBaseMap());
            mapsConfigFactory.Add(() => new GlassBaseIMap());
        }
    }
}
