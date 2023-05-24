using Guna.UI2.WinForms;
using media.Classes;
using media.Friends;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static media.Friends.FriendRequestForm;
using static System.Net.Mime.MediaTypeNames;

namespace media
{
    public partial class Home : Form
    {
        private int searchKey=0;
        private Classes.User nativeUser;
        List<ClassFriendRequest> classFriendRequestlist = new List<ClassFriendRequest>();
        List<FriendRequestAdopter> friendRequestAdopter = new List<FriendRequestAdopter>();
        List<ContactAdaptorPanel> contactAdaptorPanel = new List<ContactAdaptorPanel>();
        List<FriendRequestForm> friendRequestForms = new List<FriendRequestForm>();
        List<FormContactList> formContactLists = new List<FormContactList>();

        public Classes.User NativeUser
        {
            get { return this.nativeUser; }
            set { this.nativeUser = value; }
        }

        public Home(Classes.User nativeUser)
        {
            this.NativeUser = nativeUser;
            List<media.Classes.ClassPost> classPostList= new List<media.Classes.ClassPost>(); 
            InitializeComponent();
            panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 40F);
            panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent,40F);
            panelBaseHome.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
            panelFeed.Resize += new System.EventHandler(this.panelNavBar_Resize);
            Methods.RoundPanelCorners(ref panelNavBar, 20);
            Methods.RoundPanelCorners(ref contactPanel, 20);

            this.panelNavBar.Resize += (sender, e) =>
            {
                int availableWidth =this.panel1.Width;
                this.panelNavBar.Width = availableWidth;
                Methods.RoundPanelCorners1(ref this.panelNavBar, 30);
            };

            
            this.contactPanel.Resize += (sender, e) =>
            {
                contactPanel.Height = this.panel3.Height;
                contactPanel.Width=this.panel3.Width;
                Methods.RoundPanelCorners(ref this.contactPanel, 20);

            };

            this.guna2Panel2.Resize += (sender, e) =>
            {
                guna2Panel2.Width = friendRequestPanel.Width;

            };


            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel3, true);
            Methods.SetDoubleBuffer(panelBaseHome, true);
            Methods.SetDoubleBuffer(panelFC, true);
            Methods.SetDoubleBuffer(friendRequestPanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(panelFC, true);
            Methods.SetDoubleBuffer(panelFeed, true);
            Methods.SetDoubleBuffer(contactPanel, true);



            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Button Column";
            buttonColumn.Name = "btnColumn";
            buttonColumn.Text = "Click Me";
            buttonColumn.UseColumnTextForButtonValue = true;

            guna2DataGridView1.Columns.Add(buttonColumn);
        }
        public Home(int userId)
        {
            List<media.Classes.ClassPost> classPostList = new List<media.Classes.ClassPost>();
            InitializeComponent();
            panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 40F);
            panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 40F);
            panelBaseHome.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
            panelFeed.Resize += new System.EventHandler(this.panelNavBar_Resize);
            Methods.RoundPanelCorners(ref panelNavBar, 20);
            Methods.RoundPanelCorners(ref contactPanel, 20);

            this.panelNavBar.Resize += (sender, e) =>
            {
                int availableWidth = this.panel1.Width;
                this.panelNavBar.Width = availableWidth;
                Methods.RoundPanelCorners1(ref this.panelNavBar, 30);
            };


            this.contactPanel.Resize += (sender, e) =>
            {
                contactPanel.Height = this.panel3.Height;
                contactPanel.Width = this.panel3.Width;
                Methods.RoundPanelCorners(ref this.contactPanel, 20);

            };

            this.guna2Panel2.Resize += (sender, e) =>
            {
                guna2Panel2.Width = friendRequestPanel.Width;

            };
            friendRequestPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            friendRequestPanel.BackColor = System.Drawing.Color.White;
            friendRequestPanel.Controls.Add(this.guna2Panel2);
            friendRequestPanel.Location = new System.Drawing.Point(10, 66);
            friendRequestPanel.Name = "friendRequestPanel";
            friendRequestPanel.Size = new System.Drawing.Size(668, 385);
            friendRequestPanel.TabIndex = 1;


            Methods.SetDoubleBuffer(panel1, true);
            Methods.SetDoubleBuffer(panel3, true);
            Methods.SetDoubleBuffer(panelBaseHome, true);
            Methods.SetDoubleBuffer(panelFC, true);
            Methods.SetDoubleBuffer(friendRequestPanel, true);
            Methods.SetDoubleBuffer(tableLayoutPanel1, true);
            Methods.SetDoubleBuffer(panelFC, true);
            Methods.SetDoubleBuffer(panelFeed, true);
            Methods.SetDoubleBuffer(contactPanel, true);

            string connectionString = DatabaseCredentials.connectionStringLocalServer;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid, i.image FROM postofuser p, mediacontent_postuser i where p.userid=@userId and i.postid=p.postid";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userId", userId);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DBImageOperation dbio = new DBImageOperation();
                int postID = reader.GetInt32("postid");
                string postText = (string)reader["posttext"];
                DateTime postTime = reader.GetDateTime("posttime");
                string postPermission = (string)reader["postPermission"];
                int postReact = reader.GetInt32("postReactCount");
                int Key = reader.GetInt32("userid");
                //System.Drawing.Image postImage= dbio.LoadPostImageFromDataBase(postID);
                User postCreator = dbio.GetUserByUserId(Key);
                Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postPermission, postReact, postCreator);
                //MessageBox.Show(p.PostText);
                classPostList.Add(p);

            }
            reader.Close();
            connection.Close();

            List<Post> posts = new List<Post>();
            List<FormPost> formPost = new List<FormPost>();
            List<PostAdopter> postAdopters = new List<PostAdopter>();
            string s = new string('e', 'e');
            ClassPost[] distinctPostList = null;
            if (classPostList != null && classPostList.Count > 0)
            {
                distinctPostList = classPostList
                     .Where(p => p != null) // Filter out any null objects
                     .GroupBy(p => p.PostId)
                     .Select(g => g.First())
                     .ToArray();
            }


            for (int i = 0; i < distinctPostList.Length; i++)
            {
                postAdopters.Add(new PostAdopter(distinctPostList[i]));

                if (distinctPostList[i].PostImage != null)
                {
                    formPost.Add(new FormPost(distinctPostList[i]));
                    Methods.OpenChildForm2(formPost[i], postAdopters[i].panelBase);
                    panelFeed.Controls.Add(postAdopters[i].panelBase);
                }
                else
                {

                    posts.Add(new Post(distinctPostList[i]));
                    Methods.OpenChildForm2(posts[i], postAdopters[i].panelBase);
                    panelFeed.Controls.Add(postAdopters[i].panelBase);

                }
            }
            
        }


        private void panelNavBar_Resize(object sender, EventArgs e)
        {
            if (panelFeed.Width <= 600)
            {
                panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 0F);
                panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 0F);
            }
            if (panelFeed.Width > 600)
            {
                panelBaseHome.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 40F);
                panelBaseHome.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 40F);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.guna2Panel4.BringToFront();
            List<media.Classes.ClassPost> classPostList = new List<media.Classes.ClassPost>();
            string connectionString = DatabaseCredentials.connectionStringLocalServer;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p, mediacontent_postuser mcpu WHERE p.postid= mcpu.postid AND p.userid IN(SELECT FriendUserId FROM friends WHERE NativeUserId = " + this.NativeUser.Key + " OR FriendUserId = " + this.NativeUser.Key + " ORDER BY userfriendId ASC);";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                DBImageOperation dbio = new DBImageOperation();
                int postID = reader.GetInt32("postid");
                string postText = (string)reader["posttext"];
                DateTime postTime = reader.GetDateTime("posttime");
                string postPermission = (string)reader["postPermission"];
                int postReact = (int)reader["postReactCount"];
                int Key = reader.GetInt32("userid");
                User postCreator = dbio.GetUserByUserId(Key);
                Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postPermission, postReact, postCreator);
                classPostList.Add(p);
            }
            reader.Close();

            query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p WHERE p.postid NOT IN (SELECT DISTINCT postid FROM  mediacontent_postuser) AND p.userid IN(SELECT FriendUserId FROM friends WHERE NativeUserId = " + this.NativeUser.Key + " OR FriendUserId = " + this.NativeUser.Key + " ORDER BY userfriendId ASC);";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                DBImageOperation dbio = new DBImageOperation();
                int postID = reader.GetInt32("postid");
                string postText = (string)reader["posttext"];
                DateTime postTime = reader.GetDateTime("posttime");
                string postPermission = (string)reader["postPermission"];
                int postReact = (int)reader["postReactCount"];
                int Key = reader.GetInt32("userid");
                User postCreator = dbio.GetUserByUserId(Key);
                Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postPermission, postReact, postCreator);
                //MessageBox.Show(p.PostText);
                classPostList.Add(p);

            }
            connection.Close();

            List<Post> posts = new List<Post>();
            List<FormPost> formPost = new List<FormPost>();
            List<PostAdopter> postAdopters = new List<PostAdopter>();
            ClassPost[] distinctPostList = classPostList.ToArray();
            if (classPostList != null && classPostList.Count > 0)
            {
                distinctPostList = classPostList
                     .Where(p => p != null)
                     .GroupBy(p => p.PostId)
                     .Select(g => g.First())
                     .ToArray();
            }

            List<User> distinctUserList = new List<User>();

            if (classPostList != null && classPostList.Count > 0)
            {
                distinctUserList = classPostList
                    .Where(p => p != null && p.PostCreator != null && p.PostCreator.Key != null)
                    .Select(p => p.PostCreator)
                    .GroupBy(u => u.Key)
                    .Select(g => g.First())
                    .ToList();
            }
            ClassNativeUser.DistinctUserList = distinctUserList;


            Panel f = new Panel();
            f.Size = new Size(870, 350);
            f.Location = new Point(25, 20);
            f.BackColor = Color.WhiteSmoke;
            Methods.OpenChildForm2(new Story(this.NativeUser), f);
            panelFeed.Controls.Add(f);

            Panel f2 = new Panel();
            f2.Size = new Size(730, 150);
            f2.Location = new Point(200, 20);
            f2.Margin=new Padding(70,0,0,10);
            f2.BackColor = Color.WhiteSmoke;
            Methods.OpenChildForm2(new Form3(this.NativeUser), f2);
            panelFeed.Controls.Add(f2);



            for (int i = 0; i < distinctPostList.Length; i++)
            {
                postAdopters.Add(new PostAdopter(distinctPostList[i]));

                if (distinctPostList[i].PostImage != null)
                {
                    posts.Add(new Post(distinctPostList[i]));
                    Methods.OpenChildForm2(posts[i], postAdopters[i].panelBase);
                    panelFeed.Controls.Add(postAdopters[i].panelBase);
                }
                else
                {
                    posts.Add(new Post(distinctPostList[i]));
                    Methods.OpenChildForm2(posts[i], postAdopters[i].panelBase);
                    panelFeed.Controls.Add(postAdopters[i].panelBase);

                }
            }






            connection.Open();
            string queryx = "SELECT requestid, requestStatus, requestfrom FROM friendrequest where requestto = " + this.NativeUser.Key + " ;";
            MySqlCommand commandx = new MySqlCommand(queryx, connection);
            MySqlDataReader readerx = commandx.ExecuteReader();
            while (readerx.Read())
            {
                DBImageOperation dbio = new DBImageOperation();
                int requestid = readerx.GetInt32("requestid");
                int requestStatus = readerx.GetInt32("requestStatus");
                int Key = readerx.GetInt32("requestfrom");
                User requesterProfile = dbio.GetUserByUserId(Key);
                ClassFriendRequest cfr = new ClassFriendRequest(requestid, this.NativeUser.Key, Key, requestStatus, requesterProfile);
                classFriendRequestlist.Add(cfr);
            }
            readerx.Close();
            connection.Close();
            for (int i = 0; i < classFriendRequestlist.Count; i++)
            {
                friendRequestForms.Add(new Friends.FriendRequestForm(classFriendRequestlist[i]));
                friendRequestAdopter.Add(new FriendRequestAdopter(friendRequestForms[i]));
                this.friendRequestPanel.Controls.Add(friendRequestAdopter[i].panelEachContact);
            }
            for (int i = 0; i < ClassNativeUser.DistinctUserList.Count; i++)
            {
                formContactLists.Add(new Friends.FormContactList(ClassNativeUser.DistinctUserList[i]));
                contactAdaptorPanel.Add(new ContactAdaptorPanel(formContactLists[i]));
                this.contactPanel.Controls.Add(contactAdaptorPanel[i].panelEachContact);
            }
            
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.Trim();
            guna2DataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable dataTable = RetrieveUserData(searchText);
                foreach (DataRow row in dataTable.Rows)
                {
                    string fullName = row["FullName"].ToString();
                    int id = Convert.ToInt32(row["ID"]);

                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.Height = 50;

                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    buttonCell.Value = fullName;
                    buttonCell.Tag = id; 

                    dataGridViewRow.Cells.Add(buttonCell);
                    guna2DataGridView1.Rows.Add(dataGridViewRow);
                }
            }
        }

        private async void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) 
            {
                DBImageOperation dbio = new DBImageOperation();
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int id = Convert.ToInt32(buttonCell.Tag);
                if (searchKey == 2)
                {
                    Methods.OpenChildForm2(new FormProfile(dbio.GetUserByUserId(id)), FormBase.panelSubMain);
                }
                if (searchKey == 3)
                {
                    Classes.ClassPost p= new ClassPost();
                    string connectionString = DatabaseCredentials.connectionStringLocalServer;
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    string query = "SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid, i.image FROM postofuser p, mediacontent_postuser i where p.postid= "+ id+" and i.postid=p.postid";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int postID = reader.GetInt32("postid");
                        string postText = (string)reader["posttext"];
                        DateTime postTime = reader.GetDateTime("posttime");
                        string postPermission = (string)reader["postPermission"];
                        int postReact = reader.GetInt32("postReactCount");
                        int Key = reader.GetInt32("userid");
                        Task <System.Drawing.Image> postImage= dbio.LoadPostImageFromDataBaseAsync(postID);
                        System.Drawing.Image image = await postImage;
                        User postCreator = dbio.GetUserByUserId(Key);
                         p = new Classes.ClassPost(postID, postText, postTime, image, postPermission,  postReact, postCreator);
                    }
                    reader.Close();
                    connection.Close();

                    FormTest f = new FormTest();
                    f.FormBorderStyle = FormBorderStyle.None;
                    Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
                    f.StartPosition = FormStartPosition.Manual;
                    FormPostSingle fsp = new FormPostSingle(p);
                    shadowPanel.Location = new Point(580, 100);
                    shadowPanel.Size = fsp.Size;
                    shadowPanel.ShadowDepth = 100;
                    shadowPanel.ShadowShift = 10;
                    shadowPanel.ShadowColor = Color.Black;
                    shadowPanel.Radius = 20;
                    Methods.OpenChildForm(fsp, shadowPanel);
                    f.Controls.Add(shadowPanel);
                    shadowPanel.BringToFront();
                    f.Location = new Point(3, 32);
                    f.ShowDialog(this);
                }
            }
        }

        private DataTable RetrieveUserData(string searchText)
        {
            DataTable dataTable = new DataTable();

            if (searchKey == 2)
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT CONCAT(userFirstName, ' ', userLastName) AS FullName, userID AS ID FROM user WHERE userFirstName LIKE @searchText OR userLastName LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string));
                    dataTable.Columns.Add("ID", typeof(int));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            else if (searchKey == 4)
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT page_name AS FullName, page_id AS ID FROM pages WHERE page_name LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string));
                    dataTable.Columns.Add("ID", typeof(int));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            else if (searchKey == 3)
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT postText AS FullName, postID AS ID FROM postofuser WHERE postText LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string));
                    dataTable.Columns.Add("ID", typeof(int));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }



        private void btnPeople_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor= Color.SlateBlue;
            btnPage.FillColor= Color.White;
            btnPost.FillColor= Color.White;

            btnPeople.ForeColor = Color.White;
            btnPost.ForeColor = Color.SlateBlue;
            btnPage.ForeColor = Color.SlateBlue;
            searchKey = 2;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor = Color.White;
            btnPage.FillColor = Color.White;
            btnPost.FillColor = Color.SlateBlue;

            btnPeople.ForeColor = Color.SlateBlue;
            btnPost.ForeColor = Color.White;
            btnPage.ForeColor = Color.SlateBlue;
            searchKey = 3;

        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor = Color.White;
            btnPage.FillColor = Color.SlateBlue;
            btnPost.FillColor = Color.White;

            btnPeople.ForeColor = Color.SlateBlue;
            btnPost.ForeColor = Color.SlateBlue;
            btnPage.ForeColor = Color.White;
            searchKey = 4;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.White;
            guna2Button1.FillColor = Color.SlateBlue;

            guna2Button2.ForeColor = Color.Black;
            guna2Button2.FillColor = Color.White;

            guna2Button3.ForeColor = Color.Black;
            guna2Button3.FillColor = Color.White;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.ForeColor = Color.White;
            guna2Button2.FillColor = Color.SlateBlue;

            guna2Button1.ForeColor = Color.Black;
            guna2Button1.FillColor = Color.White;

            guna2Button3.ForeColor = Color.Black;
            guna2Button3.FillColor = Color.White;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button3.ForeColor = Color.White;
            guna2Button3.FillColor = Color.SlateBlue;

            guna2Button2.ForeColor = Color.Black;
            guna2Button2.FillColor = Color.White;

            guna2Button1.ForeColor = Color.Black;
            guna2Button1.FillColor = Color.White;
        }

        private void panelFeed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
