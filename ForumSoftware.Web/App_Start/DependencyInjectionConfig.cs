using DependenctyResolver.InjectionModules;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumSoftware
{
    public class DependencyInjectionConfig
    {
        public static void RegisterModules(HashSet<INinjectModule> modules)
        {
            modules.Add(new AutoMapperNinjectModule());
            modules.Add(new DALNinjectModule());
            modules.Add(new BLLNinjectModule());
        }
    }
}