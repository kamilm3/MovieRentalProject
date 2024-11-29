﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMPT291_Project
{
    public partial class Form2 : Form

    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        private DataTable dt;
        private SqlDataAdapter sd;


        public Form2()
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

            /*
            // Initialize the connection
            myConnection = new SqlConnection("user id=Memoh;" + // Username
                                              "password=memoh4321;" + // Password
                                              "server=DESKTOP-H6FU9US\\MSSQLSERVER01;" + // Server name
                                              "TrustServerCertificate=True;" +
                                              "database=project291; " + // Database
                                              "connection timeout=30"); // Timeout in seconds
            */

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


        // *********************************
        //     Customer Management Tab
        // *********************************
        private void NewCustButtonClick(object sender, EventArgs e)
        {
            ModifyCustBox.Visible = false;
            ModifyCustDataView.Visible = false;
            FirstNameSearchLabel.Visible = false;
            FirstNameSearchText.Visible = false;
            LastNameSearchLabel.Visible = false;
            LastNameSearchText.Visible = false;
            EmailSearchLabel.Visible = false;
            EmailSearchText.Visible = false;
            CustSearchButton.Visible = false;
            AddCustBox.Visible = true;
        }

        private void ModifyCustButtonClick(object sender, EventArgs e)
        {
            AddCustBox.Visible = false;
            FirstNameSearchLabel.Visible = true;
            FirstNameSearchText.Visible = true;
            LastNameSearchLabel.Visible = true;
            LastNameSearchText.Visible = true;
            EmailSearchLabel.Visible = true;
            EmailSearchText.Visible = true;
            CustSearchButton.Visible = true;
        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameCustText.Text.Trim();
            string lastName = LastNameCustText.Text.Trim();
            string city = CityCustText.Text.Trim();
            string email = EmailCustText.Text.Trim();
            string state = StateCustComboBox?.SelectedItem?.ToString();
            string address = AddressCustText.Text.Trim();
            string zip = ZipCustText.Text.Trim();
            string accountNumber = AccountCustText.Text.Trim();
            string creditCard = CreditCustText.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zip) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(creditCard))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Add customer
                string query = "INSERT INTO Customer (firstName, lastName, cusAddress, cusCity, cusState, cusZipCode, Email, AccountNumber, CreditCard) " +
                               "VALUES (@FirstName, @LastName, @Address, @City, @State, @Zip, @Email, @AccountNumber, @CreditCard)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@Zip", zip);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.AddWithValue("@CreditCard", creditCard);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer addition failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustButton_Click(object sender, EventArgs e)
        {
            string customerID = CustIDText?.Text.Trim();

            string firstName = FirstNameModText.Text.Trim();
            string lastName = LastNameModText.Text.Trim();
            string address = AddressModText.Text.Trim();
            string city = CityModText.Text.Trim();
            string state = StateModComboBox?.SelectedItem?.ToString();
            string zip = ZipModText.Text.Trim();
            string email = EmailModText.Text.Trim();
            string accountNumber = AccountModText.Text.Trim();
            string creditCard = CreditModText.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zip) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(creditCard))
            {
                MessageBox.Show("All fields must be filled in to update the customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Update customer
                string query = "UPDATE Customer SET firstName = @FirstName, lastName = @LastName, cusAddress = @Address, " +
                               "cusCity = @City, cusState = @State, cusZipCode = @Zip, Email = @Email, AccountNumber = @AccountNumber, CreditCard = @CreditCard " +
                               "WHERE customerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@Zip", zip);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CreditCard", creditCard);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustButton_Click(object sender, EventArgs e)
        {
            string customerID = CustIDText?.Text.Trim();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer? This action cannot be undone.",
                                                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return; // User canceled
            }

            try
            {
                // Delete customer
                string query = "DELETE FROM Customer WHERE customerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer deletion failed. Please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustSearchButtonClick(object sender, EventArgs e)
        {
            ModifyCustBox.Visible = false;
            string firstName = FirstNameSearchText?.Text.Trim();
            string lastName = LastNameSearchText?.Text.Trim();
            string email = EmailSearchText?.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter the Customer Name and Email to search", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Search for the customer
                string query = "SELECT customerID as [Customer ID], firstName as [First Name], lastName as [Last Name], Email, cusAddress, " +
                               "cusCity, cusState, cusZipCode, AccountNumber, CreditCard " +
                               "FROM Customer " +
                               "WHERE firstName = @FirstName AND lastName = @LastName AND Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);

                    // Load results into the data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        ModifyCustDataView.DataSource = results;

                        ModifyCustDataView.Columns["cusAddress"].Visible = false;
                        ModifyCustDataView.Columns["cusCity"].Visible = false;
                        ModifyCustDataView.Columns["cusState"].Visible = false;
                        ModifyCustDataView.Columns["cusZipCode"].Visible = false;
                        ModifyCustDataView.Columns["AccountNumber"].Visible = false;
                        ModifyCustDataView.Columns["CreditCard"].Visible = false;

                        // Error check to ensure customer exists
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No customer found with the provided details.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ModifyCustDataView.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyCustDataViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure row selected is not header
            {
                DataGridViewRow selectedRow = ModifyCustDataView.Rows[e.RowIndex];

                CustIDText.Text = selectedRow.Cells["Customer ID"].Value?.ToString();
                FirstNameModText.Text = selectedRow.Cells["First Name"].Value?.ToString();
                LastNameModText.Text = selectedRow.Cells["Last Name"].Value?.ToString();
                EmailModText.Text = selectedRow.Cells["Email"].Value?.ToString();
                AddressModText.Text = selectedRow.Cells["cusAddress"].Value?.ToString();
                CityModText.Text = selectedRow.Cells["cusCity"].Value?.ToString();
                StateModComboBox.SelectedItem = selectedRow.Cells["cusState"].Value?.ToString();
                ZipModText.Text = selectedRow.Cells["cusZipCode"].Value?.ToString();
                AccountModText.Text = selectedRow.Cells["AccountNumber"].Value?.ToString();
                CreditModText.Text = selectedRow.Cells["CreditCard"].Value?.ToString();

                ModifyCustDataView.Visible = false;
                ModifyCustBox.Visible = true;
            }
        }

        // *********************************
        //      Movie Management Tab
        // *********************************
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            ShowGroupBox(AddMovieBox);
        }

        private void ModifyMovieButton_Click(object sender, EventArgs e)
        {
            ShowGroupBox(ModifyMovieBox);
        }

        private void MovieAddButton_Click(object sender, EventArgs e)
        {
            string movieName = NameAddText.Text.Trim();
            string movieType = TypeAddComboBox.SelectedItem?.ToString();
            string distFee = FeeAddText.Text.Trim();
            string numCopies = CopiesAddText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(movieType) || string.IsNullOrEmpty(distFee) || string.IsNullOrEmpty(numCopies))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MovieModifyButton_Click(object sender, EventArgs e)
        {
            string movieID = MovieIDText?.Text.Trim();
            string movieName = NameModText.Text.Trim();
            string movieType = TypeModComboBox.SelectedItem?.ToString();
            string distFee = FeeModText.Text.Trim();
            string numCopies = CopiesModText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieID))
            {
                MessageBox.Show("Please enter the Movie ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            string movieID = MovieIDText?.Text.Trim();

            if (string.IsNullOrEmpty(movieID))
            {
                MessageBox.Show("Please enter the Movie ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Movie (not yet) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AssignActorButton_Click(object sender, EventArgs e)
        {
            ShowGroupBox(AssignActorBox);
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            // Collect input data
            string movieName = MovieAssignText.Text.Trim();
            string actorName = ActorAssignText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(actorName))
            {
                MessageBox.Show("Please provide both the movie name and actor name.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Actor successfully assigned to the movie!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowGroupBox(GroupBox targetGroupBox)
        {
            // Hide all group boxes first
            AssignActorBox.Visible = false;
            ModifyMovieBox.Visible = false;
            AddMovieBox.Visible = false;

            // Show the desired group box
            if (targetGroupBox != null)
            {
                targetGroupBox.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameModText_TextChanged(object sender, EventArgs e)
        {

        }
        // *********************************
        //      Rental Management Tab
        // *********************************
        private void button6_Click(object sender, EventArgs e)
        {

            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string emailAddress = textBox3.Text;

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Query to check first name, last name, and email
                string query = "SELECT COUNT(*) FROM Customer WHERE firstName = @fName AND lastName = @lName AND Email = @emailAddress";


                // Create SQL command
                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@fName", fName);
                    command.Parameters.AddWithValue("@lName", lName);
                    command.Parameters.AddWithValue("@emailAddress", emailAddress);

                    int result = (int)command.ExecuteScalar();

                    // if statement will be exceuted if Customer exists in the database
                    if (result > 0)
                    {

                        SqlCommand myCommand = new SqlCommand("select customerID from Customer where firstName = '" + @fName + "'AND lastName= '" + @lName + "' AND Email= '" + @emailAddress + "'", myConnection);

                        int custID = (int)myCommand.ExecuteScalar();

                        SqlCommand myCommand1 = new SqlCommand("select movieName, QueuePosition from Movie as R1, MovieQueue as R2, Customer as R3 where R1.movieID = R2.movieID and R2.customerID = R3.customerID and R3.customerID = '" + custID + "'", myConnection);
                        SqlDataAdapter sd = new SqlDataAdapter(myCommand1);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        label2.Visible = true;
                        label2.Text = fName + "'s Movie Queue";

                        //MessageBox.Show("Testing successful");
                    }
                    else
                    {
                        // Customer does not exist in database
                        MessageBox.Show("Customer does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;


        }


        private void button7_Click(object sender, EventArgs e)
        {
            string actorFName = textBox4.Text;
            string ageInput = textBox5.Text;
            int actorAge = Convert.ToInt32(textBox5.Text);
            string selectedMovieType = comboBox1.Text;

            if (string.IsNullOrEmpty(actorFName) || string.IsNullOrEmpty(ageInput) || string.IsNullOrEmpty(selectedMovieType))
            {
                MessageBox.Show("Please fill in all the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Query to check first name, last name, and email
                string query2 = "select firstName, lastName, DATEDIFF(yy, DateofBirth, GETDATE()) " +
                    "from Actor " +
                    "where firstName = @actorFName and (DATEDIFF(yy, DateofBirth, GETDATE())) > @actorAge " +
                    "and actorID in " +
                    "(select T1.actorID from ActorAppearedIn as T1, Actor as T2, Movie as T3 where T1.actorID = T2.actorID and T1.movieID = T3.movieID and MovieType = @selectedMovieType)";


                // Create SQL command
                using (SqlCommand command = new SqlCommand(query2, myConnection))
                {
                    command.Parameters.AddWithValue("@actorFName", actorFName);
                    command.Parameters.AddWithValue("@actorAge", actorAge);
                    command.Parameters.AddWithValue("@selectedMovieType", selectedMovieType);

                    int result = (int)command.ExecuteScalar();

                    // if statement will be exceuted if Customer exists in the database
                    if (result > 0)
                    { 

                        //SqlCommand myCommand1 = new SqlCommand("select movieName, QueuePosition from Movie as R1, MovieQueue as R2, Customer as R3 where R1.movieID = R2.movieID and R2.customerID = R3.customerID and R3.customerID = '" + custID + "'", myConnection);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView2.DataSource = dt;

                        //MessageBox.Show("Testing successful");
                    }
                    else
                    {
                        // Customer does not exist in database
                        MessageBox.Show("Customer does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
