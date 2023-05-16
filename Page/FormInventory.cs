using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.Page
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer);
            string query = "SELECT productId, productName, productPrice, productDescription, productRating, productSold, Quantiy FROM product";
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
                // Retrieve the selected row
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                // Extract the cell values and populate the text fields
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
    }
}
