using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormMarketPlace : Form
    {
        public FormMarketPlace()
        {
            InitializeComponent();
            SetDoubleBuffer(guna2GradientPanel1, true);
            this.DisplayImageFromDatabase(202);

        }
        private async void SetImage()
        {
            /*WebClient wc = new WebClient();
            byte[] bytes = null;

            try
            {
                Uri u = new Uri("https://wshuv-o.github.io/100506316.jpeg");
                bytes = await wc.DownloadDataTaskAsync(u);

                Image img;
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    img = Image.FromStream(ms);
                }

                this.guna2PictureBox1.Image = img;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error downloading image: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error creating image: " + ex.Message);
            }*/
            
        }
        private void DisplayImageFromDatabase(int productId)
        {
            string connectionString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

            try
            {
                // Open a connection to the database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Create a command to retrieve the image data
                    string sql = "SELECT productimage FROM product WHERE productid = @ProductId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    // Execute the command and retrieve the image data
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["productimage"];

                            // Load the image from the byte array
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image img = Image.FromStream(ms);

                                // Set the image in the picture box
                                guna2PictureBox1.Image = img;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving image from database: " + ex.Message);
            }
        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, ctl, new object[] { DoubleBuffered });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetImage();
        }
    }
}