using ForumSoftware.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.DataContext
{
    public class ApplicationDataContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDataContext(string connectionString) : base(connectionString)
        {

        }
        public ApplicationDataContext() :base("DefaultConnection")
        {

        }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
