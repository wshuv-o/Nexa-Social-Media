﻿namespace media
{
    partial class FormPost
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
            this.basePanel = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.postTime = new System.Windows.Forms.Label();
            this.UserProfileImage = new media.CustomRoundPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPostText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lblPostReact = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            this.basePanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.guna2ShadowPanel1);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Margin = new System.Windows.Forms.Padding(4);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(20);
            this.basePanel.Size = new System.Drawing.Size(933, 579);
            this.basePanel.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(20, 20);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(893, 539);
            this.guna2ShadowPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPostReact, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(853, 499);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.postTime);
            this.panel1.Controls.Add(this.UserProfileImage);
            this.panel1.Controls.Add(lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(845, 93);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.White;
            this.guna2CircleButton1.BackgroundImage = global::media.Properties.Resources.dots;
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(761, 10);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(73, 73);
            this.guna2CircleButton1.TabIndex = 3;
            // 
            // postTime
            // 
            this.postTime.AutoSize = true;
            this.postTime.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTime.ForeColor = System.Drawing.Color.Black;
            this.postTime.Location = new System.Drawing.Point(105, 59);
            this.postTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postTime.Name = "postTime";
            this.postTime.Size = new System.Drawing.Size(114, 20);
            this.postTime.TabIndex = 2;
            this.postTime.Text = "08:10 12-July-2022";
            // 
            // UserProfileImage
            // 
            this.UserProfileImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UserProfileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserProfileImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.UserProfileImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.UserProfileImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.UserProfileImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.UserProfileImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.UserProfileImage.BorderSize = 0;
            this.UserProfileImage.GradientAngle = 50F;
            this.UserProfileImage.Location = new System.Drawing.Point(4, 9);
            this.UserProfileImage.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfileImage.Name = "UserProfileImage";
            this.UserProfileImage.Size = new System.Drawing.Size(80, 81);
            this.UserProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserProfileImage.TabIndex = 0;
            this.UserProfileImage.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserName.ForeColor = System.Drawing.Color.Black;
            lblUserName.Location = new System.Drawing.Point(101, 28);
            lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(168, 31);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Sakib Sarwar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblPostText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 285);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblPostText
            // 
            this.lblPostText.AutoSize = true;
            this.lblPostText.BackColor = System.Drawing.Color.White;
            this.lblPostText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPostText.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lblPostText.ForeColor = System.Drawing.Color.Black;
            this.lblPostText.Location = new System.Drawing.Point(12, 0);
            this.lblPostText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostText.Name = "lblPostText";
            this.lblPostText.Size = new System.Drawing.Size(72, 25);
            this.lblPostText.TabIndex = 0;
            this.lblPostText.Text = "          ";
            this.lblPostText.Click += new System.EventHandler(this.postText_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 317F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 435);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 60);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.White;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button2.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::media.Properties.Resources.icons8_share_96;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(560, 4);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(281, 52);
            this.guna2Button2.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::media.Properties.Resources.icons8_speech_bubble_96;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(282, 4);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(270, 52);
            this.guna2Button1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.BorderRadius = 10;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FillColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::media.Properties.Resources.icons8_heart_96;
            this.button2.ImageSize = new System.Drawing.Size(40, 40);
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 52);
            this.button2.TabIndex = 0;
            // 
            // lblPostReact
            // 
            this.lblPostReact.AutoSize = true;
            this.lblPostReact.Location = new System.Drawing.Point(3, 394);
            this.lblPostReact.Name = "lblPostReact";
            this.lblPostReact.Size = new System.Drawing.Size(44, 16);
            this.lblPostReact.TabIndex = 11;
            this.lblPostReact.Text = "label1";
            // 
            // FormPostr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 579);
            this.Controls.Add(this.basePanel);
            this.Name = "FormPostr";
            this.Text = "FormPost";
            this.Load += new System.EventHandler(this.FormPost_Load);
            this.basePanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel basePanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label postTime;
        private CustomRoundPictureBox UserProfileImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPostText;
        private System.Windows.Forms.Label lblPostReact;
        System.Windows.Forms.Label lblUserName;

    }
}