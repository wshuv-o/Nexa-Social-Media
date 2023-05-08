using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class ClassPost
    {
        
        private int postId;
        private string postText;
        private DateTime postTime;
        private Image[] postImages;
        private string permission;
        private ClassMedia[] classMedias;
        private int noOfReacts;
        private User postCreator;
        public User PostCreator
        {
            get { return this.postCreator; }
            set { this.postCreator = value; }
        }
        public string PostText
        {
            get { return this.postText; }
            set { this.postText = value; }
        }
        public int PostId
        {
            get { return this.postId; }
            set { this.postId = value; }
        }
        public DateTime PostTime
        {
            get { return this.postTime; }
            set { this.postTime = value; }
        }
        public Image[] PostImages
        {
            get { return this.postImages; }
            set
            {
                this.postImages = value;
            }
        }
        public string Permission
        {
            get { return this.permission; }
            set
            {
                this.permission = value;
            }
        }
        public int NoOfReacts
        {
            get { return this.noOfReacts; }
            set
            {
                this.noOfReacts = value;
            }
        }
        public ClassMedia[] ClassMedias
        {
            get { return this.classMedias; }
            set { this.classMedias = value; }
        }
        public ClassPost(int postId, string postText, DateTime postTime, Image[] postImages, string permission, ClassMedia[] classMedias, int noOfReacts)
        {
            this.PostId = postId;
            this.PostText = postText;
            this.PostTime = postTime;
            this.PostImages = postImages;
            this.Permission = permission;
            this.ClassMedias = classMedias;
        }
        public ClassPost(int postId, string postText, DateTime postTime, Image[] postImages, string permission, int noOfReacts, User postCreator)
        {
            this.PostId = postId;
            this.PostText = postText;
            this.PostTime = postTime;
            this.PostImages = postImages;
            this.Permission = permission;
            this.PostCreator= postCreator;
        }
        public ClassPost() { }
    }
}
