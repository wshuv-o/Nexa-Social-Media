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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            FormAdminReview user = new FormAdminReview();

            OpenChildForm(user, guna2Panel1);

        }

        public void OpenChildForm(Form AdminFormUser_Load, Panel guna2Panel1_Paint)
        {
            Form activeForm = null;
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = AdminFormUser_Load;
                AdminFormUser_Load.TopLevel = false;
                AdminFormUser_Load.FormBorderStyle = FormBorderStyle.None;
                AdminFormUser_Load.Dock = DockStyle.Fill;
                guna2Panel1_Paint.Controls.Add(AdminFormUser_Load);
                guna2Panel1_Paint.Tag = AdminFormUser_Load;
                AdminFormUser_Load.BringToFront();
                AdminFormUser_Load.Show();
            }
            else
            {
                activeForm = AdminFormUser_Load;
                AdminFormUser_Load.TopLevel = false;
                AdminFormUser_Load.FormBorderStyle = FormBorderStyle.None;
                AdminFormUser_Load.Dock = DockStyle.Fill;
                guna2Panel1_Paint.Controls.Add(AdminFormUser_Load);
                guna2Panel1_Paint.Tag = AdminFormUser_Load;
                AdminFormUser_Load.BringToFront();
                AdminFormUser_Load.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
