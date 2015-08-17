using Glass.Mapper.Sc;
using SimpleInjector;
using SimpleInjector.Packaging;
using SitecoreMVC.Business.Caching;
using SitecoreMVC.Business.Common;
using SitecoreMVC.Business.Metadata;
using SitecoreMVC.Business.Scripts;
using SitecoreMVC.Business.Shared;
using SitecoreMVC.Business.SitecoreSettings;

namespace SitecoreMVC.Web.App_Start
{
    public class SimpleInjector : IPackage
    {
        public void RegisterServices(global::SimpleInjector.Container container)
        {
            container.Register<ISitecoreContext>(() => new SitecoreContext());
            container.Register<IMetadataLogic, MetadataLogic>();
            container.Register<IScriptsLogic, ScriptsLogic>();
            container.Register<ISitecoreSiteLogic, SitecoreSiteLogic>();
            container.Register<IDateTimeLogic, DateTimeLogic>();
            container.Register<ICanonicalLink, CanonicalLink>();
            container.Register<ISettingsLogic, SettingsLogic>();
            


            container.Register<ICacheLogic, CacheLogic>();
            //singleton
            container.Register<ICacheRepositoryLogic, CacheRepositoryLogic>(Lifestyle.Singleton);
        }
    }
}
