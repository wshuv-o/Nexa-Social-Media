using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Post : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        private media.Classes.ClassPost classPosts;
        private Panel panelMain;
        private FlowLayoutPanel panelSecondary;
        public media.Classes.ClassPost ClassPosts
        {
            get { return classPosts; }
            set { classPosts = value; }
        }
        public Post(media.Classes.ClassPost classPost)
        {
            // Create and configure the flow layout panel
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Visible = false;



            this.classPosts = new Classes.ClassPost();
            this.classPosts = classPost;
            InitializeComponent();
            Methods.RoundImageBoxCorners(UserProfileImage, 20);
            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel4, true);
            Methods.SetDoubleBuffer(guna2ShadowPanel1, true);
            Methods.SetDoubleBuffer(basePanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(tableLayoutPanel2, true);

            if (classPost != null)
            {

                this.postTime.Text = classPost.PostTime.ToString();
                this.postText.Text = classPost.PostText;


                this.reactCount.Text = classPost.NoOfReacts.ToString();
                this.UserProfileImage.BackgroundImage = classPost.PostCreator.ProfilePhoto;
                this.lblUserName.Text = classPost.PostCreator.UserFirstName + " " + classPost.PostCreator.UserLastName;

            }
            else
            {
                this.postTime.Text = "N/A";
            }
            postText.MaximumSize = new Size(700, 100);

            bool alreadyLiked = CheckIfAlreadyLiked(this.ClassPosts.PostId, ClassNativeUser.NativeUser.Key);
            if (alreadyLiked)
            {
                button2.Image = global::media.Properties.Resources.icons8_favorite_96;
            }
            this.Refresh();


        }
        private bool IsLabelVisibleOnScreen(System.Windows.Forms.Label label)
        {
            Rectangle labelRect = label.RectangleToScreen(label.ClientRectangle);
            Rectangle screenRect = Screen.FromControl(label).WorkingArea;  // Use WorkingArea to exclude taskbars and other screen elements

            return screenRect.IntersectsWith(labelRect);
        }
        public Post()
        {

        }







        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm2(new FormProfile(this.ClassPosts.PostCreator), FormBase.panelSubMain);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

/*        private void button1_Click_1(object sender, EventArgs e)
        {
            string richTextBoxText = richTextBox1.Text;
            postText.Text = richTextBoxText;
            postText.AutoSize = true;
            postText.MaximumSize = new Size(panel2.Width, int.MaxValue);
            panel2.Height = postText.Height;
        }
*/
        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Post_Load(object sender, EventArgs e)
        {

            if (IsLabelVisibleOnScreen(lblUserName))
            {
                //MessageBox.Show("Post_Load");
                DBImageOperation dbio = new DBImageOperation();
                Task<System.Drawing.Image> image =  dbio.LoadPostImageFromDataBaseAsync(this.ClassPosts.PostId);
                System.Drawing.Image postImage = await image;
                if (postImage != null)
                {
                    this.postImagePanel.BackgroundImage = postImage;
                    Methods.SetDoubleBuffer(postImagePanel, true);
                    this.ClassPosts.PostImage=postImage;
                    postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)postImagePanel.BackgroundImage);
                    this.postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)this.postImagePanel.BackgroundImage);


                }
                else
                {
                    int removeColumnIndex = 0;
                    int removeRowIndex = 2;

                    Control controlToRemove = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex);
                    if (controlToRemove != null)
                    {
                        tableLayoutPanel2.Controls.Remove(controlToRemove);
                        controlToRemove.Dispose();

                        for (int rowIndex = removeRowIndex + 1; rowIndex < tableLayoutPanel2.RowCount; rowIndex++)
                        {
                            Control control = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, rowIndex);
                            if (control != null)
                            {
                                tableLayoutPanel2.SetCellPosition(control, new TableLayoutPanelCellPosition(removeColumnIndex, rowIndex - 1));
                            }
                        }

                        Control adjacentControl = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex - 1);
                        if (adjacentControl != null)
                        {
                            tableLayoutPanel2.SetRowSpan(adjacentControl, tableLayoutPanel2.GetRowSpan(adjacentControl) + 1);
                        }

                        tableLayoutPanel2.RowCount--;
                    }

                this.ClientSize = new System.Drawing.Size(965, 500);

                }



            }
        }
            private void ParentContainer_Scroll(object sender, ScrollEventArgs e)
            {

                if (IsLabelVisibleOnScreen(lblUserName))
                {
                MessageBox.Show("ParentContainer_Scroll");

                DBImageOperation dbio = new DBImageOperation();
                    //System.Drawing.Image postImage = dbio.LoadPostImageFromDataBase(this.ClassPosts.PostId);

/*                    if (postImage != null)
                    {
                        this.postImagePanel.BackgroundImage = postImage;
                        Methods.SetDoubleBuffer(postImagePanel, true);
                        postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)postImagePanel.BackgroundImage);
                        this.postImagePanel.BackColor = Methods.GetBackgroundAverageColor((Bitmap)this.postImagePanel.BackgroundImage);


                    }*/
                    //else
                    {
                        int removeColumnIndex = 0;
                        int removeRowIndex = 2;

                        Control controlToRemove = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex);
                        if (controlToRemove != null)
                        {
                            tableLayoutPanel2.Controls.Remove(controlToRemove);
                            controlToRemove.Dispose();

                            for (int rowIndex = removeRowIndex + 1; rowIndex < tableLayoutPanel2.RowCount; rowIndex++)
                            {
                                Control control = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, rowIndex);
                                if (control != null)
                                {
                                    tableLayoutPanel2.SetCellPosition(control, new TableLayoutPanelCellPosition(removeColumnIndex, rowIndex - 1));
                                }
                            }

                            Control adjacentControl = tableLayoutPanel2.GetControlFromPosition(removeColumnIndex, removeRowIndex - 1);
                            if (adjacentControl != null)
                            {
                                tableLayoutPanel2.SetRowSpan(adjacentControl, tableLayoutPanel2.GetRowSpan(adjacentControl) + 1);
                            }

                            tableLayoutPanel2.RowCount--;
                        }


                    }


                }
            
        }
        private bool IsPanelVisibleOnScreen(Panel panel)
        {
            Rectangle visibleRect = panel.Parent.RectangleToScreen(panel.Parent.ClientRectangle);
            return visibleRect.IntersectsWith(panel.RectangleToScreen(panel.ClientRectangle));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int postId = GetPostId(); 
            int userId = GetUserId(); 

            bool alreadyLiked = CheckIfAlreadyLiked(postId, userId);

            if (!alreadyLiked)
            {
                InsertLike(postId, userId);
                UpdateReactCount(postId, 1);
                button2.Image = global::media.Properties.Resources.icons8_favorite_96;
            }
            else
            {
                RemoveLike(postId, userId);
                UpdateReactCount(postId, -1);
                button2.Image = global::media.Properties.Resources.icons8_heart_96;
            }
        }

        private bool CheckIfAlreadyLiked(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "SELECT COUNT(*) FROM LikeTable WHERE PostId = @postId AND UserId = @userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
                
            }
        }

        private void InsertLike(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "INSERT INTO LikeTable (PostId, UserId, LikedOn) VALUES (@postId, @userId, @likedOn)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@likedOn", DateTime.Now); // You can replace DateTime.Now with the actual likedOn value

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void RemoveLike(int postId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "DELETE FROM LikeTAble WHERE PostId = @postId AND UserId = @userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@postId", postId);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void UpdateReactCount(int postId, int incrementValue)
        {
            this.reactCount.Text= (Convert.ToInt32(this.reactCount.Text)+ incrementValue).ToString();
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "UPDATE postofuser SET postReactCount = postReactCount + @incrementValue WHERE PostId = @postId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@incrementValue", incrementValue);
                command.Parameters.AddWithValue("@postId", postId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private int GetPostId()
        {
            return this.ClassPosts.PostId;
        }

        private int GetUserId()
        {
            return ClassNativeUser.NativeUser.Key;
        }

/*        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            Form f = new Form();
            Guna.UI2.WinForms.Guna2ShadowForm a = new Guna.UI2.WinForms.Guna2ShadowForm(this); 

            
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormBorderStyle= FormBorderStyle.None;

            
            f.Size = new Size(100, 200);

            
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            f.Controls.Add(tableLayoutPanel);

            
            Button buttonSave = new Button();
            buttonSave.Text = "Save";
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.OK;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonSave, 0, 0);

            Button buttonReport = new Button();
            buttonReport.Text = "Report";
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.Dock = DockStyle.Fill;
            buttonReport.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.Yes;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonReport, 0, 1);

            Button buttonDelete = new Button();
            buttonDelete.Text = "Delete";
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.No;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonDelete, 0, 2);

            Button buttonRemove = new Button();
            buttonRemove.Text = "Edit";
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.Abort;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonRemove, 0, 3);

            DialogResult result = f.ShowDialog();

            int returnValue = 0;
            switch (result)
            {
                case DialogResult.OK:
                    returnValue = 1;
                    break;
                case DialogResult.Yes:
                    returnValue = 2;
                    break;
                case DialogResult.No:
                    returnValue = 3;
                    break;
                case DialogResult.Abort:
                    returnValue = 4;
                    break;
            }
            if (this.ClassPosts.PostCreator.Key == ClassNativeUser.NativeUser.Key && returnValue == 3)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                    {
                        conn.Open();

                        // Check if a row exists in mediacontent_postuser for the given postid
                        string checkQuery = "SELECT COUNT(*) FROM mediacontent_postuser WHERE postid = @PostId";
                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn))
                        {
                            checkCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                            int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (rowCount > 0)
                            {
                                // Delete the row from mediacontent_postuser
                                string deleteMediaQuery = "DELETE FROM mediacontent_postuser WHERE postid = @PostId";
                                using (MySqlCommand deleteMediaCommand = new MySqlCommand(deleteMediaQuery, conn))
                                {
                                    deleteMediaCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                                    deleteMediaCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        // Delete the row from postofuser
                        string deletePostQuery = "DELETE FROM postofuser WHERE postid = @PostId";
                        using (MySqlCommand deletePostCommand = new MySqlCommand(deletePostQuery, conn))
                        {
                            deletePostCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                            deletePostCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

*/        
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        private void yyy_guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Guna.UI2.WinForms.Guna2ShadowForm a = new Guna.UI2.WinForms.Guna2ShadowForm(f);
            Guna.UI2.WinForms.Guna2Elipse y = new Guna.UI2.WinForms.Guna2Elipse();

            f.FormBorderStyle = FormBorderStyle.None;
            y.TargetControl = f;
            y.BorderRadius = 20;

            f.Size = new Size(100, 200);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            f.Controls.Add(tableLayoutPanel);

            Button buttonSave = new Button();
            buttonSave.Text = "Save";
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.OK;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonSave, 0, 0);

            Button buttonReport = new Button();
            buttonReport.Text = "Report";
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.Dock = DockStyle.Fill;
            buttonReport.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.Yes;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonReport, 0, 1);

            Button buttonDelete = new Button();
            buttonDelete.Text = "Delete";
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.No;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonDelete, 0, 2);

            Button buttonRemove = new Button();
            buttonRemove.Text = "Edit";
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Click += (btnSender, btnEvent) =>
            {
                f.DialogResult = DialogResult.Abort;
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonRemove, 0, 3);

            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(
                this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2
            );

            this.Click += (clickSender, clickEvent) =>
            {
                if (f.Visible)
                {
                    f.Close();
                }
            };

            f.Show(this);

            f.FormClosing += (closingSender, closingEvent) =>
            {
                f.Owner = null;
            };

            int returnValue = 0;
            if (f.DialogResult == DialogResult.OK)
            {
                returnValue = 1;
            }
            else if (f.DialogResult == DialogResult.Yes)
            {
                returnValue = 2;
            }
            else if (f.DialogResult == DialogResult.No)
            {
                returnValue = 3;
            }
            else if (f.DialogResult == DialogResult.Abort)
            {
                returnValue = 4;
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FormTest f = new FormTest();
            Guna.UI2.WinForms.Guna2ShadowForm a = new Guna.UI2.WinForms.Guna2ShadowForm(f);


            f.FormBorderStyle = FormBorderStyle.None;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
            tableLayoutPanel.Anchor= AnchorStyles.None;
            tableLayoutPanel.Size = new Size(200, 300);
            tableLayoutPanel.Location= new Point(860, 310);
            f.Controls.Add(tableLayoutPanel);

            Guna.UI2.WinForms.Guna2Button buttonSave = new Guna.UI2.WinForms.Guna2Button();
            buttonSave.Text = "Save";
            buttonSave.FillColor = Color.FromArgb(80, 200, 120);
            buttonSave.HoverState.FillColor = Color.FromArgb(100, 220, 140);
            buttonSave.HoverState.Parent = buttonSave;
            buttonSave.BorderRadius = 15;
            buttonSave.BorderThickness = 1;
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Click += (btnSender, btnEvent) =>
            {
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonSave, 0, 0);

            Guna.UI2.WinForms.Guna2Button buttonReport = new Guna.UI2.WinForms.Guna2Button();
            buttonReport.Text = "Report";
            buttonReport.FillColor = Color.FromArgb(200, 120, 80);
            buttonReport.HoverState.FillColor = Color.FromArgb(220, 140, 100);
            buttonReport.HoverState.Parent = buttonReport;
            buttonReport.BorderRadius = 15;
            buttonReport.BorderThickness = 2;
            buttonReport.Dock = DockStyle.Fill;
            buttonReport.Click += (btnSender, btnEvent) =>
            {
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonReport, 0, 1);

            Guna.UI2.WinForms.Guna2Button buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            buttonDelete.Text = "Delete";
            buttonDelete.FillColor = Color.FromArgb(200, 80, 80);
            buttonDelete.HoverState.FillColor = Color.FromArgb(220, 100, 100);
            buttonDelete.HoverState.Parent = buttonDelete;
            buttonDelete.BorderRadius = 15;
            buttonDelete.BorderThickness = 1;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Click += (btnSender, btnEvent) =>
            {
                f.Close();
                if (this.ClassPosts.PostCreator.Key == ClassNativeUser.NativeUser.Key)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                        {
                            conn.Open();

                            // Check if a row exists in mediacontent_postuser for the given postid
                            string checkQuery = "SELECT COUNT(*) FROM mediacontent_postuser WHERE postid = @PostId";
                            using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn))
                            {
                                checkCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                                int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                if (rowCount > 0)
                                {
                                    // Delete the row from mediacontent_postuser
                                    string deleteMediaQuery = "DELETE FROM mediacontent_postuser WHERE postid = @PostId";
                                    using (MySqlCommand deleteMediaCommand = new MySqlCommand(deleteMediaQuery, conn))
                                    {
                                        deleteMediaCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                                        deleteMediaCommand.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Delete the row from postofuser
                            string deletePostQuery = "DELETE FROM postofuser WHERE postid = @PostId";
                            using (MySqlCommand deletePostCommand = new MySqlCommand(deletePostQuery, conn))
                            {
                                deletePostCommand.Parameters.AddWithValue("@PostId", this.ClassPosts.PostId);
                                deletePostCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete this post!");
                }

            };
            tableLayoutPanel.Controls.Add(buttonDelete, 0, 2);

            Guna.UI2.WinForms.Guna2Button buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            buttonRemove.Text = "Edit";
            buttonRemove.FillColor = Color.FromArgb(120, 120, 200);
            buttonRemove.HoverState.FillColor = Color.FromArgb(140, 140, 220);
            buttonRemove.HoverState.Parent = buttonRemove;
            buttonRemove.BorderRadius = 15;
            buttonRemove.BorderThickness = 1;
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.Click += (btnSender, btnEvent) =>
            {
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonRemove, 0, 3);

            Guna.UI2.WinForms.Guna2Button buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.FillColor = Color.FromArgb(150, 150, 150);
            buttonCancel.HoverState.FillColor = Color.FromArgb(170, 170, 170);
            buttonCancel.HoverState.Parent = buttonCancel;
            buttonCancel.BorderRadius = 15;
            buttonCancel.BorderThickness = 1;
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Click += (btnSender, btnEvent) =>
            {
                f.Close();
            };
            tableLayoutPanel.Controls.Add(buttonCancel, 0, 4);
            tableLayoutPanel.BringToFront();
            // Center the child form on the parent form
            //f.StartPosition = FormStartPosition.CenterParent;

            // Show the form as a modal dialog
            f.ShowDialog(this);
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormTest f = new FormTest();
            f.FormBorderStyle = FormBorderStyle.None;
            Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            f.StartPosition = FormStartPosition.Manual;
            FormPostSingle fsp = new FormPostSingle(this.classPosts);
            shadowPanel.Location= new Point(580, 70);
            shadowPanel.Size = fsp.Size;
            shadowPanel.ShadowDepth = 100;
            shadowPanel.ShadowShift = 10;
            shadowPanel.ShadowColor = Color.Black;
            shadowPanel.Radius = 20;
            Methods.OpenChildForm(fsp, shadowPanel);
            f.Controls.Add(shadowPanel);
            shadowPanel.BringToFront();
            f.Location = new Point(3,32);
            f.ShowDialog(this);

        }
    }
}
/*
 *   <data name="microfunnel-flaticon-removebg-preview" type="System.Resources.ResXFileRef, System.Windows.Forms">
    <value>..\Resources\microfunnel-flaticon-removebg-preview.png;System.Drawing.Bitmap, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</value>
  </data>

 */
