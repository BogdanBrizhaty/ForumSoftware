using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class ApplicationUser : IdentityUser, IDbEntity
    {
        public virtual UserProfile UserProfile { get; set; }
    }
}
