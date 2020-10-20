using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFour.Data
{
    public class Like
    {
        public Post LikedPost { get; set; }

        public User Liker { get; set; }
    }
}
