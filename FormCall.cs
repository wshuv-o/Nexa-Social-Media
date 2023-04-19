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
    public partial class FormCall : Form
    {
        private bool isVideoOn = true;
        private bool isMicOn = true;
        public FormCall()
        {
            InitializeComponent();
            this.guna2Panel1.MouseHover += Guna2Panel1_MouseHover;
            this.panel1.MouseHover += Panel1_MouseHover;
            this.guna2Button4.Image = global::media.Properties.Resources.noVideo;
            this.guna2Button5.Image = global::media.Properties.Resources.noMic;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel1_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = true;
        }
        private void panel1_mouseLeave(object sender, EventArgs e)
        {

            this.tableLayoutPanel1.Visible = false;
        }
        private void Guna2Panel1_MouseHover(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (isVideoOn)
            {
                this.guna2Button4.Image = Properties.Resources.noVideo;
                isVideoOn = false;
            }
            else 
            {
                this.guna2Button4.Image = Properties.Resources.Video;
                isVideoOn = true;
            }
        }

        private void FormCall_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (isMicOn)
            {
                this.guna2Button5.Image = Properties.Resources.noMic;
                isMicOn = false;
            }
            else
            {
                this.guna2Button5.Image = Properties.Resources.Mic;
                isMicOn = true;
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
