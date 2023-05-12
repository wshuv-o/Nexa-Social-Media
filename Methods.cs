using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;

namespace media
{
    public static class Methods
    {
        private static Form activeForm = null;
        public static void SetDoubleBuffer(Panel ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, ctl, new object[] { DoubleBuffered });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RoundPanelCorners(ref Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundPanelCorners1(ref Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundPanelCorners(ref FlowLayoutPanel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundPanelCorners(ref TableLayoutPanel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        public static void RoundButtonCorners(Button panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundButtonCorners(Guna.UI2.WinForms.Guna2Button panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundTextBoxCorners(TextBox panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundTextBoxCorners(RichTextBox panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundImageBoxCorners(PictureBox panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }


        public static void OpenChildForm(Form childForm, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        public static void OpenChildForm2(Form childForm, Panel parentPanel)
        {
            Form activeForm = null;
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        public static int spaceBetweenPictureBoxes = 10;
        static void AddPictureBox(Bitmap image, Panel basePanel)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(image.Width, image.Height);
            basePanel.Controls.Add(pictureBox);
            pictureBox.Margin = new Padding(spaceBetweenPictureBoxes, 0, 0, 0);
        }
        public static void GradientOnPanel(Panel panel)
        {
            // Set the background of gradientPanel to a gradient brush
            Color color1 = Color.FromArgb(255, 192, 192);
            Color color2 = Color.FromArgb(192, 192, 255);
            LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(panel.Width, panel.Height), color1, color2);
            panel.Paint += (s, e) => e.Graphics.FillRectangle(brush, e.ClipRectangle);
            panel.SendToBack();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public static void SendEmailWithCode(string recipient, string code)
        {
            string senderEmail = "22-49070-1@student.iub.edu"; // Your email address
            string senderPassword = "4@hjbAbnc45"; // Your email account password
            string smtpServer = "smtp.office365.com"; // Your SMTP server address
            int smtpPort = 587; // Your SMTP server port number

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            MailMessage message = new MailMessage(senderEmail, recipient);
            message.Subject = "Your verification code";
            message.Body = $"Your verification code is {code}";
            smtpClient.Send(message);
        }
        public static Color GetBackgroundAverageColor(Bitmap image)
        {
            // Load the image into a bitmap object
            Bitmap bmp = new Bitmap(image);

            // Convert the bitmap to a Color array
            Color[] pixels = new Color[bmp.Width * bmp.Height];
            int index = 0;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    pixels[index++] = bmp.GetPixel(x, y);
                }
            }

            int threshold = 50;

            int totalRed = 0, totalGreen = 0, totalBlue = 0, count = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                int redDiff = Math.Abs(pixels[i].R - Color.White.R);
                int greenDiff = Math.Abs(pixels[i].G - Color.White.G);
                int blueDiff = Math.Abs(pixels[i].B - Color.White.B);
                int colorDiff = redDiff + greenDiff + blueDiff;

                if (colorDiff > threshold)
                {
                    totalRed += pixels[i].R;
                    totalGreen += pixels[i].G;
                    totalBlue += pixels[i].B;
                    count++;
                }
            }

            // Calculate the average color of the pixels that are not part of the human body
            if (count == 0) return Color.Transparent; // Return transparent color if there are no background pixels
            int averageRed = totalRed / count;
            int averageGreen = totalGreen / count;
            int averageBlue = totalBlue / count;

            return Color.FromArgb(averageRed, averageGreen, averageBlue);
        }
        public static Classes.User GetUserByEmail(int userId)
        {
            DBImageOperation dbio = new DBImageOperation();
            Classes.User user = new Classes.User();
            try
            {
                string connectionString = DatabaseCredentials.connectionStringLocalServer;
                string query = "SELECT * FROM user WHERE userid = @userId";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.Key = reader.GetInt32("userid");
                    user.UserFirstName = reader.GetString("userfirstname");
                    user.UserLastName = reader.GetString("userlastname");
                    user.Dob = reader.GetDateTime("dob");
                    user.Email = reader.GetString("email");
                    user.PhoneNumber = reader.GetString("phoneno");
                    user.ProfilePhoto = dbio.LoadImageFromDataBase(reader.GetInt32("userid"));
                    user.Gender = reader.GetString("gender");
                    user.Bio = reader.GetString("bio");

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return user;
        }

    }
}
