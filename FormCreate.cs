using System;
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
        public FormCreate()
        {
            InitializeComponent();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
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

            // Create a new bitmap to hold the components that should not be blurred
            Bitmap componentBitmap = new Bitmap(panel.Width, panel.Height);

            // Draw the components of the panel onto the new bitmap
            panel.DrawToBitmap(componentBitmap, new Rectangle(0, 0, panel.Width, panel.Height));

            // Create a new bitmap to hold the blurred image
            Bitmap blurred = new Bitmap(panel.Size.Width, panel.Size.Height);

            using (Graphics graphics = Graphics.FromImage(blurred))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the blurred bitmap
                graphics.DrawImage(image, new Rectangle(panel.Location.X, panel.Location.Y, blurred.Width, blurred.Height), panel.Location.X, panel.Location.Y, image.Width, image.Height, GraphicsUnit.Pixel);

                // Draw the component bitmap onto the blurred bitmap without blurring them
                graphics.DrawImage(componentBitmap, new Rectangle(panel.Location.X, panel.Location.Y, componentBitmap.Width, componentBitmap.Height), 0, 0, componentBitmap.Width, componentBitmap.Height, GraphicsUnit.Pixel);

                // Blur the rest of the image
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
