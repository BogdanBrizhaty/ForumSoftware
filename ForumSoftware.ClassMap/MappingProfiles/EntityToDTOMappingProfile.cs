using AutoMapper;
using ForumSoftware.BLL.DTO;
using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.ClassMapping.MappingProfiles
{
    public class EntityToDTOMappingProfile : Profile
    {
        public EntityToDTOMappingProfile()
        {
            CreateMap<ApplicationUser, UserCredentialsDTO>();
            CreateMap<UserProfile, UserProfileDTO>();
            CreateMap<UserRole, UserRoleDTO>();
            //Mapper
            // other maps goe here
        }
    }
}
