using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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
        private bool isAuthenticated=false;
        private string AuthCode = "123456";
        public FormSignUp()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

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
           // guna2GradientPanel1.Controls.Clear();
           // guna2GradientPanel1.Padding= new Padding(0,0,0,0);  
            Nexa n = new Nexa();
            //n.Dock=DockStyle.Fill;
            Methods.OpenChildForm(n, guna2GradientPanel1);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bool isPasswordMatched = true;
            if (this.txtbxPassword.Text != null && this.txtbxPassword.Text != this.txtbxConfirmPassword.Text)
            {
                this.txtbxConfirmPassword.FocusedState.BorderColor = Color.Red;
                this.txtbxConfirmPassword.HoverState.BorderColor = Color.Red;
                this.txtbxConfirmPassword.BorderColor = Color.Red;
                isPasswordMatched = false;
                
            }

            if (isPasswordMatched && isAuthenticated && txtBoxEmail.Text != null && txtbxFirstName.Text != null && txtbxLastName.Text != null && txtbxPassword.Text != null && datePickerDOB.Text != null)
            {


                string connString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO user (userfirstname, userlastname, email, dob, gender, password) VALUES (@first_name, @last_name, @email, @dob, @gender, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtbxFirstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtbxLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@dob", datePickerDOB.Value);
                        cmd.Parameters.AddWithValue("@gender", "male");
                        cmd.Parameters.AddWithValue("@password", txtbxPassword.Text);
                        cmd.ExecuteNonQuery();
                        guna2Panel3.Controls.Clear();
                        this.addSuccessPanel();
                    }
                }
                 

            }
        }

            private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (this.guna2Button3.Text == "Send" && this.txtBoxEmail.Text != null)
            {
                this.guna2Button3.Text = "Verify";
                if (this.txtBoxEmail.Text != null)
                {
                    if (Methods.IsValidEmail(this.txtBoxEmail.Text))
                    {
                        Methods.SendEmailWithCode(this.txtBoxEmail.Text, AuthCode);
                    }
                    else
                    {
                        MessageBox.Show("Please provide an valid mail address");
                    }
                }
            }
            else
            {
                if (this.txtbxAuth.Text == this.AuthCode)
                {
                    isAuthenticated= true;
                }
            }
        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtbxPassword.Text != null && this.txtbxPassword.Text != this.txtbxConfirmPassword.Text)
            {
                this.txtbxConfirmPassword.FocusedState.BorderColor = Color.Red;
                this.txtbxConfirmPassword.HoverState.BorderColor = Color.Red;
                this.txtbxConfirmPassword.BorderColor = Color.Red;
            }
            else
            {
                this.txtbxConfirmPassword.FocusedState.BorderColor = Color.Blue;
                this.txtbxConfirmPassword.HoverState.BorderColor = Color.Blue;
                this.txtbxConfirmPassword.BorderColor = Color.Blue;
            }
        }
          private void addSuccessPanel()
        {
            Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1 = new Guna2PictureBox();
            Panel panel1 = new Panel();
            Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1 = new Guna2HtmlLabel();
            Guna.UI2.WinForms.Guna2Button guna2Button4 = new Guna2Button();
            guna2PictureBox1.Image = global::media.Properties.Resources.party_popper;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new System.Drawing.Point(116, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.Size = new System.Drawing.Size(267, 259);
            guna2PictureBox1.TabIndex = 3;
            guna2PictureBox1.TabStop = false;
            panel1.Controls.Add(guna2Button4);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Location = new System.Drawing.Point(36, 87);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(498, 451);
            panel1.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guna2HtmlLabel1.Location = new System.Drawing.Point(24, 283);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new System.Drawing.Size(450, 64);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "You succesfully created your account <br>please go back to login page to get star" +
    "ted";
            guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            guna2Button4.BorderRadius = 20;
            guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            guna2Button4.FillColor = System.Drawing.Color.DarkSlateBlue;
            guna2Button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            guna2Button4.ForeColor = System.Drawing.Color.White;
            guna2Button4.Location = new System.Drawing.Point(131, 368);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new System.Drawing.Size(237, 45);
            guna2Button4.TabIndex = 32;
            guna2Button4.Text = "Sign in";

            this.guna2Panel3.Controls.Add(panel1);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
