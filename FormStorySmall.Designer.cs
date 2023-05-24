namespace media
{
    partial class FormStorySmall
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
            this.customPanel1 = new media.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customRoundPictureBox1 = new media.CustomRoundPictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customRoundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.customRoundPictureBox1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(173, 267);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            this.customPanel1.Click += new System.EventHandler(this.ToStory);
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.ToStory);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.ToStory);
            // 
            // customRoundPictureBox1
            // 
            this.customRoundPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customRoundPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customRoundPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.customRoundPictureBox1.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.customRoundPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.customRoundPictureBox1.BorderSize = 2;
            this.customRoundPictureBox1.GradientAngle = 50F;
            this.customRoundPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.customRoundPictureBox1.Name = "customRoundPictureBox1";
            this.customRoundPictureBox1.Size = new System.Drawing.Size(46, 46);
            this.customRoundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customRoundPictureBox1.TabIndex = 1;
            this.customRoundPictureBox1.TabStop = false;
            this.customRoundPictureBox1.Click += new System.EventHandler(this.ToStory);
            // 
            // FormStorySmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 267);
            this.Controls.Add(this.customPanel1);
            this.Name = "FormStorySmall";
            this.Text = "FormStorySmall";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customRoundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomRoundPictureBox customRoundPictureBox1;
    }
}