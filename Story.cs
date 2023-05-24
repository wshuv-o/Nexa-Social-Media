using Guna.UI2.WinForms;
using media.Classes;
using MySql.Data.MySqlClient;
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

        private Classes.User nativeUser;
        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }

        public Story(Classes.User nativeUser)
        {
            this.NativeUser=nativeUser;
            InitializeComponent();



            /*            AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button2);
                        AddOrRemoveColorOverlay(Color.FromArgb(23, 32, 42), button1, false);

                        AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button3);
                        AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button4);
                        AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button5);
                        AddColorOverlayToButton(170, Color.FromArgb(23, 32, 42), button6);

          
            try {         customPanel1.BackgroundImage= this.NativeUser.ProfilePhoto;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  */
            
            //guna2PictureBox1.BackColor = Methods.GetBackgroundAverageColor((Bitmap)guna2PictureBox1.BackgroundImage);
            if(nativeUser.ProfilePhoto != null ) { MessageBox.Show("not null"); guna2PictureBox1.BackgroundImage = this.nativeUser.ProfilePhoto; }
        }
        private void AddColorOverlayToButton(int Transparency, Color overlayColor, Button button)
        {
            Image backgroundImage = button.BackgroundImage;

            if (backgroundImage != null)
            {
                Bitmap bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);

                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.DrawImage(backgroundImage, 0, 0);

                graphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, overlayColor)), 0, 0, backgroundImage.Width, backgroundImage.Height);

                button.BackgroundImage = bitmap;
            }
        }
        private void RemoveColorOverlayOnHover(Button button)
        {
            Image originalImage = button.BackgroundImage;

            button.MouseEnter += (sender, args) =>
            {
                button.BackgroundImage = originalImage;
            };

            button.MouseLeave += (sender, args) =>
            {
                Image currentImage = button.BackgroundImage;

                if (currentImage != originalImage)
                {
                    AddColorOverlayToButton(130, Color.FromArgb(23, 32, 42), button);
                }
            };
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
/*            Guna.UI2.WinForms.Guna2Panel pane = new Guna.UI2.WinForms.Guna2Panel();

            pane.BackColor = Color.White;
            pane.BackColor = System.Drawing.Color.WhiteSmoke;
            pane.BorderRadius = 20;
            pane.FillColor = System.Drawing.Color.WhiteSmoke;
            pane.Location = new System.Drawing.Point(63, 3);
            pane.Size = new System.Drawing.Size(158, 263);
            FormStorySmall fs = new FormStorySmall(ClassNativeUser.NativeUser);
            Methods.OpenChildForm(fs, pane);
            this.flowLayoutPanel1.Controls.Add(pane);*/



            MessageBox.Show(ClassNativeUser.DistinctUserList.Count.ToString());
            List<Guna.UI2.WinForms.Guna2Panel> panel = new List<Guna.UI2.WinForms.Guna2Panel>();



            for (int i=0; i< ClassNativeUser.DistinctUserList.Count; i++)
            {
                panel.Add(new Guna.UI2.WinForms.Guna2Panel());
                panel[i].BackColor= Color.White;
                panel[i].BackColor = System.Drawing.Color.WhiteSmoke;
                panel[i].BorderRadius = 20;
                panel[i].FillColor = System.Drawing.Color.WhiteSmoke;
                panel[i].Location = new System.Drawing.Point(63, 3);
                panel[i].Size = new System.Drawing.Size(158, 263);

                FormStorySmall fss= new FormStorySmall(ClassNativeUser.DistinctUserList[i]);
                Methods.OpenChildForm2(fss, panel[i]);
                this.flowLayoutPanel1.Controls.Add(panel[i]);
            }
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
        }
        private void AddOrRemoveColorOverlay(Color overlayColor, Button button, bool addOverlay)
        {
            Image backgroundImage = button.BackgroundImage;

            if (backgroundImage != null)
            {
                Bitmap bitmap = new Bitmap(backgroundImage.Width, backgroundImage.Height);

                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.DrawImage(backgroundImage, 0, 0);

                if (addOverlay)
                {
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, overlayColor)), 0, 0, backgroundImage.Width, backgroundImage.Height);
                }

                button.BackgroundImage = bitmap;
            }
        }



        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.guna2GradientButton2.FillColor = Color.SlateBlue;
            this.guna2GradientButton2.FillColor2 = Color.SlateBlue;
            this.guna2GradientButton2.ForeColor = Color.White;

            this.guna2GradientButton1.FillColor = Color.White;
            this.guna2GradientButton1.FillColor2 = Color.White;
            this.guna2GradientButton1.ForeColor = Color.Black;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.guna2GradientButton2.FillColor = Color.White;
            this.guna2GradientButton2.FillColor2 = Color.White;
            this.guna2GradientButton2.ForeColor = Color.Black;


            this.guna2GradientButton1.FillColor = Color.SlateBlue;
            this.guna2GradientButton1.FillColor2 = Color.SlateBlue;
            this.guna2GradientButton1.ForeColor = Color.White;

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}