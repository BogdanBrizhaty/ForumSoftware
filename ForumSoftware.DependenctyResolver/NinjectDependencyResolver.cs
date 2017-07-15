using Ninject;
using Ninject.Modules;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ForumSoftware.DependenctyResolver
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        /// <summary>
        /// ctor which allows loading multiple instances of injection modules
        /// </summary>
        /// <param name="injectionModules"></param>
        public NinjectDependencyResolver(HashSet<INinjectModule> injectionModules)
        {
            kernel = new StandardKernel();
            AddBindings();
            kernel.Load(injectionModules);
        }
        /// <summary>
        /// ctor for a single injection module
        /// </summary>
        /// <param name="injectModule"></param>
        public NinjectDependencyResolver(INinjectModule injectModule)
        {
            kernel = new StandardKernel(injectModule);
            AddBindings();
        }
        /// <summary>
        /// ctor for a standart empty kernel. Loads
        /// </summary>
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public IBindingToSyntax<T> Bind<T>()
        {
            return kernel.Bind<T>();
        }

        public IKernel Kernel
        {
            get { return kernel; }
        }

        private void AddBindings()
        {
            // add main bindings here if need
        }

    }
}
