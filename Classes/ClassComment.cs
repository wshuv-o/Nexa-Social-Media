using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class ClassComment
    {
        private DateTime commentTime;
        private string commentText;
        private int commentId;
        private User[] commenters;
        private int likes;
        private bool isLiked;
    }
}
