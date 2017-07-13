using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class Thread : IDbEntity
    {
        // Key setup
        [Key]
        public int ThreadId { get; set; }
        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        // Thread info
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }

        // navigation properties
        public ICollection<Post> Posts { get; set; }
        public virtual UserProfile Author { get; set; }


    }
}
