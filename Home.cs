using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace media
{
    public partial class Home : Form
    {
        Story s= new Story();
        public Home()
        {
            InitializeComponent();
            panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 40F);
            panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent,40F);
            panelBaseHome.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
            panelFeed.Resize += new System.EventHandler(this.panelNavBar_Resize);
            Methods.RoundPanelCorners(ref panelNavBar, 20);
            Methods.RoundPanelCorners(ref flowLayoutPanel2, 20);
            //Methods.RoundPanelCorners(ref panel3, 20);
           // Methods.RoundPanelCorners(ref panelSavior, 20);


            this.panelNavBar.Resize += (sender, e) =>
            {
                int availableWidth =this.panel1.Width;
                this.panelNavBar.Width = availableWidth;
                Methods.RoundPanelCorners1(ref this.panelNavBar, 30);
            };

            
            this.flowLayoutPanel2.Resize += (sender, e) =>
            {
                flowLayoutPanel2.Height = this.panel3.Height;
                flowLayoutPanel2.Width=this.panel3.Width;
                Methods.RoundPanelCorners(ref this.flowLayoutPanel2, 20);

            };

            this.guna2Panel2.Resize += (sender, e) =>
            {
                guna2Panel2.Width = flowLayoutPanel1.Width;
                // Methods.RoundPanelCorners(ref panel4, 20);

            };
            //this.Visible = true;

            /*this.panelSavior.Resize += (sender, e) =>
             {
                 this.panel3.Height += this.panel1.Height;
                 this.panel3.Width += this.panel3.Width;
                 Methods.RoundPanelCorners(ref this.panelSavior, 20);
             };*/




        }



        private void panelFeed_Paint(object sender, PaintEventArgs e)
        {
            // Check if the panel has vertical scrollbar
            if (panelFeed.VerticalScroll.Visible)
            {
                // Draw the vertical scrollbar using a custom color
                int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
                int scrollbarX = panelFeed.Width - scrollbarWidth;
                int scrollbarY = panelFeed.VerticalScroll.Value * (panelFeed.Height - scrollbarWidth) /
                    (panelFeed.VerticalScroll.Maximum - panelFeed.VerticalScroll.Minimum);
                int scrollbarHeight = panelFeed.Height * scrollbarWidth / (panelFeed.Height - scrollbarWidth);
                Rectangle scrollbarRect = new Rectangle(scrollbarX, scrollbarY, scrollbarWidth, scrollbarHeight);
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(brush, scrollbarRect);
                }
            }

            // Check if the panel has horizontal scrollbar
            if (panelFeed.HorizontalScroll.Visible)
            {
                // Draw the horizontal scrollbar using a custom color
                int scrollbarHeight = SystemInformation.HorizontalScrollBarHeight;
                int scrollbarX = panelFeed.HorizontalScroll.Value * (panelFeed.Width - scrollbarHeight) /
                    (panelFeed.HorizontalScroll.Maximum - panelFeed.HorizontalScroll.Minimum);
                int scrollbarY = panelFeed.Height - scrollbarHeight;
                int scrollbarWidth = panelFeed.Width * scrollbarHeight / (panelFeed.Width - scrollbarHeight);
                Rectangle scrollbarRect = new Rectangle(scrollbarX, scrollbarY, scrollbarWidth, scrollbarHeight);
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(brush, scrollbarRect);
                }
            }
        }

        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            Point currentAutoScrollPosition = panelFeed.AutoScrollPosition;
            currentAutoScrollPosition.Offset(0, -numberOfTextLinesToMove);
            panelFeed.AutoScrollPosition = currentAutoScrollPosition;
        }
        private void panelNavBar_Resize(object sender, EventArgs e)
        {
            if (panelFeed.Width <= 600)
            {
                panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 0F);
                panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 0F);
            }
            if (panelFeed.Width > 600)
            {
                panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 40F);
                panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 40F);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    
        }

        private void panelBaseStory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBaseHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guna2Panel panelBase =new Guna2Panel();    
            Guna2Panel panelChild=new Guna2Panel();
            panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            panelBase.BackColor = System.Drawing.Color.WhiteSmoke;
            panelBase.Controls.Add(panelChild);
            panelBase.Location = new System.Drawing.Point(43, 347);
            panelBase.Name = "panel1";
            panelBase.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            panelBase.Size = new System.Drawing.Size(866, 850);
            panelBase.TabIndex = 1;
            panelBase.Paint += new System.Windows.Forms.PaintEventHandler(panelBase_Paint);
            // 
            // panel2
            // 
            panelChild.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            panelChild.Location = new System.Drawing.Point(50, 0);
            panelChild.Name = "panel2";
            panelChild.Size = new System.Drawing.Size(766, 600);
            panelChild.TabIndex = 0;
            panelChild.BorderColor = Color.Red;
            panelChild.BorderThickness = 1;
            panelChild.BorderRadius = 20;
            panelChild.BackColor = Color.White;
            panelChild.Paint += new System.Windows.Forms.PaintEventHandler(panelChild_Paint_1);
            panelChild.MouseEnter += new System.EventHandler(panelChild_MouseEnter);
            panelChild.MouseLeave += new System.EventHandler(panelChild_MouseLeave);

            Post a = new Post();
            Methods.OpenChildForm(a, panelChild);

           // panelBase.Height = a.basePanel.Height;
           // panelBase.Width = 866;
            //panelChild.Height = a.basePanel.Height;
            //panelChild.Width = 766;
            //panelChild.Height = a.Height;
            panelFeed.Controls.Add(panelBase);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }        
        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = false;
        }        
        private void panelChild_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panelChild_MouseEnter(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = true;
        }

        private void panelChild_MouseLeave(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void AddNewFriendRequest()
        {
            TableLayoutPanel BaseEachRequest= new TableLayoutPanel();
            TableLayoutPanel panelsAcceptDecline= new TableLayoutPanel();
            Guna2Panel panelUser = new Guna2Panel();
            Guna2Button accept =new Guna2Button();
            Guna2Button decline =new Guna2Button();
            Guna2Button toUserProfile =new Guna2Button();
            Guna2PictureBox pictureBox1 =new Guna2PictureBox();
            Guna2HtmlLabel friendName = new Guna2HtmlLabel();
            Guna2HtmlLabel noOfMutual=new Guna2HtmlLabel();



            BaseEachRequest.BackColor = System.Drawing.Color.White;
            BaseEachRequest.ColumnCount = 1;
            BaseEachRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            BaseEachRequest.Controls.Add(panelsAcceptDecline, 0, 1);
            BaseEachRequest.Controls.Add(panelUser, 0, 0);
            BaseEachRequest.Location = new System.Drawing.Point(3, 3);
            BaseEachRequest.Name = "BaseEachRequest";
            BaseEachRequest.RowCount = 2;
            BaseEachRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923F));
            BaseEachRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077F));
            BaseEachRequest.Size = new System.Drawing.Size(380, 130);
            BaseEachRequest.TabIndex = 0;

            /*this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            */ 
            // panelsAcceptDecline
            // 
            panelsAcceptDecline.ColumnCount = 2;
            panelsAcceptDecline.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelsAcceptDecline.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelsAcceptDecline.Controls.Add(accept, 0, 0);
            panelsAcceptDecline.Controls.Add(decline, 1, 0);
            panelsAcceptDecline.Dock = System.Windows.Forms.DockStyle.Fill;
            panelsAcceptDecline.Location = new System.Drawing.Point(3, 89);
            panelsAcceptDecline.Name = "panelsAcceptDecline";
            panelsAcceptDecline.RowCount = 1;
            panelsAcceptDecline.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelsAcceptDecline.Size = new System.Drawing.Size(378, 63);
            panelsAcceptDecline.TabIndex = 0;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(noOfMutual);
            panelUser.Controls.Add(friendName);
            panelUser.Controls.Add(pictureBox1);
            panelUser.Controls.Add(toUserProfile);
            panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUser.Location = new System.Drawing.Point(3, 3);
            panelUser.Name = "panelUser";
            panelUser.Size = new System.Drawing.Size(378, 80);
            panelUser.TabIndex = 1;
            // 
            // accept
            // 
            accept.BackColor = Color.FromArgb(134,27,242);
            accept.Dock = System.Windows.Forms.DockStyle.Fill;
            accept.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accept.ForeColor = System.Drawing.Color.White;
            accept.Location = new System.Drawing.Point(3, 3);
            accept.Name = "accept";
            accept.Size = new System.Drawing.Size(183, 57);
            accept.TabIndex = 0;
            accept.Text = "Accept";
            // 
            // decline
            // 
            decline.BackColor = Color.FromArgb(134, 27, 242);
            decline.Dock = System.Windows.Forms.DockStyle.Fill;
            decline.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            decline.ForeColor = System.Drawing.Color.White;
            decline.Location = new System.Drawing.Point(192, 3);
            decline.Name = "decline";
            decline.Size = new System.Drawing.Size(183, 57);
            decline.TabIndex = 1;
            decline.Text = "Decline";
            // 
            // toUserProfile
            // 
            toUserProfile.BackColor = System.Drawing.SystemColors.HighlightText;
            toUserProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            toUserProfile.Location = new System.Drawing.Point(0, 0);
            toUserProfile.Name = "toUserProfile";
            toUserProfile.Padding = new System.Windows.Forms.Padding(15);
            toUserProfile.Size = new System.Drawing.Size(378, 80);
            toUserProfile.TabIndex = 0;
            //toUserProfile.Click += new System.EventHandler(this.toUserProfile_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::media.Properties.Resources.rsz_160721257_848984555463636_5606238717187457024_n;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(71, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click_1);
            // 
            // friendName
            // 
            friendName.AutoSize = true;
            friendName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            friendName.Location = new System.Drawing.Point(85, 15);
            friendName.Name = "friendName";
            friendName.Size = new System.Drawing.Size(101, 22);
            friendName.TabIndex = 2;
            friendName.Text = "Imtiaj Sajin";
            friendName.ForeColor = System.Drawing.Color.Black;

            // 
            // noOfMutual
            // panelEachContact
            noOfMutual.AutoSize = true;
            noOfMutual.Location = new System.Drawing.Point(86, 53);
            noOfMutual.Name = "noOfMutual";
            noOfMutual.Size = new System.Drawing.Size(92, 13);
            noOfMutual.TabIndex = 3;
            noOfMutual.Text = "20 mutual contact";
            noOfMutual.ForeColor= System.Drawing.Color.Black;



        }
        public void ContactList()
        {
            Panel panelEachContact;
            Label active;
            Label contactName;
            PictureBox contactPicture;
            Button contactButton;
            panelEachContact = new System.Windows.Forms.Panel();
            active = new System.Windows.Forms.Label();
            contactName = new System.Windows.Forms.Label();
            contactPicture = new System.Windows.Forms.PictureBox();
            contactButton = new System.Windows.Forms.Button();
            panelEachContact.BackColor = System.Drawing.Color.White;
            panelEachContact.Controls.Add(active);
            panelEachContact.Controls.Add(contactName);
            panelEachContact.Controls.Add(contactPicture);
            panelEachContact.Controls.Add(contactButton);
            panelEachContact.Location = new System.Drawing.Point(3, 87);
            panelEachContact.Name = "panelEachContact";
            panelEachContact.Padding = new System.Windows.Forms.Padding(10);
            panelEachContact.Size = new System.Drawing.Size(378, 75);
            panelEachContact.TabIndex = 6;
            // 
            // active
            // 
            active.AutoSize = true;
            active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            active.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            active.Location = new System.Drawing.Point(343, 25);
            active.Name = "active";
            active.Size = new System.Drawing.Size(31, 24);
            active.TabIndex = 2;
            active.Text = "🔴";
            // 
            // contactName
            // 
            contactName.AutoSize = true;
            contactName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactName.ForeColor = System.Drawing.Color.Black;
            contactName.Location = new System.Drawing.Point(84, 23);
            contactName.Name = "contactName";
            contactName.Size = new System.Drawing.Size(113, 26);
            contactName.TabIndex = 1;
            contactName.Text = "Saif Hasan";
            contactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactPicture
            // 
            contactPicture.BackColor = System.Drawing.Color.Goldenrod;
            contactPicture.Dock = System.Windows.Forms.DockStyle.Left;
            contactPicture.Image = global::media.Properties.Resources.p2;
            contactPicture.Location = new System.Drawing.Point(10, 10);
            contactPicture.Name = "contactPicture";
            contactPicture.Size = new System.Drawing.Size(55, 55);
            contactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            contactPicture.TabIndex = 0;
            contactPicture.TabStop = false;
            // 
            // contactButton
            // 
            contactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            contactButton.FlatAppearance.BorderSize = 0;
            contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            contactButton.ForeColor = System.Drawing.Color.Black;
            contactButton.Location = new System.Drawing.Point(10, 10);
            contactButton.Name = "contactButton";
            contactButton.Size = new System.Drawing.Size(358, 55);
            contactButton.TabIndex = 3;
            contactButton.UseVisualStyleBackColor = true;
            Methods.RoundPanelCorners(ref panelEachContact, 20);
            Methods.RoundImageBoxCorners(contactPicture, 25);

            flowLayoutPanel2.Controls.Add(panelEachContact);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.AddNewFriendRequest();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }        
        private void labelContact_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            new Form();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ContactList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
                Panel panelBase = new Panel();
                Panel panelChild = new Panel();
                panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                panelBase.BackColor = System.Drawing.Color.Blue;
                panelBase.Controls.Add(panelChild);
                panelBase.Location = new System.Drawing.Point(43, 347);
                panelBase.Name = "panel1";
                panelBase.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
                panelBase.Size = new System.Drawing.Size(866, 750);
                panelBase.TabIndex = 1;
                panelBase.Paint += new System.Windows.Forms.PaintEventHandler(panelBase_Paint);
                // 
                // panel2
                // 
                panelChild.BackColor = System.Drawing.SystemColors.ControlLightLight;
                panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
                panelChild.Location = new System.Drawing.Point(50, 0);
                panelChild.Name = "panel2";
                panelChild.Size = new System.Drawing.Size(766, 500);
                panelChild.TabIndex = 0;
                panelChild.BackColor = Color.White;
                panelChild.Paint += new System.Windows.Forms.PaintEventHandler(panelChild_Paint_1);
                panelChild.MouseEnter += new System.EventHandler(panelChild_MouseEnter);
                panelChild.MouseLeave += new System.EventHandler(panelChild_MouseLeave);
                Methods.RoundPanelCorners(ref panelChild, 30);

                Story a = new Story();
                Methods.OpenChildForm(a, panelChild);

                // panelBase.Height = a.basePanel.Height;
                // panelBase.Width = 866;
                //panelChild.Height = a.basePanel.Height;
                //panelChild.Width = 766;
                //panelChild.Height = a.Height;
                panelFeed.Controls.Add(panelBase);

            

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customRoundPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customRoundPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
