using ForumSoftware.Crosscutting;
using ForumSoftware.DAL.Abstract;
using ForumSoftware.DAL.DataContext;
using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Concrete
{
    public class UserProfileRepository : AEfRepository<UserProfile, string>, IProfileRepository/*, IRepository<UserProfile, int>*/
    {
        // ctor to invoke base one
        public UserProfileRepository(ApplicationDataContext context)
            :base(context)
        {

        }

        // specific methods go here
        /* 
        IDataPortion<ApplicationUser> IProfileRepository.GetManyByName(string template, int page, int pageSize, Ordering<ApplicationUser> order = null)
        {
            var query = DataContext.Set<ApplicationUser>().Where(usr => usr.UserName.Contains(template));

            if (order != null)
                query = order.Apply(query);

            var totalItemsFound = query.Count();

            if (page * pageSize > totalItemsFound)
                throw new ArgumentOutOfRangeException("Attempt to access elements outside of " + typeof(ApplicationUser) + " table bounds in the database");

            var resultationEntities = (page == 1) ? query.Take(pageSize) : query.Skip((page - 1) * pageSize).Take(pageSize);

            return new DataPortion<ApplicationUser>(resultationEntities, totalItemsFound);
        }  */


    }
}
