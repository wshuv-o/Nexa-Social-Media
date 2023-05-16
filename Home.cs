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
            friendRequestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint); 


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
                System.Drawing.Image postImage= dbio.LoadPostImageFromDataBase(postID);
                User postCreator = dbio.GetUserByUserId(Key);
                Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postImage, postPermission, postReact, postCreator);
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
                //MessageBox.Show(x);
            }
            //MessageBox.Show(x);
        }


        private void panelFeed_Paint(object sender, PaintEventArgs e)
        {
            if (panelFeed.VerticalScroll.Visible)
            {
                int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
                int scrollbarX = panelFeed.Width - scrollbarWidth;
                int scrollbarY = panelFeed.VerticalScroll.Value * (panelFeed.Height - scrollbarWidth) /
                    (panelFeed.VerticalScroll.Maximum - panelFeed.VerticalScroll.Minimum);
                int scrollbarHeight = panelFeed.Height * scrollbarWidth / (panelFeed.Height - scrollbarWidth);
                Rectangle scrollbarRect = new Rectangle(scrollbarX, scrollbarY, scrollbarWidth, scrollbarHeight);
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(brush, scrollbarRect);
                }
            }

            if (panelFeed.HorizontalScroll.Visible)
            {
                int scrollbarHeight = SystemInformation.HorizontalScrollBarHeight;
                int scrollbarX = panelFeed.HorizontalScroll.Value * (panelFeed.Width - scrollbarHeight) /
                    (panelFeed.HorizontalScroll.Maximum - panelFeed.HorizontalScroll.Minimum);
                int scrollbarY = panelFeed.Height - scrollbarHeight;
                int scrollbarWidth = panelFeed.Width * scrollbarHeight / (panelFeed.Width - scrollbarHeight);
                Rectangle scrollbarRect = new Rectangle(scrollbarX, scrollbarY, scrollbarWidth, scrollbarHeight);
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillRectangle(brush, scrollbarRect);
                }
            }
        }

        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            Point currentAutoScrollPosition = panelFeed.AutoScrollPosition;
            currentAutoScrollPosition.Offset(0, -numberOfTextLinesToMove);
            panelFeed.AutoScrollPosition = currentAutoScrollPosition;
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
                //string mediaContent = (string)reader["image"];
                System.Drawing.Image postImage = dbio.LoadPostImageFromDataBase(postID);
                User postCreator = dbio.GetUserByUserId(Key);
                if (postImage != null)
                {
                    j += 1;

                    Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postImage, postPermission, postReact, postCreator);
                    //MessageBox.Show(p.PostText);
                    classPostList.Add(p);
                }
                else
                {
                    j += 1;
                    Classes.ClassPost p = new Classes.ClassPost(postID, postText, postTime, postPermission, postReact, postCreator);
                    //MessageBox.Show(p.PostText);
                    classPostList.Add(p);
                }
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
            MessageBox.Show(distinctPostList.Length.ToString());

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
            MessageBox.Show("sdgfdg" + distinctUserList.Count.ToString());
            MessageBox.Show("there :" + ClassNativeUser.DistinctUserList.Count.ToString());






            for (int i = 0; i < distinctPostList.Length; i++)
            {
                postAdopters.Add(new PostAdopter(distinctPostList[i]));
                //MessageBox.Show(x);

                if (distinctPostList[i].PostImage != null)
                {
                    // x = x + "x" + distinctPostList[i].PostId;
                    posts.Add(new Post(distinctPostList[i]));
                    Methods.OpenChildForm2(posts[i], postAdopters[i].panelBase);
                    panelFeed.Controls.Add(postAdopters[i].panelBase);
                }
                else
                {
                    // x = x + "y" + distinctPostList[i].PostId;
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
                //MessageBox.Show(p.PostText);
                classFriendRequestlist.Add(cfr);
                //MessageBox.Show(classFriendRequestlist.Count.ToString());

            }
            readerx.Close();
            connection.Close();
            for (int i = 0; i < classFriendRequestlist.Count; i++)
            {

                friendRequestForms.Add(new Friends.FriendRequestForm(classFriendRequestlist[i]));
                friendRequestAdopter.Add(new FriendRequestAdopter(friendRequestForms[i]));
                //Methods.OpenChildForm(friendRequestForms[i], friendRequestAdopter[i].panelEachContact);
                this.friendRequestPanel.Controls.Add(friendRequestAdopter[i].panelEachContact);


            }
            //MessageBox.Show(classFriendRequestlist.Count.ToString());
            //MessageBox.Show(friendRequestAdopter.Count.ToString());
            for (int i = 0; i < ClassNativeUser.DistinctUserList.Count; i++)
            {
                formContactLists.Add(new Friends.FormContactList(ClassNativeUser.DistinctUserList[i]));
                contactAdaptorPanel.Add(new ContactAdaptorPanel(formContactLists[i]));
                //Methods.OpenChildForm(friendRequestForms[i], friendRequestAdopter[i].panelEachContact);
                this.contactPanel.Controls.Add(contactAdaptorPanel[i].panelEachContact);

            }
            
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panelBaseStory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBaseHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guna2Panel panelBase =new Guna2Panel();    
            Guna2Panel panelChild=new Guna2Panel();
            panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            panelBase.BackColor = System.Drawing.Color.White;
            panelBase.Controls.Add(panelChild);
            panelBase.Location = new System.Drawing.Point(43, 347);
            panelBase.Name = "panel1";
            panelBase.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            panelBase.Size = new System.Drawing.Size(866, 850);
            panelBase.TabIndex = 1;
            panelBase.Paint += new System.Windows.Forms.PaintEventHandler(panelBase_Paint);


            panelChild.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            panelChild.Location = new System.Drawing.Point(50, 0);
            panelChild.Name = "panel2";
            panelChild.Size = new System.Drawing.Size(766, 600);
            panelChild.TabIndex = 0;
            panelChild.BorderColor = Color.Red;
            panelChild.BorderThickness = 1;
            panelChild.BorderRadius = 20;
            panelChild.BackColor = Color.White;
            panelChild.Paint += new System.Windows.Forms.PaintEventHandler(panelChild_Paint_1);
            panelChild.MouseEnter += new System.EventHandler(panelChild_MouseEnter);
            panelChild.MouseLeave += new System.EventHandler(panelChild_MouseLeave);

            Post a = new Post();
            Methods.OpenChildForm(a, panelChild);

           // panelBase.Height = a.basePanel.Height;
           // panelBase.Width = 866;
            //panelChild.Height = a.basePanel.Height;
            //panelChild.Width = 766;
            //panelChild.Height = a.Height;
            panelFeed.Controls.Add(panelBase);

        }

      
        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }


    
        private void panelChild_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panelChild_MouseEnter(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = true;
        }

        private void panelChild_MouseLeave(object sender, EventArgs e)
        {
            panelFeed.VerticalScroll.Visible = false;
        }





        private void label1_Click_1(object sender, EventArgs e)
        {

        }        
        private void labelContact_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            new Form();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Friends.FreindRequestPanel f = new Friends.FreindRequestPanel();

                

            

        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customRoundPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customRoundPictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void friendRequestPanel_Paint(object sender, PaintEventArgs e)
        {

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
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.Height = 50; 
                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    buttonCell.Value = fullName;
                    dataGridViewRow.Cells.Add(buttonCell);
                    guna2DataGridView1.Rows.Add(dataGridViewRow);
                }
            }
        }





        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable RetrieveUserData(string searchText)
        {                
            DataTable dataTable = new DataTable();

            if (searchKey == 2)
            {

                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT CONCAT(userFirstName, ' ', userLastName) AS FullName FROM user WHERE userFirstName LIKE @searchText OR userLastName LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string)); // Column for FullName
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    //return dataTable;
                }
            }
            else if(searchKey == 4)
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT page_name AS FullName FROM pages WHERE page_name LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string)); // Column for FullName
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    //return dataTable;
                }
            }
            else if (searchKey == 3)
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                {
                    string query = "SELECT postText AS FullName FROM postofuser WHERE postText LIKE @searchText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    dataTable.Columns.Add("FullName", typeof(string)); // Column for FullName
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    //return dataTable;
                }
            }
            return dataTable;


        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor= Color.Black;
            btnPage.FillColor= Color.White;
            btnPost.FillColor= Color.White;

            btnPeople.ForeColor = Color.White;
            btnPost.ForeColor = Color.Black;
            btnPage.ForeColor = Color.Black;
            searchKey = 2;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor = Color.White;
            btnPage.FillColor = Color.White;
            btnPost.FillColor = Color.Black;

            btnPeople.ForeColor = Color.Black;
            btnPost.ForeColor = Color.White;
            btnPage.ForeColor = Color.Black;
            searchKey = 3;

        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            btnPeople.FillColor = Color.White;
            btnPage.FillColor = Color.Black;
            btnPost.FillColor = Color.White;

            btnPeople.ForeColor = Color.Black;
            btnPost.ForeColor = Color.Black;
            btnPage.ForeColor = Color.White;
            searchKey = 4;

        }
    }
}
