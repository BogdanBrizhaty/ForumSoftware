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
    public class DTOtoEntityMappingProfile : Profile
    {
        public DTOtoEntityMappingProfile()
        {
            CreateMap<UserCredentialsDTO, ApplicationUser>().ForMember("Id", opt => opt.Ignore());
            CreateMap<UserProfileDTO, UserProfile>();

            // other maps goe here
        }
    }
}
