using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class ClassMedia
    {
        private int mediaId;
        private Image mediaContent;
        public int MediaId { get { return this.mediaId; } set { this.mediaId = value; } }
        public Image MediaContent { get { return this.mediaContent; } set { this.mediaContent = value; } }
        public ClassMedia(int mediaId, Image mediaContent) 
        {
            this.MediaId = mediaId;
            this.MediaContent = mediaContent;
        }
    }
}
