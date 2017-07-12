using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class Thread
    {
        // Key setup
        [Key]
        public int ThreadId { get; set; }
        [ForeignKey("UserProfile")]
        public int AuthorId { get; set; }

        // Thread info
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        
        // navigation properties
        public ICollection<Post> Posts { get; set; }
    }
}
