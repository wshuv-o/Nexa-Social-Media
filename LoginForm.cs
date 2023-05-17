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
            FormForgetPassword f= new FormForgetPassword();
            f.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, EventArgs e)
        {

        }
        //192.168.208.69
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text;
            string password = txtbxPassword.Text;

            try
            {
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                    {
                        conn.Open();
                        string query = "SELECT password FROM user WHERE email = @Email";
                        string queryPage = "SELECT page_password FROM pages WHERE page_email = @Email";
                        string queryAdmin = "SELECT adminpassword FROM admin WHERE adminemail = @Email";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string userPassword = reader.GetString(0);
                                    if (password.Equals(userPassword))
                                    {
                                        this.panel1.Dispose();
                                        User user = this.GetUserByEmail(email);
                                        openChildForm(new FormBase(user));
                                        ClassNativeUser.NativeUser = user;
                                        return;
                                    }
                                }
                            }
                        }

                        using (MySqlCommand cmd = new MySqlCommand(queryPage, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string pagePassword = reader.GetString(0);
                                    if (password.Equals(pagePassword))
                                    {
                                        this.panel1.Dispose();
                                        Classes.Page page = this.GetPageByEmail(email);
                                        openChildForm(new Page.FormPageHome(page));
                                        ClassNativeUser.NativePage = page;
                                        return;
                                    }
                                }
                            }
                        }
                        using (MySqlCommand cmd = new MySqlCommand(queryAdmin, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string adminPassword = reader.GetString(0);
                                    if (password.Equals(adminPassword))
                                    {
                                        this.panel1.Dispose();
                                        Classes.Admin admin = this.GetAdminByEmail(email);
                                        openChildForm(new FormAdminHome(admin));
                                        ClassNativeUser.NativeAdmin = admin;
                                        return;
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Invalid email or password.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both email and password.");
                }
            }
            catch (Exception ex)
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

        public Classes.Page GetPageByEmail(string email)
        {
            DBImageOperation dbio = new DBImageOperation();
            Classes.Page page = new Classes.Page();
            try
            {
                string query = "SELECT * FROM pages WHERE page_email = @Email";
                MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    page.PageId = reader.GetInt32("page_id");
                    page.PageName = reader.GetString("page_name");
                    page.PageEmail = reader.GetString("page_email");
                    page.CreationDate = reader.GetDateTime("page_creation_date");
                    page.PagePhoneNumber = reader.GetString("page_phone_no");
                    page.PageAddress = reader.GetString("page_address");
                    page.PageType = reader.GetString("page_type");
                    page.PageProfileImage = dbio.LoadPageProfileImageFromDataBase(page.PageId);

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return page;
        }
        public Classes.Admin GetAdminByEmail(string email)
        {
            DBImageOperation dbio = new DBImageOperation();
            Classes.Admin admin = new Classes.Admin();
            try
            {
                string query = "SELECT * FROM pages WHERE page_email = @Email";
                MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    admin.AdminId = reader.GetInt32("adminid");
                    admin.FirstName = reader.GetString("adminfirstname");
                    admin.FirstName = reader.GetString("adminlastname");
                    admin.Email = reader.GetString("adminemail");
                    admin.AdminImage = dbio.LoadAdminImageFromDataBase(admin.AdminId);

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return admin;
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
            
        }        
        private void btnPageSignUp_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm( new FormPageSignUp(), panelBase);
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
