using AutoMapper;
using ForumSoftware.ClassMapping.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.ClassMapping
{
    public static class AutoMapperConfigurator
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(
                //cfg => cfg.Add
                cfg =>
                {
                    cfg.AddProfile(new EntityToDTOMappingProfile());
                    cfg.AddProfile(new DTOtoEntityMappingProfile());
                    // initialize other mapping profiles
                }
                );
            return config;
        }
    }
}
