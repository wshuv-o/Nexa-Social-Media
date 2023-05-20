using media.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.Friends
{
    public partial class FriendRequestForm : Form
    {
        private Classes.User nativeUser;
        private ClassFriendRequest classFriendRequests;
        public ClassFriendRequest ClassFriendRequests
        {
            get { return this.classFriendRequests; }
            set { this.classFriendRequests = value; }
        }

        public Classes.User NativeUser
        {
            get { return nativeUser; }
            set { this.nativeUser = value; }
        }

        public FriendRequestForm(ClassFriendRequest classFriendRequest)
        {
            this.ClassFriendRequests= classFriendRequest;
            InitializeComponent();
            this.frProfileName.Text = classFriendRequest.RequesterProfile.UserFirstName + " " + classFriendRequest.RequesterProfile.UserLastName;
            this.frProfileImage.Image = classFriendRequest.RequesterProfile.ProfilePhoto;
        }

        private void FriendRequestPanel_Load(object sender, EventArgs e)
        {

        }
        public class ClassFriendRequest
        {
            private int requestId;
            private int requestToUserId;
            private int requestFromUserId;
            private int requestStatus;
            User requesterProfile;
            public int RequestId
            {
                get { return this.requestId; }
                set { this.requestId = value; }
            }           
            public int RequestToUserId
            {
                get { return this.requestToUserId; }
                set { this.requestToUserId = value; }
            }
            public int RequestFromUserId
            {
                get { return this.requestFromUserId; }
                set { this.requestFromUserId = value; }
            }
            public int RequestStatus
            {
                get { return this.requestStatus; }
                set { this.requestStatus = value; }
            }
            public User RequesterProfile
            {
                get { return this.requesterProfile; }
                set { this.requesterProfile = value;}
            }
            public ClassFriendRequest(int requestId, int requestToUserId,  int requestFromUserId, int requestStatus, User requesterProfile)
            {
                this.RequestId = requestId;
                this.RequestToUserId= requestToUserId;
                this.RequestFromUserId= requestFromUserId;
                this.RequestStatus= requestStatus;
                this.RequesterProfile = requesterProfile;
           }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.btnAccept.Text = "Accepted";
            this.btnAccept.Enabled = false;
            this.btnDecline.Enabled = false;
            MessageBox.Show("Congratulations! You are now friends!");

            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM friendrequest WHERE requestid = @RequestId";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@RequestId", this.ClassFriendRequests.RequestId);
                    deleteCommand.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO friends (nativeUserId, FriendUserId) VALUES (@NativeUserId, @FriendUserId)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@NativeUserId", ClassFriendRequests.RequestToUserId);
                    insertCommand.Parameters.AddWithValue("@FriendUserId", ClassFriendRequests.RequestFromUserId);
                    insertCommand.ExecuteNonQuery();
                }
            }

        }
        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDecline.Enabled)
            {
                // Button is enabled
                //button1.BackColor = Color.Green;
            }
            else
            {
                // Button is disabled
                btnDecline.FillColor = Color.Red;
            }
        }

        private void frProfileImage_Click(object sender, EventArgs e)
        {
            
             Methods.OpenChildForm2(new FormProfile(this.ClassFriendRequests.RequesterProfile), FormBase.panelSubMain);
            
        }

        private void frProfileName_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm2(new FormProfile(this.ClassFriendRequests.RequesterProfile), FormBase.panelSubMain);
        }
    }
}
