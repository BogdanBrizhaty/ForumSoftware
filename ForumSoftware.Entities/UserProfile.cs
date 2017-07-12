using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class UserProfile
    {
        // KeySetup to reffer AppUser
        [Key]
        [ForeignKey("ApplicationUser")]
        public int Id { get; set; }

        // user info
        public DateTime? BirthDate { get; set; }
        public DateTime? JoinDate { get; set; }
        public int Reputation { get; set; }
        public string Location { get; set; }

        // navigation properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<Thread> Threads { get; set; }

        // bind to AppUser class
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
