using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Post : Form
    {
        private media.Classes.ClassPost classPosts;
        public media.Classes.ClassPost ClassPosts
        {
            get { return classPosts; }
            set { classPosts = value; }
        }
        public Post(media.Classes.ClassPost classPost)
        {
            this.classPosts = new Classes.ClassPost();
            this.classPosts = classPost;
            InitializeComponent();
            Methods.RoundImageBoxCorners(pictureBox1, 20);
            postImagePanel.BackColor=Methods.GetBackgroundAverageColor((Bitmap)postImagePanel.BackgroundImage);
            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel4, true);
            Methods.SetDoubleBuffer(postImagePanel, true);
            Methods.SetDoubleBuffer(guna2ShadowPanel1, true);
            Methods.SetDoubleBuffer(basePanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel2, true);

            if (classPost != null)
            {
                //MessageBox.Show("prob");
                this.postTime.Text = classPost.PostTime.ToString();
                this.postText.Text = classPost.PostText;
                this.postImagePanel.BackgroundImage = classPost.PostImages[0];
                this.reactCount.Text = classPost.NoOfReacts.ToString();
                this.postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)this.postImagePanel.BackgroundImage);
            }
            else
            {
                this.postTime.Text = "N/A";
            }
            
        }
        public Post()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string richTextBoxText = richTextBox1.Text;
            postText.Text = richTextBoxText;
            postText.AutoSize = true;
            postText.MaximumSize = new Size(panel2.Width, int.MaxValue);
            panel2.Height = postText.Height;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Post_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
