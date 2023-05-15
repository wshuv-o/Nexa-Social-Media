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
    public partial class GamesPage : Form
    {
        public GamesPage()
        {
            InitializeComponent();
            // Methods.RoundPanelCorners(ref customFlowLayoutPanel1,20);
            // s= FunctionsAll.GetBackgroundColor((Bitmap)guna2PictureBox1.BackgroundImage);
            // this.guna2PictureBox1.BackColor = s;
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(flowLayoutPanel1, true);
            Methods.SetDoubleBuffer(guna2CustomGradientPanel1, true);
            Methods.SetDoubleBuffer(guna2CustomGradientPanel2, true);
            Methods.SetDoubleBuffer(guna2CustomGradientPanel3, true);
            Methods.SetDoubleBuffer(customFlowLayoutPanel1, true);



        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void customFlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void GamesPage_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
