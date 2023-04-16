namespace media
{
    partial class FormTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.testControl1 = new media.TestControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.guna2WinProgressIndicator1);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.testControl1);
            this.panel1.Location = new System.Drawing.Point(201, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 458);
            this.panel1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(199, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(536, 549);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://m.facebook.com", System.UriKind.Absolute);
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(372, 179);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2WinProgressIndicator1.TabIndex = 2;
            // 
            // testControl1
            // 
            this.testControl1.BackgroundImage = global::media.Properties.Resources._335671610_1374871103291531_4501878706397560800_n_modified;
            this.testControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testControl1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.testControl1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.testControl1.BorderColor2 = System.Drawing.Color.HotPink;
            this.testControl1.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.testControl1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.testControl1.BorderSize = 5;
            this.testControl1.GradientAngle = 50F;
            this.testControl1.Location = new System.Drawing.Point(0, 0);
            this.testControl1.Name = "testControl1";
            this.testControl1.Size = new System.Drawing.Size(99, 102);
            this.testControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testControl1.TabIndex = 0;
            this.testControl1.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1047, 692);
            this.Controls.Add(this.panel1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TestControl testControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
    }
}