using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace media
{
    public partial class FormPageSignUp : Form
    {
        public FormPageSignUp()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageSignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox2.Text.Equals(guna2TextBox3.Text)&& !string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                if (!string.IsNullOrEmpty(guna2TextBox1.Text) && !string.IsNullOrEmpty(guna2TextBox2.Text) && guna2ComboBox1.SelectedIndex != -1 && guna2ComboBox2.SelectedIndex != -1)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(DatabaseCredentials.connectionStringLocalServer))
                        {
                            connection.Open();

                            string query = "INSERT INTO pages (page_name, page_creation_date, page_email, page_password, page_type, page_address) " +
                                           "VALUES (@pageName, @pageCreationDate, @pageEmail, @pagePassword, @pageType, @pageaddress)";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@pageName", guna2TextBox1.Text);
                            command.Parameters.AddWithValue("@pageCreationDate", DateTime.Now);
                            command.Parameters.AddWithValue("@pageEmail", guna2TextBox4.Text);
                            command.Parameters.AddWithValue("@pagePassword", guna2TextBox3.Text);
                            command.Parameters.AddWithValue("@pageType", guna2ComboBox2.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@pageaddress", guna2ComboBox1.SelectedItem.ToString());

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Page created successfully!");
                                guna2GradientPanel1.Controls.Clear();
                                guna2GradientPanel1.BackgroundImage = global::media.Properties.Resources.party_popper;
                                Methods.OpenChildForm(new Nexa(), guna2CustomGradientPanel1);
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                { 
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Methods.OpenChildForm(new Nexa(), guna2CustomGradientPanel1);
        }
    }
}