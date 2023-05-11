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
        private Classes.User user= new User();
        private ClassChatList[] classChatList = new ClassChatList[20];
        private Guna2GradientPanel[] panelArray = new Guna2GradientPanel[20];
        public static int key = 0;

        Classes.User User
        {
            get { return user; }
            set { this.user = value; }
        }

        public FormChat(Classes.User user)
        {
            this.User= user;

            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            panelChatBox.Resize += (sender, e) =>
            {
                int availableWidth = panelChatBox.ClientSize.Width - panelChatBox.Padding.Left - panelChatBox.Padding.Right;
            };
            this.Visible= false;
            Methods.SetDoubleBuffer(panel2, true);
            Methods.SetDoubleBuffer(panel3, true);
            Methods.SetDoubleBuffer(panel4, true);




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
                int friendUserId = reader.GetInt32(0); 
                DBImageOperation dbio = new DBImageOperation();
                User chatPerson = dbio.GetUserByUserId(friendUserId);
                ClassChatList p = new ClassChatList(chatPerson);
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

        public void GetMessagesOfUser(int chatPersonId)
        {
            string connectionString = DatabaseCredentials.connectionStringLocalServer;

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string querySent = "SELECT * FROM message WHERE senderid = " + this.User.Key + " AND recieverid = " +chatPersonId+"";
            List<Classes.Message> sentMessages = GetMessages(conn, querySent);

            string queryReceived = "SELECT * FROM message WHERE senderid = " +chatPersonId+ " AND recieverid = "+ this.User.Key +"";
            List<Classes.Message> receivedMessages = GetMessages(conn, queryReceived);

            List<Classes.Message> mergedMessages = new List<Classes.Message>();
            mergedMessages.AddRange(sentMessages);
            mergedMessages.AddRange(receivedMessages);
            mergedMessages.Sort((m1, m2) => DateTime.Compare(m1.SendTime, m2.SendTime));

            DBImageOperation dbio = new DBImageOperation();
            User chatPerson = dbio.GetUserByUserId(chatPersonId);
            

            foreach (Classes.Message message in mergedMessages)
            {
                if (sentMessages.Contains(message))
                {
                    InitiateOldChatSent(message);
                }
                else
                {
                    InitiateOldChatRecieved(chatPerson, message);
                }
            }

            conn.Close();

        }

        private static List<Classes.Message> GetMessages(MySqlConnection connection, string query)
        {
            List<Classes.Message> messages = new List<Classes.Message>();

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int messageId = Convert.ToInt32(reader["messageid"]);
                string messageText = reader["messagetext"].ToString();
                DateTime sendTime = Convert.ToDateTime(reader["messageTime"]);
                int senderId = Convert.ToInt32(reader["senderid"]);
                int receiverId = Convert.ToInt32(reader["recieverid"]);

            Classes.Message message = new Classes.Message(messageId, messageText, sendTime, senderId, receiverId);
                messages.Add(message);
            }

            reader.Close();
            return messages;
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            panelChatBox.Size = new Size(tableLayoutPanel1.ClientSize.Width, tableLayoutPanel1.ClientSize.Height);            
            Methods.RoundPanelCorners(ref panelChatBox, 20);
        }



/*        void p()
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
*/



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
                lblMessage.ForeColor= System.Drawing.Color.Black;
                lblMessage.Size = new System.Drawing.Size(68, 27);
                lblMessage.TabIndex = 1;
                lblMessage.Text = this.guna2TextBox1.Text;
                lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                panelText.BorderColor = System.Drawing.Color.Purple;
                panelText.BorderRadius = 10;
                panelText.BorderThickness = 1;
                panelText.CustomizableEdges.BottomRight = false;
                panelText.Location = new System.Drawing.Point(500, 11);
                panelText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                panelText.Name = "panelText";
                panelText.Size = new System.Drawing.Size(270, 46);
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

/*                    lblMessage.AutoSize = true;
                lblMessage.MaximumSize = new Size(panelText.Width, 40);
                panelText.Size = new Size(panelText.Width, lblMessage.Height+100);
                panelSendContent.Size = new Size(panelSendContent.Width, panelText.Height);
                lblMessage.MaximumSize = new Size(lblMessage.Width, 40); 
                lblMessage.AutoSize = false;
                lblMessage.Dock = DockStyle.Fill;
                lblMessage.MaximumSize = new Size(panelText.Width, 40);

*/                //lblMessage.TextImageRelation = TextImageRelation.Overlay;

            this.panelChatBox.Controls.Add(panelSendContent);
                this.guna2TextBox1.Text = "";
                panelChatBox.ScrollControlIntoView(panelSendContent);


            }
        }
        public void InitiateOldChatSent(Classes.Message message)
        {
            Panel panelSendContent = new Panel();
            Guna2Panel panelText = new Guna2Panel();
            CustomRoundPictureBox userProfilePic = new CustomRoundPictureBox();
            Guna2HtmlLabel lblMessage = new Guna2HtmlLabel();
            if(this.User.ProfilePhoto!=null) userProfilePic.BackgroundImage = this.User.ProfilePhoto;

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
            lblMessage.ForeColor = System.Drawing.Color.Black;
            lblMessage.Size = new System.Drawing.Size(68, 27);
            lblMessage.TabIndex = 1;
            lblMessage.Text = message.MessageText;
            lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            panelText.BorderColor = System.Drawing.Color.Purple;
            panelText.BorderRadius = 10;
            panelText.BorderThickness = 1;
            panelText.CustomizableEdges.BottomRight = false;
            panelText.Location = new System.Drawing.Point(500, 11);
            panelText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panelText.Name = "panelText";
            panelText.Size = new System.Drawing.Size(270, 46);
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

            /*                    lblMessage.AutoSize = true;
                                lblMessage.MaximumSize = new Size(panelText.Width, 40);
                                panelText.Size = new Size(panelText.Width, lblMessage.Height+100);
                                panelSendContent.Size = new Size(panelSendContent.Width, panelText.Height);
                                lblMessage.MaximumSize = new Size(lblMessage.Width, 40); 
                                lblMessage.AutoSize = false;
                                lblMessage.Dock = DockStyle.Fill;
                                lblMessage.MaximumSize = new Size(panelText.Width, 40);

            */                //lblMessage.TextImageRelation = TextImageRelation.Overlay;

            this.panelChatBox.Controls.Add(panelSendContent);
            this.guna2TextBox1.Text = "";
            panelChatBox.ScrollControlIntoView(panelSendContent);

        }

        public void InitiateOldChatRecieved(Classes.User chatPerson, Classes.Message message)
        {
            Panel panelSendContent = new Panel();
            Guna2Panel panelText = new Guna2Panel();
            CustomRoundPictureBox userProfilePic = new CustomRoundPictureBox();
            Guna2HtmlLabel lblMessage = new Guna2HtmlLabel();

            if (chatPerson.ProfilePhoto != null) userProfilePic.BackgroundImage = chatPerson.ProfilePhoto;

            userProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            userProfilePic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            userProfilePic.BorderColor = System.Drawing.Color.White;
            userProfilePic.BorderColor2 = System.Drawing.Color.White;
            userProfilePic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            userProfilePic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            userProfilePic.BorderSize = 2;
            userProfilePic.Dock = System.Windows.Forms.DockStyle.Left;
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
            lblMessage.ForeColor = System.Drawing.Color.Black;
            lblMessage.Size = new System.Drawing.Size(68, 27);
            lblMessage.TabIndex = 1;
            lblMessage.Text = message.MessageText;
            lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            panelText.BorderColor = System.Drawing.Color.Purple;
            panelText.BorderRadius = 10;
            panelText.BorderThickness = 1;
            panelText.CustomizableEdges.BottomLeft = false;
            panelText.Location = new System.Drawing.Point(20, 11);
            panelText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panelText.Name = "panelText";
            panelText.Size = new System.Drawing.Size(270, 46);
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

            /*                    lblMessage.AutoSize = true;
                                lblMessage.MaximumSize = new Size(panelText.Width, 40);
                                panelText.Size = new Size(panelText.Width, lblMessage.Height+100);
                                panelSendContent.Size = new Size(panelSendContent.Width, panelText.Height);
                                lblMessage.MaximumSize = new Size(lblMessage.Width, 40); 
                                lblMessage.AutoSize = false;
                                lblMessage.Dock = DockStyle.Fill;
                                lblMessage.MaximumSize = new Size(panelText.Width, 40);

            */                //lblMessage.TextImageRelation = TextImageRelation.Overlay;

            this.panelChatBox.Controls.Add(panelSendContent);
            this.guna2TextBox1.Text = "";
            panelChatBox.ScrollControlIntoView(panelSendContent);

        }


        public class ClassChatList
        {
            private CustomRoundPictureBox contactProfilePic = new CustomRoundPictureBox();
            private Guna2GradientPanel chatPanel = new Guna2GradientPanel();
            private System.Windows.Forms.Label lastMessage = new System.Windows.Forms.Label();
            private System.Windows.Forms.Label contactName = new System.Windows.Forms.Label();
            public static Guna2GradientPanel[] panelChats = new Guna2GradientPanel[20];
            private Classes.User user = new Classes.User();
            private Label lblKey = new Label();
            private int chatPersonKey;


            public Guna2GradientPanel ChatPanel
            {
                get { return chatPanel; }
                set { chatPanel = value; }
            }


            Classes.User User
            {
                get { return user; }
                set { user = value; }
            }

            public int ChatPersonKey
            {
                get; set;
            }


            public ClassChatList(Classes.User user)
            {
                this.User = user;
                if (this.User.ProfilePhoto != null)
                {
                    contactProfilePic.BackgroundImage = this.User.ProfilePhoto;
                }
                lblKey.Text = this.User.Key.ToString();
                lblKey.Visible= false;
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
                contactProfilePic.Click += new System.EventHandler(this.FocusOnChat);

                chatPanel.Controls.Add(contactProfilePic);
                chatPanel.Controls.Add(lastMessage);
                chatPanel.Controls.Add(contactName);
                chatPanel.Controls.Add(lblKey);
                chatPanel.FillColor = System.Drawing.Color.White;
                chatPanel.FillColor2 = System.Drawing.Color.White;
                chatPanel.Location = new System.Drawing.Point(3, 2);
                chatPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                chatPanel.Name = "chatPanel";
                chatPanel.Size = new System.Drawing.Size(409, 74);
                chatPanel.TabIndex = 0;
                chatPanel.Click += new System.EventHandler(this.FocusOnChat);

                lastMessage.AutoSize = true;
                lastMessage.BackColor = System.Drawing.Color.Transparent;
                lastMessage.Location = new System.Drawing.Point(77, 43);
                lastMessage.Name = "lastMessage";
                lastMessage.Size = new System.Drawing.Size(106, 16);
                lastMessage.TabIndex = 2;
                lastMessage.Text = ".....";
                lastMessage.Click += new System.EventHandler(this.FocusOnChat);

                contactName.AutoSize = true;
                contactName.BackColor = System.Drawing.Color.Transparent;
                contactName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                contactName.ForeColor = System.Drawing.Color.Black;
                contactName.Location = new System.Drawing.Point(77, 15);
                contactName.Name = "contactName";
                contactName.Size = new System.Drawing.Size(134, 25);
                contactName.Click += new System.EventHandler(this.FocusOnChat);
                contactName.TabIndex = 1;
                contactName.Text = user.UserFirstName + " " + user.UserLastName;

            }


/*            public void FocusOnChat(object sender, EventArgs e)
            {

                foreach (Guna2GradientPanel panel in panelChats)
                {
                    panel.FillColor = System.Drawing.Color.White; // Set the desired background color
                    panel.FillColor2 = System.Drawing.Color.White; // Set the desired background color
                }
                this.chatPanel.FillColor = System.Drawing.Color.Pink;
                this.chatPanel.FillColor2 = System.Drawing.Color.HotPink;

                int chatPersonId = 35; // Example value
               // guna2TextBox1_TextChanged(sender, e);

            }*/
            private void FocusOnChat(object sender, EventArgs e)
            {
                foreach (Guna2GradientPanel panel in panelChats)
                {
                    panel.FillColor = System.Drawing.Color.White; // Set the desired background color
                    panel.FillColor2 = System.Drawing.Color.White; // Set the desired background color
                }
                this.chatPanel.FillColor = System.Drawing.Color.Pink;
                this.chatPanel.FillColor2 = System.Drawing.Color.HotPink;

                //MessageBox.Show(lblKey.Text);
                ChatPersonKey = Convert.ToInt32(lblKey.Text);
                if (ChatPersonKey != null)
                {
                    //MessageBox.Show(ChatPersonKey.ToString());
                    // parent.InvokeGetMessagesOfUser(ChatPersonKey);
                    FormChat.key = ChatPersonKey;
                    FormChat.FormChat_Load(sender, e);
                }
            }

        }

        private void panelSendContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            this.panelChatBox_Paint_1(sender, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void FormChat_Load(object sender, EventArgs e)
        {
            //this.Visible= false;
            label9.Text = FormChat.key.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void panelText_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelChatBox_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
