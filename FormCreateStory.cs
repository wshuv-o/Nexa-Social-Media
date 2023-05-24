/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace media
{
    public partial class FormCreateStory : Form
    {
        public FormCreateStory()
        {
            InitializeComponent();
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                guna2ComboBox1.Items.Add(fontFamily.Name);
            }
            label4.AutoSize = false;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Size = new Size(200, 500);
            guna2TrackBar1.Minimum = 0;
            guna2TrackBar1.Maximum = 255;
            guna2TrackBar1.Value = 0;
            guna2TrackBar1.Scroll += TrackBar1_Scroll;

            // Update the color of label3 based on the initial scrollbar value
            UpdateLabelColor();
        }

        private void FormCreateStory_Load(object sender, EventArgs e)
        {

        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            // Update the color of label3 based on the scrollbar value
            UpdateLabelColor();
        }

        private void UpdateLabelColor()
        {
            int red = guna2TrackBar1.Value;
            int green = 0;
            int blue = 255 - guna2TrackBar1.Value;

            label4.ForeColor = Color.FromArgb(red, green, blue);
        }


        private void CustomRoundPictureBox_Click(object sender, EventArgs e)
        {
            CustomRoundPictureBox clickedButton = (CustomRoundPictureBox)sender;

            Image backgroundImage = clickedButton.Image;
            guna2Panel3.BackgroundImage = backgroundImage;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = guna2ComboBox1.SelectedItem.ToString();

            // Update the text of label3 with the selected font name
            label4.Font = new Font(selectedFontName, label3.Font.Size);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = guna2TextBox1.Text;
        }
    }
}
*/
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Web.Services.Description;
using System.Windows.Forms;
using media.Classes;
using MySql.Data.MySqlClient;

namespace media
{
    public partial class FormCreateStory : Form
    {
        private Classes.User nativeUser;
        private int bg = 1;
        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { this.nativeUser = value; }
        }
        private bool isLabelDragging = false;
        private Point labelOffset;

        public FormCreateStory(Classes.User nativeUser, string text)
        {
            InitializeComponent();
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                guna2ComboBox1.Items.Add(fontFamily.Name);
            }
            label4.AutoSize = false;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Size = new Size(200, 500);
            label4.MouseDown += Label4_MouseDown;
            label4.MouseMove += Label4_MouseMove;
            label4.MouseUp += Label4_MouseUp;
            this.nativeUser = nativeUser;
            this.guna2TextBox1.Text= text;
            this.customRoundPictureBox1.Image = ClassNativeUser.NativeUser.ProfilePhoto;
            this.label1.Text = ClassNativeUser.NativeUser.UserFirstName + " " + ClassNativeUser.NativeUser.UserLastName;


        }




        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {
            isLabelDragging = true;
            labelOffset = e.Location;
            label4.BringToFront();
        }

        private void Label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLabelDragging)
            {
                Point newLocation = label4.Location;
                newLocation.Offset(e.Location.X - labelOffset.X, e.Location.Y - labelOffset.Y);
                label4.Location = newLocation;
            }
        }










        private void Label4_MouseUp(object sender, MouseEventArgs e)
        {
            isLabelDragging = false;
        }

        private void CustomRoundPictureBox_Click(object sender, EventArgs e)
        {
            CustomRoundPictureBox clickedButton = (CustomRoundPictureBox)sender;

            Image backgroundImage = clickedButton.Image;
            guna2Panel3.BackgroundImage = backgroundImage;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = guna2ComboBox1.SelectedItem.ToString();

            // Update the text of label4 with the selected font name
            label4.Font = new Font(selectedFontName, label4.Font.Size);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = guna2TextBox1.Text;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label4.ForeColor = colorDialog.Color;
                MessageBox.Show(label4.ForeColor.A.ToString()+" "+ label4.ForeColor.R.ToString());
            }
        }

        private void FormCreateStory_Load(object sender, EventArgs e)
        {

        }
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int fontSize = guna2TrackBar1.Value;

            label4.Font = new Font(label4.Font.FontFamily, fontSize);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg1)
            {
                bg = 1;
            }
            else if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg2)
            {
                bg = 2;
            }
            else if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg3)
            {
                bg = 3;
            }
            else if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg4)
            {
                bg = 4;
            }
            else if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg5)
            {
                bg = 5;
            }
            else if (guna2Panel3.BackgroundImage == global::media.Properties.Resources.sbg6)
            {
                bg = 6;
            }
            else 
            {
                bg = 7;
            }
            string storyText = label4.Text;
                    DateTime storyTime = DateTime.Now;
                    int storyBackground = bg;
                    string storyFont = label4.Font.Name;
                    int a = label4.ForeColor.A;
                    int r = label4.ForeColor.R;
                    int g = label4.ForeColor.G;
                    int b = label4.ForeColor.B;
                    int storyFontSize = guna2TrackBar1.Value;
                    int userId = ClassNativeUser.NativeUser.Key;
                    int lblX = this.label4.Location.X;
                    int lbly = this.label4.Location.Y;

                    DBImageOperation dbio=new DBImageOperation();
                    string connstring = "server = 127.0.0.1; user = root; database = nexaa; port = 3306; password = ";
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        string query = "INSERT INTO story (storyText, storyTime, storyBackground, x, y, storyFont, A, R, G, B, StoryFontSize, userId) " +
                                       "VALUES (@storyText, @storyTime, @storyBackground, @x, @y,  @storyFont, @a, @r, @g, @b, @storyFontSize, @userId)";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@storyText", storyText);
                        command.Parameters.AddWithValue("@storyTime", storyTime);
                        command.Parameters.AddWithValue("@storyBackground", storyBackground);
                        command.Parameters.AddWithValue("@x", lblX);
                        command.Parameters.AddWithValue("@y", lbly);
                        command.Parameters.AddWithValue("@storyFont", storyFont);
                        command.Parameters.AddWithValue("@a", a);
                        command.Parameters.AddWithValue("@r", r);
                        command.Parameters.AddWithValue("@g", g);
                        command.Parameters.AddWithValue("@b", b);
                        command.Parameters.AddWithValue("@storyFontSize", storyFontSize);
                        command.Parameters.AddWithValue("@userId", userId);

                        command.ExecuteNonQuery();
                    }
                

        }
    }
}
