namespace CMPT291_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DashboardTabs = new TabControl();
            tabPage1 = new TabPage();
            ModifyCustButton = new Button();
            NewCustButton = new Button();
            tabPage2 = new TabPage();
            AssignActorButton = new Button();
            ModifyMovieButton = new Button();
            AddMovieButton = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            DashboardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 19);
            label1.Name = "label1";
            label1.Size = new Size(233, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee Name's Dashboard";
            // 
            // DashboardTabs
            // 
            DashboardTabs.Controls.Add(tabPage1);
            DashboardTabs.Controls.Add(tabPage2);
            DashboardTabs.Controls.Add(tabPage3);
            DashboardTabs.Controls.Add(tabPage4);
            DashboardTabs.Location = new Point(10, 61);
            DashboardTabs.Margin = new Padding(3, 2, 3, 2);
            DashboardTabs.Name = "DashboardTabs";
            DashboardTabs.SelectedIndex = 0;
            DashboardTabs.Size = new Size(1160, 412);
            DashboardTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(ModifyCustButton);
            tabPage1.Controls.Add(NewCustButton);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1152, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // ModifyCustButton
            // 
            ModifyCustButton.Location = new Point(19, 52);
            ModifyCustButton.Margin = new Padding(3, 2, 3, 2);
            ModifyCustButton.Name = "ModifyCustButton";
            ModifyCustButton.Size = new Size(217, 51);
            ModifyCustButton.TabIndex = 1;
            ModifyCustButton.Text = "Update/Retrieve/Delete Customer Information";
            ModifyCustButton.UseVisualStyleBackColor = true;
            ModifyCustButton.Click += ModifyCustButtonClick;
            // 
            // NewCustButton
            // 
            NewCustButton.Location = new Point(19, 16);
            NewCustButton.Margin = new Padding(3, 2, 3, 2);
            NewCustButton.Name = "NewCustButton";
            NewCustButton.Size = new Size(217, 32);
            NewCustButton.TabIndex = 0;
            NewCustButton.Text = "Add New Customer";
            NewCustButton.UseVisualStyleBackColor = true;
            NewCustButton.Click += NewCustButtonClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 192, 128);
            tabPage2.Controls.Add(AssignActorButton);
            tabPage2.Controls.Add(ModifyMovieButton);
            tabPage2.Controls.Add(AddMovieButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1152, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie Management";
            // 
            // AssignActorButton
            // 
            AssignActorButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignActorButton.Location = new Point(25, 98);
            AssignActorButton.Margin = new Padding(3, 2, 3, 2);
            AssignActorButton.Name = "AssignActorButton";
            AssignActorButton.Size = new Size(217, 32);
            AssignActorButton.TabIndex = 3;
            AssignActorButton.Text = "Assign Actor to Movie";
            AssignActorButton.UseVisualStyleBackColor = true;
            AssignActorButton.Click += AssignActorButton_Click;
            // 
            // ModifyMovieButton
            // 
            ModifyMovieButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyMovieButton.Location = new Point(25, 62);
            ModifyMovieButton.Margin = new Padding(3, 2, 3, 2);
            ModifyMovieButton.Name = "ModifyMovieButton";
            ModifyMovieButton.Size = new Size(217, 32);
            ModifyMovieButton.TabIndex = 2;
            ModifyMovieButton.Text = "Search/Modify Movie";
            ModifyMovieButton.UseVisualStyleBackColor = true;
            ModifyMovieButton.Click += ModifyMovieButton_Click;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMovieButton.Location = new Point(25, 25);
            AddMovieButton.Margin = new Padding(3, 2, 3, 2);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(217, 32);
            AddMovieButton.TabIndex = 1;
            AddMovieButton.Text = "Add New Movie";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 192);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1152, 384);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rental Management";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(192, 255, 192);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1152, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 499);
            Controls.Add(DashboardTabs);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Employee Homescreen ";
            DashboardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // *******************************
        //   Customer Tab Functionality
        // *******************************
        private void InitializeCustomerInputComponents()
        {
            CustInputPanel = new Panel
            {
                Size = new System.Drawing.Size(799, 364),
                Location = new System.Drawing.Point(336, 15),
                BackColor = System.Drawing.Color.White,
            };
            tabPage1.Controls.Add(CustInputPanel);
            Label lblFirstName = new Label { Text = "First Name:", Location = new Point(20, 20) };
            txtFirstName = new TextBox { Location = new Point(170, 20), Width = 300 };
            Label lblLastName = new Label { Text = "Last Name:", Location = new Point(20, 60) };
            txtLastName = new TextBox { Location = new Point(170, 60), Width = 300 };
            Label lblAddress = new Label { Text = "Address:", Location = new Point(20, 100) };
            txtAddress = new TextBox { Location = new Point(170, 100), Width = 300 };
            Label lblCity = new Label { Text = "City:", Location = new Point(20, 140) };
            txtCity = new TextBox { Location = new Point(170, 140), Width = 300 };
            Label lblState = new Label { Text = "State:", Location = new Point(20, 180) };
            //
            ComboBox cmbState = new ComboBox
            {
                Location = new Point(170, 180),
                Width = 50,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                BackColor = Color.White
            };
            // Add provinces
            cmbState.Items.AddRange(new string[]
            {
                "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT"
            });
            //
            Label lblZip = new Label { Text = "Zip Code:", Location = new Point(20, 220) };
            txtZip = new TextBox { Location = new Point(170, 220), Width = 100 };
            Label lblEmail = new Label { Text = "Email:", Location = new Point(20, 260)};
            txtEmail = new TextBox { Location = new Point(170, 260), Width = 300 };
            Label lblAccountNumber = new Label { Text = "Account Number:", Location = new Point(20, 300)};
            txtAccountNumber = new TextBox { Location = new Point(170, 300), Width = 100 };
            Label lblCreditCard = new Label { Text = "Credit Card:", Location = new Point(20, 340)};
            txtCreditCard = new TextBox { Location = new Point(170, 340), Width = 150 };

            CustInputPanel.Controls.Add(cmbState);
            CustInputPanel.Controls.Add(lblFirstName);
            CustInputPanel.Controls.Add(txtFirstName);
            CustInputPanel.Controls.Add(lblLastName);
            CustInputPanel.Controls.Add(txtLastName);
            CustInputPanel.Controls.Add(lblAddress);
            CustInputPanel.Controls.Add(txtAddress);
            CustInputPanel.Controls.Add(lblCity);
            CustInputPanel.Controls.Add(txtCity);
            CustInputPanel.Controls.Add(lblState);
            CustInputPanel.Controls.Add(lblZip);
            CustInputPanel.Controls.Add(txtZip);
            CustInputPanel.Controls.Add(lblEmail);
            CustInputPanel.Controls.Add(txtEmail);
            CustInputPanel.Controls.Add(lblAccountNumber);
            CustInputPanel.Controls.Add(txtAccountNumber);
            CustInputPanel.Controls.Add(lblCreditCard);
            CustInputPanel.Controls.Add(txtCreditCard);
        }

        // *******************************
        //    Movie Tab Functionality
        // *******************************

        // For the Add Movie and Modify Movie Buttons
        private void InitializeMovieInputComponents()
        {
            MovieInputPanel = new Panel
            {
                Size = new Size(799, 364),
                Location = new Point(336, 15),
                BackColor = Color.White
            };
            tabPage2.Controls.Add(MovieInputPanel);

            Label lblMovieName = new Label { Text = "Movie Name:", Location = new Point(20, 20), AutoSize = true };
            txtMovieName = new TextBox { Location = new Point(170, 20), Width = 300 };

            Label lblMovieType = new Label { Text = "Movie Type:", Location = new Point(20, 60), AutoSize = true };
            cmbMovieType = new ComboBox
            {
                Location = new Point(170, 60),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                BackColor = Color.White
            };
            cmbMovieType.Items.AddRange(new string[] { "Comedy", "Drama", "Action", "Foreign" });

            Label lblDistFee = new Label { Text = "Distribution Fee:", Location = new Point(20, 100), AutoSize = true };
            txtDistFee = new TextBox { Location = new Point(170, 100), Width = 150 };

            Label lblNumCopies = new Label { Text = "Number of Copies:", Location = new Point(20, 140), AutoSize = true };
            txtNumCopies = new TextBox { Location = new Point(170, 140), Width = 100 };

            MovieInputPanel.Controls.Add(lblMovieName);
            MovieInputPanel.Controls.Add(txtMovieName);
            MovieInputPanel.Controls.Add(lblMovieType);
            MovieInputPanel.Controls.Add(cmbMovieType);
            MovieInputPanel.Controls.Add(lblDistFee);
            MovieInputPanel.Controls.Add(txtDistFee);
            MovieInputPanel.Controls.Add(lblNumCopies);
            MovieInputPanel.Controls.Add(txtNumCopies);
        }

        // For the Assign Actor button
        private void InitializeAssignActorComponents()
        {
            AssignActorPanel = new Panel
            {
                Size = new Size(799, 364),
                Location = new Point(336, 15),
                BackColor = Color.White
            };
            tabPage2.Controls.Add(AssignActorPanel);

            Label lblMovieName = new Label { Text = "Movie Name:", Location = new Point(20, 20), AutoSize = true };
            txtAssignMovieName = new TextBox { Location = new Point(170, 20), Width = 300 };

            Label lblActorName = new Label { Text = "Actor Name:", Location = new Point(20, 60), AutoSize = true };
            txtAssignActorName = new TextBox { Location = new Point(170, 60), Width = 300 };

            AssignActorPanel.Controls.Add(lblMovieName);
            AssignActorPanel.Controls.Add(txtAssignMovieName);
            AssignActorPanel.Controls.Add(lblActorName);
            AssignActorPanel.Controls.Add(txtAssignActorName);
        }
        #endregion

        private Label label1;
        private TabControl DashboardTabs;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;

        // Customer Tab
        private TabPage tabPage1;
        private Button NewCustButton;
        private Button ModifyCustButton;
        private ComboBox cmbState;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtZip;
        private TextBox txtEmail;
        private TextBox txtAccountNumber;
        private TextBox txtCreditCard;
        private Panel CustInputPanel;
        private GroupBox groupBox1;

        // Movie Tab
        private TabPage tabPage2;
        private Button AssignActorButton;
        private Button ModifyMovieButton;
        private Button AddMovieButton;
        private Panel MovieInputPanel;
        private TextBox txtDistFee;
        private TextBox txtNumCopies;
        private TextBox txtMovieName;
        private ComboBox cmbMovieType;
        private Panel AssignActorPanel;
        private TextBox txtAssignActorName;
        private TextBox txtAssignMovieName;
    }
}