using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class UserRole : IdentityRole, IDbEntity, IRole<string>
    {
        public UserRole()
            :base()
        {

        }
        public UserRole(string roleName)
            :base(roleName)
        {

        }
    }
}
