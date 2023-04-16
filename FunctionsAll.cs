using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    internal static class FunctionsAll
    {
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

        public static Color GetMostCommonClothColor(Bitmap image)
        {
            Dictionary<Color, int> colorCounts = new Dictionary<Color, int>();
            int maxCount = 0;
            Color mostCommonColor = Color.Black;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    if (pixelColor.A == 0) // skip transparent pixels
                    {
                        continue;
                    }

                    if (!colorCounts.ContainsKey(pixelColor))
                    {
                        colorCounts[pixelColor] = 0;
                    }

                    colorCounts[pixelColor]++;

                    if (colorCounts[pixelColor] > maxCount)
                    {
                        maxCount = colorCounts[pixelColor];
                        mostCommonColor = pixelColor;
                    }
                }
            }

            return mostCommonColor;
        }

        public static Color GetMostCommonClothColor(Image image)
        {
            // Set the target area of the cloth in the lower-middle part of the image
            int targetWidth = image.Width / 2;
            int targetHeight = (int)(image.Height * 0.75);
            int targetArea = targetWidth * targetHeight;

            // Create a dictionary to store color frequencies
            Dictionary<Color, int> colorFrequency = new Dictionary<Color, int>();

            // Loop through each pixel in the target area and count color frequencies
            Bitmap bitmap = new Bitmap(image);
            for (int x = (image.Width - targetWidth) / 2; x < (image.Width + targetWidth) / 2; x++)
            {
                for (int y = targetHeight - 1; y >= 0; y--)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (!colorFrequency.ContainsKey(pixelColor))
                    {
                        colorFrequency.Add(pixelColor, 1);
                    }
                    else
                    {
                        colorFrequency[pixelColor]++;
                    }
                }
            }

            // Find the color with the highest frequency
            Color mostCommonColor = Color.Black;
            int highestFrequency = 0;
            foreach (KeyValuePair<Color, int> kvp in colorFrequency)
            {
                if (kvp.Value > highestFrequency)
                {
                    highestFrequency = kvp.Value;
                    mostCommonColor = kvp.Key;
                }
            }

            return mostCommonColor;
        }
        public static Color GetClothColor(Bitmap image)
        {
            int clothHeight = (int)(image.Height * 0.82); // get the height of the lower 4/5th area
            int clothWidthStart = (int)(image.Width * 0.25); // get the starting width position of the middle area
            int clothWidthEnd = (int)(image.Width * 0.75); // get the ending width position of the middle area

            List<Color> clothColors = new List<Color>(); // list to store all the colors in the cloth area

            for (int x = clothWidthStart; x < clothWidthEnd; x++)
            {
                for (int y = clothHeight; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    clothColors.Add(pixelColor); // add the color of the current pixel to the list
                }
            }

            // get the most common color from the list of cloth colors
            Color mostCommonColor = clothColors.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

            return mostCommonColor;
        }



        public static Color GetBackgroundColor(Image photo)
        {
            Bitmap bitmap = new Bitmap(photo);

            int width = bitmap.Width;
            int height = bitmap.Height;

            int xStart = width / 5; // left limit
            int yStart = height / 5; // top limit
            int xEnd = width - xStart; // right limit
            int yEnd = height - height / 5; // bottom limit

            // create a dictionary to store the count of each color
            Dictionary<Color, int> colorCounts = new Dictionary<Color, int>();

            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    Color color = bitmap.GetPixel(x, y);

                    if (!colorCounts.ContainsKey(color))
                    {
                        colorCounts[color] = 0;
                    }

                    colorCounts[color]++;
                }
            }

            // get the color with the highest count
            Color mostCommonColor = Color.Black;
            int highestCount = 0;

            foreach (KeyValuePair<Color, int> kvp in colorCounts)
            {
                if (kvp.Value > highestCount)
                {
                    mostCommonColor = kvp.Key;
                    highestCount = kvp.Value;
                }
            }

            return mostCommonColor;
        }

        public static Bitmap CropToCircle(Image image, Size size)
        {
            Bitmap output = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(output);
            g.Clear(Color.Transparent);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size.Width, size.Height);
            g.SetClip(path);
            g.DrawImage(image, new Rectangle(0, 0, size.Width, size.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            return output;
        }

        public static Image GetCircularImage(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, img.Width, img.Height);
            g.SetClip(path);
            g.DrawImage(img, 0, 0);
            return bmp;
        }

        public static void RoundPanel(Panel panel5, int radius)
        {
            int radius2 = radius;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(panel5.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel5.ClientRectangle.Width - radius, panel5.ClientRectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel5.ClientRectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            panel5.Region = new System.Drawing.Region(path);
            panel5.Paint += (s, e) => { e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; };
        }
        public static void RoundButton(Button button, int radius)
        {
            int radius2 = radius;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(button.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.ClientRectangle.Width - radius, button.ClientRectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.ClientRectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            button.Region = new System.Drawing.Region(path);
            button.Paint += (s, e) => { e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; };
        }

        public static void RoundButtonParams(int radius, params Button[] buttons)
        {
            int radius2 = radius;
            foreach (Button button in buttons)
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(button.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(button.ClientRectangle.Width - radius, button.ClientRectangle.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, button.ClientRectangle.Height - radius, radius, radius, 90, 90);
                path.AddArc(0, 0, radius, radius, 180, 90);
                button.Region = new System.Drawing.Region(path);
                button.Paint += (s, e) => { e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; };
            }
        }
        public static void RoundPictureBox(PictureBox panel5, int radius)
        {
            int radius2 = radius;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(panel5.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel5.ClientRectangle.Width - radius, panel5.ClientRectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel5.ClientRectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            panel5.Region = new System.Drawing.Region(path);
            panel5.Paint += (s, e) => { e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; };
        }
        public static Image MakeRoundPicture(Image image, int cornerRadius)
        {
            Bitmap roundedImage = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(roundedImage))
            {
                graphics.Clear(Color.Transparent);

                using (Brush brush = new TextureBrush(image))
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                        path.AddArc(roundedImage.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                        path.AddArc(roundedImage.Width - cornerRadius, roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                        path.AddArc(0, roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                        path.CloseFigure();

                        graphics.FillPath(brush, path);
                    }
                }
            }

            return roundedImage;
        }

        public static Bitmap ReduceOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = opacity;

                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return bmp;
        }
        public static Image MakeImageBrighter(Image inputImage, float brightness)
        {
            // Create a new bitmap with the same dimensions as the input image
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Loop through each pixel in the input image
            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    // Get the color of the current pixel
                    Color pixelColor = ((Bitmap)inputImage).GetPixel(x, y);

                    // Increase the brightness of the pixel color by the specified amount
                    int r = (int)(pixelColor.R * brightness);
                    int g = (int)(pixelColor.G * brightness);
                    int b = (int)(pixelColor.B * brightness);

                    // Make sure the color values are within the valid range (0-255)
                    r = Math.Min(r, 255);
                    g = Math.Min(g, 255);
                    b = Math.Min(b, 255);

                    // Set the color of the corresponding pixel in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, r, g, b));
                }
            }

            // Return the new, brighter image
            return outputImage;
        }




    }
}