using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class User
    {
        private string userFirstName;
        private string userLastName;
        private string bio;
        private int key;
        private string email;
        private string password;
        private string phoneNumber;
        private DateTime dob;
        private string gender;
        private Image profilePhoto;
        private Websites[] personalWebsites;
        private User[] friends;

            public int Key
        {
            get { return key; }
            set { key = value; }
        }


        public Websites[] PersonalWebsites
        {
            get { return this.personalWebsites; }
            set { this.personalWebsites = value; }
        }
        public string UserFirstName
        {
            get { return this.userFirstName; }
            set { this.userFirstName = value; }
        }
        public string UserLastName
        {
            get { return this.userLastName; }
            set { this.userLastName = value; }
        }
        public string Bio
        {
            get { return this.bio; }
            set
            {
                this.bio = value.Substring(0,100);
            }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                this.phoneNumber = value;
            }
        }
        public DateTime Dob
        {
            get { return this.dob; }
            set
            {
                this.dob = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
            }
        }
        public Image ProfilePhoto
        {
            get { return this.profilePhoto; }
            set
            {
                this.profilePhoto = value;
            }
        }
        
        public User(string userFirstName, string userLastName, string email, string phoneNumber, DateTime dob, string gender) 
        { 
            this.UserFirstName= userFirstName;
            this.UserLastName= userLastName;
            this.Email= email;
            this.PhoneNumber= phoneNumber;
            this.Dob= dob;
            this.Gender=gender;
        }
        public User()
        {

        }
    }
}
