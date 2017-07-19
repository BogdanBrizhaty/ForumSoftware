using DependenctyResolver;
using ForumSoftware.ClassMapping;
using ForumSoftware.DependenctyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ForumSoftware
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // pick up local profiles from DLL itself
            AutoMapperConfigurator.PickUpLocalProfiles();
            // call to map registration with profiles, created in this assembly(WEB)
            AutoMapperConfig.RegisterMaps(AutoMapperConfigurator.Profiles);
            DependencyInjectionConfig.RegisterModules(InjectionModuleContainer.Modules);

            DependencyResolver.SetResolver(NinjectDependencyResolver.UseRegisteredModules());
        }
    }
}
