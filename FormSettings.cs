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

namespace media
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            string selectedImagePath="";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected an image file, so you can now use it in your code
                 selectedImagePath = openFileDialog.FileName;

                // Convert the selected image to a byte array
                byte[] imageData = File.ReadAllBytes(selectedImagePath);
                string conString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";
                // Create a MySQL connection and command objects
                string query = "UPDATE user SET user_image = @userimage WHERE userid = 38";

                MySqlConnection conn = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // Add the image data as a parameter to the command
                MySqlParameter param = new MySqlParameter("@userimage", MySqlDbType.Blob);
                param.Value = imageData;
                cmd.Parameters.Add(param);

                // Open the connection and execute the command
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            this.guna2Button4.Image = new Bitmap(Image.FromFile(selectedImagePath));
        }
    }
}
