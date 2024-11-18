using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMPT291_Project
{
    public partial class Form1 : Form
    {
        /*
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        */
        public Form1()
        {

            InitializeComponent();
            /*
            ///////////////////////////////
            operation.Items.Clear();
            operation.Items.Add("Show all");
            operation.Items.Add("Show with starting grade: ");
            //////////////////////////////////
            ///
            String connectionString = "Server = LAPTOP-6TEGHEN2; Database = ConnectTutorial; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            */
            //String connectionString = "Server = LAPTOP-6TEGHEN2; Database = ConnectTutorial; Trusted_Connection = yes;";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             if (username in database AND password = database.password)
                login --> show homescreen
            */
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            int loginCheck = 0;
            
            while (loginCheck == 0)
            {
                //loginButton.Enabled = false;
                /*
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    loginButton.Enabled = false;
                }
                */
                if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
                {
                    loginButton.Enabled = true;
                    Form2 homeScreen = new Form2();
                    homeScreen.Show();
                    loginCheck = 1;
                }

                /*
                if (loginButton.Enabled)
                {
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        loginButton.Enabled = false;
                    }
                    else if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
                    {
                        loginButton.Enabled = true;
                        Form2 homeScreen = new Form2();
                        homeScreen.Show();
                        break;
                    }
                }
                */
            }
                    
                
                /*
                else
                {
                    loginButton.Enabled = true;
                    Form2 homeScreen = new Form2();
                    homeScreen.Show();
                }
                */
                    
            
            /*

            if (string.IsNullOrEmpty(usernameInput.Text) || string.IsNullOrEmpty(passwordInput.Text))
            {

                Form2 homeScreen = new Form2();
                homeScreen.Show();
            }
            else if (string.IsNullOrEmpty(usernameInput.Text) && string.IsNullOrEmpty(passwordInput.Text))
            {
                loginButton.Enabled = false;
            }
            */
 
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
