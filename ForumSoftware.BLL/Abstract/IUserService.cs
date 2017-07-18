using ForumSoftware.BLL.DTO;
using ForumSoftware.Crosscutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.BLL.Abstract
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserCredentialsDTO user, UserProfileDTO profile);
        Task<ClaimsIdentity> Authenticate(UserCredentialsDTO user);
        //Task SetInitialData(UserCredentialsDTO admin, List<string> roles);
    }
}
