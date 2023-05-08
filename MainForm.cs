using Aspose.Imaging;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

namespace media
{
    public partial class MainForm : Form
    {
        private string imagePath;
        private System.Drawing.Image originalImage;
        private System.Drawing.Image compressedImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    originalImage = System.Drawing.Image.FromFile(imagePath);
                    pictureBox1.Image = originalImage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                    openFileDialog.Title = "Select Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (System.Drawing.Image image = System.Drawing.Image.FromFile(openFileDialog.FileName))
                        {
                            // Check if the stream is null
                            if (image == null)
                            {
                                MessageBox.Show("Invalid image file.");
                                return;
                            }

                            // Compress the image
                        }

                        // Update the picture box with the compressed image
                        pictureBox1.Image = compressedImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (compressedImage == null)
            {
                MessageBox.Show("Please compress an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Compressed Image";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(imagePath) + "_compressed";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                    ImageFormat format = ImageFormat.Jpeg;
                    if (extension == ".bmp")
                    {
                        format = ImageFormat.Bmp;
                    }
                    else if (extension == ".png")
                    {
                        format = ImageFormat.Png;
                    }

                    // Save the compressed image to disk
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        if (format.Equals(ImageFormat.Jpeg))
                        {
                            JpegOptions options = new JpegOptions();

                        }
                        else
                        {
                            compressedImage.Save(fs, format);
                        }
                    }

                    MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
