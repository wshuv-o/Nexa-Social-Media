namespace media
{
    partial class FormPostPanelForProfile
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
            this.panelFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.BackColor = System.Drawing.Color.White;
            this.panelFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeed.Location = new System.Drawing.Point(0, 0);
            this.panelFeed.Margin = new System.Windows.Forms.Padding(4);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Padding = new System.Windows.Forms.Padding(53, 25, 27, 25);
            this.panelFeed.Size = new System.Drawing.Size(840, 777);
            this.panelFeed.TabIndex = 3;
            // 
            // FormPostPanelForProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 777);
            this.Controls.Add(this.panelFeed);
            this.Name = "FormPostPanelForProfile";
            this.Text = "FormPostPanelForProfile";
            this.Load += new System.EventHandler(this.FormPostPanelForProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel panelFeed;
    }
}