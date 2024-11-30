using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMPT291_Project
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();
            /*
            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=LAPTOP-6TEGHEN2;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=Project_291; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            */

            /*
            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=Kamil\\MSSQLSERVER03;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=project291; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            */


            // Initialize the connection
            /*
            myConnection = new SqlConnection("user id=Memoh;" + // Username
                                              "password=memoh4321;" + // Password
                                              "server=DESKTOP-H6FU9US\\MSSQLSERVER01;" + // Server name
                                              "TrustServerCertificate=True;" +
                                              "database=project291; " + // Database
                                              "connection timeout=30"); // Timeout in seconds
            */

            myConnection = new SqlConnection("user id=admin3;" + // Username
                                             "password=admin;" + // Password
                                             "server=DESKTOP-6QG008O;" + // Server name
                                             "TrustServerCertificate=True;" +
                                             "database=project291; " + // Database
                                             "connection timeout=30"); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open the connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get input from text fields
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            // Check if fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // SQL query to decrypt and check the password
                string query = @"
                    SELECT CASE 
                               WHEN CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('lemon', Password)) = @password 
                               THEN 1 ELSE 0 
                           END AS IsValid
                    FROM UsernamePassword
                    WHERE Username = @username";

                // Create SQL command
                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    // Execute query
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        // Login successful
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 homeScreen = new Form2();
                        homeScreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
