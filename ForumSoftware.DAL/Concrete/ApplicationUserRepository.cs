using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ForumSoftware.Crosscutting;

namespace ForumSoftware.DAL.Concrete
{
    // created
    public class ApplicationUserRepository : AEfRepository<ApplicationUser, string>
    {
        public ApplicationUserRepository(DbContext context) : base(context)
        {
        }

        // all methods below are overridden to throw not implemented exception, 
        // because of this functionallity is already provided by ApplicationUserManager class
        public override void Create(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
        public override void Delete(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
        public override bool Exists(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
        public override ApplicationUser GetById(string id)
        {
            throw new NotImplementedException();
        }
        public override void Update(ApplicationUser item)
        {
            throw new NotImplementedException();
        }
        public override IDataPortion<ApplicationUser> GetMany(int page, int pageSize = 10, Ordering<ApplicationUser> order = null)
        {
            throw new NotImplementedException();
        }
    }
}
