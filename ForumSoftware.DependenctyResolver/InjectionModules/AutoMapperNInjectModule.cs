using AutoMapper;
using ForumSoftware.ClassMapping;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenctyResolver.InjectionModules
{
    public class AutoMapperNinjectModule : NinjectModule
    {
        public override void Load()
        {
            IMapper _mapper = AutoMapperConfigurator.InitializeAutoMapper().CreateMapper();
            Bind<IMapper>().ToConstant(_mapper).InSingletonScope();
        }
    }
}
