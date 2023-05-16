using media.Classes;
using media.Friends;
using media.MarketPlace;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static media.Friends.FriendRequestForm;

namespace media
{
    public partial class FormMarketPlace : Form
    {
        List<ClassProduct> classProductLists = new List<ClassProduct>();
        List<FormProduct> formProducts = new List<FormProduct>();
        List<ProductFormAdopter> productFormAdopters = new List<ProductFormAdopter>();
        public FormMarketPlace()
        {
            InitializeComponent();
            SetDoubleBuffer(guna2GradientPanel1, true);

            //this.DisplayImageFromDatabase(202);
        }
        private async void SetImage()
        {
            /*WebClient wc = new WebClient();
            byte[] bytes = null;

            try
            {
                Uri u = new Uri("https://wshuv-o.github.io/100506316.jpeg");
                bytes = await wc.DownloadDataTaskAsync(u);

                Image img;
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    img = Image.FromStream(ms);
                }

                this.guna2PictureBox1.Image = img;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error downloading image: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error creating image: " + ex.Message);
            }*/
            
        }
        private void DisplayImageFromDatabase(int productId)
        {
            string connectionString = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT productimage FROM product WHERE productid = @ProductId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["productimage"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image img = Image.FromStream(ms);
                                //guna2PictureBox1.Image = img;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving image from database: " + ex.Message);
            }
        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, ctl, new object[] { DoubleBuffered });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetImage();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FormMarketPlace_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
            connection.Open();
            string queryx = "SELECT productid, productName, productPrice, productdescription, productRating, productSold, page_id FROM product ";
            MySqlCommand commandx = new MySqlCommand(queryx, connection);
            MySqlDataReader readerx = commandx.ExecuteReader();
            DBImageOperation dbio = new DBImageOperation();
            while (readerx.Read())
            {
                int productId = readerx.GetInt32("productid");
                string productName = readerx.GetString("productName");
                int productPrice = readerx.GetInt32("productPrice");
                string productDescription = readerx.GetString("productdescription");
                double productRating = readerx.GetDouble("productRating");
                int productSold = readerx.GetInt32("productSold");
                int page_id = readerx.GetInt32("page_id");

                Image productImage = dbio.LoadProductImageFromDataBase(productId);
                ClassProduct cp = new ClassProduct(productId, productName, productDescription, productPrice, productImage, productRating, productSold, page_id);
                classProductLists.Add(cp);
                MessageBox.Show(classProductLists.Count.ToString());

            }
            readerx.Close();
            connection.Close();
            for (int i = 0; i < classProductLists.Count; i++)
            {

                formProducts.Add(new MarketPlace.FormProduct(classProductLists[i]));
                productFormAdopters.Add(new ProductFormAdopter(formProducts[i]));
                //Methods.OpenChildForm(friendRequestForms[i], friendRequestAdopter[i].panelEachContact);
                this.productPanel.Controls.Add(productFormAdopters[i].panelEachProduct);


            }
        }
    }
}