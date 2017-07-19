using DependenctyResolver;
using ForumSoftware.ClassMapping;
using ForumSoftware.DependenctyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ForumSoftware
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //private void Application_BeginRequest(Object source, EventArgs e)
        //{
        //    HttpApplication application = (HttpApplication)source;
        //    HttpContext context = application.Context;

        //    string culture = null;
        //    if (context.Request.UserLanguages != null && Request.UserLanguages.Length > 0)
        //    {
        //        culture = Request.UserLanguages[0];
        //        System.Globalization.CultureInfo.CreateSpecificCulture(culture);
        //        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        //        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        //    }
        //}
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
