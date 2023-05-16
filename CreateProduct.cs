using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace media
{
    public partial class CreateProduct : Form
    {
        private Classes.Page nativePage;
        private System.Drawing.Image productImage; 

        public Classes.Page NativePage
        {
            get { return nativePage; }
            set { nativePage = value; }
        }
        public CreateProduct(Classes.Page nativePage)
        {
            this.NativePage=nativePage;

            InitializeComponent();
            Methods.SetDoubleBuffer(this.guna2CustomGradientPanel1, true);
            Methods.SetDoubleBuffer(this.guna2Panel1, true);
            Methods.SetDoubleBuffer(this.guna2Panel2, true);
            Methods.SetDoubleBuffer(this.guna2Panel3, true);
            Methods.SetDoubleBuffer(this.guna2Panel4, true);
            label10.Text = NativePage.PageName;
            customRoundPictureBox1.Image = NativePage.PageProfileImage;

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {


        }



        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void FormProductSingle_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
              guna2TextBox1.Text= this.label6.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {
             this.label8.Text= this.guna2TextBox2.Text;
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label7.Text=this.guna2ComboBox2.SelectedItem.ToString();
        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {
            this.label3.Text = guna2TextBox4.Text;
            label1.AutoSize = false;
            int desiredWidth = 250;

            // Calculate the size required for the wrapped text
            System.Drawing.Size textSize = TextRenderer.MeasureText(label3.Text, label3.Font, new System.Drawing.Size(desiredWidth, int.MaxValue), TextFormatFlags.WordBreak);

            // Set the size of the label
            label1.Size = new System.Drawing.Size(desiredWidth, textSize.Height);

            guna2TextBox4.Multiline = true;
            guna2TextBox4.WordWrap = true;
        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {
            this.label22.Text= this.guna2TextBox1.Text;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                DBImageOperation dbio = new DBImageOperation();
                this.InsertProduct(label22.Text, Convert.ToInt32(label8.Text), label3.Text, dbio.ImageToByteArray(productImage), this.NativePage.PageId);
            }
            catch
            {
                MessageBox.Show("Error uploading the image");
            }
        }

        public void InsertProduct(string productName, int productPrice, string productDescription, byte[] productImage, int pageId)
        {
            using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO `product` (`productName`, `productPrice`, `productDescription`, `productImage`, `page_id`) " +
                                   "VALUES (@productName, @productPrice, @productDescription, @productImage, @pageId)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", productPrice);
                    command.Parameters.AddWithValue("@productDescription", productDescription);
                    command.Parameters.AddWithValue("@productImage", productImage);
                    command.Parameters.AddWithValue("@pageId", pageId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product data inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert product data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            productImage = ImageCompress.SelectAndCompressImage();
            this.pictureBox1.Image = productImage;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}