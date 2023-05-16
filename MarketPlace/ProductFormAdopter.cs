using media.Friends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media.MarketPlace
{
    internal class ProductFormAdopter
    {
        public System.Windows.Forms.Panel panelEachProduct;
        private System.Windows.Forms.Panel PanelEachProduct
        {
            get { return this.panelEachProduct; }
            set { this.panelEachProduct = value; }
        }
        public ProductFormAdopter(FormProduct fp)
        {

            panelEachProduct = new System.Windows.Forms.Panel();
            panelEachProduct.BackColor = System.Drawing.Color.White;
            panelEachProduct.Location = new System.Drawing.Point(10, 10);
            panelEachProduct.Name = "panelEachContact";
            panelEachProduct.Padding = new System.Windows.Forms.Padding(0);
            panelEachProduct.Size = new System.Drawing.Size(280, 400);
            panelEachProduct.TabIndex = 6;
            Methods.OpenChildForm2(fp, panelEachProduct);

        }
    }
}
