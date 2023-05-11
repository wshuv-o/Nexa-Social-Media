using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace media
{
    partial class FormTemp
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
            this.panelSendContent = new System.Windows.Forms.Panel();
            this.userProfilePic = new media.CustomRoundPictureBox();
            this.panelText = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.customPanel1 = new media.CustomPanel();
            this.panelSendContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSendContent
            // 
            this.panelSendContent.BackColor = System.Drawing.Color.White;
            this.panelSendContent.Controls.Add(this.userProfilePic);
            this.panelSendContent.Controls.Add(this.panelText);
            this.panelSendContent.Location = new System.Drawing.Point(30, 157);
            this.panelSendContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.panelSendContent.Name = "panelSendContent";
            this.panelSendContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelSendContent.Size = new System.Drawing.Size(853, 160);
            this.panelSendContent.TabIndex = 5;
            // 
            // userProfilePic
            // 
            this.userProfilePic.BackgroundImage = global::media.Properties.Resources.PicsArt_09_0m7_09_40_49;
            this.userProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userProfilePic.BorderColor = System.Drawing.Color.White;
            this.userProfilePic.BorderColor2 = System.Drawing.Color.White;
            this.userProfilePic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userProfilePic.BorderSize = 2;
            this.userProfilePic.Dock = System.Windows.Forms.DockStyle.Right;
            this.userProfilePic.GradientAngle = 50F;
            this.userProfilePic.Location = new System.Drawing.Point(773, 20);
            this.userProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProfilePic.Name = "userProfilePic";
            this.userProfilePic.Size = new System.Drawing.Size(60, 120);
            this.userProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfilePic.TabIndex = 2;
            this.userProfilePic.TabStop = false;
            // 
            // panelText
            // 
            this.panelText.BorderColor = System.Drawing.Color.Purple;
            this.panelText.BorderRadius = 10;
            this.panelText.BorderThickness = 1;
            this.panelText.CustomizableEdges.BottomRight = false;
            this.panelText.Location = new System.Drawing.Point(500, 11);
            this.panelText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(250, 46);
            this.panelText.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(13, 11);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(61, 27);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "sdfksdj";
            this.lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Location = new System.Drawing.Point(253, 125);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(301, 257);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 635);
            this.Controls.Add(this.customPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.Load += new System.EventHandler(this.FormTemp_Load);
            this.panelSendContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSendContent;
        private CustomRoundPictureBox userProfilePic;
        private Guna2Panel panelText;
        private Guna2HtmlLabel lblMessage;
        private ColorDialog colorDialog1;
        private CustomPanel customPanel1;
    }
}