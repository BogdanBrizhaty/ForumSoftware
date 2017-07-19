using AutoMapper;
using ForumSoftware.BLL.DTO;
using ForumSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumSoftware
{
    #region Mapping profiles

    public class ViewModelToDTOMappingProfile : Profile
    {
        public ViewModelToDTOMappingProfile()
        {
            CreateMap<LoginModel, UserCredentialsDTO>();
            CreateMap<RegisterUserModel, UserCredentialsDTO>();
            CreateMap<RegisterUserModel, UserProfileDTO>();
            //CreateMap<>
        }
    }
    public class DTOToViewModelMappingProfile : Profile
    {

    }

    #endregion


    public class AutoMapperConfig
    {
        public static void RegisterMaps(HashSet<Profile> profiles)
        {
            profiles.Add(new ViewModelToDTOMappingProfile());
            profiles.Add(new DTOToViewModelMappingProfile());
            //maps.
        }
    }
}