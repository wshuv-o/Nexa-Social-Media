using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class Page
    {
        private int pageId;
        private string pageName;
        private string pageType;
        private string pageEmail;
        private string pagePassword;
        private string pagePhoneNumber;
        private DateTime creationDate;
        private Image pageProfileImage;
        
        public string PageAddress
        {
            get;set;
        }
        public int PageId
        {
            get { return this.pageId; }
            set { this.pageId = value; }
        }
        public string PageName { get { return pageName; } set { this.pageName = value; } }
        public string PageType { get { return this.pageType; } set { this.pageType = value; } }
        public string PageEmail { get { return this.pageEmail; } set { this.pageEmail = value; } }
        public string PagePassword
        {
            get { return this.pagePassword; }
            set { this.pagePassword = value; }
        }
        public string PagePhoneNumber
        {
            get { return this.pagePhoneNumber; }
            set { this.pagePhoneNumber = value; }
        }
        public DateTime CreationDate
        {
            get { return this.creationDate; }
            set
            {
                this.creationDate = value;
            }
        }
        public Image PageProfileImage
        {
            get { return this.pageProfileImage;}
            set
            {
                this.pageProfileImage = value;
            }
        }
        public Page(string pageName, string pageType, string pageEmail, Image pageProfileImage)
        {
            this.PageName = pageName;
            this.PageType = pageType;
            this.PageEmail = pageEmail;
            this.PageProfileImage = pageProfileImage;
        }
        public Page()
        {

        }
    }
}
