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
            ModifyCustBox.Visible = false;
            AddCustBox.Visible = true;
        }

        private void ModifyCustButtonClick(object sender, EventArgs e)
        {
            AddCustBox.Visible = false;
            ModifyCustBox.Visible = true;
        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            // Collect input that will be validated
            string firstName = FirstNameCustText.Text.Trim();
            string lastName = LastNameCustText.Text.Trim();
            string email = EmailCustText.Text.Trim();
            string state = StateCustComboBox?.SelectedItem?.ToString();
            string accountNumber = AccountCustText.Text.Trim();
            string creditCard = CreditCustText.Text.Trim();
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

        private void UpdateCustButton_Click(object sender, EventArgs e)
        {
            // CustomerID field
            string customerID = CustIDText?.Text.Trim();

            // Validate CustomerID
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter the Customer ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect input data from user input
            string firstName = FirstNameModText.Text.Trim();
            string lastName = LastNameModText.Text.Trim();
            string address = AddressModText.Text.Trim();
            string city = CityModText.Text.Trim();
            string state = StateModComboBox?.SelectedItem?.ToString();
            string zip = ZipModText.Text.Trim();
            string email = EmailModText.Text.Trim();
            string accountNumber = AccountModText.Text.Trim();
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

        private void DeleteCustButton_Click(object sender, EventArgs e)
        {
            // CustomerID field
            string customerID = CustIDText?.Text.Trim();

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
    }
}
