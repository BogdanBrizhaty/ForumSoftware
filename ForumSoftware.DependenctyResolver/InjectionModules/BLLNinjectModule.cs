using ForumSoftware.BLL.Abstract;
using ForumSoftware.BLL.Concrete.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenctyResolver.InjectionModules
{
    public class BLLNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
        }
    }
}
