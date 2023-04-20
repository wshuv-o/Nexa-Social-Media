using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class ClassPost
    {
        
        private string postText;
        private DateTime postTime;
        private Image[] postImages;
        private string permission;
        private ClassMedia[] classMedias;
        private int noOfReacts;
        public string PostText
        {
            get { return this.postText; }
            set { this.postText = value; }
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
        private int NoOfReacts
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
        public ClassPost(string postText, DateTime postTime, Image[] postImages, string permission, ClassMedia[] classMedias, int noOfReacts)
        {
            this.PostText = postText;
            this.PostTime = postTime;
            this.PostImages = postImages;
            this.Permission = permission;
            this.ClassMedias = classMedias;
        }
    }
}
