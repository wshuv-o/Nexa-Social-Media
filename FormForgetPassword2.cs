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
    public partial class FormForgetPassword2 : Form
    {
        public FormForgetPassword2()
        {
            InitializeComponent();
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.guna2TextBox6.Visible = false;
            this.guna2TextBox5.Visible = false;
            this.guna2Button3.Visible = false;
            this.guna2Button4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.label4.Visible= true;
            this.label5.Visible= true;
            this.guna2TextBox6.Visible= true;
            this.guna2TextBox5.Visible= true;
            this.guna2Button3.Visible= true;
            this.guna2Button4.Visible= true;

            this.guna2TextBox1.Visible = false;
            this.guna2TextBox2.Visible = false;
            this.guna2TextBox3.Visible = false;
            this.guna2TextBox4.Visible = false;
            this.guna2Button1.Visible = false;
            this.guna2Button2.Visible = false;
            this.label3.Visible= false;
            this.label1.Visible= false; 

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}