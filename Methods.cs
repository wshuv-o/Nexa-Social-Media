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
        private static void FuncRound(TextBox textBox1)
        {
            // Set the border style of the textbox to none
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Height = 100;
            textBox1.Padding = new Padding(20);

            // Set the rounded corners of the textbox
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddLine(20, 0, textBox1.Width - 20, 0);
            path.AddArc(textBox1.Width - 20, 0, 20, 20, 270, 90);
            path.AddLine(textBox1.Width, 20, textBox1.Width, textBox1.Height - 20);
            path.AddArc(textBox1.Width - 20, textBox1.Height - 20, 20, 20, 0, 90);
            path.AddLine(textBox1.Width - 20, textBox1.Height, 20, textBox1.Height);
            path.AddArc(0, textBox1.Height - 20, 20, 20, 90, 90);
            path.CloseFigure();
            textBox1.Region = new Region(path);
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

            // Define a threshold color difference to determine whether a pixel is part of the human body
            int threshold = 50;

            // Iterate through the color array and calculate the average color of the pixels that are not part of the human body
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
    }
}
