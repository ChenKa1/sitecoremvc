using SimpleInjector;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace SitecoreMVC.SCExtensions.DI
{
    /// <summary>
    /// Inspiration: http://blog.istern.dk/2012/10/23/sitecore-mvc-new-ninject-controller-factory-clean-version/
    /// </summary>
    public class SimpleInjectorControllerFactory : DefaultControllerFactory
    {
        private Container _container;

        public SimpleInjectorControllerFactory(Container container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_container.GetInstance(controllerType);
        }
    }
}
