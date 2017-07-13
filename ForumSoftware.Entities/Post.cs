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
        [ForeignKey("UserProfile")]
        public int AuthorId { get; set; }

        // post info
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
    }
}
