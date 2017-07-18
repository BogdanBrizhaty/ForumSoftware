using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.BLL.DTO
{
    public class UserProfileDTO
    {
        // userprofile
        public string Id { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public int Reputation { get; set; }
        public string Location { get; set; }
    }
}
