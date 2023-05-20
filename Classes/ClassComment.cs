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
        private int commenterId;
        private int likesCount;
        private bool isLiked;
        public DateTime CommentTime
        {
            get { return this.commentTime; }
            set { this.commentTime = value; }
        }
        public string CommentText
        {
            get { return this.commentText; }
            set { this.commentText = value; }
        }
        public int CommentId
        {
            get { return this.commentId; }
            set { this.commentId = value; }
        }
        public int CommenterId
        {
            get { return this.commenterId; }
            set { this.commenterId = value; }
        }
        public bool IsLiked
        {
            get { return this.isLiked; }
            set { this.isLiked = value;}
        }
        public int LikesCount
        {
            get { return this.likesCount; }
            set { this.likesCount = value;}
        }
        public ClassComment(string commentText, int commentId,  int commenterId)
        {
            this.CommentTime = DateTime.Now;
            this.CommentText = commentText;
            this.CommentId = commentId;
            this.CommenterId = commenterId;
        }
    }
}
