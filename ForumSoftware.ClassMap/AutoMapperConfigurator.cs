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
        private static HashSet<Profile> _profiles = new HashSet<Profile>();
        public static HashSet<Profile> Profiles { get { return _profiles; } }
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    foreach (var profile in Profiles)
                        cfg.AddProfile(profile);
                }
                );
            return config;
        }
        public static void PickUpLocalProfiles()
        {
            Profiles.Add(new DTOtoEntityMappingProfile());
            Profiles.Add(new EntityToDTOMappingProfile());
        }
    }
}
