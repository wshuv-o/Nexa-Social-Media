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

        public Post()
        {
            InitializeComponent();
            Methods.RoundImageBoxCorners(pictureBox1, 20);
            panel3.BackColor=Methods.GetBackgroundAverageColor((Bitmap)panel3.BackgroundImage);
            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel4, true);
            Methods.SetDoubleBuffer(panel3, true);
            Methods.SetDoubleBuffer(guna2ShadowPanel1, true);
            Methods.SetDoubleBuffer(basePanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel2, true);
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
            label3.Text = richTextBoxText;
            label3.AutoSize = true;
            label3.MaximumSize = new Size(panel2.Width, int.MaxValue);
            panel2.Height = label3.Height;
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
    }
}
