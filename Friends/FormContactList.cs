using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.Friends
{
    public partial class FormContactList : Form
    {
        Classes.User contact;
        public Classes.User Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        
        public FormContactList(Classes.User user)
        {
            this.Contact = user;
            InitializeComponent();
            this.contactProfileImage.Image = user.ProfilePhoto;
            this.lblContactName.Text=user.UserFirstName+" "+user.UserLastName;
        }

        private void FormContactList_Load(object sender, EventArgs e)
        {

        }
        private  void OpenContact(object sender, EventArgs e)
        {
            Methods.OpenChildForm2(new FormProfile(this.Contact), FormBase.panelSubMain);
        }
    }
}
