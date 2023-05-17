using media.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.MarketPlace
{
    public partial class FormProduct : Form
    {
        private ClassProduct classProducts;
        public ClassProduct ClassProducts
        {
            get { return this.classProducts; }
            set { this.classProducts = value; }
        }

        public FormProduct(ClassProduct classproduct)
        {

            this.ClassProducts= classproduct;
            InitializeComponent();
            this.lblPrice.Text=classproduct.ProductPrice.ToString();
            this.lblProductName.Text=classproduct.ProductName.ToString();
            this.lblProductDesc.Text=classproduct.ProductDescription.ToString();
            this.btnProductRating.Text=classproduct.ProductRating.ToString();
            this.productSold.Text=classproduct.ProductSold.ToString();
            this.productImage.Image = classproduct.ProductImage;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Click(object sender, EventArgs e)
        {
            SingleProduct p= new SingleProduct();
            p.Show();

        }
    }
}
