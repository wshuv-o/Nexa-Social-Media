using Aspose.Imaging.Xmp.Types.Basic;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Data;
using System.Windows.Forms;

namespace media.Page
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
            string query = "SELECT productId, productName, productPrice, productDescription, productRating, productSold, Quantiy FROM product WHERE page_id= "+ClassNativeUser.NativePage.PageId+" ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
            guna2TextBox4.Multiline = true;
            guna2TextBox4.WordWrap = true;

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox5.Text = "";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                guna2TextBox1.Text = selectedRow.Cells["productId"].Value.ToString();
                guna2TextBox2.Text = selectedRow.Cells["productName"].Value.ToString();
                guna2TextBox3.Text = selectedRow.Cells["productPrice"].Value.ToString();
                guna2TextBox4.Text = selectedRow.Cells["productDescription"].Value.ToString();
                guna2TextBox6.Text = selectedRow.Cells["productRating"].Value.ToString();
                guna2TextBox7.Text = selectedRow.Cells["productSold"].Value.ToString();
                guna2TextBox8.Text = selectedRow.Cells["quantiy"].Value.ToString();
            }
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {                
            MySqlConnection conn = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);

            try
            {

                string productId = guna2TextBox1.Text;
                string productName = guna2TextBox2.Text;
                int productPrice = Convert.ToInt32(guna2TextBox3.Text);
                string productDescription = guna2TextBox4.Text;
                int productSold = Convert.ToInt32(guna2TextBox7.Text);
                int quantity = Convert.ToInt32(guna2TextBox8.Text);


                string updateQuery = "UPDATE product SET productname=@name, productprice = @price, productDescription=@description, productsold = @sold,  quantiy=@quantity  WHERE productId = @productId";
                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@name", productName);
                    command.Parameters.AddWithValue("@price", productPrice);
                    command.Parameters.AddWithValue("@description", productDescription);
                    command.Parameters.AddWithValue("@sold", productSold);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@productId", productId);

                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {


                        MessageBox.Show("Product updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Product not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string productId = guna2TextBox1.Text;
            MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
            string deleteQuery = "DELETE FROM product WHERE productId = @productId";
            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@productId", productId);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Row deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }


        }

        private void FormInventory_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
            string searchKeyword = guna2TextBox5.Text;
            string searchQuery = "SELECT productId, productName, productPrice, productDescription, productRating, productSold, Quantiy FROM product WHERE productdescription LIKE @keyword OR productname LIKE @keyword AND page_id = "+ClassNativeUser.NativePage.PageId;
            using (MySqlCommand command = new MySqlCommand(searchQuery, connection))
            {
                command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
        }
    }
}
