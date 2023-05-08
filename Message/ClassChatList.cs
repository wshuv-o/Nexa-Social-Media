using Aspose.Imaging;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace media.Message
{
    internal class ClassChatList
    {
        private CustomRoundPictureBox contactProfilePic = new CustomRoundPictureBox();
        private Guna2GradientPanel chatPanel = new Guna2GradientPanel();
        private System.Windows.Forms.Label lastMessage = new System.Windows.Forms.Label();
        private System.Windows.Forms.Label contactName = new System.Windows.Forms.Label();
        public Guna2GradientPanel ChatPanel
        {
            get { return chatPanel; }
            set { chatPanel = value; }
        }
        public Guna2GradientPanel previousPanel;
        public Guna2GradientPanel NewPanel;
        public static Guna2GradientPanel[] panelChats= new Guna2GradientPanel[20];
        private Classes.User user= new Classes.User();
        Classes.User User
        {
            get { return user; }
            set { user = value; }
        }
        public ClassChatList(Classes.User user) 
        {
            this.User= user;
            if (this.User.ProfilePhoto != null)
            {
                contactProfilePic.BackgroundImage = this.User.ProfilePhoto;
            }
            contactProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            contactProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            contactProfilePic.BorderColor = System.Drawing.Color.White;
            contactProfilePic.BorderColor2 = System.Drawing.Color.White;
            contactProfilePic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            contactProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            contactProfilePic.BorderSize = 2;
            contactProfilePic.Dock = System.Windows.Forms.DockStyle.Left;
            contactProfilePic.GradientAngle = 50F;
            contactProfilePic.Location = new System.Drawing.Point(0, 0);
            contactProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contactProfilePic.Name = "contactProfilePic";
            contactProfilePic.Size = new System.Drawing.Size(71, 74);
            contactProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            contactProfilePic.TabIndex = 3;
            contactProfilePic.TabStop = false;
            contactProfilePic.Click += new System.EventHandler(this.FocusOnChat);

            chatPanel.Controls.Add(contactProfilePic);
            chatPanel.Controls.Add(lastMessage);
            chatPanel.Controls.Add(contactName);
            chatPanel.FillColor = System.Drawing.Color.White;
            chatPanel.FillColor2 = System.Drawing.Color.White;
            chatPanel.Location = new System.Drawing.Point(3, 2);
            chatPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new System.Drawing.Size(409, 74);
            chatPanel.TabIndex = 0;
            chatPanel.Click += new System.EventHandler(this.FocusOnChat);

            lastMessage.AutoSize = true;
            lastMessage.BackColor = System.Drawing.Color.Transparent;
            lastMessage.Location = new System.Drawing.Point(77, 43);
            lastMessage.Name = "lastMessage";
            lastMessage.Size = new System.Drawing.Size(106, 16);
            lastMessage.TabIndex = 2;
            lastMessage.Text = ".....";
            lastMessage.Click += new System.EventHandler(this.FocusOnChat);

            contactName.AutoSize = true;
            contactName.BackColor = System.Drawing.Color.Transparent;
            contactName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactName.ForeColor = System.Drawing.Color.Black;
            contactName.Location = new System.Drawing.Point(77, 15);
            contactName.Name = "contactName";
            contactName.Size = new System.Drawing.Size(134, 25);
            contactName.Click += new System.EventHandler(this.FocusOnChat);
            contactName.TabIndex = 1;
            contactName.Text = user.UserFirstName+" "+ user.UserLastName;
        }
        private void FocusOnChat1(object sender, EventArgs e)
        {
            chatPanel.FillColor = System.Drawing.Color.Pink;
            chatPanel.FillColor2 = System.Drawing.Color.HotPink;
        }
        private void FocusOnChat(object sender, EventArgs e)
        {
            foreach (Guna2GradientPanel panel in panelChats)
            {
                panel.FillColor = System.Drawing.Color.White; // Set the desired background color
                panel.FillColor2 = System.Drawing.Color.White; // Set the desired background color
            }
            this.chatPanel.FillColor= System.Drawing.Color.Pink;
            this.chatPanel.FillColor2= System.Drawing.Color.HotPink;

        }
    }
}
