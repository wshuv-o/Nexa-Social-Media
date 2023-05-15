using Guna.UI2.WinForms;
using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace media
{
    public partial class Nexa : Form
    {
        Form activeForm = null;
        public Nexa()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            new FormForgetPassword();
        }

        private void flowLayoutPanel1_Paint(object sender, EventArgs e)
        {

        }
        //192.168.208.69
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text;
            string connString = DatabaseCredentials.connectionStringLocalServer;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT  password  FROM user WHERE email=@Email";
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
                                    User user=this.GetUserByEmail(email);
                                    //MessageBox.Show("userFound!"+"user name is"+user.UserFirstName);
                                    openChildForm(new FormBase(user));
                                    ClassNativeUser.NativeUser=user;
                                }
                                else
                                {
                                    CustomMessageBox x = new CustomMessageBox();
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
                            reader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        public Classes.User GetUserByEmail(string email)
        {
            DBImageOperation dbio = new DBImageOperation();
            Classes.User user = new Classes.User();
            try
            {
                string connectionString = DatabaseCredentials.connectionStringLocalServer;
                string query = "SELECT * FROM user WHERE email = @Email";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.Key = reader.GetInt32("userid");
                   
                    user.UserFirstName = reader.GetString("userfirstname");
                    user.UserLastName = reader.GetString("userlastname");
                    user.Dob = reader.GetDateTime("dob");
                    user.Email = reader.GetString("email");
                    user.PhoneNumber = reader.GetString("phoneno");
                    user.ProfilePhoto = dbio.LoadImageFromDataBase(reader.GetInt32("userid"));
                    user.Gender = reader.GetString("gender");
                    user.Bio = reader.GetString("bio");
                    //MessageBox.Show(" " + user.Key);

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return user;
        }
       

        private void btnSignUp(object sender, EventArgs e){
            Methods.OpenChildForm(new FormSignUp(), this.panelBase);
            //panelBase.SuspendLayout();
            //FormSignUp f= new FormSignUp();
            // set the Dock property of form2 to Fill and add it to panel1
            //f.Dock = DockStyle.Fill;
            //this.Controls.Add(f);

            // resume layout logic for panel1
            //this.ResumeLayout();
        }
        /*private void button2_Click_1(object sender, EventArgs e)
        {
            // Clear all controls from form1
            this.Controls.Clear();
            FormSignUp f = new FormSignUp();
            // Add all controls from form2 to form1
            this.Controls.AddRange(f.Controls.Cast<Control>().ToArray());
        }
        */


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm( new FormSignUp(), panelBase);
            //this.Close();
        }        
        private void btnPageSignUp_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm( new FormPageSignUp(), panelBase);
            //this.Close();
        }    
        private void panel1_Paint(object sender, EventArgs e)
        {

        }    
        private void panelBase_Paint(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
