using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Form3 : Form
    {
        Classes.User nativeUser;
        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }
        public Form3(Classes.User nativeUserr)
        {
            InitializeComponent();
            this.NativeUser = nativeUser;
            this.customRoundPictureBox1.Image = ClassNativeUser.NativeUser.ProfilePhoto;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormTest f = new FormTest();
            f.FormBorderStyle = FormBorderStyle.None;
            Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            f.StartPosition = FormStartPosition.Manual;
            FormCreateStory fcs = new FormCreateStory(this.NativeUser, this.guna2TextBox1.Text);
            shadowPanel.Location = new Point(580, 100);
            shadowPanel.Size = fcs.Size;
            shadowPanel.ShadowDepth = 100;
            shadowPanel.ShadowShift = 10;
            shadowPanel.ShadowColor = Color.Black;
            shadowPanel.Radius = 20;
            Methods.OpenChildForm(fcs, shadowPanel);
            f.Controls.Add(shadowPanel);
            shadowPanel.BringToFront();
            f.Location = new Point(3, 32);
            f.ShowDialog(this);
            //Form3.cs:line 25

        }
    }
}
