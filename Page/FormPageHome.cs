using System;
using System.Drawing;
using System.Windows.Forms;
using media.Classes;

namespace media.Page
{
    public partial class FormPageHome : Form
    {
        private Form activeForm = null;
        private Color defColor = Color.RoyalBlue;
        public Color myColor = Color.FromArgb(65, 90, 180);
        private Classes.Page nativePage;

        public Classes.Page NativePage
        {
            get { return nativePage; }
            set { nativePage = value; }
        }


        public FormPageHome(Classes.Page page)
        {
            this.NativePage = page;
            InitializeComponent();
            Methods.SetDoubleBuffer(panelSubMain, true);


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
            Methods.RoundPanelCorners(ref panelSideMenu, 20);


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
            buttonSettings.BackColor = defColor;
            buttonMessages.BackColor = defColor;
            buttonCreate.BackColor = defColor;
            buttonNotification.BackColor = defColor;
            buttonMarketPlace.BackColor = defColor;
            buttonCreateProduct.BackColor = defColor;
            buttonTwizzle.BackColor = defColor;
            buttonStatistics.BackColor = defColor;

            button.BackColor = myColor;
        }

        private void buttonTwizzle_Click(object sender, EventArgs e)
        {
/*            DefaultButtonColor(ref buttonTwizzle);
            FormProfile profile = new FormProfile(this.NativePage);
            MessageBox.Show(this.NativePage.PageName);
            openChildForm(profile);
            profile.Visible = true;*/
        }
        private void buttonReels_Click(object sender, EventArgs e)
        {

        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonSettings);
            FormSettings games = new FormSettings(this.NativePage);
            MessageBox.Show(this.NativePage.PageName);
            openChildForm(games);
            games.Visible = true;
        }



        private void buttonNotification_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonNotification);
            FormCall games = new FormCall();
            openChildForm(games);
            games.Visible = true;
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonStatistics);
            MarketPlaceStats games = new MarketPlaceStats();
            openChildForm(games);
            games.Visible = true;
        }

        public void buttonHome_Click(object sender, EventArgs e)
        {
/*            DefaultButtonColor(ref buttonHome);
            Home h = new Home(this.NativePage);
            openChildForm(h);
            //h.Visible= true;*/
        }



        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonCreate);
            FormCreate fc = new FormCreate(this.NativePage);
            openChildForm(fc);
            fc.Visible = true;


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
            FormChat c = new FormChat(this.NativePage);
            DefaultButtonColor(ref buttonMessages);
            openChildForm(c);
            c.Visible = true;
        }

        private void panelSubMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonCreateProduct);
            CreateProduct profile = new CreateProduct(this.nativePage);
            openChildForm(profile);
            profile.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefaultButtonColor(ref buttonCreateProduct);
            FormInventory profile = new FormInventory();//FormInventory
            openChildForm(profile);
            profile.Visible = true;
        }
    }
}
