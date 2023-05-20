namespace media.Friends
{
    partial class FormContactList
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
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.contactProfileImage = new media.CustomRoundPictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.contactButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackColor = System.Drawing.Color.White;
            this.guna2Button14.BorderRadius = 20;
            this.guna2Button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button14.FillColor = System.Drawing.Color.White;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button14.ForeColor = System.Drawing.Color.Black;
            this.guna2Button14.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.guna2Button14.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button14.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button14.Location = new System.Drawing.Point(0, 0);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button14.Size = new System.Drawing.Size(335, 55);
            this.guna2Button14.TabIndex = 4;
            // 
            // contactProfileImage
            // 
            this.contactProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactProfileImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.contactProfileImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.contactProfileImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.contactProfileImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.contactProfileImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.contactProfileImage.BorderSize = 0;
            this.contactProfileImage.GradientAngle = 50F;
            this.contactProfileImage.Image = global::media.Properties.Resources.PicsArt_09_0m7_09_40_49;
            this.contactProfileImage.Location = new System.Drawing.Point(9, 2);
            this.contactProfileImage.Name = "contactProfileImage";
            this.contactProfileImage.Size = new System.Drawing.Size(51, 51);
            this.contactProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactProfileImage.TabIndex = 8;
            this.contactProfileImage.TabStop = false;
            this.contactProfileImage.Click += new System.EventHandler(this.OpenContact);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(293, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "🔴";
            this.label17.Click += new System.EventHandler(this.OpenContact);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.BackColor = System.Drawing.Color.White;
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 11.2F);
            this.lblContactName.ForeColor = System.Drawing.Color.Black;
            this.lblContactName.Location = new System.Drawing.Point(69, 13);
            this.lblContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(59, 25);
            this.lblContactName.TabIndex = 5;
            this.lblContactName.Text = "name";
            this.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactName.Click += new System.EventHandler(this.OpenContact);
            // 
            // contactButton
            // 
            this.contactButton.BackColor = System.Drawing.Color.White;
            this.contactButton.BorderRadius = 20;
            this.contactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactButton.FillColor = System.Drawing.Color.White;
            this.contactButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactButton.ForeColor = System.Drawing.Color.Black;
            this.contactButton.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.contactButton.HoverState.FillColor = System.Drawing.Color.White;
            this.contactButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.contactButton.Location = new System.Drawing.Point(0, 0);
            this.contactButton.Margin = new System.Windows.Forms.Padding(0);
            this.contactButton.Name = "contactButton";
            this.contactButton.PressedColor = System.Drawing.Color.Transparent;
            this.contactButton.Size = new System.Drawing.Size(335, 55);
            this.contactButton.TabIndex = 7;
            this.contactButton.Click += new System.EventHandler(this.OpenContact);
            // 
            // FormContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 55);
            this.Controls.Add(this.contactProfileImage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.guna2Button14);
            this.Name = "FormContactList";
            this.Text = "FormContactList";
            this.Load += new System.EventHandler(this.FormContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private CustomRoundPictureBox contactProfileImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblContactName;
        private Guna.UI2.WinForms.Guna2Button contactButton;
    }
}