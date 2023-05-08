using Guna.UI2.WinForms;
using media.Classes;
using media.Message;
using media.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class FormChat : Form
    {
        Classes.User user= new User();
        Classes.User User
        {
            get { return user; }
            set { this.user = value; }
        }
        Message.ClassChatList[] classChatList= new ClassChatList[20];
        Guna2GradientPanel[] panelArray= new Guna2GradientPanel[20];
        public FormChat(Classes.User user)
        {
            this.User= user;

            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            panelChatBox.Resize += (sender, e) =>
            {
                int availableWidth = panelChatBox.ClientSize.Width - panelChatBox.Padding.Left - panelChatBox.Padding.Right;
                sendPanel.Width = availableWidth;
            };


            this.Visible= false;
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel3, true);
            Methods.SetDoubleBuffer(panel4, true);

            /*string connectionString = DatabaseCredentials.connectionStringLocalServer;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT CASE WHEN nativeuserid = @userId THEN frienduserid ELSE nativeuserid END FROM friends WHERE nativeuserid = @userId OR frienduserid = @userId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userId", this.User.Key);
            MySqlDataReader reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                DBImageOperation dbio = new DBImageOperation();
                User chatPerson = dbio.GetUserByUserId(this.User.Key);
                Message.ClassChatList p = new Message.ClassChatList(chatPerson);
                classChatList[j] = p;
                j++;

            }
            reader.Close();
            connection.Close();
            */
            string connectionString = DatabaseCredentials.connectionStringLocalServer;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT CASE WHEN nativeuserid = @userId THEN frienduserid ELSE nativeuserid END FROM friends WHERE nativeuserid = @userId OR frienduserid = @userId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userId", this.User.Key);
            MySqlDataReader reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                int friendUserId = reader.GetInt32(0); // Assuming the column index is 0
                DBImageOperation dbio = new DBImageOperation();
                User chatPerson = dbio.GetUserByUserId(friendUserId);
                Message.ClassChatList p = new Message.ClassChatList(chatPerson);
                classChatList[j] = p;
                j++;
            }
            reader.Close();
            connection.Close();

            foreach (ClassChatList c in classChatList)
            {
                if(c!=null)
                this.flowLayoutPanel3.Controls.Add(c.ChatPanel);
            }
            panelArray = flowLayoutPanel3.Controls.OfType<Guna2GradientPanel>().ToArray();
            ClassChatList.panelChats= panelArray;
        }
        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            panelChatBox.Size = new Size(tableLayoutPanel1.ClientSize.Width, tableLayoutPanel1.ClientSize.Height);            
            Methods.RoundPanelCorners(ref panelChatBox, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            this.Visible= false;

        }

        private void panelChatBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void AllPanel()
        {
            Panel[] panelArray = flowLayoutPanel1.Controls.OfType<Guna2GradientPanel>().ToArray();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void p()
        {
            Guna2Panel sendPanel=new Guna2Panel();
            Guna2Button btn13 = new Guna2Button();
            Guna2Button btn4 = new Guna2Button();
            Guna2Button btn3 = new Guna2Button();

            sendPanel.BackColor = System.Drawing.Color.Transparent;
            sendPanel.BorderRadius = 30;
            sendPanel.Controls.Add(btn13);
            sendPanel.Controls.Add(btn4);
            sendPanel.Controls.Add(btn3);
            sendPanel.FillColor = System.Drawing.Color.Indigo;
            sendPanel.ForeColor = System.Drawing.SystemColors.Info;
            sendPanel.Location = new System.Drawing.Point(510, 629);
            sendPanel.Margin = new System.Windows.Forms.Padding(4);
            sendPanel.Name = "sendPanel";
            sendPanel.Padding = new System.Windows.Forms.Padding(40, 6, 40, 6);
            sendPanel.Size = new System.Drawing.Size(868, 84);
            sendPanel.TabIndex = 2;



            btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn13.Dock = System.Windows.Forms.DockStyle.Right;     
            btn13.Location = new System.Drawing.Point(586, 6);
            btn13.Margin = new System.Windows.Forms.Padding(4);
            btn13.Name = "btn13";
            btn13.Size = new System.Drawing.Size(83, 72);
            btn13.TabIndex = 39;

            btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn4.Dock = System.Windows.Forms.DockStyle.Right;
            btn4.Location = new System.Drawing.Point(669, 6);
            btn4.Margin = new System.Windows.Forms.Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(83, 72);
            btn4.TabIndex = 38;
            // 
            // button3
            // 
            btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn3.Dock = System.Windows.Forms.DockStyle.Right;
            btn3.Location = new System.Drawing.Point(752, 6);
            btn3.Margin = new System.Windows.Forms.Padding(4);
            btn3.Name = "btn3";
            btn3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            btn3.Size = new System.Drawing.Size(76, 72);
            btn3.TabIndex = 37;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
                    }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sendPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == (char)Keys.Enter) 
                {
                    Panel panelSendContent = new Panel();
                    Guna2Panel panelText = new Guna2Panel();
                    CustomRoundPictureBox userProfilePic= new CustomRoundPictureBox();
                    Guna2HtmlLabel lblMessage = new Guna2HtmlLabel();

                    userProfilePic.BackgroundImage = global::media.Properties.Resources.PicsArt_09_0m7_09_40_49;
                    userProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    userProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
                    userProfilePic.BorderColor = System.Drawing.Color.White;
                    userProfilePic.BorderColor2 = System.Drawing.Color.White;
                    userProfilePic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    userProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    userProfilePic.BorderSize = 2;
                    userProfilePic.Dock = System.Windows.Forms.DockStyle.Right;
                    userProfilePic.GradientAngle = 50F;
                    userProfilePic.Location = new System.Drawing.Point(773, 0);
                    userProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    userProfilePic.Name = "userProfilePic";
                    userProfilePic.Size = new System.Drawing.Size(60, 60);
                    userProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    userProfilePic.TabIndex = 2;
                    userProfilePic.TabStop = false;

                    lblMessage.BackColor = System.Drawing.Color.Transparent;
                    lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblMessage.Location = new System.Drawing.Point(13, 11);
                    lblMessage.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
                    lblMessage.Name = "lblMessage";
                    lblMessage.Size = new System.Drawing.Size(68, 27);
                    lblMessage.TabIndex = 1;
                    lblMessage.Text = this.guna2TextBox1.Text;
                    lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    panelText.BorderColor = System.Drawing.Color.Purple;
                    panelText.BorderRadius = 10;
                    panelText.BorderThickness = 1;
                    panelText.Controls.Add(guna2HtmlLabel11);
                    panelText.CustomizableEdges.BottomRight = false;
                    panelText.Location = new System.Drawing.Point(625, 11);
                    panelText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    panelText.Name = "panelText";
                    panelText.Size = new System.Drawing.Size(143, 46);
                    panelText.TabIndex = 1;
                    panelText.Paint += new System.Windows.Forms.PaintEventHandler(panelText_Paint);

                    panelSendContent.BackColor = System.Drawing.Color.White;
                    panelSendContent.Controls.Add(userProfilePic);
                    panelSendContent.Controls.Add(panelText);
                    panelSendContent.Location = new System.Drawing.Point(30, 157);
                    panelSendContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
                    panelSendContent.Name = "panelSendContent";
                    panelSendContent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
                    panelSendContent.Size = new System.Drawing.Size(853, 60);
                    panelSendContent.TabIndex = 5;

                    this.panelChatBox.Controls.Add(panelSendContent);
                    this.guna2TextBox1.Text = "";
                panelChatBox.ScrollControlIntoView(panelSendContent);

            }
        }

        private void panelText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSendContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void IniTiateChatLists()
        {
            CustomRoundPictureBox contactProfilePic = new CustomRoundPictureBox();
            Guna2GradientPanel chatPanel = new Guna2GradientPanel();
            Label lastMessage = new Label();
            Label contactName = new Label();

            contactProfilePic.BackgroundImage = global::media.Properties.Resources.PicsArt_09_0m7_09_40_49;
            contactProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            contactProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            contactProfilePic.BorderColor = System.Drawing.Color.White;
            contactProfilePic.BorderColor2 = System.Drawing.Color.White;
            contactProfilePic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            contactProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            contactProfilePic.BorderSize = 2;
            contactProfilePic.Dock = System.Windows.Forms.DockStyle.Left;
            contactProfilePic.GradientAngle = 50F;
            contactProfilePic.Location = new System.Drawing.Point(0, 0);
            contactProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contactProfilePic.Name = "contactProfilePic";
            contactProfilePic.Size = new System.Drawing.Size(71, 74);
            contactProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            contactProfilePic.TabIndex = 3;
            contactProfilePic.TabStop = false;

            chatPanel.Controls.Add(contactProfilePic);
            chatPanel.Controls.Add(lastMessage);
            chatPanel.Controls.Add(contactName);
            chatPanel.FillColor = System.Drawing.Color.White;
            chatPanel.FillColor2 = System.Drawing.Color.White;
            chatPanel.Location = new System.Drawing.Point(3, 2);
            chatPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new System.Drawing.Size(409, 74);
            chatPanel.TabIndex = 0;

            lastMessage.AutoSize = true;
            lastMessage.BackColor = System.Drawing.Color.Transparent;
            lastMessage.Location = new System.Drawing.Point(77, 43);
            lastMessage.Name = "lastMessage";
            lastMessage.Size = new System.Drawing.Size(106, 16);
            lastMessage.TabIndex = 2;
            lastMessage.Text = ".....";
            // 
            // contactName
            // 
            contactName.AutoSize = true;
            contactName.BackColor = System.Drawing.Color.Transparent;
            contactName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactName.ForeColor = System.Drawing.Color.Black;
            contactName.Location = new System.Drawing.Point(77, 15);
            contactName.Name = "contactName";
            contactName.Size = new System.Drawing.Size(134, 25);
            contactName.TabIndex = 1;
            contactName.Text = "wAHID sHUVO";
            this.flowLayoutPanel3.Controls.Add(chatPanel);
        }
    }
}
