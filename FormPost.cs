using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormPost : Form
    {
        private Classes.ClassPost classPost= new Classes.ClassPost();
        public Classes.ClassPost ClassPost
        {
            get { return classPost; }
            set { classPost = value; }
        }
        public FormPost(Classes.ClassPost classPost)
        {
            InitializeComponent();
            this.ClassPost = classPost;
            this.lblPostReact.Text= classPost.NoOfReacts.ToString();
            this.lblPostText.Text=classPost.PostText.ToString();
            this.UserProfileImage.Image = classPost.PostCreator.ProfilePhoto;
            this.lblUserName.Text = classPost.PostCreator.UserFirstName + " " + classPost.PostCreator.UserFirstName;
            this.postTime.Text= classPost.PostTime.ToString();

        }

        private void FormPost_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void postText_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
