using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace media
{
    public partial class Post : Form
    {
        private media.Classes.ClassPost classPosts;
        public media.Classes.ClassPost ClassPosts
        {
            get { return classPosts; }
            set { classPosts = value; }
        }
        public Post(media.Classes.ClassPost classPost)
        {
            this.classPosts = new Classes.ClassPost();
            this.classPosts = classPost;
            InitializeComponent();
            Methods.RoundImageBoxCorners(UserProfileImage, 20);
            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel4, true);
            Methods.SetDoubleBuffer(guna2ShadowPanel1, true);
            Methods.SetDoubleBuffer(basePanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel2, true);

            if (classPost != null)
            {

                this.postTime.Text = classPost.PostTime.ToString();
                this.postText.Text = classPost.PostText;
                if (classPost.PostImage != null)
                {
                    this.postImagePanel.BackgroundImage = classPost.PostImage;
                    Methods.SetDoubleBuffer(postImagePanel, true);
                    postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)postImagePanel.BackgroundImage);
                    //MessageBox.Show("image");
                    this.postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)this.postImagePanel.BackgroundImage);


                }
                else
                {
                    int removeColumnIndex = 0;
                    int removeRowIndex = 2;

                    Control controlToRemove = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex);
                    if (controlToRemove != null)
                    {
                        tableLayoutPanel2.Controls.Remove(controlToRemove);
                        controlToRemove.Dispose();

                        for (int rowIndex = removeRowIndex + 1; rowIndex < tableLayoutPanel2.RowCount; rowIndex++)
                        {
                            Control control = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, rowIndex);
                            if (control != null)
                            {
                                tableLayoutPanel2.SetCellPosition(control, new TableLayoutPanelCellPosition(removeColumnIndex, rowIndex - 1));
                            }
                        }

                        Control adjacentControl = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex - 1);
                        if (adjacentControl != null)
                        {
                            tableLayoutPanel2.SetRowSpan(adjacentControl, tableLayoutPanel2.GetRowSpan(adjacentControl) + 1);
                        }

                        tableLayoutPanel2.RowCount--;
                    }


                }

                this.reactCount.Text = classPost.NoOfReacts.ToString();
                this.UserProfileImage.BackgroundImage = classPost.PostCreator.ProfilePhoto;
                this.lblUserName.Text = classPost.PostCreator.UserFirstName + " " + classPost.PostCreator.UserLastName;

            }
            else
            {
                this.postTime.Text = "N/A";
            }
            //postText.AutoSize = false;
            postText.MaximumSize = new Size(700, 100);

            bool alreadyLiked = CheckIfAlreadyLiked(this.ClassPosts.PostId, ClassNativeUser.NativeUser.Key);
            if (alreadyLiked)
            {
                button2.Image = global::media.Properties.Resources.icons8_favorite_96;
            }

        }
        public Post()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

/*        private void button1_Click_1(object sender, EventArgs e)
        {
            string richTextBoxText = richTextBox1.Text;
            postText.Text = richTextBoxText;
            postText.AutoSize = true;
            postText.MaximumSize = new Size(panel2.Width, int.MaxValue);
            panel2.Height = postText.Height;
        }
*/
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Post_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int postId = GetPostId(); 
            int userId = GetUserId(); 

            bool alreadyLiked = CheckIfAlreadyLiked(postId, userId);

            if (!alreadyLiked)
            {
                InsertLike(postId, userId);
                UpdateReactCount(postId, 1);
                button2.Image = global::media.Properties.Resources.icons8_favorite_96;
            }
            else
            {
                RemoveLike(postId, userId);
                UpdateReactCount(postId, -1);
                button2.Image = global::media.Properties.Resources.icons8_heart_96;
            }
        }

        private bool CheckIfAlreadyLiked(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "SELECT COUNT(*) FROM LikeTable WHERE PostId = @postId AND UserId = @userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
                
            }
        }

        private void InsertLike(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "INSERT INTO LikeTable (PostId, UserId, LikedOn) VALUES (@postId, @userId, @likedOn)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@likedOn", DateTime.Now); // You can replace DateTime.Now with the actual likedOn value

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Method to remove the like from the Likes table
        private void RemoveLike(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "DELETE FROM LikeTAble WHERE PostId = @postId AND UserId = @userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void UpdateReactCount(int postId, int incrementValue)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "UPDATE postofuser SET postReactCount = postReactCount + @incrementValue WHERE PostId = @postId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@incrementValue", incrementValue);
                command.Parameters.AddWithValue("@postId", postId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private int GetPostId()
        {
            return this.ClassPosts.PostId;
        }

        private int GetUserId()
        {
            return ClassNativeUser.NativeUser.Key;
        }

    }
}
