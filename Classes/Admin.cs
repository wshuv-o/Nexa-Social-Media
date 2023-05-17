using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    public class Admin
    {
            private int adminId;
            private string firstName;
            private string lastName;
            private System.Drawing.Image adminImage;
            private string password;
            private string email;

            public int AdminId
            {
                get { return adminId; }
                set { adminId = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public System.Drawing.Image AdminImage
        {
                get { return adminImage; }
                set { adminImage = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public Admin(int adminId, string firstName, string lastName, System.Drawing.Image image, string email)
            {
                AdminId = adminId;
                FirstName = firstName;
                LastName = lastName;
                AdminImage = image;
                Email = email;
            }
        public Admin()
        {

        }
    }

}
