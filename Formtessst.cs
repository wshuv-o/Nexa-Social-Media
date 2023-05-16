using System;
using System.Runtime.CompilerServices;
using System.Web.Services.Description;
using System.Windows.Forms;
using media.Classes;
using MySql.Data.MySqlClient;

namespace media
{
    public partial class Formtessst : Form
    {
        public Formtessst() {
            // Connection string
            InitializeComponent();
            

            //Console.ReadLine();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=hopeful-shape-79805.pktriot.net;database=nexaa;user=root;port = 3306;password=";
            // SQL query
            string query = "SELECT * FROM user";

            // Create a connection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any rows were returned
                            if (reader.HasRows)
                            {
                                // Iterate over the rows and retrieve data
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32("userid");
                                    string name = reader.GetString("userfirstname");
                                    // Retrieve other columns as needed
                                    this.label2.Text = name;

                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
    
}
