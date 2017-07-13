using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Entities
{
    public class Post : IDbEntity
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey("Author")]
        public string AuthorId { get; set; }
        [ForeignKey("Thread")]
        public int ThreadId { get; set; }

        // post info
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }

        // navigational properties
        public int MyProperty { get; set; }
        public virtual UserProfile Author { get; set; }
        public virtual Thread Thread { get; set; }

    }
}
