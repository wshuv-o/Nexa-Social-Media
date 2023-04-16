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
            this.customPanel1 = new media.CustomPanel();
            this.customPanel2 = new media.CustomPanel();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 28;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Location = new System.Drawing.Point(554, 64);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(190, 139);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.customPanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.BorderSize = 2;
            this.customPanel2.Location = new System.Drawing.Point(399, 404);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(267, 123);
            this.customPanel2.TabIndex = 1;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // FormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTemp";
            this.Text = "FormTemp";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private CustomPanel customPanel2;
    }
}