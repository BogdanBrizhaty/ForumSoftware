using ForumSoftware.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumSoftware.BLL.DTO;
using ForumSoftware.Crosscutting;
using System.Security.Claims;
using ForumSoftware.DAL.Abstract;
using AutoMapper;
using ForumSoftware.Entities;
using Microsoft.AspNet.Identity;

namespace ForumSoftware.BLL.Concrete.Services
{
    public class UserService : IUserService
    {
        private IDbUnitOfWork _db = null;
        private IMapper _mapper = null;
        public UserService(IDbUnitOfWork uow, IMapper mapper)
        {
            _db = uow;
            _mapper = mapper;
        }

        public async Task<ClaimsIdentity> Authenticate(UserCredentialsDTO userDto)
        {
            ClaimsIdentity claim = null;
            var user = await _db.UserManager.FindAsync(userDto.UserName, userDto.Password);
            if (user != null)
            {
                claim = await _db.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            }
            return claim;
        }

        public async Task<OperationDetails> Create(UserCredentialsDTO user, UserProfileDTO profileDto)
        {
            var usr = await _db.UserManager.FindByEmailAsync(user.Email);//.CreateAsync(_mapper.Map<ApplicationUser>(user));
            if (usr == null)
                usr = await _db.UserManager.FindByNameAsync(user.UserName);
            else return new OperationDetails(new OperationFailureError("This email is already taken", "Email"));
            if (usr == null)
            {
                var usrCredentials = _mapper.Map<ApplicationUser>(user);
                // OR NEED TO CREATE IMPLICITLY !!!! IMPORTANT!!!
                // = new ApplicationUser() { UserName = ... }
                var result = await _db.UserManager.CreateAsync(usrCredentials, user.Password);
                if (result.Errors.Count() > 0)
                    return new OperationDetails(new OperationFailureError(result.Errors.FirstOrDefault(), ""));

                await _db.UserManager.AddToRoleAsync(usrCredentials.Id, user.Role);

                // create profile
                var profile = _mapper.Map<UserProfile>(profileDto);
                profile.Id = usrCredentials.Id;
                _db.Profiles.Create(profile);
                await _db.SaveAsync();

                return new OperationDetails();
            }
            else return new OperationDetails(new OperationFailureError("This username is already taken", "UserName"));
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _db.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
