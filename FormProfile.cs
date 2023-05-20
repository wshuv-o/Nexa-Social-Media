using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormProfile : Form
    {
        private User nativeUser;
        public User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }
        public FormProfile(User nativeUser)
        {
            this.NativeUser= nativeUser;
            InitializeComponent();
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel2, true);
            Methods.SetDoubleBuffer(tableLayoutPanel3, true);
            Methods.SetDoubleBuffer(tableLayoutPanel4, true);
            Methods.SetDoubleBuffer(tableLayoutPanel5, true);
            Methods.SetDoubleBuffer(guna2GradientPanel1, true);
            Methods.SetDoubleBuffer(guna2GradientPanel2, true);
            Methods.SetDoubleBuffer(guna2GradientPanel3, true);
            Methods.SetDoubleBuffer(guna2GradientPanel4, true);
            Methods.SetDoubleBuffer(guna2Panel1, true);
            if(this.NativeUser.ProfilePhoto!=null)
            this.userProfilePhoto.BackgroundImage = this.NativeUser.ProfilePhoto;
            this.lblUserName.Text = this.NativeUser.UserFirstName + " "+ this.NativeUser.UserLastName;
            this.lblBio.Text= this.NativeUser.Bio;
            this.nativeUser.PersonalWebsites = this.GetWebsitesByUserId(this.nativeUser.Key);
            if (this.nativeUser.PersonalWebsites.Length > 0)
            {
                int i= 0;
                foreach (Websites wb in this.NativeUser.PersonalWebsites) 
                {
                    this.web[i].Text = this.NativeUser.PersonalWebsites[0].Link;
                    i++;
                }

            }
            //bool isFriend=false;
            
            if (IsFriend())
            {
                btnFollow.Text = "Unfollow";
                btnFollow.FillColor = Color.WhiteSmoke;
                btnFollow.ForeColor = Color.Black;
                btnFollow.Click += delegate
                {
                    btnFollow.Text = "Follow";
                    btnFollow.FillColor = Color.FromArgb(94, 148, 255);
                    btnFollow.ForeColor = Color.White;
                    RemoveFriendship();

                };
            }
            else
            {
                btnFollow.Text = "Follow";
                btnFollow.FillColor = Color.FromArgb(94, 148, 255);
                btnFollow.ForeColor = Color.White;
                btnFollow.Click += delegate
                {
                    btnFollow.Text = "Requested";
                    btnFollow.FillColor = Color.WhiteSmoke;
                    btnFollow.ForeColor = Color.Black;
                };
            }

        }
        private bool IsFriend()
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM friends WHERE nativeuserid = " + this.NativeUser.Key + " AND frienduserid = " + ClassNativeUser.NativeUser.Key, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0) return true;
                }
                using (var command = new MySqlCommand("SELECT * FROM friends WHERE nativeuserid = " + ClassNativeUser.NativeUser.Key + " AND frienduserid = " + this.NativeUser.Key, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0) return true;
                }
                connection.Close();
            }
            return false;
        }

        private void RemoveFriendship()
        {
            using (var connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                connection.Open();

                using (var command = new MySqlCommand("DELETE FROM friends WHERE (nativeuserid = @x AND frienduserid = @y) OR (nativeuserid = @y AND frienduserid = @x)", connection))
                {
                    command.Parameters.AddWithValue("@x", this.NativeUser.Key);
                    command.Parameters.AddWithValue("@y", ClassNativeUser.NativeUser.Key);
                    command.ExecuteNonQuery();
                }
            }
            btnFollow.Text = "Follow";
            btnFollow.FillColor = Color.FromArgb(94, 148, 255);
            btnFollow.ForeColor = Color.White;
            btnFollow.Click += delegate
            {
                btnFollow.Text = "Requested";
                btnFollow.FillColor = Color.WhiteSmoke;
                btnFollow.ForeColor = Color.Black;
            };
        }
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CreateFloatingPanel()
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }

        private void userProfilePhoto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
        public Websites[] GetWebsitesByUserId(int userId)
        {
            List<Websites> websitesList = new List<Websites>();

            try
            {
                string connectionString = DatabaseCredentials.connectionStringLocalServer;
                string query = "SELECT * FROM websites WHERE userid = @UserId";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string link = reader.GetString("website_link");
                    Websites website = new Websites(link);
                    websitesList.Add(website);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            //MessageBox .Show("" + websitesList.ToArray().Length);
            return websitesList.ToArray();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            guna2Button3.FillColor = Color.White;
            guna2Button3.ForeColor = Color.Black;

            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.ForeColor = Color.White;
            
            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.ForeColor = Color.White;
            
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.White;



            FormPostPanelForProfile h = new FormPostPanelForProfile(this.NativeUser.Key);
            h.panelFeed.Padding = new Padding(170,0,0,0);
            Methods.OpenChildForm(h, this.panel1);
            //this.panel1.Refresh();
            
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.White;
            guna2Button4.ForeColor = Color.Black;

            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.ForeColor = Color.White;

            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.ForeColor = Color.White;

            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.White;

            Profile.FormPostImages fpi = new Profile.FormPostImages();
            Methods.OpenChildForm(fpi, this.panel1);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.White;
            guna2Button5.ForeColor = Color.Black;

            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.ForeColor = Color.White;

            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.ForeColor = Color.White;

            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.ForeColor = Color.White;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.White;
            guna2Button6.ForeColor = Color.Black;

            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.ForeColor = Color.White;

            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.ForeColor = Color.White;

            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.ForeColor = Color.White;
        }
    }
}
