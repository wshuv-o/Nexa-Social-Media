using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace media
{
    public partial class DBImageOperation
    {
        private const string ConnectionString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";
        private int userId = 38;
        private Image image;
        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        public Image Image
        {
            get { return this.image; }
        }


        public  Image SelectImageFromFile(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(dialog.FileName);
                }
            }
            return image;
        }

        public void SaveToDataBase(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = ImageToByteArray(image);
            UpdateUserImage(imageBytes);
            MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Image LoadImageFromDataBase(object sender, EventArgs e)
        {
            byte[] imageBytes = GetUserImage();
            if (imageBytes == null)
            {
                MessageBox.Show("No image found for user ID " + userId + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            image = ByteArrayToImage(imageBytes);
            return image;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return stream.ToArray();
            }
        }

        private void UpdateUserImage(byte[] imageBytes)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "UPDATE user SET userimage = @userimage WHERE userId = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userimage", imageBytes);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private byte[] GetUserImage()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT userimage FROM user WHERE userId = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                return (byte[])reader[0];
                            }
                        }
                    }
                }
            }

            return null;
        }

        private Image ByteArrayToImage(byte[] imageBytes)
        {
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
