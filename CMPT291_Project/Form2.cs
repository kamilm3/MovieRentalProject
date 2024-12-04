using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
            string phoneNum = PhoneNumAddBox.Text.Trim();
            string phoneType = PhoneTypeAddBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zip) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(creditCard) ||
                string.IsNullOrEmpty(phoneNum) || string.IsNullOrEmpty(phoneType))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int customerId;

                // Add customer
                string query = "insert into Customer (firstName, lastName, cusAddress, cusCity, cusState, cusZipCode, Email, AccountNumber, CreditCard) " +
                               // output the customer id
                               "output inserted.customerID " +
                               "values (@FirstName, @LastName, @Address, @City, @State, @Zip, @Email, @AccountNumber, @CreditCard)";

                using (SqlCommand customerCmd = new SqlCommand(query, myConnection))
                {
                    customerCmd.Parameters.AddWithValue("@FirstName", firstName);
                    customerCmd.Parameters.AddWithValue("@LastName", lastName);
                    customerCmd.Parameters.AddWithValue("@Address", address);
                    customerCmd.Parameters.AddWithValue("@City", city);
                    customerCmd.Parameters.AddWithValue("@State", state);
                    customerCmd.Parameters.AddWithValue("@Zip", zip);
                    customerCmd.Parameters.AddWithValue("@Email", email);
                    customerCmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    customerCmd.Parameters.AddWithValue("@CreditCard", creditCard);

                    // Get customerID of inserted customer
                    customerId = (int)customerCmd.ExecuteScalar();
                }

                 // Add phone number
                 string phoneQuery = "insert into CustomerPhone (customerID, PhoneType, Number) values (@CustomerID, @PhoneType, @Number)";

                 using (SqlCommand phoneCmd = new SqlCommand(phoneQuery, myConnection))
                 {
                     phoneCmd.Parameters.AddWithValue("@CustomerID", customerId);
                     phoneCmd.Parameters.AddWithValue("@PhoneType", phoneType);
                     phoneCmd.Parameters.AddWithValue("@Number", phoneNum);

                     int phoneRowsAffected = phoneCmd.ExecuteNonQuery();

                     if (phoneRowsAffected > 0)
                     {
                         MessageBox.Show("Customer and phone details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                     {
                         MessageBox.Show("Phone details addition failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string phoneNum = PhoneNumUpBox.Text.Trim();
            string phoneType = PhoneTypeUpBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zip) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(creditCard) ||
                string.IsNullOrEmpty(phoneNum) || string.IsNullOrEmpty(phoneType))
            {
                MessageBox.Show("All fields must be filled in to update the customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Update customer
                string query = "update Customer set firstName = @FirstName, lastName = @LastName, cusAddress = @Address, " +
                               "cusCity = @City, cusState = @State, cusZipCode = @Zip, Email = @Email, AccountNumber = @AccountNumber, CreditCard = @CreditCard " +
                               "where customerID = @CustomerID";

                using (SqlCommand customerCmd = new SqlCommand(query, myConnection))
                {
                    customerCmd.Parameters.AddWithValue("@FirstName", firstName);
                    customerCmd.Parameters.AddWithValue("@LastName", lastName);
                    customerCmd.Parameters.AddWithValue("@Address", address);
                    customerCmd.Parameters.AddWithValue("@City", city);
                    customerCmd.Parameters.AddWithValue("@State", state);
                    customerCmd.Parameters.AddWithValue("@Zip", zip);
                    customerCmd.Parameters.AddWithValue("@Email", email);
                    customerCmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    customerCmd.Parameters.AddWithValue("@CreditCard", creditCard);
                    customerCmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int rowsAffected = customerCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update phone table
                        string phoneQuery = "update CustomerPhone set PhoneType = @PhoneType, Number = @Number where customerID = @CustomerID";

                        using (SqlCommand phoneCmd = new SqlCommand(phoneQuery, myConnection))
                        {
                            phoneCmd.Parameters.AddWithValue("@PhoneType", phoneType);
                            phoneCmd.Parameters.AddWithValue("@Number", phoneNum);
                            phoneCmd.Parameters.AddWithValue("@CustomerID", customerID);

                            int phoneRowsAffected = phoneCmd.ExecuteNonQuery();

                            if (phoneRowsAffected > 0)
                            {
                                MessageBox.Show("Customer and phone details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Phone details update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
                // Search for the customer and phone details
                string query = "select c.customerID as [Customer ID], c.firstName as [First Name], c.lastName as [Last Name], c.Email, " +
                               "c.cusAddress, c.cusCity, c.cusState, c.cusZipCode, c.AccountNumber, c.CreditCard, " +
                               "cp.PhoneType, cp.Number " +
                               "from Customer c " +
                               // Left join will retrieve all customers, even if they have no phone number attached
                               "left join CustomerPhone cp ON c.customerID = cp.customerID " +
                               "where c.firstName = @FirstName AND c.lastName = @LastName AND c.Email = @Email";

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
                        ModifyCustDataView.Columns["PhoneType"].Visible = false;
                        ModifyCustDataView.Columns["Number"].Visible = false;

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
                PhoneTypeUpBox.Text = selectedRow.Cells["PhoneType"].Value?.ToString();
                PhoneNumUpBox.Text = selectedRow.Cells["Number"].Value?.ToString();

                ModifyCustDataView.Visible = false;
                ModifyCustBox.Visible = true;
            }
        }

        // *********************************
        //      Movie Management Tab
        // *********************************
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            ModifyMovieBox.Visible = false;
            AddMovieBox.Visible = true;
            AssignActorBox.Visible = false;
            SearchMoviePanel.Visible = false;
            MovieDataViewPanel.Visible = false;
        }

        private void ModifyMovieButton_Click(object sender, EventArgs e)
        {
            ModifyMovieBox.Visible = false;
            AddMovieBox.Visible = false;
            AssignActorBox.Visible = false;
            SearchMoviePanel.Visible = true;
            MovieDataViewPanel.Visible = true;

        }

        private void MovieAddButton_Click(object sender, EventArgs e)
        {
            string MovieName = NameAddText.Text.Trim();
            string MovieType = TypeAddComboBox.SelectedItem?.ToString();
            string DistFee = FeeAddText.Text.Trim();
            string NumCopies = CopiesAddText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(MovieName) || string.IsNullOrEmpty(MovieType) || string.IsNullOrEmpty(DistFee) || string.IsNullOrEmpty(NumCopies))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add Movie
            try
            {
                string query = "INSERT INTO Movie (movieName, MovieType, DistFee,NumCopies)" + "VALUES(@moviename, @movietype, @distfee, @numcopies)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@moviename", MovieName);
                    cmd.Parameters.AddWithValue("@movietype", MovieType);
                    cmd.Parameters.AddWithValue("@distfee", DistFee);
                    cmd.Parameters.AddWithValue("@numcopies", NumCopies);

                    int MovierowsAffected = cmd.ExecuteNonQuery();

                    if (MovierowsAffected > 0)
                    {
                        MessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Movie addition failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void MovieModifyButton_Click(object sender, EventArgs e)
        {
            string movieId = MovieIDText?.Text.Trim();
            string moviename = NameModText.Text.Trim();
            string movietype = TypeModComboBox.SelectedItem?.ToString();
            string distfee = FeeModText.Text.Trim();
            string numcopies = CopiesModText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieId) || string.IsNullOrEmpty(moviename) || string.IsNullOrEmpty(movietype) || string.IsNullOrEmpty(distfee) ||
                string.IsNullOrEmpty(numcopies))
            {
                MessageBox.Show("All fields must be filled in to update the movie.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                string query = "UPDATE Movie SET movieName = @MovieName, MovieType = @movieType, " +
                                "DistFee = @distFee, NumCopies = @numCopies " +
                                "WHERE movieID = @MovieId";

                using (SqlCommand cmnd = new SqlCommand(query, myConnection))
                {
                    cmnd.Parameters.AddWithValue("@MovieId", movieId);
                    cmnd.Parameters.AddWithValue("@MovieName", moviename);
                    cmnd.Parameters.AddWithValue("@movieType", movietype);
                    cmnd.Parameters.AddWithValue("@distFee", distfee);
                    cmnd.Parameters.AddWithValue("@numCopies", numcopies);

                    // Execute the query
                    int rowsAffected = cmnd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Movie modified successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Movie modification failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            string movieId = MovieIDText?.Text.Trim();

            // Confirm delete action
            DialogResult confirm_delete = MessageBox.Show("Are you sure you want to delete this movie? This action cannot be undone.",
                                                            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm_delete != DialogResult.Yes)
            {
                return; // Pressed No
            }

            try
            {
                // Delete from the ActorAppearedIn table to avoid foreign key constraint issues
                string deleteActorAppearedInQuery = "DELETE FROM ActorAppearedIn WHERE movieID = @MovieId";

                using (SqlCommand cmnd = new SqlCommand(deleteActorAppearedInQuery, myConnection))
                {
                    cmnd.Parameters.AddWithValue("@MovieId", movieId);

                    // Execute deletion
                    int actorAppearedInRowsAffected = cmnd.ExecuteNonQuery();

                    if (actorAppearedInRowsAffected > 0)
                    {
                        Console.WriteLine("Related actor appearances deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No related actor appearances found to delete.");
                    }
                }

                // Now, delete the movie from the Movie table
                string deleteMovieQuery = "DELETE FROM Movie WHERE movieID = @MovieId";

                using (SqlCommand cmnd = new SqlCommand(deleteMovieQuery, myConnection))
                {
                    cmnd.Parameters.AddWithValue("@MovieId", movieId);

                    // Execute deletion
                    int movieRowsAffected = cmnd.ExecuteNonQuery();

                    if (movieRowsAffected > 0)
                    {
                        MessageBox.Show("Movie deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Movie deletion failed. Please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AssignActorButton_Click(object sender, EventArgs e)
        {
            ModifyMovieBox.Visible = false;
            AddMovieBox.Visible = false;
            AssignActorBox.Visible = true;
            SearchMoviePanel.Visible = false;
            MovieDataViewPanel.Visible = false;
            ActorAssignLabel.Visible = false;
            ActorFirstAssignText.Visible = false;
            ActorLastAssignText.Visible = false;
            label6.Visible = false;
            label11.Visible = false;
            AssignButton.Visible = false;
            MovieActorDataView.Visible = false;

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            // Collect input data
            string movieName = MovieAssignText.Text.Trim();
            string actorFirstName = ActorFirstAssignText.Text.Trim();
            string actorLastName = ActorLastAssignText.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(actorFirstName) || string.IsNullOrEmpty(actorLastName))
            {
                MessageBox.Show("Please provide both the movie name and the actor's full name.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Check if a row is selected in the MovieActorDataView
                if (MovieActorDataView.SelectedRows.Count > 0)
                {
                    // Get the first selected row
                    DataGridViewRow selectedRow = MovieActorDataView.SelectedRows[0];

                    // Access the movieID of a specific column in the selected row
                    int movieId = Convert.ToInt32(selectedRow.Cells["movieID"].Value);

                    // Retrieve actorID based on first and last name
                    string actorIdQuery = "SELECT actorID FROM Actor WHERE firstName = @FirstName AND lastName = @LastName";
                    int actorId = 0;

                    using (SqlCommand cmd = new SqlCommand(actorIdQuery, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", actorFirstName);
                        cmd.Parameters.AddWithValue("@LastName", actorLastName);

                        // Execute the query and get the actor ID
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            actorId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Actor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert into ActorAppearedIn table to associate the actor with the movie
                    string query1 = "INSERT INTO ActorAppearedIn (actorID, movieID) VALUES (@ActorId, @MovieId)";

                    using (SqlCommand cmnd = new SqlCommand(query1, myConnection))
                    {
                        cmnd.Parameters.AddWithValue("@ActorId", actorId);
                        cmnd.Parameters.AddWithValue("@MovieId", movieId);

                        // Execute the query
                        int rowsAffected = cmnd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Actor successfully assigned to the movie!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Could not assign actor to movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                        SqlCommand myCommand1 = new SqlCommand("select movieName as MovieName, QueuePosition from Movie as R1, MovieQueue as R2, Customer as R3 where R1.movieID = R2.movieID and R2.customerID = R3.customerID and R3.customerID = '" + custID + "'", myConnection);
                        SqlDataAdapter sd = new SqlDataAdapter(myCommand1);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        label2.Visible = true;
                        label2.Text = fName + "'s Movie Queue";


                        if (dataGridView1.Rows.Count == 1)
                        {
                            label15.Visible = false;
                            string message = fName + " has no movies in their queue";
                            MessageBox.Show(message);
                        }
                        else
                        {

                            SqlCommand myCommand2 = new SqlCommand("select count(*) from MovieQueue as R2, Customer as R3 where R2.customerID = R3.customerID and R3.customerID = '" + custID + "' and R2.QueuePosition = 1", myConnection);
                            int availability = (int)myCommand2.ExecuteScalar();

                            if (availability > 0)
                            {
                                button2.Visible = true;
                                button2.BackColor = Color.Blue;
                                button2.ForeColor = Color.White;
                                label15.Visible = false;
                            }
                            else
                            {
                                label15.Visible = true;
                                button2.Visible = false;
                            }

                        }

                    }
                    else
                    {
                        // Customer does not exist in database
                        string message = fName + " " + lName + " does not exist in database";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void button2_Click_1(object sender, EventArgs e)
        {


            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string emailAddress = textBox3.Text;
            SqlCommand myCommand = new SqlCommand("select customerID from Customer where firstName = '" + @fName + "'AND lastName= '" + @lName + "' AND Email= '" + @emailAddress + "'", myConnection);

            int custID = (int)myCommand.ExecuteScalar();

            //retrieves movie name before deletion
            SqlCommand myCommand1 = new SqlCommand("select movieName as MovieName, QueuePosition from Movie as R1, MovieQueue as R2, Customer as R3 where R1.movieID = R2.movieID and R2.customerID = R3.customerID and R3.customerID = '" + custID + "'and R2.QueuePosition = 1", myConnection);
            string movie = (string)myCommand1.ExecuteScalar();

            // string query to delete row from MovieQueue
            string deleteQuery = "DELETE FROM MovieQueue WHERE customerID = @custID and QueuePosition = 1";

            using (SqlCommand command = new SqlCommand(deleteQuery, myConnection))
            {
                command.Parameters.AddWithValue("@custID", custID);

                //execute delete query
                int deletedQuery = command.ExecuteNonQuery();


                // displays message that movie has been rented out to customer
                string message = movie + " has been rented to " + fName + " " + lName;
                MessageBox.Show(message);

            }
            // calls updateMovieQueue to show updated data
            updateMovieQueue();



        }
        void updateMovieQueue()
        {
            string fName = textBox1.Text;
            string lName = textBox2.Text;
            string emailAddress = textBox3.Text;
            button2.Visible = false;

            SqlCommand myCommand = new SqlCommand("select customerID from Customer where firstName = '" + @fName + "'AND lastName= '" + @lName + "' AND Email= '" + @emailAddress + "'", myConnection);

            int custID = (int)myCommand.ExecuteScalar();

            SqlCommand myCommand1 = new SqlCommand("select movieName as MovieName, QueuePosition from Movie as R1, MovieQueue as R2, Customer as R3 where R1.movieID = R2.movieID and R2.customerID = R3.customerID and R3.customerID = '" + custID + "'", myConnection);
            SqlDataAdapter sd = new SqlDataAdapter(myCommand1);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            label2.Visible = true;
            label2.Text = fName + "'s Movie Queue";


            if (dataGridView1.Rows.Count == 1)
            {

                string message = fName + " has no movies in their queue";
                MessageBox.Show(message);
            }
            else
            {

                SqlCommand myCommand2 = new SqlCommand("select count(*) from MovieQueue as R2, Customer as R3 where R2.customerID = R3.customerID and R3.customerID = '" + custID + "' and R2.QueuePosition = 1", myConnection);
                int availability = (int)myCommand2.ExecuteScalar();

                if (availability > 0)
                {
                    button2.Visible = true;
                    button2.BackColor = Color.Blue;
                    button2.ForeColor = Color.White;
                    label15.Visible = false;
                }
                else
                {
                    label15.Visible = true;
                    button2.Visible = false;
                }

            }

        }


        // *********************************
        //            Report Tab
        // *********************************

        /////////////////////
        //     Report 1    //
        /////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            string actorFName = textBox4.Text;
            string ageInput = textBox5.Text;
            string selectedMovieType = comboBox1.Text;


            if (string.IsNullOrEmpty(actorFName) || string.IsNullOrEmpty(ageInput) || string.IsNullOrEmpty(selectedMovieType))
            {
                MessageBox.Show("Please fill in all the parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!int.TryParse(ageInput, out int value))
            {
                MessageBox.Show("Please enter numbers only for Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                int actorAge = Convert.ToInt32(textBox5.Text);

                // Query to check if data exists (if data is empty or not)
                string query2 = "select count(*) " +
                    "from Movie as M, ActorAppearedIn as A " +
                    "where M.movieID = A.movieID and MovieType = @selectedMovieType and A.movieID in " +
                        "(select A2.movieID " +
                        "from ActorAppearedIn as A2, Actor as A3 " +
                        "where A2.actorID = A3.actorID and A3.firstName = @actorFName " +
                        "and (DATEDIFF(yy, A3.DateofBirth, GETDATE())) = @actorAge)";


                // Create SQL command
                using (SqlCommand command = new SqlCommand(query2, myConnection))
                {

                    command.Parameters.AddWithValue("@actorFName", actorFName);
                    command.Parameters.AddWithValue("@actorAge", actorAge);
                    command.Parameters.AddWithValue("@selectedMovieType", selectedMovieType);

                    int result = (int)command.ExecuteScalar();

                    //if statement is executed if it passes condition
                    if (result > 0)
                    {


                        string query3 = "select movieName as Movie " +
                        "from Movie as M, ActorAppearedIn as A " +
                        "where M.movieID = A.movieID and MovieType = @selectedMovieType and A.movieID in " +
                            "(select A2.movieID " +
                            "from ActorAppearedIn as A2, Actor as A3 " +
                            "where A2.actorID = A3.actorID and A3.firstName = @actorFName " +
                            "and (DATEDIFF(yy, A3.DateofBirth, GETDATE())) = @actorAge)";

                        // executes query 3 and redeclare variables on command1
                        SqlCommand command1 = new SqlCommand(query3, myConnection);
                        command1.Parameters.AddWithValue("@actorFName", actorFName);
                        command1.Parameters.AddWithValue("@actorAge", actorAge);
                        command1.Parameters.AddWithValue("@selectedMovieType", selectedMovieType);

                        //creates table and displays data
                        SqlDataAdapter sd = new SqlDataAdapter(command1);
                        DataTable dt1 = new DataTable();
                        sd.Fill(dt1);
                        ReportDataGrid.DataSource = dt1;
                    }
                    else
                    {
                        string message = "Actor does not exist in database or actor does not have a movie of selected genre, " + selectedMovieType;

                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /////////////////////
        //     Report 2    //
        /////////////////////

        private void MonthText_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox MonthText = sender as System.Windows.Forms.TextBox;
            if (MonthText.Text == "Ex. 3")
            {
                MonthText.Text = "";
                MonthText.ForeColor = Color.Black;
            }
        }

        private void MonthText_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox MonthText = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrWhiteSpace(MonthText.Text))
            {
                MonthText.Text = "Ex. 3";
                MonthText.ForeColor = Color.DarkGray;
            }
        }


        private void Report2Button_Click(object sender, EventArgs e)
        {
            string monthRangeText = MonthText.Text.Trim();

            if (string.IsNullOrEmpty(monthRangeText) || !int.TryParse(monthRangeText, out int monthRange))
            {
                MessageBox.Show("Please enter a valid month range (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Search for the customer sales
            string query = @"
                select C.customerID, C.firstName + ' ' + C.lastName AS FullName, C.Email, count(P.movieID) as TotalMoviesRented, sum(M.DistFee) as TotalAmountSpent, min(P.CheckoutTime) as FirstRentalDate, max(P.CheckoutTime) as LastRentalDate
                from Customer C, PlacedOrder P, Movie M
                where P.customerID = C.customerID AND M.movieID = P.movieID AND P.CheckoutTime >= DATEADD(MONTH, -@MonthRange, GETDATE())
                group by C.customerID, C.firstName, C.lastName, C.Email
                order by TotalAmountSpent DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    // Add parameter for month range
                    cmd.Parameters.AddWithValue("@MonthRange", monthRange);

                    // Load results into the data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        // Bind results to the data view
                        ReportDataGrid.DataSource = results;

                        // Check if results are empty
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No customer found within the provided range.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ReportDataGrid.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchMovieButton_Click(object sender, EventArgs e)
        {
            ModifyMovieBox.Visible = false;
            AddMovieBox.Visible = false;
            AssignActorBox.Visible = false;
            MovieDataViewPanel.Visible = true;

            string moviename = SearchMovieText?.Text.Trim();

            if (string.IsNullOrEmpty(moviename))
            {
                MessageBox.Show("Please enter the Movie Title to search", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Query to get movie details
                string query1 = "SELECT movieID, movieName, MovieType, DistFee, NumCopies " +
                                 "FROM Movie " +
                                 "WHERE movieName = @MovieName";

                // Query to get actors for the movie
                string query2 = "SELECT A.firstName, A.lastName " +
                                "FROM Actor A, ActorAppearedIn AM " +
                                "WHERE AM.movieId IN (SELECT movieID FROM Movie WHERE movieName = @MovieName) " +
                                "AND A.actorID = AM.actorID";

                using (SqlCommand cmnd = new SqlCommand(query1, myConnection))
                {
                    cmnd.Parameters.AddWithValue("@MovieName", moviename);

                    // Load results into the data table
                    using (SqlDataAdapter Moviedata = new SqlDataAdapter(cmnd))
                    {
                        DataTable movieresults = new DataTable();
                        Moviedata.Fill(movieresults);

                        // Remove duplicates by movieID
                        DataView distinctMovies = new DataView(movieresults);
                        distinctMovies.Sort = "movieID";  // Sorting to group by movieID
                        DataTable uniqueMovies = distinctMovies.ToTable(true, "movieID", "movieName", "MovieType", "DistFee", "NumCopies");

                        // Set the unique data as the DataSource for MovieDataView
                        MovieDataView.DataSource = uniqueMovies;

                        // Error check to ensure movie exists
                        if (movieresults.Rows.Count == 0)
                        {
                            MessageBox.Show("No movie found with the provided details.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MovieDataView.Visible = true;
                        }
                    }
                }

                // Clear existing items from actor list box
                actorList.Items.Clear();

                using (SqlCommand actorCmnd = new SqlCommand(query2, myConnection))
                {
                    actorCmnd.Parameters.AddWithValue("@MovieName", moviename);

                    SqlDataReader reader = actorCmnd.ExecuteReader();

                    // Read actors and add to the actor list box
                    while (reader.Read())
                    {
                        string fullName = reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                        actorList.Items.Add(fullName);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /////////////////////
            //     Report 3    //
            /////////////////////

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string genre = Report3DropDownBox.Text.Trim();

            // Validate if the user selected a genre
            if (string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Please select a genre or 'All' before generating the report.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                SELECT A.actorID, A.firstName, A.lastName, COUNT(M.movieID) as MovieCount
                FROM Actor as A, Movie as M, ActorAppearedIn as AM
                WHERE A.actorID = AM.actorID AND M.movieID = AM.movieID";

            // Add genre filter if a specific genre is selected
            if (!genre.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                query += " AND M.MovieType = @Genre";
            }

            query += " GROUP BY A.actorID, A.firstName, A.lastName";
            query += " ORDER BY MovieCount DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    // Add parameter for Genre
                    if (!genre.Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.Parameters.AddWithValue("@Genre", genre);

                    }

                    // Load results into the data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        // Bind results to the data view
                        ReportDataGrid.DataSource = results;

                        // Check if results are empty
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No actor found for the selected genre.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ReportDataGrid.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MovieDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row selected is not the header
            {
                DataGridViewRow selectedMovieRow = MovieDataView.Rows[e.RowIndex];

                NameModText.Text = selectedMovieRow.Cells["movieName"].Value?.ToString();
                MovieIDText.Text = selectedMovieRow.Cells["movieID"].Value?.ToString();
                TypeModComboBox.SelectedItem = selectedMovieRow.Cells["MovieType"].Value?.ToString();
                FeeModText.Text = selectedMovieRow.Cells["DistFee"].Value?.ToString();
                CopiesModText.Text = selectedMovieRow.Cells["NumCopies"].Value?.ToString();



                MovieDataView.Visible = false;
                ModifyMovieBox.Visible = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActorMovieSearchButton_Click(object sender, EventArgs e)
        {
            // Collect input data
            string moviename = MovieAssignText.Text.Trim();


            // Validate inputs
            if (string.IsNullOrEmpty(moviename))
            {
                MessageBox.Show("Please provide the movie name.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Search for the Movie
                string query = "SELECT movieID, movieName " +
                               "FROM Movie " +
                               "WHERE movieName = @MovieName";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@MovieName", moviename);


                    // Load results into the data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        MovieActorDataView.DataSource = results;

                        // Error check to ensure movie exists
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No movie found with the provided details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MovieActorDataView.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MovieActorDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row selected is not the header
            {
                DataGridViewRow selectedMovieRow = MovieActorDataView.Rows[e.RowIndex];

                int MovieId = selectedMovieRow.Cells["movieID"].Value != DBNull.Value
                ? Convert.ToInt32(selectedMovieRow.Cells["movieID"].Value)
                : 0; // Default value if null or DBNull

                ActorAssignLabel.Visible = true;
                ActorFirstAssignText.Visible = true;
                ActorLastAssignText.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                AssignButton.Visible = true;

            }
        }

        private void MovieActorDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /////////////////////
        //     Report 4    //
        /////////////////////

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void reportButton4_Click_1(object sender, EventArgs e)
        {
            string selectedGenre = dropdownReport4.Text.Trim();

            // Validate if the user selected a genre
            if (string.IsNullOrEmpty(selectedGenre))
            {
                MessageBox.Show("Please select a genre or 'All' before generating the report.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
        SELECT 
            M.movieName, 
            (SELECT COUNT(PO.orderID) 
             FROM PlacedOrder PO 
             WHERE PO.movieID = M.movieID) AS TotalRentals
        FROM 
            Movie M
        WHERE 
            M.movieID IN (SELECT movieID FROM PlacedOrder)";

            // Add genre filter if a specific genre is selected
            if (!selectedGenre.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                query += " AND M.MovieType = @selectedGenre";
            }

            query += " ORDER BY TotalRentals DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    // Add parameter only if a specific genre is selected
                    if (!selectedGenre.Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.Parameters.AddWithValue("@selectedGenre", selectedGenre);
                    }

                    // Load results into a DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        // Bind results to the DataGridView
                        ReportDataGrid.DataSource = results;

                        // Check if results are empty
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No movies found for the selected genre.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ReportDataGrid.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /////////////////////
        //     Report 5    //
        /////////////////////
        private void reportButton5_Click(object sender, EventArgs e)
        {
            // Validate if one of the radio buttons is selected
            if (!radioButton_report5.Checked && !radioButton2_report5.Checked)
            {
                MessageBox.Show("Please select an order type: Most or Least.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine the sorting order based on the selected radio button
            string sortOrder = radioButton_report5.Checked ? "DESC" : "ASC";

            string query = $@"
        SELECT 
            (SELECT CONCAT(firstName, ' ', lastName) 
             FROM Employee 
             WHERE Employee.employeeID = PO.employeeID) AS EmployeeName,
            COUNT(PO.orderID) AS TotalOrders
        FROM 
            PlacedOrder PO
        GROUP BY 
            PO.employeeID
        ORDER BY 
            TotalOrders {sortOrder}"; // Sorting based on radio button

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    // Load results into a DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();
                        adapter.Fill(results);

                        // Bind results to the DataGridView
                        ReportDataGrid.DataSource = results;

                        // Check if results are empty
                        if (results.Rows.Count == 0)
                        {
                            MessageBox.Show("No orders found for employees.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ReportDataGrid.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report3DropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropdownReport4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReportDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MovieDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MonthText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModifyCustDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}


