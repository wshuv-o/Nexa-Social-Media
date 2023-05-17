using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormCreate : Form
    {
        private int type;
        private User nativeUser;
        private Classes.Page nativePage;
        private Classes.ClassPost postDetails;
        public User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }       
        public Classes.Page NativePage
        {
            get { return nativePage; }
            set { nativePage = value; }
        }

        public FormCreate(User user)
        {
            postDetails= new ClassPost();
            this.NativeUser= user;
            InitializeComponent();
            this.pboxUserProfilePhoto.Image = this.NativeUser.ProfilePhoto;
            this.lblUserName.Text = this.NativeUser.UserFirstName + " "+this.NativeUser.UserLastName;
            type = 5;
        }        
        public FormCreate(Classes.Page nativePage)
        {
            postDetails= new ClassPost();
            this.NativePage= nativePage;
            InitializeComponent();
            this.pboxUserProfilePhoto.Image = this.NativePage.PageProfileImage;
            this.lblUserName.Text = this.NativePage.PageName;
            type = 7;
        }





        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Image image= ImageCompress.SelectAndCompressImage();
            postDetails.PostImage=image;

            Guna.UI2.WinForms.Guna2PictureBox pictureTemplate= new Guna.UI2.WinForms.Guna2PictureBox();
            pictureTemplate.ImageRotate = 0F;
            pictureTemplate.Location = new System.Drawing.Point(3, 3);
            pictureTemplate.Name = "pictureTemplate";
            pictureTemplate.Size = new System.Drawing.Size(633, 334);
            pictureTemplate.Image = image;
            pictureTemplate.BackgroundImageLayout=ImageLayout.Stretch; 
            pictureTemplate.TabIndex = 0;
            pictureTemplate.TabStop = false;
            this.flowLayoutPanel1.Controls.Add(pictureTemplate);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int postId = 0;
            postDetails.PostTime = DateTime.Now;
            postDetails.PostText = txtbxPostText.Text;
            postDetails.Permission = permission.SelectedItem.ToString();
            if (type == 5)
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    string query = "INSERT INTO postofuser (postText, postTime, postPermission, userid) VALUES (@a, @b, @c, @d)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", postDetails.PostText);
                        cmd.Parameters.AddWithValue("@b", postDetails.PostTime);
                        cmd.Parameters.AddWithValue("@c", postDetails.Permission);
                        cmd.Parameters.AddWithValue("@d", this.NativeUser.Key);
                        cmd.ExecuteNonQuery();

                        if (postDetails.PostImage == null)
                        {
                            MessageBox.Show("Successfully posted");
                            this.Close();
                            return;
                        }
                        
                        string retrieveQuery = "SELECT LAST_INSERT_ID()";
                        using (MySqlCommand retrieveCmd = new MySqlCommand(retrieveQuery, conn))
                        {
                            postId = Convert.ToInt32(retrieveCmd.ExecuteScalar());
                        }
                    }
                    conn.Close();
                }

                if (postDetails.PostImage != null)
                {
                    using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                    {
                        DBImageOperation dbio = new DBImageOperation();
                        string query = "INSERT INTO mediacontent_postuser (image, postid) VALUES (@a, @b)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@a", dbio.ImageToByteArray(postDetails.PostImage));
                            cmd.Parameters.AddWithValue("@b", postId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Successfully posted");
                        this.Close();
                        conn.Close();
                    }
                }
            }
            else if(type==7)
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    string query = "INSERT INTO postofpage (postText, postTime, postPermission, page_id) VALUES (@a, @b, @c, @d)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", postDetails.PostText);
                        cmd.Parameters.AddWithValue("@b", postDetails.PostTime);
                        cmd.Parameters.AddWithValue("@c", postDetails.Permission);
                        cmd.Parameters.AddWithValue("@d", this.NativePage.PageId);
                        cmd.ExecuteNonQuery();

                        string retrieveQuery = "SELECT LAST_INSERT_ID()";
                        using (MySqlCommand retrieveCmd = new MySqlCommand(retrieveQuery, conn))
                        {
                            postId = Convert.ToInt32(retrieveCmd.ExecuteScalar());
                        }
                    }
                    conn.Close();
                }

                if (postDetails.PostImage != null)
                {
                    using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                    {
                        DBImageOperation dbio = new DBImageOperation();
                        string query = "INSERT INTO mediacontent_postpage (image, postid) VALUES (@a, @b)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            conn.Open();
                            cmd.Parameters.AddWithValue("@a", dbio.ImageToByteArray(postDetails.PostImage));
                            cmd.Parameters.AddWithValue("@b", postId);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
            }

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*public void BlurPanel(Panel panel)
{
Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
this.DrawToBitmap(bitmap, new Rectangle(panel.Location.X, panel.Location.Y, panel.Width, panel.Height));            // Apply the blur effect to the bitmap
Bitmap blurred = ApplyGaussianBlurOnPanel(bitmap, 10, Size);
this.BackgroundImage = blurred;
this.Opacity = 1;
this.ShowDialog();
}*/


        /* public Bitmap GetBlurredImage(Panel panel, int blurAmount)
         {
             Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
             panel.DrawToBitmap(bitmap, new Rectangle(panel.Location.X, panel.Location.Y, panel.Width, panel.Height));
             return ApplyGaussianBlurOnPanel(bitmap, blurAmount, panel);
         }

         private Bitmap ApplyGaussianBlurOnPanel(Bitmap image, int blurAmount, Panel panel)
         {
             if (blurAmount < 1)
                 return image;
             Bitmap componentBitmap = new Bitmap(panel.Width, panel.Height);
             panel.DrawToBitmap(componentBitmap, new Rectangle(0, 0, panel.Width, panel.Height));
             Bitmap blurred = new Bitmap(panel.Size.Width, panel.Size.Height);
             using (Graphics graphics = Graphics.FromImage(blurred))
             {
                 graphics.SmoothingMode = SmoothingMode.AntiAlias;
                 graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                 graphics.DrawImage(image, new Rectangle(panel.Location.X, panel.Location.Y, blurred.Width, blurred.Height), panel.Location.X, panel.Location.Y, image.Width, image.Height, GraphicsUnit.Pixel);
                 graphics.DrawImage(componentBitmap, new Rectangle(panel.Location.X, panel.Location.Y, componentBitmap.Width, componentBitmap.Height), 0, 0, componentBitmap.Width, componentBitmap.Height, GraphicsUnit.Pixel);
                 for (int i = 0; i < blurAmount; i++)
                 {
                     using (Bitmap temp = (Bitmap)blurred.Clone())
                     {
                         using (Graphics tempGraphics = Graphics.FromImage(blurred))
                         {
                             tempGraphics.Clear(Color.Transparent);
                             tempGraphics.DrawImage(temp, new Rectangle(panel.Location.X, panel.Location.Y, blurred.Width, blurred.Height), panel.Location.X, panel.Location.Y, temp.Width, temp.Height, GraphicsUnit.Pixel);
                             tempGraphics.Flush();
                         }
                         temp.Dispose();
                     }
                 }
             }

             return blurred;
         }*/
    }
}
