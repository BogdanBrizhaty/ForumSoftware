using AutoMapper.XpressionMapper;
using ForumSoftware.App_GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Web;

namespace ForumSoftware.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Localization3))]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Localization3))]
        public string Password { get; set; }
    }
}