using media.Classes;
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
            //this.web1.Text = this.NativeUser.PersonalWebsites[0].Link;

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
            Home h = new Home(this.NativeUser.Key);
           // h.panelFC.Dispose();
            //h.panel1.Dispose();
            h.panelFeed.Padding = new Padding(170,0,0,0);
            Methods.OpenChildForm(h, this.panel1);
            this.panel1.Refresh();
            
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Profile.FormPostImages fpi = new Profile.FormPostImages();
            Methods.OpenChildForm(fpi, this.panel1);
        }
    }
}
