using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    internal class ClassPost
    {
        public Guna2Panel panelBase;
        public Guna2Panel panelChild;
        public Post a;
        public Post A
        {
            get { return a; }
            set { a = value; }
        }
        public ClassPost()
        {
            /*this.A = new Post();
            panelBase = new Guna2Panel();
            panelChild = new Guna2Panel();


            panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            panelBase.BackColor = System.Drawing.Color.WhiteSmoke;
            panelBase.Controls.Add(panelChild);
            panelBase.Location = new System.Drawing.Point(43, 347);
            panelBase.Name = "panel1";
            panelBase.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            panelBase.Size = new System.Drawing.Size(866, 850);
            panelBase.TabIndex = 1;
            //panelBase.Paint += new System.Windows.Forms.PaintEventHandler(panelBase_Paint);
            // 
            // panel2
            // 
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
            //panelChild.Paint += new System.Windows.Forms.PaintEventHandler(panelChild_Paint_1);
           // panelChild.MouseEnter += new System.EventHandler(panelChild_MouseEnter);
           // panelChild.MouseLeave += new System.EventHandler(panelChild_MouseLeave);

            
            Methods.OpenChildForm(this.A, panelChild);

            // panelBase.Height = a.basePanel.Height;
            // panelBase.Width = 866;
            //panelChild.Height = a.basePanel.Height;
            //panelChild.Width = 766;
            //panelChild.Height = a.Height;
            *///panelFeed.Controls.Add(panelBase);


            a= new Post();
                panelBase = new Guna2Panel();
                panelChild = new Guna2Panel();

                panelBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                panelBase.BackColor = System.Drawing.Color.WhiteSmoke;
                panelBase.Controls.Add(panelChild);
                panelBase.Location = new System.Drawing.Point(43, 347);
                panelBase.Name = "panel1";
                panelBase.Padding = new System.Windows.Forms.Padding(50, -10, 50, 0);
                panelBase.Size = new System.Drawing.Size(866, 850);
                panelBase.TabIndex = 1;

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

                Methods.OpenChildForm(a, panelChild);

                //parentPanel.Controls.Add(panelBase);
            

        }
    }
}
