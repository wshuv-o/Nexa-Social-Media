using System;
using System.Drawing;
using System.Windows.Forms;
using media.Classes;

namespace media
{
    public partial class FormBase : Form
    {
        private Form activeForm = null;
        private Color defColor = Color.FromArgb(134, 27, 242);
        public Color myColor = Color.FromArgb(120, 24, 217);
        private User nativeUser;

        public User NativeUser
        {
            get { return nativeUser; }
            set { nativeUser = value; }
        }


        public FormBase(User nativeUser)
        {
            this.NativeUser = nativeUser;
            InitializeComponent();
            Methods.SetDoubleBuffer(panelSubMain, true);
            Methods.SetDoubleBuffer(panelSideMenu, true);


        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelSubMain.Controls.Add(childForm);
                panelSubMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelSubMain.Controls.Add(childForm);
                panelSubMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }




        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {
           Methods.RoundPanelCorners(ref panelSideMenu,20);

            
        }



        public void ExpandOnHover(Panel panel, int minWidth, int maxWidth)
        {
            
            panel.MinimumSize = new Size(minWidth, panel.Height);

            panel.MouseEnter += (sender, args) =>
            {
                panel.Width = maxWidth;
                Methods.RoundPanelCorners(ref panelSideMenu, 20);
            };

            panel.MouseLeave += (sender, args) =>
            {
                panel.Width = minWidth;
                Methods.RoundPanelCorners(ref panelSideMenu, 20);
            };
        }


        private void DefaultButtonColor(ref Button button)
        {
            buttonTwizzle.BackColor = defColor;
            buttonHome.BackColor = defColor;
            buttonSearch.BackColor = defColor;
            buttonSettings.BackColor = defColor;
            buttonMessages.BackColor = defColor;
            buttonCreate.BackColor = defColor;
            buttonNotification.BackColor = defColor;
            buttonMarketPlace.BackColor = defColor;
            buttonReels.BackColor = defColor;
            buttonTwizzle.BackColor = defColor;
            buttonGames.BackColor = defColor;

            button.BackColor = myColor;
        }

        private void buttonTwizzle_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonTwizzle);
            FormProfile profile = new FormProfile(this.NativeUser);
            MessageBox.Show(this.NativeUser.UserFirstName);
            Methods.OpenChildForm2(profile, panelSubMain);
            profile.Visible = true;
        }
        private void buttonReels_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonReels);
            FormStorySingle profile = new FormStorySingle();
            openChildForm(profile);
            profile.Visible = true;
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonSettings);
            FormSettings games = new FormSettings(out this.nativeUser, this.nativeUser);
            MessageBox.Show(this.NativeUser.UserFirstName);
            openChildForm(games);
            games.Visible = true;
        }



        private void buttonNotification_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonNotification);
            FormCall    games = new FormCall();
            openChildForm(games);
            games.Visible = true;
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonGames);
            GamesPage games= new GamesPage();   
            openChildForm(games);
            games.Visible= true;
        }

        public void buttonHome_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonHome);
            Home h= new Home(this.NativeUser);
            openChildForm(h);
            //h.Visible= true;
        }
        


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonCreate);
            FormCreate fc= new FormCreate(this.NativeUser);
            openChildForm(fc);
            fc.Visible = true;
            

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonSearch);
        }
        private void buttonMarketPlace_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonMarketPlace);
            FormMarketPlace c = new FormMarketPlace();
            openChildForm(c);
            c.Visible = true;
        }

        private void buttonMessages_Click(object sender, EventArgs e)
        {
            FormChat c=new FormChat(this.NativeUser);
            DefaultButtonColor(ref buttonMessages);
            openChildForm(c);
            c.Visible= true;
        }

        private void panelSubMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
