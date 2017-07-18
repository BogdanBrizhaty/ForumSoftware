using ForumSoftware.DAL.Abstract;
using ForumSoftware.DAL.Concrete;
using ForumSoftware.DAL.DataContext;
using ForumSoftware.DAL.Identity;
using ForumSoftware.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Ninject.Modules;
using System.Data.Entity;

namespace DependenctyResolver.InjectionModules
{
    public class DALNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ApplicationDataContext>().ToSelf().InSingletonScope();
            Bind<DbContext>().To<ApplicationDataContext>();
            Bind<IRoleStore<UserRole, string>>().To<RoleStore<UserRole>>();
            Bind<IUserStore<ApplicationUser>>().To<UserStore<ApplicationUser>>();
            Bind<ApplicationUserManager>().ToSelf();
            Bind<ApplicationRoleManager>().ToSelf();
            Bind<IProfileRepository>().To<UserProfileRepository>();
            Bind<IDbUnitOfWork>().To<ApplicationDbUnitOfWork>();//.InSingletonScope();
        }
    }
}
