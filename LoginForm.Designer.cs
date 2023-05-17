using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace media
{
    partial class Nexa
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
            this.panelBase = new System.Windows.Forms.Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new media.CustomFlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnForgotPassword = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new media.CustomPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPageSignUp = new System.Windows.Forms.Button();
            this.btnUserSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.panelBase.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBase.Controls.Add(this.panel1);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Margin = new System.Windows.Forms.Padding(4);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1429, 882);
            this.panelBase.TabIndex = 1;
            this.panelBase.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBase_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 20;
            this.panel1.BorderThickness = 4;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(142, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.panel1.Size = new System.Drawing.Size(1128, 682);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(303, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Community";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "and discover a world of new connections.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(175, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nexa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Join the ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.pictureBox2.BackgroundImage = global::media.Properties.Resources.microfunnel_flaticon_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(53, 107);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(676, 384);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.5F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(735, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.14534F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85466F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 633);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.flowLayoutPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.flowLayoutPanel1.BorderRadius = 20;
            this.flowLayoutPanel1.BorderSize = 5;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtbxEmail);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtbxPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnSignIn);
            this.flowLayoutPanel1.Controls.Add(this.btnForgotPassword);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 478);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.UnderlinedStyle = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::media.Properties.Resources._338458104_1527903524367608_1923566569049492375_n_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(100);
            this.pictureBox1.Size = new System.Drawing.Size(323, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 20, 15, 0);
            this.label1.Size = new System.Drawing.Size(99, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtbxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.txtbxEmail.BorderRadius = 10;
            this.txtbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxEmail.DefaultText = "";
            this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F);
            this.txtbxEmail.Location = new System.Drawing.Point(22, 177);
            this.txtbxEmail.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.PasswordChar = '\0';
            this.txtbxEmail.PlaceholderText = "";
            this.txtbxEmail.SelectedText = "";
            this.txtbxEmail.Size = new System.Drawing.Size(315, 45);
            this.txtbxEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 232);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(11, 15, 15, 0);
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtbxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.txtbxPassword.BorderRadius = 10;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F);
            this.txtbxPassword.Location = new System.Drawing.Point(22, 279);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(11, 10, 11, 30);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '●';
            this.txtbxPassword.PlaceholderText = "";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.Size = new System.Drawing.Size(315, 45);
            this.txtbxPassword.TabIndex = 4;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.btnSignIn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Location = new System.Drawing.Point(18, 356);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(319, 45);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnForgotPassword.BorderRadius = 10;
            this.btnForgotPassword.FillColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.btnForgotPassword.Location = new System.Drawing.Point(18, 413);
            this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(7, 10, 3, 0);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(317, 45);
            this.btnForgotPassword.TabIndex = 9;
            this.btnForgotPassword.Text = "Password Forgotten?";
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panel2.BorderRadius = 20;
            this.panel2.BorderSize = 1;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnPageSignUp);
            this.panel2.Controls.Add(this.btnUserSignUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 484);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 147);
            this.panel2.TabIndex = 3;
            this.panel2.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(127, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "for brand or bussines";
            // 
            // btnPageSignUp
            // 
            this.btnPageSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnPageSignUp.FlatAppearance.BorderSize = 0;
            this.btnPageSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageSignUp.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.btnPageSignUp.Location = new System.Drawing.Point(13, 80);
            this.btnPageSignUp.Margin = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.btnPageSignUp.Name = "btnPageSignUp";
            this.btnPageSignUp.Size = new System.Drawing.Size(123, 41);
            this.btnPageSignUp.TabIndex = 10;
            this.btnPageSignUp.Text = "Create a page";
            this.btnPageSignUp.UseVisualStyleBackColor = false;
            this.btnPageSignUp.Click += new System.EventHandler(this.btnPageSignUp_Click);
            // 
            // btnUserSignUp
            // 
            this.btnUserSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSignUp.BorderRadius = 10;
            this.btnUserSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(242)))));
            this.btnUserSignUp.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserSignUp.Location = new System.Drawing.Point(16, 16);
            this.btnUserSignUp.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.btnUserSignUp.Name = "btnUserSignUp";
            this.btnUserSignUp.Size = new System.Drawing.Size(319, 45);
            this.btnUserSignUp.TabIndex = 6;
            this.btnUserSignUp.Text = "Sign Up";
            this.btnUserSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // Nexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1429, 882);
            this.Controls.Add(this.panelBase);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nexa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twizzle";
            this.panelBase.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2GradientPanel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomFlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEmail;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private CustomPanel panel2;
        private Guna.UI2.WinForms.Guna2Button btnUserSignUp;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2Button btnForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPageSignUp;
        private Panel panelBase;
    }
}