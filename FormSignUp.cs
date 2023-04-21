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
                new Form();
            }

            if (isPasswordMatched && isAuthenticated && txtBoxEmail.Text != null && txtbxFirstName.Text != null && txtbxLastName.Text != null && txtbxPassword.Text != null && datePickerDOB.Text != null)
            {


                string connString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

                // Create MySqlConnection object
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    // Open database connection
                    conn.Open();

                    // Define SQL query to insert data into table
                    string query = "INSERT INTO user (userfirstname, userlastname, email, dob, gender) VALUES (@first_name, @last_name, @email, @dob, @gender)";

                    // Create MySqlCommand object
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to SQL query
                        cmd.Parameters.AddWithValue("@first_name", txtbxFirstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtbxLastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@dob", datePickerDOB.Text);
                        cmd.Parameters.AddWithValue("@gender", "male");


                        cmd.ExecuteNonQuery();
                    }
                }
                new Form();

            }
        }

            private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (this.guna2Button3.Text == "Send")
            {
                this.guna2Button3.Text = "Verify";
                if (this.txtBoxEmail != null)
                {
                    if (Methods.IsValidEmail(this.txtBoxEmail.Text))
                    {
                        Methods.SendEmailWithCode(this.txtBoxEmail.Text, AuthCode);
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
    }
}
