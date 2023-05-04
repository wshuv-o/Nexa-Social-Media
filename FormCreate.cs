using media.Classes;
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
        private User nativeUser;
        public User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }

        public FormCreate(User user)
        {
            this.NativeUser= user;
            InitializeComponent();

           
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
            DBImageOperation dbio= new DBImageOperation();
            
            Guna.UI2.WinForms.Guna2PictureBox pictureTemplate= new Guna.UI2.WinForms.Guna2PictureBox();
            pictureTemplate.ImageRotate = 0F;
            pictureTemplate.Location = new System.Drawing.Point(3, 3);
            pictureTemplate.Name = "pictureTemplate";
            pictureTemplate.Size = new System.Drawing.Size(633, 334);
            pictureTemplate.Image = dbio.SelectImageFromFile();
            pictureTemplate.BackgroundImageLayout=ImageLayout.Stretch; 
            pictureTemplate.TabIndex = 0;
            pictureTemplate.TabStop = false;
            this.flowLayoutPanel1.Controls.Add(pictureTemplate);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
