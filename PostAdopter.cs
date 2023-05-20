using Guna.UI2.WinForms;
using System.Drawing;


namespace media
{
    internal class PostAdopter
    {
        public Guna2Panel panelBase;
        public Guna2Panel panelChild;
        public Post a;
        public FormPost b;
        public Post A
        {
            get { return a; }
            set { a = value; }
        }
        public PostAdopter(media.Classes.ClassPost classPosts)
        {
            if(classPosts.PostImage != null) 
            {
                a = new Post(classPosts);
                panelBase = new Guna2Panel();
                panelChild = new Guna2Panel();

                panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                panelBase.BackColor = System.Drawing.Color.White;
                panelBase.Controls.Add(panelChild);
                panelBase.Location = new System.Drawing.Point(10, 347);
                panelBase.Name = "panelBase";
                panelBase.Padding = new System.Windows.Forms.Padding(50, -10, 50, 0);
                panelBase.Size = new System.Drawing.Size(866, 850);
                panelBase.TabIndex = 1;

                panelChild.BackColor = System.Drawing.Color.White;
                panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
                panelChild.Location = new System.Drawing.Point(10, 0);
                panelChild.Name = "panelChild";
                panelChild.Size = new System.Drawing.Size(766, 600);
                panelChild.TabIndex = 0;
                panelChild.BorderColor = Color.Red;
                panelChild.BorderThickness = 1;
                panelChild.BorderRadius = 20;
                //panelChild.BackColor = Color.White;

                /*panelBase.Width = 866;
                panelBase.Height = 800;

                panelChild.Height = 800;
                panelChild.Width = 766;
                panelChild.Height = 800;*/

                Methods.OpenChildForm(a, panelChild);

                //parentPanel.Controls.Add(panelBase);
            }
            else
            {
                b = new FormPost(classPosts);
                panelBase = new Guna2Panel();
                panelChild = new Guna2Panel();

                panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                panelBase.BackColor = System.Drawing.Color.WhiteSmoke;
                panelBase.Controls.Add(panelChild);
                panelBase.Location = new System.Drawing.Point(43, 347);
                panelBase.Name = "panelBase";
                panelBase.Padding = new System.Windows.Forms.Padding(50, -10, 50, 0);
                panelBase.Size = new System.Drawing.Size(866, 850);
                panelBase.TabIndex = 1;

                panelChild.BackColor = System.Drawing.Color.White;
                panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
                panelChild.Location = new System.Drawing.Point(50, 0);
                panelChild.Name = "panelChild";
                panelChild.Size = new System.Drawing.Size(766, 600);
                panelChild.TabIndex = 0;
                panelChild.BorderColor = Color.Red;
                panelChild.BorderThickness = 1;
                panelChild.BorderRadius = 20;
                //panelChild.BackColor = Color.White;

                /*panelBase.Width = 866;
                panelBase.Height = 800;

                panelChild.Height = 800;
                panelChild.Width = 766;
                panelChild.Height = 800;*/

                Methods.OpenChildForm(b, panelChild);

                //parentPanel.Controls.Add(panelBase);
            }



        }
    }
}
