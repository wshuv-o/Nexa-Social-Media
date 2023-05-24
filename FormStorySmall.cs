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
    public partial class FormStorySmall : Form
    {
        Classes.User nativeUser;
        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }
        public FormStorySmall(Classes.User nativeUser)
        {
            InitializeComponent();
            NativeUser = nativeUser;
            this.customRoundPictureBox1.Image = NativeUser.ProfilePhoto;
            this.label1.Text = NativeUser.UserFirstName + " " + NativeUser.UserLastName;
            
            ClassStory story = new ClassStory();
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                string query = "SELECT * FROM story WHERE userid = @userId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", this.NativeUser.Key);

                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DBImageOperation dbio = new DBImageOperation();
                    while (reader.Read())
                    {

                        story.StoryId = Convert.ToInt32(reader["storyid"]);
                        story.StoryText = reader["storyText"].ToString();
                        story.StoryTime = Convert.ToDateTime(reader["storyTime"]);
                        story.StoryBackground = Convert.ToInt32(reader["StoryBackground"]);
                        story.X = Convert.ToInt32(reader["X"]);
                        story.Y = Convert.ToInt32(reader["Y"]);
                        FontConverter fontConverter = new FontConverter();
                        try
                        {
                            story.StoryFont = (Font)fontConverter.ConvertFromString(reader["storyFont"].ToString());

                        }
                        catch (NotSupportedException)
                        {
                            story.StoryFont = new Font("Arial", 12, FontStyle.Bold);
                        }

                        story.A = Convert.ToInt32(reader["A"]);
                        story.R = Convert.ToInt32(reader["R"]);
                        story.G = Convert.ToInt32(reader["G"]);
                        story.B = Convert.ToInt32(reader["B"]);
                        story.StoryFontSize = Convert.ToInt32(reader["StoryFontSize"]);
                        story.UserId = Convert.ToInt32(reader["userid"]);

                    }
                }
                MessageBox.Show("here"+story.ToString());
            }

            this.label2.Text=story.StoryTime.ToString();
            if (story.StoryBackground == 1)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg1;

            }            
            else if (story.StoryBackground == 2)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg2;

            }            
            else if (story.StoryBackground == 3)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg3;

            }            
            else if (story.StoryBackground == 4)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg4;

            }            
            else if (story.StoryBackground == 5)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg5;

            }            
            else if (story.StoryBackground == 6)
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg6;

            }
            else
            {
                this.customPanel1.BackgroundImage = global::media.Properties.Resources.sbg7;

            }
            Label storyText= new Label();
            storyText.Text=story.StoryText;
            storyText.Font = story.StoryFont;
            storyText.ForeColor = Color.FromArgb(story.A, story.R, story.G, story.B);
            storyText.BackColor = Color.Transparent;
            storyText.Location= new Point(story.X, story.Y); 
            customPanel1.Controls.Add(storyText);
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ToStory(object sender, EventArgs e)
        {
            Methods.OpenChildForm2(new FormStorySingle(), FormBase.panelSubMain);
        }
    }
}
