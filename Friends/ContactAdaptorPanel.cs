using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.Friends
{
    internal class ContactAdaptorPanel
    {
        public System.Windows.Forms.Panel panelEachContact;
        private System.Windows.Forms.Panel PanelEachContact
        {
            get { return this.panelEachContact; }
            set { this.panelEachContact = value; }
        }
        public ContactAdaptorPanel(FormContactList fcl)
        {
            panelEachContact = new System.Windows.Forms.Panel();
            panelEachContact.BackColor = System.Drawing.Color.White;
            panelEachContact.Location = new System.Drawing.Point(0, 87);
            panelEachContact.Name = "panelEachContact";
            panelEachContact.Padding = new System.Windows.Forms.Padding(10);
            panelEachContact.Size = new System.Drawing.Size(350, 80);
            panelEachContact.TabIndex = 6;
            Methods.OpenChildForm2(fcl, panelEachContact);
        }
    }
}
