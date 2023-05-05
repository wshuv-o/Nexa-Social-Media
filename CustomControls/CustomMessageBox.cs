using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace media
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();

            


        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] bytes = null;

            try
            {
                bytes = wc.DownloadData("https://wshuv-o.github.io/100506316.jpeg\r\n");
                  
                Image img;
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    img = Image.FromStream(ms);
                }

                pictureBox1.Image = img;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error downloading image: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error creating image: " + ex.Message);
            }
        }

    }
}
