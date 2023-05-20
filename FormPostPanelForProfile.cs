using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormPostPanelForProfile : Form
    {
        private int nativeUserkey;
        public int NativeUserKey
        {
            get
            { return nativeUserkey; }
            set
            {
                nativeUserkey = value;
            }
        }
        public FormPostPanelForProfile(int nativeUserkey)
        {
            InitializeComponent();
            this.NativeUserKey = nativeUserkey;


            List<media.Classes.ClassPost> classPostList = new List<media.Classes.ClassPost>();
            List<Post> posts = new List<Post>();
            List<FormPost> formPost = new List<FormPost>();
            List<PostAdopter> postAdopters = new List<PostAdopter>();


            string connectionString = DatabaseCredentials.connectionStringLocalServer;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //string query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p, mediacontent_postuser mcpu WHERE p.postid = mcpu.postid AND p.userid = " + this.NativeUserKey + " ORDER BY p.postTime DESC;";
            string query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p, mediacontent_postuser mcpu WHERE p.postid = mcpu.postid AND p.userid = " + this.NativeUserKey + " ORDER BY p.postTime DESC;";

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

            
            query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p WHERE p.postid NOT IN (SELECT DISTINCT postid FROM  mediacontent_postuser) AND p.userid = " + this.NativeUserKey + " ORDER BY postTime Desc);";
            query = @"SELECT p.postid, p.posttext, p.posttime, p.postPermission, p.postReactCount, p.userid FROM postofuser p WHERE p.postid NOT IN (SELECT DISTINCT postid FROM mediacontent_postuser) AND p.userid = " + this.NativeUserKey + " ORDER BY postTime DESC;";

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
                classPostList.Add(p);

            }
            connection.Close();


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
        }

        private void FormPostPanelForProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
