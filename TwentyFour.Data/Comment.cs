using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }

        public Guid UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        //[Required]
        //public virtual User User { get; set; }
        //public User Author { get; set; }
        //[Required]
        //public Post CommentPost { get; set; }
    }
}
