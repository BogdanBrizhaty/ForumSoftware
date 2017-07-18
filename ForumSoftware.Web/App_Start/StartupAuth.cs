using ForumSoftware.BLL.Abstract;
using ForumSoftware.BLL.Concrete.Services;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
[assembly: OwinStartup(typeof(ForumSoftware.App_Start.StartupAuth))]
namespace ForumSoftware.App_Start
{

    public class StartupAuth
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private IUserService CreateUserService()
        {
            return DependencyResolver.Current.GetService<IUserService>();
        }
    }
}