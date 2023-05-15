using media.Admin;
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
    public partial class FormAdminHome : Form
    {
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            Methods.OpenChildForm(new FormAdminReview(), panel1);

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm(new FormAdminReview(), panel1);
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm(new FormAdmin(), panel1);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm(new AdminFormUser(), panel1);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm(new AdminHome(), panel1);
        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
