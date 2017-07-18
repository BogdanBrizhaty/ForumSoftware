using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DependenctyResolver
{
    public class InjectionModuleContainer
    {
        private static HashSet<INinjectModule> _modules = new HashSet<INinjectModule>();
        public static HashSet<INinjectModule> Modules { get { return _modules; } }
    }
}
