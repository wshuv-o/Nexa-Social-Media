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

namespace media
{
    public partial class FormSettings : Form
    {
        private byte[] image;
        private DBImageOperation dbio = new DBImageOperation();
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
            this.guna2CircleButton4.Image= dbio.SelectImageFromFile();
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            dbio.SaveToDataBase(38);
            this.guna2CircleButton4.Image = dbio.LoadImageFromDataBase(38);
            //guna2CircleButton4.ImageSize = new Size(200, 200);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
