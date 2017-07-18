using ForumSoftware.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumSoftware.DAL.Identity;
using ForumSoftware.DAL.DataContext;
using Microsoft.AspNet.Identity.EntityFramework;
using ForumSoftware.Entities;

namespace ForumSoftware.DAL.Concrete
{
    public class ApplicationDbUnitOfWork : IDbUnitOfWork
    {
        private ApplicationDataContext _dbContext = null;
        private ApplicationUserManager _userManager = null;
        private ApplicationRoleManager _roleManager = null;
        private IProfileRepository _profileRepository = null;
        private IThreadRepository _threadRepository = null;
        private IPostRepository _postRepository = null;

        // ctor
        public ApplicationDbUnitOfWork(ApplicationDataContext context,
            ApplicationUserManager userMngr,
            ApplicationRoleManager roleMngr,
            IProfileRepository profileRepo
            //IProfileRepository profileRepo,
            //IThreadRepository threadRepo,
            //IPostRepository postRepo
            )
        {
            if (context == null)
                throw new ArgumentNullException("context");
            if (userMngr == null)
                throw new ArgumentNullException("userMngr");
            if (roleMngr == null)
                throw new ArgumentNullException("roleMngr");
            if (profileRepo == null)
                throw new ArgumentNullException("profileRepo");
            //if (threadRepo == null)
            //    throw new ArgumentNullException("threadRepo");
            //if (postRepo == null)
            //    throw new ArgumentNullException("postRepo");

            _dbContext = context;
            _userManager = userMngr;
            _roleManager = roleMngr;
            _profileRepository = profileRepo;
            //_threadRepository = threadRepo;
            //_postRepository = postRepo;
        }

        //public ApplicationDbUnitOfWork(ApplicationDataContext context)
        //{
        //    if (context == null)
        //        throw new ArgumentNullException("context");
        //    _dbContext = context;

        //    _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(_dbContext));
        //    _roleManager = new ApplicationRoleManager(new RoleStore<UserRole>(_dbContext));
        //    _profileRepository = new UserProfileRepository(_dbContext);
        //    //_threadRepository = threadRepo;
        //    //_postRepository = postRepo;
        //}
        IPostRepository IDbUnitOfWork.Posts
        {
            get { return _postRepository; }
        }

        IProfileRepository IDbUnitOfWork.Profiles
        {
            get { return _profileRepository; }
        }

        ApplicationRoleManager IDbUnitOfWork.RoleManager
        {
            get { return _roleManager; }
        }

        IThreadRepository IDbUnitOfWork.Threads
        {
            get { return _threadRepository; }
        }

        ApplicationUserManager IDbUnitOfWork.UserManager
        {
            get { return _userManager; }
        }

        void IDbUnitOfWork.Save()
        {
            throw new NotImplementedException();
        }

        Task<int> IDbUnitOfWork.SaveAsync()
        {
            return _dbContext.SaveChangesAsync();
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
                    _userManager.Dispose();
                    _roleManager.Dispose();
                    _profileRepository.Dispose();
                    
                }
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ApplicationDbUnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
