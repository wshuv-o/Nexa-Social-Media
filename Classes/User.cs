using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Classes
{
    internal class User
    {
        private string userFirstName;
        private string userLastName;
        private string bio;
        private string email;
        private string password;
        private string phoneNumber;
        private DateTime dob;
        private char gender;
        private Image profilePhoto;
        private PersonalWebsites[] websites;
        private User[] friends;
    }
}
