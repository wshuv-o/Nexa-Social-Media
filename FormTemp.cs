using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;


// ...
namespace media
{
    public partial class FormTemp : Form
    {
        public FormTemp()
        {
            InitializeComponent();
        }

        private void FormTemp_Load(object sender, EventArgs e)
        {

        }





// ...

private void button1_Click1(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                    try
                    {
                        using (Image originalImage = Image.FromFile(imagePath))
                        {
                            int maxWidth = 800;
                            int maxHeight = 600;
                            Size newSize = CalculateNewSize(originalImage.Size, maxWidth, maxHeight);
                            Image resizedImage = ResizeImage(originalImage, newSize);

                            using (MemoryStream compressedStream = new MemoryStream())
                            {
                                long compressionLevel = 50;

                                EncoderParameters encoderParams = new EncoderParameters(1);
                                encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, compressionLevel);

                                ImageFormat imageFormat = ImageFormat.Jpeg;
                                if (Path.GetExtension(imagePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                                    imageFormat = ImageFormat.Png;

                                resizedImage.Save(compressedStream, GetImageEncoder(imageFormat), encoderParams);

                                byte[] compressedImageData = compressedStream.ToArray();

                                long originalSize = new FileInfo(imagePath).Length;
                                long compressedSize = compressedImageData.Length;

                                string message = $"Original Size: {originalSize / 1024} KB\nCompressed Size: {compressedSize / 1024} KB";
                                MessageBox.Show(message);

                                using (MemoryStream compressedImageStream = new MemoryStream(compressedImageData))
                                {
                                    pictureBox1.Image = Image.FromStream(compressedImageStream);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
            }
        }
    }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = SelectAndCompressImage();
            
        }
        public Image SelectAndCompressImage()
        {
            Image compressedImage= null;
            string imagePath="";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                     imagePath = openFileDialog.FileName;

                    try
                    {
                        Image originalImage = Image.FromFile(imagePath);
                        compressedImage=CompressAndDisplayImage(originalImage, imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }

            return compressedImage;
        }

        private Image CompressAndDisplayImage(Image originalImage, string imagePath)
        {
            int maxWidth = 800;
            int maxHeight = 600;
            Size newSize = CalculateNewSize(originalImage.Size, maxWidth, maxHeight);
            Image resizedImage = ResizeImage(originalImage, newSize);

            using (MemoryStream compressedStream = new MemoryStream())
            {
                long compressionLevel = 50;

                EncoderParameters encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, compressionLevel);

                ImageFormat imageFormat = ImageFormat.Jpeg;
                if (Path.GetExtension(imagePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                    imageFormat = ImageFormat.Png;

                resizedImage.Save(compressedStream, GetImageEncoder(imageFormat), encoderParams);

                byte[] compressedImageData = compressedStream.ToArray();

                long originalSize = new FileInfo(imagePath).Length;
                long compressedSize = compressedImageData.Length;



                string message = $"Original Size: {originalSize / 1024} KB\nCompressed Size: {compressedSize / 1024} KB";
                MessageBox.Show(message);
                using (MemoryStream compressedImageStream = new MemoryStream(compressedImageData))
                {
                    return Image.FromStream(compressedImageStream);
                }
            }
        }


        private Size CalculateNewSize(Size originalSize, int maxWidth, int maxHeight)
    {
        double aspectRatio = Math.Min((double)maxWidth / originalSize.Width, (double)maxHeight / originalSize.Height);
        return new Size((int)(originalSize.Width * aspectRatio), (int)(originalSize.Height * aspectRatio));
    }

        private Image ResizeImage(Image image, Size newSize)
        {
            Image resizedImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return resizedImage;
        }

        private ImageCodecInfo GetImageEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


}
    }
