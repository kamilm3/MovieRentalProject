using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            DashboardTabs = new TabControl();
            tabPage1 = new TabPage();
            AddCustBox = new GroupBox();
            AddCustButton = new Button();
            StateCustComboBox = new ComboBox();
            CreditCustText = new TextBox();
            AccountCustText = new TextBox();
            CityCustText = new TextBox();
            ZipCustText = new TextBox();
            EmailCustText = new TextBox();
            AddressCustText = new TextBox();
            LastNameCustText = new TextBox();
            FirstNameCustText = new TextBox();
            CreditCustLabel = new Label();
            AccountNumCustLabel = new Label();
            EmailCustLabel = new Label();
            ZipCustLabel = new Label();
            StateCustLabel = new Label();
            CityCustLabel = new Label();
            AddressCustLabel = new Label();
            LastNameCustLabel = new Label();
            FirstNameCustLabel = new Label();
            CustSearchButton = new Button();
            EmailSearchLabel = new Label();
            LastNameSearchLabel = new Label();
            FirstNameSearchLabel = new Label();
            EmailSearchText = new TextBox();
            FirstNameSearchText = new TextBox();
            LastNameSearchText = new TextBox();
            ModifyCustButton = new Button();
            NewCustButton = new Button();
            ModifyCustDataView = new DataGridView();
            ModifyCustBox = new GroupBox();
            CustIDText = new TextBox();
            CustIDLabel = new Label();
            DeleteCustButton = new Button();
            UpdateCustButton = new Button();
            StateModComboBox = new ComboBox();
            CreditModText = new TextBox();
            AccountModText = new TextBox();
            CityModText = new TextBox();
            ZipModText = new TextBox();
            EmailModText = new TextBox();
            AddressModText = new TextBox();
            LastNameModText = new TextBox();
            FirstNameModText = new TextBox();
            CreditModLabel = new Label();
            AccountModLabel = new Label();
            EmailModLabel = new Label();
            ZipModLabel = new Label();
            StateModLabel = new Label();
            CityModLabel = new Label();
            AddressModLabel = new Label();
            LastNameModLabel = new Label();
            FirstNameModLabel = new Label();
            tabPage2 = new TabPage();
            SearchMoviePanel = new Panel();
            SearchMovieLabel = new Label();
            SearchMovieText = new TextBox();
            SearchMovieButton = new Button();
            AssignActorButton = new Button();
            ModifyMovieButton = new Button();
            AddMovieButton = new Button();
            AddMovieBox = new GroupBox();
            MovieAddButton = new Button();
            TypeAddComboBox = new ComboBox();
            CopiesAddText = new TextBox();
            FeeAddText = new TextBox();
            NameAddText = new TextBox();
            CopiesAddLabel = new Label();
            FeeAddLabel = new Label();
            TypeAddLabel = new Label();
            NameAddLabel = new Label();
            MovieDataViewPanel = new Panel();
            MovieDataView = new DataGridView();
            ModifyMovieBox = new GroupBox();
            label12 = new Label();
            actorList = new ListBox();
            DeleteMovieButton = new Button();
            MovieIDText = new TextBox();
            MovieIDLabel = new Label();
            MovieModifyButton = new Button();
            TypeModComboBox = new ComboBox();
            CopiesModText = new TextBox();
            FeeModText = new TextBox();
            NameModText = new TextBox();
            CopiesModLabel = new Label();
            FeeMofLabel = new Label();
            TypeModLabel = new Label();
            NameModLabel = new Label();
            AssignActorBox = new GroupBox();
            ActorMovieSearchButton = new Button();
            MovieActorDataView = new DataGridView();
            label11 = new Label();
            label6 = new Label();
            ActorLastAssignText = new TextBox();
            ActorFirstAssignText = new TextBox();
            AssignButton = new Button();
            MovieAssignText = new TextBox();
            ActorAssignLabel = new Label();
            MovieAssignLabel = new Label();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button6 = new Button();
            tabPage4 = new TabPage();
            radioButton2_report5 = new RadioButton();
            radioButton_report5 = new RadioButton();
            dropdownReport4 = new ComboBox();
            label13 = new Label();
            MonthLabel = new Label();
            MonthText = new TextBox();
            ReportDataGrid = new DataGridView();
            label8 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox4 = new TextBox();
            reportButton5 = new Button();
            textBox5 = new TextBox();
            reportButton4 = new Button();
            button3 = new Button();
            Report2Button = new Button();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            DashboardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            AddCustBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ModifyCustDataView).BeginInit();
            ModifyCustBox.SuspendLayout();
            tabPage2.SuspendLayout();
            SearchMoviePanel.SuspendLayout();
            AddMovieBox.SuspendLayout();
            MovieDataViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MovieDataView).BeginInit();
            ModifyMovieBox.SuspendLayout();
            AssignActorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MovieActorDataView).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee Dashboard";
            // 
            // DashboardTabs
            // 
            DashboardTabs.Controls.Add(tabPage1);
            DashboardTabs.Controls.Add(tabPage2);
            DashboardTabs.Controls.Add(tabPage3);
            DashboardTabs.Controls.Add(tabPage4);
            DashboardTabs.Location = new Point(9, 61);
            DashboardTabs.Margin = new Padding(2);
            DashboardTabs.Name = "DashboardTabs";
            DashboardTabs.SelectedIndex = 0;
            DashboardTabs.Size = new Size(1160, 412);
            DashboardTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(AddCustBox);
            tabPage1.Controls.Add(CustSearchButton);
            tabPage1.Controls.Add(EmailSearchLabel);
            tabPage1.Controls.Add(LastNameSearchLabel);
            tabPage1.Controls.Add(FirstNameSearchLabel);
            tabPage1.Controls.Add(EmailSearchText);
            tabPage1.Controls.Add(FirstNameSearchText);
            tabPage1.Controls.Add(LastNameSearchText);
            tabPage1.Controls.Add(ModifyCustButton);
            tabPage1.Controls.Add(NewCustButton);
            tabPage1.Controls.Add(ModifyCustDataView);
            tabPage1.Controls.Add(ModifyCustBox);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1152, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // AddCustBox
            // 
            AddCustBox.BackColor = Color.White;
            AddCustBox.Controls.Add(AddCustButton);
            AddCustBox.Controls.Add(StateCustComboBox);
            AddCustBox.Controls.Add(CreditCustText);
            AddCustBox.Controls.Add(AccountCustText);
            AddCustBox.Controls.Add(CityCustText);
            AddCustBox.Controls.Add(ZipCustText);
            AddCustBox.Controls.Add(EmailCustText);
            AddCustBox.Controls.Add(AddressCustText);
            AddCustBox.Controls.Add(LastNameCustText);
            AddCustBox.Controls.Add(FirstNameCustText);
            AddCustBox.Controls.Add(CreditCustLabel);
            AddCustBox.Controls.Add(AccountNumCustLabel);
            AddCustBox.Controls.Add(EmailCustLabel);
            AddCustBox.Controls.Add(ZipCustLabel);
            AddCustBox.Controls.Add(StateCustLabel);
            AddCustBox.Controls.Add(CityCustLabel);
            AddCustBox.Controls.Add(AddressCustLabel);
            AddCustBox.Controls.Add(LastNameCustLabel);
            AddCustBox.Controls.Add(FirstNameCustLabel);
            AddCustBox.Dock = DockStyle.Right;
            AddCustBox.Location = new Point(-1283, 0);
            AddCustBox.Margin = new Padding(2, 3, 2, 3);
            AddCustBox.Name = "AddCustBox";
            AddCustBox.Padding = new Padding(2, 3, 2, 3);
            AddCustBox.Size = new Size(814, 384);
            AddCustBox.TabIndex = 2;
            AddCustBox.TabStop = false;
            AddCustBox.Visible = false;
            // 
            // AddCustButton
            // 
            AddCustButton.Location = new Point(586, 317);
            AddCustButton.Margin = new Padding(2, 3, 2, 3);
            AddCustButton.Name = "AddCustButton";
            AddCustButton.Size = new Size(96, 37);
            AddCustButton.TabIndex = 18;
            AddCustButton.Text = "Add";
            AddCustButton.UseVisualStyleBackColor = true;
            AddCustButton.Click += AddCustButton_Click;
            // 
            // StateCustComboBox
            // 
            StateCustComboBox.FormattingEnabled = true;
            StateCustComboBox.Items.AddRange(new object[] { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" });
            StateCustComboBox.Location = new Point(202, 178);
            StateCustComboBox.Margin = new Padding(2, 3, 2, 3);
            StateCustComboBox.Name = "StateCustComboBox";
            StateCustComboBox.Size = new Size(68, 29);
            StateCustComboBox.TabIndex = 17;
            // 
            // CreditCustText
            // 
            CreditCustText.Location = new Point(202, 330);
            CreditCustText.Margin = new Padding(2, 3, 2, 3);
            CreditCustText.Name = "CreditCustText";
            CreditCustText.Size = new Size(201, 29);
            CreditCustText.TabIndex = 16;
            // 
            // AccountCustText
            // 
            AccountCustText.Location = new Point(202, 290);
            AccountCustText.Margin = new Padding(2, 3, 2, 3);
            AccountCustText.Name = "AccountCustText";
            AccountCustText.Size = new Size(100, 29);
            AccountCustText.TabIndex = 15;
            // 
            // CityCustText
            // 
            CityCustText.Location = new Point(202, 142);
            CityCustText.Margin = new Padding(2, 3, 2, 3);
            CityCustText.Name = "CityCustText";
            CityCustText.Size = new Size(293, 29);
            CityCustText.TabIndex = 14;
            // 
            // ZipCustText
            // 
            ZipCustText.Location = new Point(202, 213);
            ZipCustText.Margin = new Padding(2, 3, 2, 3);
            ZipCustText.Name = "ZipCustText";
            ZipCustText.Size = new Size(100, 29);
            ZipCustText.TabIndex = 13;
            // 
            // EmailCustText
            // 
            EmailCustText.Location = new Point(202, 248);
            EmailCustText.Margin = new Padding(2, 3, 2, 3);
            EmailCustText.Name = "EmailCustText";
            EmailCustText.Size = new Size(201, 29);
            EmailCustText.TabIndex = 12;
            // 
            // AddressCustText
            // 
            AddressCustText.Location = new Point(202, 104);
            AddressCustText.Margin = new Padding(2, 3, 2, 3);
            AddressCustText.Name = "AddressCustText";
            AddressCustText.Size = new Size(293, 29);
            AddressCustText.TabIndex = 11;
            // 
            // LastNameCustText
            // 
            LastNameCustText.Location = new Point(202, 61);
            LastNameCustText.Margin = new Padding(2, 3, 2, 3);
            LastNameCustText.Name = "LastNameCustText";
            LastNameCustText.Size = new Size(293, 29);
            LastNameCustText.TabIndex = 10;
            // 
            // FirstNameCustText
            // 
            FirstNameCustText.Location = new Point(202, 22);
            FirstNameCustText.Margin = new Padding(2, 3, 2, 3);
            FirstNameCustText.Name = "FirstNameCustText";
            FirstNameCustText.Size = new Size(293, 29);
            FirstNameCustText.TabIndex = 9;
            // 
            // CreditCustLabel
            // 
            CreditCustLabel.AutoSize = true;
            CreditCustLabel.Location = new Point(33, 333);
            CreditCustLabel.Margin = new Padding(2, 0, 2, 0);
            CreditCustLabel.Name = "CreditCustLabel";
            CreditCustLabel.Size = new Size(97, 21);
            CreditCustLabel.TabIndex = 8;
            CreditCustLabel.Text = "Credit Card:";
            // 
            // AccountNumCustLabel
            // 
            AccountNumCustLabel.AutoSize = true;
            AccountNumCustLabel.Location = new Point(33, 293);
            AccountNumCustLabel.Margin = new Padding(2, 0, 2, 0);
            AccountNumCustLabel.Name = "AccountNumCustLabel";
            AccountNumCustLabel.Size = new Size(140, 21);
            AccountNumCustLabel.TabIndex = 7;
            AccountNumCustLabel.Text = "Account Number:";
            // 
            // EmailCustLabel
            // 
            EmailCustLabel.AutoSize = true;
            EmailCustLabel.Location = new Point(33, 256);
            EmailCustLabel.Margin = new Padding(2, 0, 2, 0);
            EmailCustLabel.Name = "EmailCustLabel";
            EmailCustLabel.Size = new Size(52, 21);
            EmailCustLabel.TabIndex = 6;
            EmailCustLabel.Text = "Email:";
            // 
            // ZipCustLabel
            // 
            ZipCustLabel.AutoSize = true;
            ZipCustLabel.Location = new Point(33, 217);
            ZipCustLabel.Margin = new Padding(2, 0, 2, 0);
            ZipCustLabel.Name = "ZipCustLabel";
            ZipCustLabel.Size = new Size(80, 21);
            ZipCustLabel.TabIndex = 5;
            ZipCustLabel.Text = "Zip Code:";
            // 
            // StateCustLabel
            // 
            StateCustLabel.AutoSize = true;
            StateCustLabel.Location = new Point(33, 181);
            StateCustLabel.Margin = new Padding(2, 0, 2, 0);
            StateCustLabel.Name = "StateCustLabel";
            StateCustLabel.Size = new Size(52, 21);
            StateCustLabel.TabIndex = 4;
            StateCustLabel.Text = "State:";
            // 
            // CityCustLabel
            // 
            CityCustLabel.AutoSize = true;
            CityCustLabel.Location = new Point(33, 142);
            CityCustLabel.Margin = new Padding(2, 0, 2, 0);
            CityCustLabel.Name = "CityCustLabel";
            CityCustLabel.Size = new Size(42, 21);
            CityCustLabel.TabIndex = 3;
            CityCustLabel.Text = "City:";
            // 
            // AddressCustLabel
            // 
            AddressCustLabel.AutoSize = true;
            AddressCustLabel.Location = new Point(33, 107);
            AddressCustLabel.Margin = new Padding(2, 0, 2, 0);
            AddressCustLabel.Name = "AddressCustLabel";
            AddressCustLabel.Size = new Size(74, 21);
            AddressCustLabel.TabIndex = 2;
            AddressCustLabel.Text = "Address:";
            // 
            // LastNameCustLabel
            // 
            LastNameCustLabel.AutoSize = true;
            LastNameCustLabel.Location = new Point(33, 66);
            LastNameCustLabel.Margin = new Padding(2, 0, 2, 0);
            LastNameCustLabel.Name = "LastNameCustLabel";
            LastNameCustLabel.Size = new Size(90, 21);
            LastNameCustLabel.TabIndex = 1;
            LastNameCustLabel.Text = "Last Name:";
            // 
            // FirstNameCustLabel
            // 
            FirstNameCustLabel.AutoSize = true;
            FirstNameCustLabel.Location = new Point(33, 25);
            FirstNameCustLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameCustLabel.Name = "FirstNameCustLabel";
            FirstNameCustLabel.Size = new Size(92, 21);
            FirstNameCustLabel.TabIndex = 0;
            FirstNameCustLabel.Text = "First Name:";
            // 
            // CustSearchButton
            // 
            CustSearchButton.Location = new Point(146, 333);
            CustSearchButton.Margin = new Padding(2, 3, 2, 3);
            CustSearchButton.Name = "CustSearchButton";
            CustSearchButton.Size = new Size(90, 29);
            CustSearchButton.TabIndex = 10;
            CustSearchButton.Text = "Search";
            CustSearchButton.UseVisualStyleBackColor = true;
            CustSearchButton.Visible = false;
            CustSearchButton.Click += CustSearchButtonClick;
            // 
            // EmailSearchLabel
            // 
            EmailSearchLabel.AutoSize = true;
            EmailSearchLabel.Location = new Point(19, 288);
            EmailSearchLabel.Margin = new Padding(2, 0, 2, 0);
            EmailSearchLabel.Name = "EmailSearchLabel";
            EmailSearchLabel.Size = new Size(52, 21);
            EmailSearchLabel.TabIndex = 9;
            EmailSearchLabel.Text = "Email:";
            EmailSearchLabel.Visible = false;
            // 
            // LastNameSearchLabel
            // 
            LastNameSearchLabel.AutoSize = true;
            LastNameSearchLabel.Location = new Point(19, 232);
            LastNameSearchLabel.Margin = new Padding(2, 0, 2, 0);
            LastNameSearchLabel.Name = "LastNameSearchLabel";
            LastNameSearchLabel.Size = new Size(90, 21);
            LastNameSearchLabel.TabIndex = 8;
            LastNameSearchLabel.Text = "Last Name:";
            LastNameSearchLabel.Visible = false;
            // 
            // FirstNameSearchLabel
            // 
            FirstNameSearchLabel.AutoSize = true;
            FirstNameSearchLabel.Location = new Point(19, 176);
            FirstNameSearchLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameSearchLabel.Name = "FirstNameSearchLabel";
            FirstNameSearchLabel.Size = new Size(92, 21);
            FirstNameSearchLabel.TabIndex = 7;
            FirstNameSearchLabel.Text = "First Name:";
            FirstNameSearchLabel.Visible = false;
            // 
            // EmailSearchText
            // 
            EmailSearchText.Location = new Point(112, 285);
            EmailSearchText.Margin = new Padding(2, 3, 2, 3);
            EmailSearchText.Name = "EmailSearchText";
            EmailSearchText.Size = new Size(188, 29);
            EmailSearchText.TabIndex = 6;
            EmailSearchText.Visible = false;
            // 
            // FirstNameSearchText
            // 
            FirstNameSearchText.Location = new Point(112, 173);
            FirstNameSearchText.Margin = new Padding(2, 3, 2, 3);
            FirstNameSearchText.Name = "FirstNameSearchText";
            FirstNameSearchText.Size = new Size(188, 29);
            FirstNameSearchText.TabIndex = 5;
            FirstNameSearchText.Visible = false;
            // 
            // LastNameSearchText
            // 
            LastNameSearchText.Location = new Point(112, 229);
            LastNameSearchText.Margin = new Padding(2, 3, 2, 3);
            LastNameSearchText.Name = "LastNameSearchText";
            LastNameSearchText.Size = new Size(188, 29);
            LastNameSearchText.TabIndex = 4;
            LastNameSearchText.Visible = false;
            // 
            // ModifyCustButton
            // 
            ModifyCustButton.Location = new Point(19, 52);
            ModifyCustButton.Margin = new Padding(2);
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
            NewCustButton.Margin = new Padding(2);
            NewCustButton.Name = "NewCustButton";
            NewCustButton.Size = new Size(217, 32);
            NewCustButton.TabIndex = 0;
            NewCustButton.Text = "Add New Customer";
            NewCustButton.UseVisualStyleBackColor = true;
            NewCustButton.Click += NewCustButtonClick;
            // 
            // ModifyCustDataView
            // 
            ModifyCustDataView.AllowUserToAddRows = false;
            ModifyCustDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ModifyCustDataView.BackgroundColor = Color.White;
            ModifyCustDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ModifyCustDataView.DefaultCellStyle = dataGridViewCellStyle1;
            ModifyCustDataView.Dock = DockStyle.Right;
            ModifyCustDataView.GridColor = Color.LightGray;
            ModifyCustDataView.Location = new Point(-469, 0);
            ModifyCustDataView.Margin = new Padding(2, 3, 2, 3);
            ModifyCustDataView.Name = "ModifyCustDataView";
            ModifyCustDataView.ReadOnly = true;
            ModifyCustDataView.RowHeadersWidth = 51;
            ModifyCustDataView.Size = new Size(807, 384);
            ModifyCustDataView.TabIndex = 11;
            ModifyCustDataView.Visible = false;
            ModifyCustDataView.CellClick += ModifyCustDataViewCellClick;
            // 
            // ModifyCustBox
            // 
            ModifyCustBox.BackColor = Color.White;
            ModifyCustBox.Controls.Add(CustIDText);
            ModifyCustBox.Controls.Add(CustIDLabel);
            ModifyCustBox.Controls.Add(DeleteCustButton);
            ModifyCustBox.Controls.Add(UpdateCustButton);
            ModifyCustBox.Controls.Add(StateModComboBox);
            ModifyCustBox.Controls.Add(CreditModText);
            ModifyCustBox.Controls.Add(AccountModText);
            ModifyCustBox.Controls.Add(CityModText);
            ModifyCustBox.Controls.Add(ZipModText);
            ModifyCustBox.Controls.Add(EmailModText);
            ModifyCustBox.Controls.Add(AddressModText);
            ModifyCustBox.Controls.Add(LastNameModText);
            ModifyCustBox.Controls.Add(FirstNameModText);
            ModifyCustBox.Controls.Add(CreditModLabel);
            ModifyCustBox.Controls.Add(AccountModLabel);
            ModifyCustBox.Controls.Add(EmailModLabel);
            ModifyCustBox.Controls.Add(ZipModLabel);
            ModifyCustBox.Controls.Add(StateModLabel);
            ModifyCustBox.Controls.Add(CityModLabel);
            ModifyCustBox.Controls.Add(AddressModLabel);
            ModifyCustBox.Controls.Add(LastNameModLabel);
            ModifyCustBox.Controls.Add(FirstNameModLabel);
            ModifyCustBox.Dock = DockStyle.Right;
            ModifyCustBox.Location = new Point(338, 0);
            ModifyCustBox.Margin = new Padding(2, 3, 2, 3);
            ModifyCustBox.Name = "ModifyCustBox";
            ModifyCustBox.Padding = new Padding(2, 3, 2, 3);
            ModifyCustBox.Size = new Size(814, 384);
            ModifyCustBox.TabIndex = 3;
            ModifyCustBox.TabStop = false;
            ModifyCustBox.Visible = false;
            // 
            // CustIDText
            // 
            CustIDText.Location = new Point(639, 22);
            CustIDText.Margin = new Padding(2, 3, 2, 3);
            CustIDText.Name = "CustIDText";
            CustIDText.ReadOnly = true;
            CustIDText.Size = new Size(68, 29);
            CustIDText.TabIndex = 23;
            // 
            // CustIDLabel
            // 
            CustIDLabel.AutoSize = true;
            CustIDLabel.Location = new Point(527, 25);
            CustIDLabel.Margin = new Padding(2, 0, 2, 0);
            CustIDLabel.Name = "CustIDLabel";
            CustIDLabel.Size = new Size(105, 21);
            CustIDLabel.TabIndex = 22;
            CustIDLabel.Text = "Customer ID:";
            // 
            // DeleteCustButton
            // 
            DeleteCustButton.BackColor = Color.Transparent;
            DeleteCustButton.Location = new Point(672, 319);
            DeleteCustButton.Margin = new Padding(2, 3, 2, 3);
            DeleteCustButton.Name = "DeleteCustButton";
            DeleteCustButton.Size = new Size(96, 40);
            DeleteCustButton.TabIndex = 21;
            DeleteCustButton.Text = "Delete";
            DeleteCustButton.UseVisualStyleBackColor = false;
            DeleteCustButton.Click += DeleteCustButton_Click;
            // 
            // UpdateCustButton
            // 
            UpdateCustButton.Location = new Point(519, 319);
            UpdateCustButton.Margin = new Padding(2, 3, 2, 3);
            UpdateCustButton.Name = "UpdateCustButton";
            UpdateCustButton.Size = new Size(96, 37);
            UpdateCustButton.TabIndex = 18;
            UpdateCustButton.Text = "Update";
            UpdateCustButton.UseVisualStyleBackColor = true;
            UpdateCustButton.Click += UpdateCustButton_Click;
            // 
            // StateModComboBox
            // 
            StateModComboBox.FormattingEnabled = true;
            StateModComboBox.Items.AddRange(new object[] { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" });
            StateModComboBox.Location = new Point(202, 178);
            StateModComboBox.Margin = new Padding(2, 3, 2, 3);
            StateModComboBox.Name = "StateModComboBox";
            StateModComboBox.Size = new Size(67, 29);
            StateModComboBox.TabIndex = 17;
            // 
            // CreditModText
            // 
            CreditModText.Location = new Point(202, 330);
            CreditModText.Margin = new Padding(2, 3, 2, 3);
            CreditModText.Name = "CreditModText";
            CreditModText.Size = new Size(167, 29);
            CreditModText.TabIndex = 16;
            // 
            // AccountModText
            // 
            AccountModText.Location = new Point(202, 290);
            AccountModText.Margin = new Padding(2, 3, 2, 3);
            AccountModText.Name = "AccountModText";
            AccountModText.Size = new Size(100, 29);
            AccountModText.TabIndex = 15;
            // 
            // CityModText
            // 
            CityModText.Location = new Point(202, 142);
            CityModText.Margin = new Padding(2, 3, 2, 3);
            CityModText.Name = "CityModText";
            CityModText.Size = new Size(293, 29);
            CityModText.TabIndex = 14;
            // 
            // ZipModText
            // 
            ZipModText.Location = new Point(202, 213);
            ZipModText.Margin = new Padding(2, 3, 2, 3);
            ZipModText.Name = "ZipModText";
            ZipModText.Size = new Size(100, 29);
            ZipModText.TabIndex = 13;
            // 
            // EmailModText
            // 
            EmailModText.Location = new Point(202, 248);
            EmailModText.Margin = new Padding(2, 3, 2, 3);
            EmailModText.Name = "EmailModText";
            EmailModText.Size = new Size(293, 29);
            EmailModText.TabIndex = 12;
            // 
            // AddressModText
            // 
            AddressModText.Location = new Point(202, 104);
            AddressModText.Margin = new Padding(2, 3, 2, 3);
            AddressModText.Name = "AddressModText";
            AddressModText.Size = new Size(293, 29);
            AddressModText.TabIndex = 11;
            // 
            // LastNameModText
            // 
            LastNameModText.Location = new Point(202, 61);
            LastNameModText.Margin = new Padding(2, 3, 2, 3);
            LastNameModText.Name = "LastNameModText";
            LastNameModText.Size = new Size(293, 29);
            LastNameModText.TabIndex = 10;
            // 
            // FirstNameModText
            // 
            FirstNameModText.Location = new Point(202, 22);
            FirstNameModText.Margin = new Padding(2, 3, 2, 3);
            FirstNameModText.Name = "FirstNameModText";
            FirstNameModText.Size = new Size(293, 29);
            FirstNameModText.TabIndex = 9;
            FirstNameModText.TextChanged += FirstNameModText_TextChanged;
            // 
            // CreditModLabel
            // 
            CreditModLabel.AutoSize = true;
            CreditModLabel.Location = new Point(33, 333);
            CreditModLabel.Margin = new Padding(2, 0, 2, 0);
            CreditModLabel.Name = "CreditModLabel";
            CreditModLabel.Size = new Size(97, 21);
            CreditModLabel.TabIndex = 8;
            CreditModLabel.Text = "Credit Card:";
            // 
            // AccountModLabel
            // 
            AccountModLabel.AutoSize = true;
            AccountModLabel.Location = new Point(33, 293);
            AccountModLabel.Margin = new Padding(2, 0, 2, 0);
            AccountModLabel.Name = "AccountModLabel";
            AccountModLabel.Size = new Size(140, 21);
            AccountModLabel.TabIndex = 7;
            AccountModLabel.Text = "Account Number:";
            // 
            // EmailModLabel
            // 
            EmailModLabel.AutoSize = true;
            EmailModLabel.Location = new Point(33, 256);
            EmailModLabel.Margin = new Padding(2, 0, 2, 0);
            EmailModLabel.Name = "EmailModLabel";
            EmailModLabel.Size = new Size(52, 21);
            EmailModLabel.TabIndex = 6;
            EmailModLabel.Text = "Email:";
            // 
            // ZipModLabel
            // 
            ZipModLabel.AutoSize = true;
            ZipModLabel.Location = new Point(33, 217);
            ZipModLabel.Margin = new Padding(2, 0, 2, 0);
            ZipModLabel.Name = "ZipModLabel";
            ZipModLabel.Size = new Size(80, 21);
            ZipModLabel.TabIndex = 5;
            ZipModLabel.Text = "Zip Code:";
            // 
            // StateModLabel
            // 
            StateModLabel.AutoSize = true;
            StateModLabel.Location = new Point(33, 181);
            StateModLabel.Margin = new Padding(2, 0, 2, 0);
            StateModLabel.Name = "StateModLabel";
            StateModLabel.Size = new Size(52, 21);
            StateModLabel.TabIndex = 4;
            StateModLabel.Text = "State:";
            // 
            // CityModLabel
            // 
            CityModLabel.AutoSize = true;
            CityModLabel.Location = new Point(33, 142);
            CityModLabel.Margin = new Padding(2, 0, 2, 0);
            CityModLabel.Name = "CityModLabel";
            CityModLabel.Size = new Size(42, 21);
            CityModLabel.TabIndex = 3;
            CityModLabel.Text = "City:";
            // 
            // AddressModLabel
            // 
            AddressModLabel.AutoSize = true;
            AddressModLabel.Location = new Point(33, 107);
            AddressModLabel.Margin = new Padding(2, 0, 2, 0);
            AddressModLabel.Name = "AddressModLabel";
            AddressModLabel.Size = new Size(74, 21);
            AddressModLabel.TabIndex = 2;
            AddressModLabel.Text = "Address:";
            // 
            // LastNameModLabel
            // 
            LastNameModLabel.AutoSize = true;
            LastNameModLabel.Location = new Point(33, 66);
            LastNameModLabel.Margin = new Padding(2, 0, 2, 0);
            LastNameModLabel.Name = "LastNameModLabel";
            LastNameModLabel.Size = new Size(90, 21);
            LastNameModLabel.TabIndex = 1;
            LastNameModLabel.Text = "Last Name:";
            // 
            // FirstNameModLabel
            // 
            FirstNameModLabel.AutoSize = true;
            FirstNameModLabel.Location = new Point(33, 25);
            FirstNameModLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameModLabel.Name = "FirstNameModLabel";
            FirstNameModLabel.Size = new Size(92, 21);
            FirstNameModLabel.TabIndex = 0;
            FirstNameModLabel.Text = "First Name:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 192, 128);
            tabPage2.Controls.Add(SearchMoviePanel);
            tabPage2.Controls.Add(AssignActorButton);
            tabPage2.Controls.Add(ModifyMovieButton);
            tabPage2.Controls.Add(AddMovieButton);
            tabPage2.Controls.Add(AddMovieBox);
            tabPage2.Controls.Add(MovieDataViewPanel);
            tabPage2.Controls.Add(AssignActorBox);
            tabPage2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1152, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie Management";
            // 
            // SearchMoviePanel
            // 
            SearchMoviePanel.BackColor = Color.Transparent;
            SearchMoviePanel.Controls.Add(SearchMovieLabel);
            SearchMoviePanel.Controls.Add(SearchMovieText);
            SearchMoviePanel.Controls.Add(SearchMovieButton);
            SearchMoviePanel.Location = new Point(0, 159);
            SearchMoviePanel.Margin = new Padding(3, 2, 3, 2);
            SearchMoviePanel.Name = "SearchMoviePanel";
            SearchMoviePanel.Size = new Size(301, 226);
            SearchMoviePanel.TabIndex = 7;
            SearchMoviePanel.Visible = false;
            // 
            // SearchMovieLabel
            // 
            SearchMovieLabel.AutoSize = true;
            SearchMovieLabel.Location = new Point(9, 115);
            SearchMovieLabel.Name = "SearchMovieLabel";
            SearchMovieLabel.Size = new Size(96, 21);
            SearchMovieLabel.TabIndex = 2;
            SearchMovieLabel.Text = "Movie Title:";
            // 
            // SearchMovieText
            // 
            SearchMovieText.Location = new Point(122, 113);
            SearchMovieText.Margin = new Padding(3, 2, 3, 2);
            SearchMovieText.Name = "SearchMovieText";
            SearchMovieText.Size = new Size(168, 29);
            SearchMovieText.TabIndex = 1;
            // 
            // SearchMovieButton
            // 
            SearchMovieButton.Location = new Point(197, 165);
            SearchMovieButton.Margin = new Padding(3, 2, 3, 2);
            SearchMovieButton.Name = "SearchMovieButton";
            SearchMovieButton.Size = new Size(93, 33);
            SearchMovieButton.TabIndex = 0;
            SearchMovieButton.Text = "Search";
            SearchMovieButton.UseVisualStyleBackColor = true;
            SearchMovieButton.Click += SearchMovieButton_Click;
            // 
            // AssignActorButton
            // 
            AssignActorButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignActorButton.Location = new Point(26, 98);
            AssignActorButton.Margin = new Padding(2);
            AssignActorButton.Name = "AssignActorButton";
            AssignActorButton.Size = new Size(217, 32);
            AssignActorButton.TabIndex = 3;
            AssignActorButton.Text = "Assign Actor to Movie";
            AssignActorButton.UseVisualStyleBackColor = true;
            AssignActorButton.Click += AssignActorButton_Click;
            // 
            // ModifyMovieButton
            // 
            ModifyMovieButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyMovieButton.Location = new Point(26, 62);
            ModifyMovieButton.Margin = new Padding(2);
            ModifyMovieButton.Name = "ModifyMovieButton";
            ModifyMovieButton.Size = new Size(217, 32);
            ModifyMovieButton.TabIndex = 2;
            ModifyMovieButton.Text = "Search/Modify/Delete Movie";
            ModifyMovieButton.UseVisualStyleBackColor = true;
            ModifyMovieButton.Click += ModifyMovieButton_Click;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMovieButton.Location = new Point(26, 25);
            AddMovieButton.Margin = new Padding(2);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(217, 32);
            AddMovieButton.TabIndex = 1;
            AddMovieButton.Text = "Add New Movie";
            AddMovieButton.UseVisualStyleBackColor = true;
            AddMovieButton.Click += AddMovieButton_Click;
            // 
            // AddMovieBox
            // 
            AddMovieBox.BackColor = Color.White;
            AddMovieBox.Controls.Add(MovieAddButton);
            AddMovieBox.Controls.Add(TypeAddComboBox);
            AddMovieBox.Controls.Add(CopiesAddText);
            AddMovieBox.Controls.Add(FeeAddText);
            AddMovieBox.Controls.Add(NameAddText);
            AddMovieBox.Controls.Add(CopiesAddLabel);
            AddMovieBox.Controls.Add(FeeAddLabel);
            AddMovieBox.Controls.Add(TypeAddLabel);
            AddMovieBox.Controls.Add(NameAddLabel);
            AddMovieBox.Location = new Point(305, 2);
            AddMovieBox.Margin = new Padding(2, 3, 2, 3);
            AddMovieBox.Name = "AddMovieBox";
            AddMovieBox.Padding = new Padding(2, 3, 2, 3);
            AddMovieBox.Size = new Size(800, 388);
            AddMovieBox.TabIndex = 4;
            AddMovieBox.TabStop = false;
            AddMovieBox.Visible = false;
            // 
            // MovieAddButton
            // 
            MovieAddButton.Location = new Point(537, 309);
            MovieAddButton.Margin = new Padding(2, 3, 2, 3);
            MovieAddButton.Name = "MovieAddButton";
            MovieAddButton.Size = new Size(121, 39);
            MovieAddButton.TabIndex = 8;
            MovieAddButton.Text = "Add";
            MovieAddButton.UseVisualStyleBackColor = true;
            MovieAddButton.Click += MovieAddButton_Click;
            // 
            // TypeAddComboBox
            // 
            TypeAddComboBox.FormattingEnabled = true;
            TypeAddComboBox.Items.AddRange(new object[] { "Comedy", "Drama", "Action", "Foreign" });
            TypeAddComboBox.Location = new Point(243, 98);
            TypeAddComboBox.Margin = new Padding(2, 3, 2, 3);
            TypeAddComboBox.Name = "TypeAddComboBox";
            TypeAddComboBox.Size = new Size(152, 29);
            TypeAddComboBox.TabIndex = 7;
            // 
            // CopiesAddText
            // 
            CopiesAddText.Location = new Point(243, 221);
            CopiesAddText.Margin = new Padding(2, 3, 2, 3);
            CopiesAddText.Name = "CopiesAddText";
            CopiesAddText.Size = new Size(100, 29);
            CopiesAddText.TabIndex = 6;
            // 
            // FeeAddText
            // 
            FeeAddText.Location = new Point(243, 158);
            FeeAddText.Margin = new Padding(2, 3, 2, 3);
            FeeAddText.Name = "FeeAddText";
            FeeAddText.Size = new Size(152, 29);
            FeeAddText.TabIndex = 5;
            // 
            // NameAddText
            // 
            NameAddText.Location = new Point(243, 30);
            NameAddText.Margin = new Padding(2, 3, 2, 3);
            NameAddText.Name = "NameAddText";
            NameAddText.Size = new Size(264, 29);
            NameAddText.TabIndex = 4;
            // 
            // CopiesAddLabel
            // 
            CopiesAddLabel.AutoSize = true;
            CopiesAddLabel.Location = new Point(54, 224);
            CopiesAddLabel.Margin = new Padding(2, 0, 2, 0);
            CopiesAddLabel.Name = "CopiesAddLabel";
            CopiesAddLabel.Size = new Size(148, 21);
            CopiesAddLabel.TabIndex = 3;
            CopiesAddLabel.Text = "Number of Copies:";
            // 
            // FeeAddLabel
            // 
            FeeAddLabel.AutoSize = true;
            FeeAddLabel.Location = new Point(54, 161);
            FeeAddLabel.Margin = new Padding(2, 0, 2, 0);
            FeeAddLabel.Name = "FeeAddLabel";
            FeeAddLabel.Size = new Size(130, 21);
            FeeAddLabel.TabIndex = 2;
            FeeAddLabel.Text = "Distribution Fee:";
            // 
            // TypeAddLabel
            // 
            TypeAddLabel.AutoSize = true;
            TypeAddLabel.Location = new Point(54, 98);
            TypeAddLabel.Margin = new Padding(2, 0, 2, 0);
            TypeAddLabel.Name = "TypeAddLabel";
            TypeAddLabel.Size = new Size(99, 21);
            TypeAddLabel.TabIndex = 1;
            TypeAddLabel.Text = "Movie Type:";
            // 
            // NameAddLabel
            // 
            NameAddLabel.AutoSize = true;
            NameAddLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameAddLabel.Location = new Point(54, 33);
            NameAddLabel.Margin = new Padding(2, 0, 2, 0);
            NameAddLabel.Name = "NameAddLabel";
            NameAddLabel.Size = new Size(107, 21);
            NameAddLabel.TabIndex = 0;
            NameAddLabel.Text = "Movie Name:";
            // 
            // MovieDataViewPanel
            // 
            MovieDataViewPanel.BackColor = Color.White;
            MovieDataViewPanel.Controls.Add(MovieDataView);
            MovieDataViewPanel.Controls.Add(ModifyMovieBox);
            MovieDataViewPanel.Location = new Point(306, 0);
            MovieDataViewPanel.Margin = new Padding(3, 2, 3, 2);
            MovieDataViewPanel.Name = "MovieDataViewPanel";
            MovieDataViewPanel.Size = new Size(843, 386);
            MovieDataViewPanel.TabIndex = 8;
            MovieDataViewPanel.Visible = false;
            // 
            // MovieDataView
            // 
            MovieDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MovieDataView.Location = new Point(34, 16);
            MovieDataView.Margin = new Padding(3, 2, 3, 2);
            MovieDataView.Name = "MovieDataView";
            MovieDataView.RowHeadersWidth = 51;
            MovieDataView.Size = new Size(785, 356);
            MovieDataView.TabIndex = 0;
            MovieDataView.Visible = false;
            MovieDataView.CellClick += MovieDataView_CellClick;
            // 
            // ModifyMovieBox
            // 
            ModifyMovieBox.BackColor = Color.White;
            ModifyMovieBox.Controls.Add(label12);
            ModifyMovieBox.Controls.Add(actorList);
            ModifyMovieBox.Controls.Add(DeleteMovieButton);
            ModifyMovieBox.Controls.Add(MovieIDText);
            ModifyMovieBox.Controls.Add(MovieIDLabel);
            ModifyMovieBox.Controls.Add(MovieModifyButton);
            ModifyMovieBox.Controls.Add(TypeModComboBox);
            ModifyMovieBox.Controls.Add(CopiesModText);
            ModifyMovieBox.Controls.Add(FeeModText);
            ModifyMovieBox.Controls.Add(NameModText);
            ModifyMovieBox.Controls.Add(CopiesModLabel);
            ModifyMovieBox.Controls.Add(FeeMofLabel);
            ModifyMovieBox.Controls.Add(TypeModLabel);
            ModifyMovieBox.Controls.Add(NameModLabel);
            ModifyMovieBox.Location = new Point(14, 0);
            ModifyMovieBox.Margin = new Padding(2, 3, 2, 3);
            ModifyMovieBox.Name = "ModifyMovieBox";
            ModifyMovieBox.Padding = new Padding(2, 3, 2, 3);
            ModifyMovieBox.Size = new Size(821, 388);
            ModifyMovieBox.TabIndex = 5;
            ModifyMovieBox.TabStop = false;
            ModifyMovieBox.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(519, 98);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 13;
            label12.Text = "Actors:";
            // 
            // actorList
            // 
            actorList.FormattingEnabled = true;
            actorList.ItemHeight = 21;
            actorList.Location = new Point(519, 131);
            actorList.Margin = new Padding(3, 2, 3, 2);
            actorList.Name = "actorList";
            actorList.Size = new Size(266, 130);
            actorList.TabIndex = 12;
            // 
            // DeleteMovieButton
            // 
            DeleteMovieButton.Location = new Point(650, 312);
            DeleteMovieButton.Margin = new Padding(2, 3, 2, 3);
            DeleteMovieButton.Name = "DeleteMovieButton";
            DeleteMovieButton.Size = new Size(112, 39);
            DeleteMovieButton.TabIndex = 11;
            DeleteMovieButton.Text = "Delete";
            DeleteMovieButton.UseVisualStyleBackColor = true;
            DeleteMovieButton.Click += DeleteMovieButton_Click;
            // 
            // MovieIDText
            // 
            MovieIDText.Enabled = false;
            MovieIDText.Location = new Point(621, 33);
            MovieIDText.Margin = new Padding(2, 3, 2, 3);
            MovieIDText.Name = "MovieIDText";
            MovieIDText.ReadOnly = true;
            MovieIDText.Size = new Size(115, 29);
            MovieIDText.TabIndex = 10;
            // 
            // MovieIDLabel
            // 
            MovieIDLabel.AutoSize = true;
            MovieIDLabel.Location = new Point(519, 36);
            MovieIDLabel.Margin = new Padding(2, 0, 2, 0);
            MovieIDLabel.Name = "MovieIDLabel";
            MovieIDLabel.Size = new Size(80, 21);
            MovieIDLabel.TabIndex = 9;
            MovieIDLabel.Text = "Movie ID:";
            // 
            // MovieModifyButton
            // 
            MovieModifyButton.Location = new Point(477, 312);
            MovieModifyButton.Margin = new Padding(2, 3, 2, 3);
            MovieModifyButton.Name = "MovieModifyButton";
            MovieModifyButton.Size = new Size(121, 39);
            MovieModifyButton.TabIndex = 8;
            MovieModifyButton.Text = "Submit";
            MovieModifyButton.UseVisualStyleBackColor = true;
            MovieModifyButton.Click += MovieModifyButton_Click;
            // 
            // TypeModComboBox
            // 
            TypeModComboBox.FormattingEnabled = true;
            TypeModComboBox.Items.AddRange(new object[] { "Comedy", "Drama", "Action", "Foreign" });
            TypeModComboBox.Location = new Point(225, 98);
            TypeModComboBox.Margin = new Padding(2, 3, 2, 3);
            TypeModComboBox.Name = "TypeModComboBox";
            TypeModComboBox.Size = new Size(152, 29);
            TypeModComboBox.TabIndex = 7;
            // 
            // CopiesModText
            // 
            CopiesModText.Location = new Point(225, 221);
            CopiesModText.Margin = new Padding(2, 3, 2, 3);
            CopiesModText.Name = "CopiesModText";
            CopiesModText.Size = new Size(100, 29);
            CopiesModText.TabIndex = 6;
            // 
            // FeeModText
            // 
            FeeModText.Location = new Point(225, 158);
            FeeModText.Margin = new Padding(2, 3, 2, 3);
            FeeModText.Name = "FeeModText";
            FeeModText.Size = new Size(152, 29);
            FeeModText.TabIndex = 5;
            // 
            // NameModText
            // 
            NameModText.Location = new Point(225, 30);
            NameModText.Margin = new Padding(2, 3, 2, 3);
            NameModText.Name = "NameModText";
            NameModText.Size = new Size(264, 29);
            NameModText.TabIndex = 4;
            // 
            // CopiesModLabel
            // 
            CopiesModLabel.AutoSize = true;
            CopiesModLabel.Location = new Point(54, 224);
            CopiesModLabel.Margin = new Padding(2, 0, 2, 0);
            CopiesModLabel.Name = "CopiesModLabel";
            CopiesModLabel.Size = new Size(148, 21);
            CopiesModLabel.TabIndex = 3;
            CopiesModLabel.Text = "Number of Copies:";
            // 
            // FeeMofLabel
            // 
            FeeMofLabel.AutoSize = true;
            FeeMofLabel.Location = new Point(54, 161);
            FeeMofLabel.Margin = new Padding(2, 0, 2, 0);
            FeeMofLabel.Name = "FeeMofLabel";
            FeeMofLabel.Size = new Size(130, 21);
            FeeMofLabel.TabIndex = 2;
            FeeMofLabel.Text = "Distribution Fee:";
            // 
            // TypeModLabel
            // 
            TypeModLabel.AutoSize = true;
            TypeModLabel.Location = new Point(54, 98);
            TypeModLabel.Margin = new Padding(2, 0, 2, 0);
            TypeModLabel.Name = "TypeModLabel";
            TypeModLabel.Size = new Size(99, 21);
            TypeModLabel.TabIndex = 1;
            TypeModLabel.Text = "Movie Type:";
            // 
            // NameModLabel
            // 
            NameModLabel.AutoSize = true;
            NameModLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameModLabel.Location = new Point(54, 33);
            NameModLabel.Margin = new Padding(2, 0, 2, 0);
            NameModLabel.Name = "NameModLabel";
            NameModLabel.Size = new Size(107, 21);
            NameModLabel.TabIndex = 0;
            NameModLabel.Text = "Movie Name:";
            // 
            // AssignActorBox
            // 
            AssignActorBox.BackColor = Color.White;
            AssignActorBox.Controls.Add(ActorMovieSearchButton);
            AssignActorBox.Controls.Add(MovieActorDataView);
            AssignActorBox.Controls.Add(label11);
            AssignActorBox.Controls.Add(label6);
            AssignActorBox.Controls.Add(ActorLastAssignText);
            AssignActorBox.Controls.Add(ActorFirstAssignText);
            AssignActorBox.Controls.Add(AssignButton);
            AssignActorBox.Controls.Add(MovieAssignText);
            AssignActorBox.Controls.Add(ActorAssignLabel);
            AssignActorBox.Controls.Add(MovieAssignLabel);
            AssignActorBox.Location = new Point(329, 0);
            AssignActorBox.Margin = new Padding(2, 3, 2, 3);
            AssignActorBox.Name = "AssignActorBox";
            AssignActorBox.Padding = new Padding(2, 3, 2, 3);
            AssignActorBox.Size = new Size(824, 388);
            AssignActorBox.TabIndex = 6;
            AssignActorBox.TabStop = false;
            AssignActorBox.Visible = false;
            // 
            // ActorMovieSearchButton
            // 
            ActorMovieSearchButton.Location = new Point(514, 28);
            ActorMovieSearchButton.Margin = new Padding(3, 2, 3, 2);
            ActorMovieSearchButton.Name = "ActorMovieSearchButton";
            ActorMovieSearchButton.Size = new Size(82, 28);
            ActorMovieSearchButton.TabIndex = 14;
            ActorMovieSearchButton.Text = "Search";
            ActorMovieSearchButton.UseVisualStyleBackColor = true;
            ActorMovieSearchButton.Click += ActorMovieSearchButton_Click;
            // 
            // MovieActorDataView
            // 
            MovieActorDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MovieActorDataView.Location = new Point(54, 64);
            MovieActorDataView.Margin = new Padding(3, 2, 3, 2);
            MovieActorDataView.Name = "MovieActorDataView";
            MovieActorDataView.RowHeadersWidth = 51;
            MovieActorDataView.Size = new Size(499, 152);
            MovieActorDataView.TabIndex = 13;
            MovieActorDataView.CellClick += MovieActorDataView_CellClick;
            MovieActorDataView.CellContentClick += MovieActorDataView_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(415, 272);
            label11.Name = "label11";
            label11.Size = new Size(75, 19);
            label11.TabIndex = 12;
            label11.Text = "Last Name";
            label11.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 272);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 11;
            label6.Text = "First Name";
            label6.Visible = false;
            // 
            // ActorLastAssignText
            // 
            ActorLastAssignText.Location = new Point(415, 239);
            ActorLastAssignText.Margin = new Padding(2, 3, 2, 3);
            ActorLastAssignText.Name = "ActorLastAssignText";
            ActorLastAssignText.Size = new Size(143, 29);
            ActorLastAssignText.TabIndex = 10;
            ActorLastAssignText.Visible = false;
            // 
            // ActorFirstAssignText
            // 
            ActorFirstAssignText.Location = new Point(225, 239);
            ActorFirstAssignText.Margin = new Padding(2, 3, 2, 3);
            ActorFirstAssignText.Name = "ActorFirstAssignText";
            ActorFirstAssignText.Size = new Size(143, 29);
            ActorFirstAssignText.TabIndex = 9;
            ActorFirstAssignText.Visible = false;
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(225, 335);
            AssignButton.Margin = new Padding(2, 3, 2, 3);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(121, 39);
            AssignButton.TabIndex = 8;
            AssignButton.Text = "Assign Actor";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Visible = false;
            AssignButton.Click += AssignButton_Click;
            // 
            // MovieAssignText
            // 
            MovieAssignText.Location = new Point(225, 30);
            MovieAssignText.Margin = new Padding(2, 3, 2, 3);
            MovieAssignText.Name = "MovieAssignText";
            MovieAssignText.Size = new Size(264, 29);
            MovieAssignText.TabIndex = 4;
            // 
            // ActorAssignLabel
            // 
            ActorAssignLabel.AutoSize = true;
            ActorAssignLabel.Location = new Point(54, 239);
            ActorAssignLabel.Margin = new Padding(2, 0, 2, 0);
            ActorAssignLabel.Name = "ActorAssignLabel";
            ActorAssignLabel.Size = new Size(102, 21);
            ActorAssignLabel.TabIndex = 1;
            ActorAssignLabel.Text = "Actor Name:";
            ActorAssignLabel.Visible = false;
            // 
            // MovieAssignLabel
            // 
            MovieAssignLabel.AutoSize = true;
            MovieAssignLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MovieAssignLabel.Location = new Point(54, 33);
            MovieAssignLabel.Margin = new Padding(2, 0, 2, 0);
            MovieAssignLabel.Name = "MovieAssignLabel";
            MovieAssignLabel.Size = new Size(107, 21);
            MovieAssignLabel.TabIndex = 0;
            MovieAssignLabel.Text = "Movie Name:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 192);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(1152, 384);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rental Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 59);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 214);
            dataGridView1.TabIndex = 17;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 154);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Email Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 171);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 121);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 59);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 9;
            label2.Text = "Customer's Movie Queue";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 76);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 28);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 21);
            label5.TabIndex = 4;
            label5.Text = "Fill in the following fields:";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(57, 216);
            button6.Margin = new Padding(2, 3, 2, 3);
            button6.Name = "button6";
            button6.Size = new Size(217, 32);
            button6.TabIndex = 3;
            button6.Text = "Search Customer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(192, 255, 192);
            tabPage4.Controls.Add(radioButton2_report5);
            tabPage4.Controls.Add(radioButton_report5);
            tabPage4.Controls.Add(dropdownReport4);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(MonthLabel);
            tabPage4.Controls.Add(MonthText);
            tabPage4.Controls.Add(ReportDataGrid);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(reportButton5);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(reportButton4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(Report2Button);
            tabPage4.Controls.Add(button1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(1152, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            // 
            // radioButton2_report5
            // 
            radioButton2_report5.AutoSize = true;
            radioButton2_report5.Location = new Point(340, 321);
            radioButton2_report5.Name = "radioButton2_report5";
            radioButton2_report5.Size = new Size(52, 19);
            radioButton2_report5.TabIndex = 14;
            radioButton2_report5.TabStop = true;
            radioButton2_report5.Text = "Least";
            radioButton2_report5.UseVisualStyleBackColor = true;
            // 
            // radioButton_report5
            // 
            radioButton_report5.AutoSize = true;
            radioButton_report5.Location = new Point(282, 321);
            radioButton_report5.Name = "radioButton_report5";
            radioButton_report5.Size = new Size(52, 19);
            radioButton_report5.TabIndex = 13;
            radioButton_report5.TabStop = true;
            radioButton_report5.Text = "Most";
            radioButton_report5.UseVisualStyleBackColor = true;
            // 
            // dropdownReport4
            // 
            dropdownReport4.FormattingEnabled = true;
            dropdownReport4.Items.AddRange(new object[] { "All", "Comedy", "Drama", "Action ", "Foreign" });
            dropdownReport4.Location = new Point(282, 247);
            dropdownReport4.Name = "dropdownReport4";
            dropdownReport4.Size = new Size(90, 23);
            dropdownReport4.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(282, 225);
            label13.Name = "label13";
            label13.Size = new Size(46, 19);
            label13.TabIndex = 11;
            label13.Text = "Genre";
            label13.Click += label13_Click;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonthLabel.Location = new Point(282, 82);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(87, 17);
            MonthLabel.TabIndex = 10;
            MonthLabel.Text = "Month Range";
            // 
            // MonthText
            // 
            MonthText.ForeColor = Color.DarkGray;
            MonthText.Location = new Point(282, 102);
            MonthText.Name = "MonthText";
            MonthText.Size = new Size(90, 23);
            MonthText.TabIndex = 9;
            MonthText.Text = "Ex. 3";
            MonthText.Enter += MonthText_Enter;
            MonthText.Leave += MonthText_Leave;
            // 
            // ReportDataGrid
            // 
            ReportDataGrid.AllowUserToAddRows = false;
            ReportDataGrid.AllowUserToDeleteRows = false;
            ReportDataGrid.AllowUserToResizeRows = false;
            ReportDataGrid.BackgroundColor = SystemColors.Window;
            ReportDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportDataGrid.Location = new Point(687, 0);
            ReportDataGrid.Name = "ReportDataGrid";
            ReportDataGrid.RowHeadersWidth = 51;
            ReportDataGrid.Size = new Size(465, 384);
            ReportDataGrid.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(282, 14);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 19);
            label8.TabIndex = 3;
            label8.Text = "First Name of Actor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(564, 14);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 6;
            label10.Text = "Movie Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Comedy", "Drama", "Action ", "Foreign" });
            comboBox1.Location = new Point(558, 35);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 23);
            comboBox1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(452, 14);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 5;
            label9.Text = "> Age";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 35);
            textBox4.Margin = new Padding(1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 1;
            // 
            // reportButton5
            // 
            reportButton5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportButton5.Location = new Point(30, 312);
            reportButton5.Margin = new Padding(2);
            reportButton5.Name = "reportButton5";
            reportButton5.Size = new Size(217, 32);
            reportButton5.TabIndex = 6;
            reportButton5.Text = "# of Orders by Employee";
            reportButton5.UseVisualStyleBackColor = true;
            reportButton5.Click += reportButton5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(452, 34);
            textBox5.Margin = new Padding(1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 4;
            // 
            // reportButton4
            // 
            reportButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportButton4.Location = new Point(30, 238);
            reportButton4.Margin = new Padding(2);
            reportButton4.Name = "reportButton4";
            reportButton4.Size = new Size(217, 32);
            reportButton4.TabIndex = 5;
            reportButton4.Text = "Best Selling Movies";
            reportButton4.UseVisualStyleBackColor = true;
            reportButton4.Click += reportButton4_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(30, 165);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(217, 32);
            button3.TabIndex = 4;
            button3.Text = "Report 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Report2Button
            // 
            Report2Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Report2Button.Location = new Point(30, 94);
            Report2Button.Margin = new Padding(2);
            Report2Button.Name = "Report2Button";
            Report2Button.Size = new Size(217, 32);
            Report2Button.TabIndex = 3;
            Report2Button.Text = "Customer Sales Report";
            Report2Button.UseVisualStyleBackColor = true;
            Report2Button.Click += Report2Button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(30, 26);
            button1.Name = "button1";
            button1.Size = new Size(217, 32);
            button1.TabIndex = 2;
            button1.Text = "Report 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 499);
            Controls.Add(DashboardTabs);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Employee Homescreen ";
            DashboardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            AddCustBox.ResumeLayout(false);
            AddCustBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ModifyCustDataView).EndInit();
            ModifyCustBox.ResumeLayout(false);
            ModifyCustBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            SearchMoviePanel.ResumeLayout(false);
            SearchMoviePanel.PerformLayout();
            AddMovieBox.ResumeLayout(false);
            AddMovieBox.PerformLayout();
            MovieDataViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MovieDataView).EndInit();
            ModifyMovieBox.ResumeLayout(false);
            ModifyMovieBox.PerformLayout();
            AssignActorBox.ResumeLayout(false);
            AssignActorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MovieActorDataView).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox AddCustBox;
        private ComboBox StateCustComboBox;
        private TextBox CreditCustText;
        private TextBox AccountCustText;
        private TextBox CityCustText;
        private TextBox ZipCustText;
        private TextBox EmailCustText;
        private TextBox AddressCustText;
        private TextBox LastNameCustText;
        private TextBox FirstNameCustText;
        private Label CreditCustLabel;
        private Label AccountNumCustLabel;
        private Label EmailCustLabel;
        private Label ZipCustLabel;
        private Label StateCustLabel;
        private Label CityCustLabel;
        private Label AddressCustLabel;
        private Label LastNameCustLabel;
        private Label FirstNameCustLabel;
        private Button AddCustButton;
        private GroupBox ModifyCustBox;
        private Button DeleteCustButton;
        private TextBox CustIDText;
        private Button UpdateCustButton;
        private ComboBox StateModComboBox;
        private TextBox CreditModText;
        private TextBox AccountModText;
        private TextBox CityModText;
        private TextBox ZipModText;
        private TextBox EmailModText;
        private TextBox AddressModText;
        private TextBox LastNameModText;
        private TextBox FirstNameModText;
        private Label CreditModLabel;
        private Label AccountModLabel;
        private Label EmailModLabel;
        private Label ZipModLabel;
        private Label StateModLabel;
        private Label CityModLabel;
        private Label AddressModLabel;
        private Label LastNameModLabel;
        private Label FirstNameModLabel;
        private Label EmailSearchLabel;
        private Label LastNameSearchLabel;
        private Label FirstNameSearchLabel;
        private TextBox EmailSearchText;
        private TextBox FirstNameSearchText;
        private TextBox LastNameSearchText;

        // Movie Tab
        private TabPage tabPage2;
        private Button AssignActorButton;
        private Button ModifyMovieButton;
        private Button AddMovieButton;
        private GroupBox AddMovieBox;
        private Label CopiesAddLabel;
        private Label FeeAddLabel;
        private Label TypeAddLabel;
        private Label NameAddLabel;
        private Button MovieAddButton;
        private ComboBox TypeAddComboBox;
        private TextBox CopiesAddText;
        private TextBox FeeAddText;
        private TextBox NameAddText;
        private GroupBox ModifyMovieBox;
        private Button MovieModifyButton;
        private ComboBox TypeModComboBox;
        private TextBox CopiesModText;
        private TextBox FeeModText;
        private TextBox NameModText;
        private Label CopiesModLabel;
        private Label FeeMofLabel;
        private Label TypeModLabel;
        private Label NameModLabel;
        private TextBox MovieIDText;
        private Label MovieIDLabel;
        private Button DeleteMovieButton;
        private GroupBox AssignActorBox;
        private TextBox ActorFirstAssignText;
        private Label label2;
        private Button AssignButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox MovieAssignText;
        private Label label3;
        private Label label4;
        private Label ActorAssignLabel;
        private Label MovieAssignLabel;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button Report2Button;
        private Button button6;
        private Button CustSearchButton;
        private TextBox textBox1;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridView ModifyCustDataView;
        private Label CustIDLabel;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private Label label10;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView ReportDataGrid;
        private Label MonthLabel;
        private TextBox MonthText;
        private Panel SearchMoviePanel;
        private Label SearchMovieLabel;
        private TextBox SearchMovieText;
        private Button SearchMovieButton;
        private Panel MovieDataViewPanel;
        private DataGridView MovieDataView;
        private TextBox ActorLastAssignText;
        private Label label11;
        private Label label6;
        private ListBox actorList;
        private Label label12;
        private Button ActorMovieSearchButton;
        private DataGridView MovieActorDataView;
        private Button reportButton5;
        private Button reportButton4;
        private Label label13;
        private ComboBox comboBox2;
        private ComboBox dropdownReport4;
        private RadioButton radioButton2_report5;
        private RadioButton radioButton_report5;
    }
}