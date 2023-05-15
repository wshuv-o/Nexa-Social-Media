using System;
using System.Windows.Forms;

namespace media
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBaseHome = new System.Windows.Forms.TableLayoutPanel();
            this.panelFC = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.contactPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.friendRequestPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecline = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.frProfileName = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.frProfileImage = new media.CustomRoundPictureBox();
            this.panelBaseHome.SuspendLayout();
            this.panelFC.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBaseHome
            // 
            this.panelBaseHome.ColumnCount = 3;
            this.panelBaseHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43478F));
            this.panelBaseHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56522F));
            this.panelBaseHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.panelBaseHome.Controls.Add(this.panelFC, 2, 0);
            this.panelBaseHome.Controls.Add(this.panelFeed, 1, 0);
            this.panelBaseHome.Controls.Add(this.panelNavBar, 0, 0);
            this.panelBaseHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseHome.Location = new System.Drawing.Point(0, 0);
            this.panelBaseHome.Margin = new System.Windows.Forms.Padding(4);
            this.panelBaseHome.Name = "panelBaseHome";
            this.panelBaseHome.RowCount = 1;
            this.panelBaseHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBaseHome.Size = new System.Drawing.Size(1924, 1006);
            this.panelBaseHome.TabIndex = 0;
            this.panelBaseHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBaseHome_Paint);
            // 
            // panelFC
            // 
            this.panelFC.BackColor = System.Drawing.Color.White;
            this.panelFC.ColumnCount = 1;
            this.panelFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFC.Controls.Add(this.panel3, 0, 1);
            this.panelFC.Controls.Add(this.guna2Panel1, 0, 0);
            this.panelFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFC.Location = new System.Drawing.Point(1217, 4);
            this.panelFC.Margin = new System.Windows.Forms.Padding(4);
            this.panelFC.Name = "panelFC";
            this.panelFC.RowCount = 2;
            this.panelFC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.56951F));
            this.panelFC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.43049F));
            this.panelFC.Size = new System.Drawing.Size(703, 998);
            this.panelFC.TabIndex = 1;
            this.panelFC.Resize += new System.EventHandler(this.panelNavBar_Resize);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.guna2Button12);
            this.panel3.Controls.Add(this.contactPanel);
            this.panel3.Controls.Add(this.guna2HtmlLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 518);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(695, 476);
            this.panel3.TabIndex = 3;
            // 
            // guna2Button12
            // 
            this.guna2Button12.BorderRadius = 15;
            this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button12.FillColor = System.Drawing.Color.White;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button12.ForeColor = System.Drawing.Color.Black;
            this.guna2Button12.Location = new System.Drawing.Point(10, 427);
            this.guna2Button12.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(675, 39);
            this.guna2Button12.TabIndex = 3;
            this.guna2Button12.Text = "See All";
            // 
            // contactPanel
            // 
            this.contactPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPanel.BackColor = System.Drawing.Color.White;
            this.contactPanel.Location = new System.Drawing.Point(9, 74);
            this.contactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(661, 444);
            this.contactPanel.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 33);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Contacts";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.guna2Button9);
            this.guna2Panel1.Controls.Add(this.friendRequestPanel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(697, 508);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderRadius = 15;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button9.FillColor = System.Drawing.Color.White;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button9.ForeColor = System.Drawing.Color.Black;
            this.guna2Button9.Location = new System.Drawing.Point(10, 469);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(677, 39);
            this.guna2Button9.TabIndex = 2;
            this.guna2Button9.Text = "See All";
            // 
            // friendRequestPanel
            // 
            this.friendRequestPanel.Location = new System.Drawing.Point(14, 44);
            this.friendRequestPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.friendRequestPanel.Name = "friendRequestPanel";
            this.friendRequestPanel.Size = new System.Drawing.Size(662, 419);
            this.friendRequestPanel.TabIndex = 3;
            this.friendRequestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.friendRequestPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friend Requests";
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.BackColor = System.Drawing.Color.White;
            this.panelFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeed.Location = new System.Drawing.Point(154, 4);
            this.panelFeed.Margin = new System.Windows.Forms.Padding(4);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Padding = new System.Windows.Forms.Padding(53, 25, 27, 25);
            this.panelFeed.Size = new System.Drawing.Size(1055, 998);
            this.panelFeed.TabIndex = 2;
            this.panelFeed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFeed_Paint);
            this.panelFeed.Resize += new System.EventHandler(this.panelNavBar_Resize);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.White;
            this.panelNavBar.Controls.Add(this.panel1);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavBar.Location = new System.Drawing.Point(4, 4);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(142, 998);
            this.panelNavBar.TabIndex = 0;
            this.panelNavBar.Resize += new System.EventHandler(this.panelNavBar_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.ShadowColor = System.Drawing.Color.Black;
            this.panel1.ShadowDepth = 40;
            this.panel1.Size = new System.Drawing.Size(142, 998);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2DataGridView1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23447F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.76553F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(142, 998);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.guna2TextBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 166);
            this.panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnPage);
            this.flowLayoutPanel1.Controls.Add(this.btnPeople);
            this.flowLayoutPanel1.Controls.Add(this.btnPost);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(136, 34);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnPage
            // 
            this.btnPage.BorderRadius = 15;
            this.btnPage.BorderThickness = 1;
            this.btnPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPage.FillColor = System.Drawing.Color.Transparent;
            this.btnPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPage.ForeColor = System.Drawing.Color.Black;
            this.btnPage.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnPage.Location = new System.Drawing.Point(4, 4);
            this.btnPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(100, 0);
            this.btnPage.TabIndex = 1;
            this.btnPage.Text = "Page";
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BorderRadius = 15;
            this.btnPeople.BorderThickness = 1;
            this.btnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeople.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPeople.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnPeople.Location = new System.Drawing.Point(4, 12);
            this.btnPeople.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(100, 30);
            this.btnPeople.TabIndex = 0;
            this.btnPeople.Text = "People";
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnPost
            // 
            this.btnPost.BorderRadius = 15;
            this.btnPost.BorderThickness = 1;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.Transparent;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPost.ForeColor = System.Drawing.Color.Black;
            this.btnPost.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnPost.Location = new System.Drawing.Point(4, 50);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(100, 30);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = global::media.Properties.Resources.icons8_search_32__1_;
            this.guna2TextBox1.Location = new System.Drawing.Point(0, 84);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search here!";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(133, 36);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 37);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 175);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(136, 820);
            this.guna2DataGridView1.TabIndex = 5;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Yellow;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Location = new System.Drawing.Point(4, 4);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(349, 85);
            this.guna2Panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.frProfileName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(85, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnDecline, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 43);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDecline
            // 
            this.btnDecline.BorderColor = System.Drawing.Color.Blue;
            this.btnDecline.BorderRadius = 10;
            this.btnDecline.BorderThickness = 1;
            this.btnDecline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecline.FillColor = System.Drawing.Color.White;
            this.btnDecline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecline.ForeColor = System.Drawing.Color.Black;
            this.btnDecline.Location = new System.Drawing.Point(135, 3);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(126, 37);
            this.btnDecline.TabIndex = 1;
            this.btnDecline.Text = "Decline";
            // 
            // btnAccept
            // 
            this.btnAccept.BorderRadius = 10;
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(126, 37);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            // 
            // frProfileName
            // 
            this.frProfileName.AutoSize = true;
            this.frProfileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frProfileName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frProfileName.ForeColor = System.Drawing.Color.Black;
            this.frProfileName.Location = new System.Drawing.Point(3, 0);
            this.frProfileName.Name = "frProfileName";
            this.frProfileName.Size = new System.Drawing.Size(132, 28);
            this.frProfileName.TabIndex = 1;
            this.frProfileName.Text = "Wahid Shuvo";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.Controls.Add(this.frProfileImage);
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.guna2Panel3.CustomizableEdges.BottomRight = false;
            this.guna2Panel3.CustomizableEdges.TopRight = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(85, 85);
            this.guna2Panel3.TabIndex = 1;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // frProfileImage
            // 
            this.frProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frProfileImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.frProfileImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.frProfileImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.frProfileImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.frProfileImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.frProfileImage.BorderSize = 2;
            this.frProfileImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frProfileImage.GradientAngle = 50F;
            this.frProfileImage.Image = global::media.Properties.Resources.PicsArt_09_0m7_09_40_49;
            this.frProfileImage.Location = new System.Drawing.Point(0, 0);
            this.frProfileImage.Name = "frProfileImage";
            this.frProfileImage.Size = new System.Drawing.Size(85, 85);
            this.frProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frProfileImage.TabIndex = 1;
            this.frProfileImage.TabStop = false;
            this.frProfileImage.Click += new System.EventHandler(this.customRoundPictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1006);
            this.Controls.Add(this.panelBaseHome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelBaseHome.ResumeLayout(false);
            this.panelFC.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelNavBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelBaseHome;
        private System.Windows.Forms.Panel panelNavBar;
        private Panel panel3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private Guna.UI2.WinForms.Guna2Button btnDecline;
        private Label frProfileName;
        private CustomRoundPictureBox frProfileImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private FlowLayoutPanel contactPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public FlowLayoutPanel panelFeed;
        private TableLayoutPanel panelFC;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel1;
        public FlowLayoutPanel friendRequestPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnPage;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnPost;

    }
}