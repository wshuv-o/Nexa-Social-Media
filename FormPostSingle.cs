using media.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormPostSingle : Form
    {
        public Size formPostSingleSize;
        private Classes.User nativeUser;
        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }
        private Classes.ClassPost post;
        public Classes.ClassPost Post
        {
            get { return post; }
            set { post = value; }
        }
        private int commentId = 6;

        public FormPostSingle(Classes.ClassPost post)
        {
            formPostSingleSize = this.Size;
            InitializeComponent();
            this.NativeUser = post.PostCreator;
            this.Post = post;
            this.userProfileImage.Image = this.NativeUser.ProfilePhoto;
            this.lblUserName.Text = this.NativeUser.UserFirstName + " " + this.NativeUser.UserLastName;
            this.lblPostTime.Text = this.Post.PostTime.ToString();
            this.lblPostText.Text = this.Post.PostText;
            this.panelPostImage.BackgroundImage = this.Post.PostImage;


            this.userProfileImageComment.Image= ClassNativeUser.NativeUser.ProfilePhoto;
            this.lblUsernameComment.Text= ClassNativeUser.NativeUser.UserFirstName+" "+ ClassNativeUser.NativeUser.UserLastName;


            LoadComments(this.Post.PostId);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPostSingle_Load(object sender, EventArgs e)
        {

        }

        private void userProfileImage_Click(object sender, EventArgs e)
        {

        }

        private void _commentSend_Click(object sender, EventArgs e)
        {
            string commentText = this.commentBox.Text;

            if (!String.IsNullOrEmpty(commentText))
            {
                string query = "INSERT INTO `comment` (`commenttext`, `commenttime`, `commentLike`, `postid`, `userid`) VALUES (@commentText, @commentTime, @commentLike, @postId, @userid);";
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@commentText", commentText);
                        cmd.Parameters.AddWithValue("@commentTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@commentLike", 0);
                        cmd.Parameters.AddWithValue("@postId", this.Post.PostId);
                        cmd.Parameters.AddWithValue("@userid", ClassNativeUser.NativeUser.Key);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Comment Added!");
                            this.commentBox.Text = "";

                            // Get the last inserted comment ID
                            int commentId;
                            query = "SELECT LAST_INSERT_ID();";
                            using (MySqlCommand selectCmd = new MySqlCommand(query, conn))
                            {
                                commentId = Convert.ToInt32(selectCmd.ExecuteScalar());
                            }

                            // Create the comment controls
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commentPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commenterPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commenterDetailsPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            CustomRoundPictureBox commenterImage = new CustomRoundPictureBox();
                            Label commenterNameLabel = new Label();
                            Label commentTextLabel = new Label();

                            // Set properties for comment controls
                            commentPanel.BackColor = System.Drawing.Color.White;
                            commenterPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterDetailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterImage.Image = ClassNativeUser.NativeUser.ProfilePhoto;
                            commenterNameLabel.Text = ClassNativeUser.NativeUser.UserFirstName + " " + ClassNativeUser.NativeUser.UserLastName;
                            commentTextLabel.Text = commentText;

                            // Set unique names for comment controls
                            commentPanel.Name = "commentPanel_" + commentId;
                            commenterPanel.Name = "commenterPanel_" + commentId;
                            commenterDetailsPanel.Name = "commenterDetailsPanel_" + commentId;
                            commenterImage.Name = "commenterImage_" + commentId;
                            commenterNameLabel.Name = "commenterNameLabel_" + commentId;
                            commentTextLabel.Name = "commentTextLabel_" + commentId;

                            // Add comment controls to the flow layout panel
                            commentPanel.Controls.Add(commenterPanel);
                            commenterPanel.Controls.Add(commenterDetailsPanel);
                            commenterPanel.Controls.Add(commenterImage);
                            commenterDetailsPanel.Controls.Add(commenterNameLabel);
                            commenterDetailsPanel.Controls.Add(commentTextLabel);

                            flowLayoutPanel1.Controls.Add(commentPanel);

                            // Increment the comment ID
                            commentId++;
                        }
                        else
                        {
                            Console.WriteLine("Error. Please retry!");
                        }
                    }
                }
            }
        }

        private void commentSend_Click(object sender, EventArgs e)
        {
            string commentText = this.commentBox.Text;

            if (!String.IsNullOrEmpty(this.commentBox.Text))
            {
                string query = "INSERT INTO `comment` (`commenttext`, `commenttime`, `commentLike`, `postid`, `userid`) VALUES (@commentText, @commentTime, @commentLike, @postId, @userid);";
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@commentText", commentBox.Text);
                        cmd.Parameters.AddWithValue("@commentTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@commentLike", 0);
                        cmd.Parameters.AddWithValue("@postId", this.Post.PostId);
                        cmd.Parameters.AddWithValue("@userid", ClassNativeUser.NativeUser.Key);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Comment Added!");
                            this.commentBox.Text = "";

                            Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            CustomRoundPictureBox commenterImage = new CustomRoundPictureBox();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CircleButton reactComment = new Guna.UI2.WinForms.Guna2CircleButton();
                            Guna.UI2.WinForms.Guna2Panel guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
                            Label commenterText = new Label();
                            CustomRoundPictureBox userProfileImageComment = new CustomRoundPictureBox();
                            Guna.UI2.WinForms.Guna2TextBox commentBox = new Guna.UI2.WinForms.Guna2TextBox();
                            Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
                            Label lblNumberOfLike = new Label();

                            guna2CustomGradientPanel4.BackColor = System.Drawing.Color.White;
                            guna2CustomGradientPanel4.Controls.Add(guna2CircleButton2);
                            guna2CustomGradientPanel4.Controls.Add(reactComment);
                            guna2CustomGradientPanel4.Controls.Add(guna2Panel2);
                            guna2CustomGradientPanel4.Controls.Add(commenterImage);
                            guna2CustomGradientPanel4.Location = new System.Drawing.Point(14, 957);
                            guna2CustomGradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                            guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4_" + commentId;
                            guna2CustomGradientPanel4.Size = new System.Drawing.Size(787, 111);
                            guna2CustomGradientPanel4.TabIndex = 11;

                            reactComment.BorderColor = System.Drawing.Color.LightGray;
                            reactComment.BorderThickness = 1;
                            reactComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                            reactComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                            reactComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                            reactComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                            reactComment.FillColor = System.Drawing.Color.WhiteSmoke;
                            reactComment.Font = new System.Drawing.Font("Segoe UI", 14F);
                            reactComment.ForeColor = System.Drawing.Color.Red;
                            reactComment.Image = global::media.Properties.Resources.icons8_heart_96;
                            reactComment.ImageSize = new System.Drawing.Size(25, 25);
                            reactComment.Location = new System.Drawing.Point(573, 30);
                            reactComment.Name = "reactComment_" + commentId;
                            reactComment.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                            reactComment.Size = new System.Drawing.Size(48, 49);
                            reactComment.TabIndex = 5;

                            guna2Panel2.BorderColor = System.Drawing.Color.LightGray;
                            guna2Panel2.BorderRadius = 20;
                            guna2Panel2.BorderThickness = 1;
                            guna2Panel2.Controls.Add(lblNumberOfLike);
                            guna2Panel2.Controls.Add(commenterText);
                            guna2Panel2.Controls.Add(commenterName);
                            guna2Panel2.CustomizableEdges.TopLeft = false;
                            guna2Panel2.FillColor = System.Drawing.Color.White;
                            guna2Panel2.Location = new System.Drawing.Point(71, 9);
                            guna2Panel2.Name = "guna2Panel2_" + commentId;
                            guna2Panel2.Size = new System.Drawing.Size(472, 86);
                            guna2Panel2.TabIndex = 4;

                            commenterText.AutoSize = true;
                            commenterText.BackColor = System.Drawing.Color.White;
                            commenterText.Location = new System.Drawing.Point(14, 31);
                            commenterText.Name = "commenterText_" + commentId;
                            commenterText.Size = new System.Drawing.Size(44, 16);
                            commenterText.TabIndex = 6;
                            commenterText.Text = commentText;

                            commenterImage.BackColor = System.Drawing.Color.DeepSkyBlue;
                            commenterImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
                            commenterImage.BorderColor = System.Drawing.Color.RoyalBlue;
                            commenterImage.BorderColor2 = System.Drawing.Color.HotPink;
                            commenterImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderSize = 0;
                            commenterImage.GradientAngle = 50F;
                            commenterImage.Location = new System.Drawing.Point(7, 5);
                            commenterImage.Margin = new System.Windows.Forms.Padding(4);
                            commenterImage.Name = "commenterImage_" + commentId;
                            commenterImage.Image = ClassNativeUser.NativeUser.ProfilePhoto;
                            commenterImage.Size = new System.Drawing.Size(55, 57);
                            commenterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                            commenterImage.TabIndex = 3;
                            commenterImage.TabStop = false;

                            guna2CircleButton2.BorderColor = System.Drawing.Color.LightGray;
                            guna2CircleButton2.BorderThickness = 1;
                            guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                            guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                            guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                            guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                            guna2CircleButton2.FillColor = System.Drawing.Color.WhiteSmoke;
                            guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 14F);
                            guna2CircleButton2.ForeColor = System.Drawing.Color.Red;
                            guna2CircleButton2.Image = global::media.Properties.Resources.dots;
                            guna2CircleButton2.ImageSize = new System.Drawing.Size(25, 25);
                            guna2CircleButton2.Location = new System.Drawing.Point(631, 30);
                            guna2CircleButton2.Name = "guna2CircleButton2_" + commentId;
                            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                            guna2CircleButton2.Size = new System.Drawing.Size(48, 49);
                            guna2CircleButton2.TabIndex = 6;

                            commenterName.AutoSize = true;
                            commenterName.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            commenterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F, System.Drawing.FontStyle.Bold);
                            commenterName.ForeColor = System.Drawing.Color.Black;
                            commenterName.Location = new System.Drawing.Point(5, 2);
                            commenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                            commenterName.Name = "commenterName_" + commentId;
                            commenterName.Size = new System.Drawing.Size(128, 25);
                            commenterName.TabIndex = 5;
                            commenterName.Text = ClassNativeUser.NativeUser.UserFirstName + " " + ClassNativeUser.NativeUser.UserLastName;

                            lblNumberOfLike.AutoEllipsis = true;
                            lblNumberOfLike.AutoSize = true;
                            lblNumberOfLike.BackColor = System.Drawing.Color.WhiteSmoke;
                            lblNumberOfLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            lblNumberOfLike.Location = new System.Drawing.Point(414, 7);
                            lblNumberOfLike.Name = "lblNumberOfLike_" + commentId;
                            lblNumberOfLike.Size = new System.Drawing.Size(44, 16);
                            lblNumberOfLike.TabIndex = 7;
                            lblNumberOfLike.Text = "0";

                            this.flowLayoutPanel1.Controls.Add(guna2CustomGradientPanel4);
                            commentId++;
                        }
                        else
                        {
                            Console.WriteLine("Error. Please retry!");
                        }
                    }
                }
            }
        }

        private void __commentSend_Click(object sender, EventArgs e)
        {
            string commentText = this.commentBox.Text;

            if (!String.IsNullOrEmpty(commentText))
            {
                string query = "INSERT INTO `comment` (`commenttext`, `commenttime`, `commentLike`, `postid`, `userid`) VALUES (@commentText, @commentTime, @commentLike, @postId, @userid);";
                using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@commentText", commentText);
                        cmd.Parameters.AddWithValue("@commentTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@commentLike", 0);
                        cmd.Parameters.AddWithValue("@postId", this.Post.PostId);
                        cmd.Parameters.AddWithValue("@userid", ClassNativeUser.NativeUser.Key);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Comment Added!");
                            this.commentBox.Text = "";

                            // Create new instances of comment controls
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commentPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commenterPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel commenterDetailsPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            CustomRoundPictureBox commenterImage = new CustomRoundPictureBox();
                            Label commenterNameLabel = new Label();
                            Label commentTextLabel = new Label();

                            // Set properties for comment controls
                            commentPanel.BackColor = System.Drawing.Color.White;
                            commentPanel.Controls.Add(commenterPanel);
                            //commentPanel.Controls.Add(commentBox);
                            commentPanel.Location = new System.Drawing.Point(14, 957);
                            commentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                            commentPanel.Name = "commentPanel_" + commentId;
                            commentPanel.Size = new System.Drawing.Size(787, 111);
                            commentPanel.TabIndex = 11;

                            commenterPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterPanel.Controls.Add(commenterDetailsPanel);
                            commenterPanel.Location = new System.Drawing.Point(71, 9);
                            commenterPanel.Margin = new System.Windows.Forms.Padding(4);
                            commenterPanel.Name = "commenterPanel_" + commentId;
                            commenterPanel.Size = new System.Drawing.Size(472, 86);
                            commenterPanel.TabIndex = 4;

                            commenterDetailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterDetailsPanel.Controls.Add(commentTextLabel);
                            commenterDetailsPanel.Controls.Add(commenterNameLabel);
                            commenterDetailsPanel.Location = new System.Drawing.Point(7, 5);
                            commenterDetailsPanel.Margin = new System.Windows.Forms.Padding(4);
                            commenterDetailsPanel.Name = "commenterDetailsPanel_" + commentId;
                            commenterDetailsPanel.Size = new System.Drawing.Size(472, 86);
                            commenterDetailsPanel.TabIndex = 4;

                            commenterImage.BackColor = System.Drawing.Color.DeepSkyBlue;
                            commenterImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
                            commenterImage.BorderColor = System.Drawing.Color.RoyalBlue;
                            commenterImage.BorderColor2 = System.Drawing.Color.HotPink;
                            commenterImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderSize = 0;
                            commenterImage.GradientAngle = 50F;
                            commenterImage.Location = new System.Drawing.Point(7, 5);
                            commenterImage.Margin = new System.Windows.Forms.Padding(4);
                            commenterImage.Name = "commenterImage_" + commentId;
                            commenterImage.Image = ClassNativeUser.NativeUser.ProfilePhoto;
                            commenterImage.Size = new System.Drawing.Size(55, 57);
                            commenterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                            commenterImage.TabIndex = 3;
                            commenterImage.TabStop = false;

                            commenterNameLabel.AutoSize = true;
                            commenterNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            commenterNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F, System.Drawing.FontStyle.Bold);
                            commenterNameLabel.ForeColor = System.Drawing.Color.Black;
                            commenterNameLabel.Location = new System.Drawing.Point(5, 2);
                            commenterNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                            commenterNameLabel.Name = "commenterNameLabel_" + commentId;
                            commenterNameLabel.Size = new System.Drawing.Size(128, 25);
                            commenterNameLabel.TabIndex = 5;
                            commenterNameLabel.Text = ClassNativeUser.NativeUser.UserFirstName + " " + ClassNativeUser.NativeUser.UserLastName;

                            commentTextLabel.AutoSize = true;
                            commentTextLabel.BackColor = System.Drawing.Color.WhiteSmoke;
                            commentTextLabel.Location = new System.Drawing.Point(14, 31);
                            commentTextLabel.Name = "commentTextLabel_" + commentId;
                            commentTextLabel.Size = new System.Drawing.Size(44, 16);
                            commentTextLabel.TabIndex = 6;
                            commentTextLabel.Text = commentText;

                            // Add comment controls to the flow layout panel
                            flowLayoutPanel1.Controls.Add(commentPanel);

                            // Increment the comment ID
                            commentId++;
                        }
                        else
                        {
                            Console.WriteLine("Error. Please retry!");
                        }
                    }
                }
            }
        }

        private void LoadComments(int postId)
        {

            string query = "SELECT * FROM `comment` WHERE `postid` = @postId;";
            using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@postId", postId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve comment details from the reader
                            int commentId = Convert.ToInt32(reader["commentid"]);
                            string commentText = reader["commenttext"].ToString();
                            DateTime commentTime = Convert.ToDateTime(reader["commenttime"]);
                            int commentLike = Convert.ToInt32(reader["commentLike"]);
                            int userId = Convert.ToInt32(reader["userid"]);

                            DBImageOperation dbio = new DBImageOperation();
                            Classes.User postUser = dbio.GetUserByUserId(userId);

                            Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            CustomRoundPictureBox commenterImage = new CustomRoundPictureBox();
                            Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
                            Guna.UI2.WinForms.Guna2CircleButton reactComment = new Guna.UI2.WinForms.Guna2CircleButton();
                            Guna.UI2.WinForms.Guna2Panel guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
                            System.Windows.Forms.Label commenterText = new Label();
                            CustomRoundPictureBox userProfileImageComment = new CustomRoundPictureBox();
                            Guna.UI2.WinForms.Guna2TextBox commentBox = new Guna.UI2.WinForms.Guna2TextBox();
                            Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
                            System.Windows.Forms.Label lblNumberOfLike = new Label();

                            guna2CustomGradientPanel4.BackColor = System.Drawing.Color.White;
                            guna2CustomGradientPanel4.Controls.Add(guna2CircleButton2);
                            guna2CustomGradientPanel4.Controls.Add(reactComment);
                            guna2CustomGradientPanel4.Controls.Add(guna2Panel2);
                            guna2CustomGradientPanel4.Controls.Add(commenterImage);
                            guna2CustomGradientPanel4.Location = new System.Drawing.Point(14, 957);
                            guna2CustomGradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                            guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
                            guna2CustomGradientPanel4.Size = new System.Drawing.Size(787, 111);
                            guna2CustomGradientPanel4.TabIndex = 11;
                            // 
                            // reactComment
                            // 
                            reactComment.BorderColor = System.Drawing.Color.LightGray;
                            reactComment.BorderThickness = 1;
                            reactComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                            reactComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                            reactComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                            reactComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                            reactComment.FillColor = System.Drawing.Color.WhiteSmoke;
                            reactComment.Font = new System.Drawing.Font("Segoe UI", 14F);
                            reactComment.ForeColor = System.Drawing.Color.Red;
                            reactComment.Image = global::media.Properties.Resources.icons8_heart_96;
                            reactComment.ImageSize = new System.Drawing.Size(25, 25);
                            reactComment.Location = new System.Drawing.Point(573, 30);
                            reactComment.Name = "reactComment";
                            reactComment.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                            reactComment.Size = new System.Drawing.Size(48, 49);
                            reactComment.TabIndex = 5;
                            // 
                            // guna2Panel2
                            // 
                            guna2Panel2.BorderColor = System.Drawing.Color.LightGray;
                            guna2Panel2.BorderRadius = 20;
                            guna2Panel2.BorderThickness = 1;
                            guna2Panel2.Controls.Add(lblNumberOfLike);
                            guna2Panel2.Controls.Add(commenterText);
                            guna2Panel2.Controls.Add(commenterName);
                            guna2Panel2.CustomizableEdges.TopLeft = false;
                            guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
                            guna2Panel2.Location = new System.Drawing.Point(71, 9);
                            guna2Panel2.Name = "guna2Panel2";
                            guna2Panel2.Size = new System.Drawing.Size(472, 86);
                            guna2Panel2.TabIndex = 4;
                            // 
                            // commenterText
                            // 
                            commenterText.AutoSize = true;
                            commenterText.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterText.Location = new System.Drawing.Point(14, 31);
                            commenterText.Name = "commenterText";
                            commenterText.Size = new System.Drawing.Size(44, 16);
                            commenterText.TabIndex = 6;
                            commenterText.Text = commentText;

                            commenterImage.BackColor = System.Drawing.Color.DeepSkyBlue;
                            commenterImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
                            commenterImage.BorderColor = System.Drawing.Color.RoyalBlue;
                            commenterImage.BorderColor2 = System.Drawing.Color.HotPink;
                            commenterImage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            commenterImage.BorderSize = 0;
                            commenterImage.GradientAngle = 50F;
                            commenterImage.Location = new System.Drawing.Point(7, 5);
                            commenterImage.Margin = new System.Windows.Forms.Padding(4);
                            commenterImage.Name = "commenterImage";
                            commenterImage.Image = (postUser).ProfilePhoto;
                            commenterImage.Size = new System.Drawing.Size(55, 57);
                            commenterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                            commenterImage.TabIndex = 3;
                            commenterImage.TabStop = false;

                            guna2CircleButton2.BorderColor = System.Drawing.Color.LightGray;
                            guna2CircleButton2.BorderThickness = 1;
                            guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                            guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                            guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                            guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                            guna2CircleButton2.FillColor = System.Drawing.Color.WhiteSmoke;
                            guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 14F);
                            guna2CircleButton2.ForeColor = System.Drawing.Color.Red;
                            guna2CircleButton2.Image = global::media.Properties.Resources.dots;
                            guna2CircleButton2.ImageSize = new System.Drawing.Size(25, 25);
                            guna2CircleButton2.Location = new System.Drawing.Point(631, 30);
                            guna2CircleButton2.Name = "guna2CircleButton2";
                            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                            guna2CircleButton2.Size = new System.Drawing.Size(48, 49);
                            guna2CircleButton2.TabIndex = 6;

                            commenterName.AutoSize = true;
                            commenterName.BackColor = System.Drawing.Color.WhiteSmoke;
                            commenterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            commenterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.25F, System.Drawing.FontStyle.Bold);
                            commenterName.ForeColor = System.Drawing.Color.Black;
                            commenterName.Location = new System.Drawing.Point(5, 2);
                            commenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                            commenterName.Name = "commenterName"+ commentText;
                            commenterName.Size = new System.Drawing.Size(128, 25);
                            commenterName.TabIndex = 5;
                            commenterName.Text = postUser.UserFirstName + " " + postUser.UserLastName;

                            lblNumberOfLike.AutoEllipsis = true;
                            lblNumberOfLike.AutoSize = true;
                            lblNumberOfLike.BackColor = System.Drawing.Color.WhiteSmoke;
                            lblNumberOfLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            lblNumberOfLike.Location = new System.Drawing.Point(414, 7);
                            lblNumberOfLike.Name = "lblNumberOfLike";
                            lblNumberOfLike.Size = new System.Drawing.Size(44, 16);
                            lblNumberOfLike.TabIndex = 7;
                            lblNumberOfLike.Text = commentLike.ToString();

                            this.flowLayoutPanel1.Controls.Add(guna2CustomGradientPanel4);
                        }
                    }
                }
            }
        }

    }
}
