using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace media
{
    public partial class GamesPage : Form
    {
        private List<Image> _images = new List<Image>(); // List of images to display
        private int _currentIndex = 0; // Index of the current image being displayed
        //private Timer _timer = new Timer(); // Timer to move the picture
        public System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public GamesPage()
        {
            InitializeComponent();
            _images.Add(media.Properties.Resources.wp6823992_cyberpunk_2077_game_poster_wallpapers);
            _images.Add(media.Properties.Resources.CITYSCAPE1142023);

            guna2PictureBox1.BackgroundImage = _images[_currentIndex];

            _timer.Interval = 2000; // 4 seconds
            _timer.Tick += timer_Tick;
            _timer.Start();
            guna2PictureBox1.BackColor=Methods.GetBackgroundAverageColor((Bitmap)guna2PictureBox1.BackgroundImage);


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            _currentIndex = (_currentIndex + 1) % _images.Count;
            guna2PictureBox1.BackgroundImage = _images[_currentIndex];


            // Start a fade-in effect
            int fadeSteps = 10; // Number of steps in the fade effect
            double fadeStepTime = 6; // Time (in ms) between fade steps
            double fadeStepOpacity = 2.0 / fadeSteps; // Opacity change per step
            double currentOpacity = 0.0;
            _timer.Stop(); // Stop the timer temporarily to avoid overlapping ticks
            for (int i = 0; i < fadeSteps; i++)
            {
                currentOpacity += fadeStepOpacity;
                guna2PictureBox1.BackgroundImage = _images[_currentIndex];
                guna2PictureBox1.BackgroundImage = ChangeOpacity(guna2PictureBox1.BackgroundImage, currentOpacity);
                //guna2PictureBox1.Refresh();
                Application.DoEvents();
                System.Threading.Thread.Sleep((int)fadeStepTime);
            }
            _timer.Start();
        }

        private Image ChangeOpacity(Image image, double opacity)
        {
            // Create a new Bitmap object with the same dimensions as the original image
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            // Draw the original image onto the new Bitmap object with the specified opacity
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = (float)opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            // Return the new image
            return bmp;
        }




        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void customFlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void GamesPage_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
