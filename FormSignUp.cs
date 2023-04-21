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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            Methods.SetDoubleBuffer(guna2Panel1, true);
            Methods.SetDoubleBuffer(guna2Panel3, true);
            Methods.SetDoubleBuffer(guna2GradientPanel1, true);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBoxEmail != null)
            {
                if (Methods.IsValidEmail(this.txtBoxEmail.Text))
                {
                    this.txtBoxEmail.BorderColor = Color.Blue;
                    this.txtBoxEmail.FocusedState.BorderColor = Color.Blue;
                    this.txtBoxEmail.HoverState.BorderColor = Color.Blue;
                }
                else
                {
                    this.txtBoxEmail.FocusedState.BorderColor = Color.Red;
                    this.txtBoxEmail.HoverState.BorderColor = Color.Red;
                    this.txtBoxEmail.BorderColor = Color.Red;
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (this.txtBoxEmail != null)
            {
                if (Methods.IsValidEmail(this.txtBoxEmail.Text))
                {
                   // this.txtBoxEmail.BorderColor = Color.Blue;
                    Methods.SendEmailWithCode(this.txtBoxEmail.Text, "1234");
                }
                //else this.txtBoxEmail.BorderColor = Color.Red;
            }
        }
    }
}
