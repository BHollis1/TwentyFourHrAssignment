using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour.Data
{
    public class Like
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        [Required]
        public virtual Post Post { get; set; }
        public Post LikedPost { get; set; }

        public Guid UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        //[Required]
        //public virtual User User { get; set; }
        //public User Liker { get; set; }
    }
}
