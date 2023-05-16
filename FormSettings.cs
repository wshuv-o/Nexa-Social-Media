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
using System.IO;
using media.Classes;
using Org.BouncyCastle.Utilities.Collections;
using Guna.UI2.WinForms;
using System.Configuration;
using System.Data.SqlClient;
using Aspose.Imaging.FileFormats.Emf.EmfPlus.Objects;

namespace media
{
    public partial class FormSettings : Form
    {
        private Image imageUser;
        private int s = 2;
        private byte[] image;
        private DBImageOperation dbio = new DBImageOperation();
        private Classes.User nativeUser= new Classes.User();
        private Classes.Page nativePage;

        public Classes.Page NativePage
        {
            get { return nativePage; }
            set { nativePage = value; }
        }
        public User NativeUser
        {
            get { return this.nativeUser; }
            set { this.nativeUser = value; }
        }
        public FormSettings(out User user, User userTemp)
        {
            user = userTemp;
            this.NativeUser = user;

            InitializeComponent();

            this.firstName.Text = user.UserFirstName;
            this.lastName.Text = user.UserLastName;
            this.txtBoxPhone.Text = user.PhoneNumber;
            this.txtBoxEmail.Text = user.Email;
            this.txtBoxBio.Text = user.Bio;
            this.scLink.Text = user.Email;
           // DBImageOperation dbio= new DBImageOperation();
            this.userProfilePhoto.Image = user.ProfilePhoto;
            s = 5;
        }
        public FormSettings(Classes.Page page)
        {
            this.NativePage = page;

            InitializeComponent();

            this.firstName.Text = page.PageName;
            this.lastName.Text ="";
            this.txtBoxPhone.Text = page.PagePhoneNumber;
            this.txtBoxEmail.Text = page.PageEmail;
            //this.scLink.Text = user.Email;
            // DBImageOperation dbio= new DBImageOperation();
            this.userProfilePhoto.Image = page.PageProfileImage;
            s = 7;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            /*string selectedImagePath = "";
             OpenFileDialog openFileDialog = new OpenFileDialog();
             openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
             string conString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

             if (openFileDialog.ShowDialog() == DialogResult.OK)
             {
                 selectedImagePath = openFileDialog.FileName;
                 byte[] imageData = File.ReadAllBytes(selectedImagePath);
                 string query = "UPDATE user SET userimage = @userimage WHERE userid = 38";
                 MySqlConnection conn = new MySqlConnection(conString);
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 MySqlParameter param = new MySqlParameter("@userimage", MySqlDbType.Blob);
                 param.Value = imageData;
                 cmd.Parameters.Add(param);
                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
            //DisplayImageFromDatabase(38);
            //DisplayUserImageFromDatabase();
            */
            //byte[] a = BTN_SHOW_Click(sender, e);
             imageUser = ImageCompress.SelectAndCompressImage();
            this.userProfilePhoto.Image = imageUser;




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DBImageOperation dbio= new DBImageOperation();
            //MessageBox.Show(imageUser.RawFormat.ToString());
            byte[] a = ConvertImageToByteArray(imageUser);
            if (s == 5)
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    string query = "UPDATE user SET userfirstname = @first_name, userlastname = @last_name, email = @email, "
                                 + "phoneno = @phoneno, userImage = @userImage, bio = @bio WHERE userid = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", lastName.Text);
                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@phoneno", txtBoxPhone.Text);
                        cmd.Parameters.AddWithValue("@userImage", a);
                        cmd.Parameters.AddWithValue("@bio", txtBoxBio.Text);
                        cmd.Parameters.AddWithValue("@user_id", this.NativeUser.Key);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            else if (s == 7)
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    string query = "UPDATE pages SET page_name = @first_name, page_email = @email, "
                                 + "page_phone_no = @phoneno, page_profile_image = @userImage WHERE page_id = @page_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                        cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@phoneno", txtBoxPhone.Text);
                        cmd.Parameters.AddWithValue("@userImage", a);
                        cmd.Parameters.AddWithValue("@page_id", this.NativePage.PageId);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            this.firstName.Text = this.NativeUser.UserFirstName;
            this.lastName.Text = this.NativeUser.UserLastName;
            this.txtBoxPhone.Text = this.NativeUser.PhoneNumber;
            this.txtBoxEmail.Text = this.NativeUser.Email;
            this.txtBoxBio.Text = this.NativeUser.Bio;
            this.scLink.Text = this.NativeUser.Email;
            this.userProfilePhoto.Image = this.NativeUser.ProfilePhoto;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
