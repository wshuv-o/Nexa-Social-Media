using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace media
{
    public partial class Nexa : Form
    {
        Form activeForm = null;
        public Nexa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods.RoundButtonCorners(button1, 20);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text;
            string connString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT password FROM user WHERE email=@Email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string password = reader.GetString(0);
                            if (password.Equals(txtbxPassword.Text))
                            {
                                this.panel1.Dispose();
                                openChildForm(new Form1());
                            }
                            else
                            {
                                CustomMessageBox x= new CustomMessageBox();
                                x.ShowDialog();
                                return;
                            }
                        }
                        else
                        {
                            CustomMessageBox x = new CustomMessageBox();
                            x.ShowDialog();
                            return;
                        }
                    }
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Twizzle_Load(object sender, EventArgs e)
        {

        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelBase.Controls.Add(childForm);
                panelBase.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelBase.Controls.Add(childForm);
                panelBase.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormSignUp());
        }

        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FormForgetPassword f = new FormForgetPassword();
            f.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Methods.OpenChildForm( new FormPageSignUp(), panelBase);
            //this.Close();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
