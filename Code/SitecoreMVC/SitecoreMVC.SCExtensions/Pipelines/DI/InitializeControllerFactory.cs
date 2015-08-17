using SimpleInjector;
using Sitecore.Pipelines;
using SitecoreMVC.SCExtensions.DI;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SitecoreMVC.SCExtensions.Pipelines.DI
{
    public class InitializeControllerFactory
    {
        public virtual void Process(PipelineArgs args)
        {
            SetControllerFactory(args);
        }

        protected virtual void SetControllerFactory(PipelineArgs args)
        {
            var container = new Container();

            PackageExtensions.RegisterPackages(container, AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("SitecoreMVC."))); // you can customize this to what ever you need

            var simpleInjectorControllerFactory = new SimpleInjectorControllerFactory(container);
            var sitecoreControllerFactory = new Sitecore.Mvc.Controllers.SitecoreControllerFactory(simpleInjectorControllerFactory);

            ControllerBuilder.Current.SetControllerFactory(sitecoreControllerFactory);
        }
    }
}

