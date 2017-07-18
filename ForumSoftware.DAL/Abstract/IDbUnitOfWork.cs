using ForumSoftware.DAL.DataContext;
using ForumSoftware.DAL.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Abstract
{
    public interface IDbUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        ApplicationRoleManager RoleManager { get; }
        IProfileRepository Profiles { get; }
        IThreadRepository Threads { get; }
        IPostRepository Posts { get; }
        // IPartialRepository Partials { get; }
        // INotificationRepository Notifications { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
