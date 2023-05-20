using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{


public partial class Story : Form
    {
        public Button btnScrollLeft;
        public Button btnScrollRight;

        // Add the buttons to your form and set their properties

        public Story()
        {
            InitializeComponent();
            Methods.RoundButtonCorners(button1, 20);
            Methods.RoundButtonCorners(button2, 20);
            Methods.RoundButtonCorners(button3, 20);
            Methods.RoundButtonCorners(button4, 20);
            Methods.RoundButtonCorners(button5, 20);
            Methods.RoundButtonCorners(button6, 20);
            Methods.RoundButtonCorners(button7, 20);


            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button2);
            this.AddOrRemoveColorOverlay(Color.FromArgb(23, 32, 42), button1, false);

            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button3);
            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button4);
            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button5);
            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button6);
        }
        private void AddColorOverlayToButton(int Transparency, Color overlayColor, Button button)
        {
            // Get the button's background image
            Image backgroundImage = button.BackgroundImage;

            if (backgroundImage != null)
            {
                // Create a new bitmap that's the same size as the button's background image
                Bitmap bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);

                // Get the graphics object for the bitmap
                Graphics graphics = Graphics.FromImage(bitmap);

                // Draw the background image onto the bitmap
                graphics.DrawImage(backgroundImage, 0, 0);

                // Draw a rectangle with the overlay color onto the bitmap
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, overlayColor)), 0, 0, backgroundImage.Width, backgroundImage.Height);

                // Set the button's background image to the new bitmap with the color overlay
                button.BackgroundImage = bitmap;
            }
        }
        private void RemoveColorOverlayOnHover(Button button)
        {
            // Save the button's original background image
            Image originalImage = button.BackgroundImage;

            // Handle the MouseEnter event to remove the color overlay and show the original image
            button.MouseEnter += (sender, args) =>
            {
                button.BackgroundImage = originalImage;
            };

            // Handle the MouseLeave event to restore the color overlay
            button.MouseLeave += (sender, args) =>
            {
                // Get the original background image again (in case it was changed)
                Image currentImage = button.BackgroundImage;

                // If the current background image is not the original image, assume it has the color overlay
                if (currentImage != originalImage)
                {
                    // Add the color overlay back onto the current image
                    AddColorOverlayToButton(130, Color.FromArgb(23, 32, 42), button);
                }
            };
        }



        public void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int scrollOffset = 0;
        private const int scrollStep = 80;

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (!flowLayoutPanel1.AutoScroll)
            {
                scrollOffset -= scrollStep;
                if (scrollOffset < flowLayoutPanel1.HorizontalScroll.Minimum)
                    scrollOffset = flowLayoutPanel1.HorizontalScroll.Minimum;
                flowLayoutPanel1.HorizontalScroll.Value = scrollOffset;
                flowLayoutPanel1.PerformLayout();
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (!flowLayoutPanel1.AutoScroll)
            {
                scrollOffset += scrollStep;
                int maxOffset = flowLayoutPanel1.HorizontalScroll.Maximum - flowLayoutPanel1.Width;
                if (scrollOffset > maxOffset)
                    scrollOffset = maxOffset;
                flowLayoutPanel1.HorizontalScroll.Value = scrollOffset;
                flowLayoutPanel1.PerformLayout();
            }
        }




        private void buttonLeft_Click3(object sender, EventArgs e)
        {
            int scrollAmount = -scrollStep;
            int newPosition = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;

            int minimumValue = flowLayoutPanel1.HorizontalScroll.Minimum; // Account for left padding

            if (newPosition < minimumValue)
                newPosition = minimumValue;

            flowLayoutPanel1.HorizontalScroll.Value = newPosition;
            flowLayoutPanel1.PerformLayout();
            //this.flowLayoutPanel1.AutoScroll = false;
        }

        private void buttonRight_Click3(object sender, EventArgs e)
        {
            
            int scrollAmount = scrollStep;
            int newPosition = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;

            int maximumValue = flowLayoutPanel1.HorizontalScroll.Maximum;

            if (newPosition > maximumValue)
                newPosition = maximumValue;

            flowLayoutPanel1.HorizontalScroll.Value = newPosition;
            flowLayoutPanel1.PerformLayout();
            //this.flowLayoutPanel1.AutoScroll = false;
        }

        private void __buttonLeft_Click(object sender, EventArgs e)
        {
            int scrollAmount = -scrollStep;
            int newPosition = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;

            if (newPosition < flowLayoutPanel1.HorizontalScroll.Minimum)
                newPosition = flowLayoutPanel1.HorizontalScroll.Minimum;

            flowLayoutPanel1.HorizontalScroll.Value = newPosition - 50;
            flowLayoutPanel1.PerformLayout();
        }

        private void __buttonRight_Click(object sender, EventArgs e)
        {
            int scrollAmount = scrollStep;
            int newPosition = flowLayoutPanel1.HorizontalScroll.Value + scrollAmount;

            if (newPosition > flowLayoutPanel1.HorizontalScroll.Maximum)
                newPosition = flowLayoutPanel1.HorizontalScroll.Maximum;

            flowLayoutPanel1.HorizontalScroll.Value = newPosition;
            flowLayoutPanel1.PerformLayout();
        }

        public void Story_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Focus();
        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BrightOnHover(object sender, EventArgs e)
        {
            //this.AddOrRemoveColorOverlay(Color.FromArgb(23, 32, 42), button1, true);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::media.Properties.Resources.p2;
        }
        private void AddOrRemoveColorOverlay(Color overlayColor, Button button, bool addOverlay)
        {
            // Get the button's background image
            Image backgroundImage = button.BackgroundImage;

            if (backgroundImage != null)
            {
                // Create a new bitmap that's the same size as the button's background image
                Bitmap bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);

                // Get the graphics object for the bitmap
                Graphics graphics = Graphics.FromImage(bitmap);

                // Draw the background image onto the bitmap
                graphics.DrawImage(backgroundImage, 0, 0);

                if (addOverlay)
                {
                    // Draw a rectangle with the overlay color onto the bitmap
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, overlayColor)), 0, 0, backgroundImage.Width, backgroundImage.Height);
                }

                // Set the button's background image to the new bitmap with or without the color overlay
                button.BackgroundImage = bitmap;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}