using Microsoft.Data.SqlClient;

namespace CMPT291_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        // *********************************
        //     Customer Management Tab
        // *********************************
        private void NewCustButtonClick(object sender, EventArgs e)
        {
            ClearPanels();
            InitializeCustomerInputComponents();
            CustInputPanel.Visible = true;

            // Add "Submit" and "Cancel" buttons for new customer functionality
            Button btnSubmit = new Button
            {
                Text = "Submit",
                Location = new Point(500, 300),
                Width = 100,
                Height = 40
            };
            btnSubmit.Click += BtnSubmit_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(620, 300),
                Width = 100,
                Height = 40
            };
            btnCancel.Click += BtnCancel_Click;

            CustInputPanel.Controls.Add(btnSubmit);
            CustInputPanel.Controls.Add(btnCancel);
        }

        private void ModifyCustButtonClick(object sender, EventArgs e)
        {
            ClearPanels();
            InitializeCustomerInputComponents();

            Label lblCustomerID = new Label
            {
                Name = "lblCustomerID",
                Text = "Customer ID:",
                Location = new Point(500, 20),
                AutoSize = true
            };

            TextBox txtCustomerID = new TextBox
            {
                Name = "txtCustomerID",
                Location = new Point(650, 20),
                Width = 100
            };

            CustInputPanel.Controls.Add(lblCustomerID);
            CustInputPanel.Controls.Add(txtCustomerID);

            CustInputPanel.Visible = true;

            // Add "Update" and "Delete" buttons for modify customer functionality
            Button btnUpdate = new Button
            {
                Text = "Update",
                Location = new Point(500, 300),
                Width = 100,
                Height = 40
            };
            btnUpdate.Click += BtnUpdate_Click;

            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new Point(620, 300),
                Width = 100,
                Height = 40
            };
            btnDelete.Click += BtnDelete_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(620, 250),
                Width = 100,
                Height = 40
            };
            btnCancel.Click += BtnCancel_Click;

            CustInputPanel.Controls.Add(btnCancel);
            CustInputPanel.Controls.Add(btnUpdate);
            CustInputPanel.Controls.Add(btnDelete);
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Collect input that will be validated
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string state = cmbState?.SelectedItem?.ToString();
            string accountNumber = txtAccountNumber.Text.Trim();
            string creditCard = txtCreditCard.Text.Trim();
            // Will add rest of info later...

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(creditCard) || string.IsNullOrEmpty(state))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE QUERIES TO ADD DATA
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CustInputPanel.Visible = false;
        }
        private void BtnCancelMovie_Click(object sender, EventArgs e)
        {
            MovieInputPanel.Visible = false;
        }

        private void BtnCancelActor_Click(object sender, EventArgs e)
        {
            AssignActorPanel.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // CustomerID field
            TextBox txtCustomerID = CustInputPanel.Controls["txtCustomerID"] as TextBox;
            string customerID = txtCustomerID?.Text.Trim();

            // Validate CustomerID
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter the Customer ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect input data from user input
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = cmbState?.SelectedItem?.ToString();
            string zip = txtZip.Text.Trim();
            string email = txtEmail.Text.Trim();
            string accountNumber = txtAccountNumber.Text.Trim();
            // Will add rest of info later...

            // Validate inputs
            if (string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(state))
            {
                MessageBox.Show("Please enter the Required Information to Update.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE QUERIES TO ADD DATA
            MessageBox.Show("Customer modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // CustomerID field
            TextBox txtCustomerID = CustInputPanel.Controls["txtCustomerID"] as TextBox;
            string customerID = txtCustomerID?.Text.Trim();

            // Validate CustomerID
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter the Customer ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer? This action cannot be undone.",
                                                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return; // User canceled
            }

            // NEED TO ADD IN DATABASE QUERIES TO ADD DATA
            MessageBox.Show("Customer (not yet) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // *********************************
        //      Movie Management Tab
        // *********************************
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            ClearPanels();
            InitializeMovieInputComponents();
            MovieInputPanel.Visible = true;

            Button btnSubmit = new Button
            {
                Text = "Submit",
                Location = new Point(500, 300),
                Width = 100,
                Height = 40
            };
            btnSubmit.Click += BtnSubmitMovie_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(620, 300),
                Width = 100,
                Height = 40
            };
            btnCancel.Click += BtnCancelMovie_Click;

            MovieInputPanel.Controls.Add(btnSubmit);
            MovieInputPanel.Controls.Add(btnCancel);
        }

        private void ModifyMovieButton_Click(object sender, EventArgs e)
        {
            ClearPanels();
            InitializeMovieInputComponents();
            MovieInputPanel.Visible = true;

            if (MovieInputPanel.Controls["lblMovieID"] == null)
            {
                Label lblMovieID = new Label { Text = "Movie ID:", Location = new Point(20, 180), AutoSize = true, Name = "lblMovieID" };
                TextBox txtMovieID = new TextBox { Location = new Point(170, 180), Width = 100, Name = "txtMovieID" };

                MovieInputPanel.Controls.Add(lblMovieID);
                MovieInputPanel.Controls.Add(txtMovieID);
            }

            Button btnUpdate = new Button
            {
                Text = "Update",
                Location = new Point(500, 300),
                Width = 100,
                Height = 40
            };
            btnUpdate.Click += BtnUpdateMovie_Click;

            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new Point(620, 300),
                Width = 100,
                Height = 40
            };
            btnDelete.Click += BtnDeleteMovie_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(620, 250),
                Width = 100,
                Height = 40
            };
            btnCancel.Click += BtnCancelMovie_Click;

            MovieInputPanel.Controls.Add(btnUpdate);
            MovieInputPanel.Controls.Add(btnDelete);
            MovieInputPanel.Controls.Add(btnCancel);
        }

        private void BtnSubmitMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtMovieName.Text.Trim();
            string movieType = cmbMovieType.SelectedItem?.ToString();
            string distFee = txtDistFee.Text.Trim();
            string numCopies = txtNumCopies.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(movieType) || string.IsNullOrEmpty(distFee) || string.IsNullOrEmpty(numCopies))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            TextBox txtMovieID = MovieInputPanel.Controls["txtMovieID"] as TextBox;
            string movieID = txtMovieID?.Text.Trim();
            string movieName = txtMovieName.Text.Trim();
            string movieType = cmbMovieType.SelectedItem?.ToString();
            string distFee = txtDistFee.Text.Trim();
            string numCopies = txtNumCopies.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(movieID))
            {
                MessageBox.Show("Please enter the Movie ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // NEED TO ADD IN DATABASE FUNCTIONALITY HERE
            MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            TextBox txtMovieID = MovieInputPanel.Controls["txtMovieID"] as TextBox;
            string movieID = txtMovieID?.Text.Trim();

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
            ClearPanels();
            InitializeAssignActorComponents();

            Button btnAssignActor = new Button
            {
                Text = "Assign Actor",
                Location = new Point(170, 100),
                Width = 120,
                Height = 40
            };
            btnAssignActor.Click += BtnAssignActor_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(290, 100),
                Width = 100,
                Height = 40
            };
            btnCancel.Click += BtnCancelActor_Click;

            AssignActorPanel.Controls.Add(btnCancel);
            AssignActorPanel.Controls.Add(btnAssignActor);

            AssignActorPanel.Visible = true;
        }

        private void BtnAssignActor_Click(object sender, EventArgs e)
        {
            // Collect input data
            string movieName = txtAssignMovieName.Text.Trim();
            string actorName = txtAssignActorName.Text.Trim();

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

        private void ClearPanels()
        {
            // Hide and clear the Customer Input Panel
            if (CustInputPanel != null)
            {
                CustInputPanel.Visible = false;
                CustInputPanel.Controls.Clear();
            }

            // Hide and clear the Movie Input Panel
            if (MovieInputPanel != null)
            {
                MovieInputPanel.Visible = false;
                MovieInputPanel.Controls.Clear();
            }

            // Hide and clear the Assign Actor Panel
            if (AssignActorPanel != null)
            {
                AssignActorPanel.Visible = false;
                AssignActorPanel.Controls.Clear();
            }
        }
    }
}
