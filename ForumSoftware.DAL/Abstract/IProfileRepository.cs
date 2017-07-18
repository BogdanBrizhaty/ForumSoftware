using ForumSoftware.Crosscutting;
using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Abstract
{
    public interface IProfileRepository : IRepository<UserProfile, string>
    {
        // extension method that provides access to dbSet of Application users
        // may be not the best decision, just don't want to override default UserStore
        //IDataPortion<ApplicationUser> GetManyByName(string template, int page, int pageSize, Ordering<ApplicationUser> order);
        
    }
}
