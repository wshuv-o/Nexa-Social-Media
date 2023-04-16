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
            this.testControl1 = new media.TestControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.testControl1);
            this.panel1.Location = new System.Drawing.Point(421, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 313);
            this.panel1.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}