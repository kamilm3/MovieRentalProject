﻿using System.Windows.Forms;

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
            CustSearchButton = new Button();
            EmailSearchLabel = new Label();
            LastNameSearchLabel = new Label();
            FirstNameSearchLabel = new Label();
            EmailSearchText = new TextBox();
            FirstNameSearchText = new TextBox();
            LastNameSearchText = new TextBox();
            ModifyCustButton = new Button();
            NewCustButton = new Button();
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
            ModifyCustDataView = new DataGridView();
            tabPage2 = new TabPage();
            AssignActorBox = new GroupBox();
            ActorAssignText = new TextBox();
            AssignButton = new Button();
            MovieAssignText = new TextBox();
            ActorAssignLabel = new Label();
            MovieAssignLabel = new Label();
            ModifyMovieBox = new GroupBox();
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
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button8 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button6 = new Button();
            tabPage4 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            DashboardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            AddCustBox.SuspendLayout();
            ModifyCustBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ModifyCustDataView).BeginInit();
            tabPage2.SuspendLayout();
            AssignActorBox.SuspendLayout();
            ModifyMovieBox.SuspendLayout();
            AddMovieBox.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
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
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1152, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // CustSearchButton
            // 
            CustSearchButton.Location = new Point(146, 333);
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
            FirstNameSearchLabel.Name = "FirstNameSearchLabel";
            FirstNameSearchLabel.Size = new Size(92, 21);
            FirstNameSearchLabel.TabIndex = 7;
            FirstNameSearchLabel.Text = "First Name:";
            FirstNameSearchLabel.Visible = false;
            // 
            // EmailSearchText
            // 
            EmailSearchText.Location = new Point(112, 285);
            EmailSearchText.Name = "EmailSearchText";
            EmailSearchText.Size = new Size(188, 29);
            EmailSearchText.TabIndex = 6;
            EmailSearchText.Visible = false;
            // 
            // FirstNameSearchText
            // 
            FirstNameSearchText.Location = new Point(112, 173);
            FirstNameSearchText.Name = "FirstNameSearchText";
            FirstNameSearchText.Size = new Size(188, 29);
            FirstNameSearchText.TabIndex = 5;
            FirstNameSearchText.Visible = false;
            // 
            // LastNameSearchText
            // 
            LastNameSearchText.Location = new Point(112, 229);
            LastNameSearchText.Name = "LastNameSearchText";
            LastNameSearchText.Size = new Size(188, 29);
            LastNameSearchText.TabIndex = 4;
            LastNameSearchText.Visible = false;
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
            AddCustBox.Location = new Point(-1284, 0);
            AddCustBox.Name = "AddCustBox";
            AddCustBox.Size = new Size(814, 384);
            AddCustBox.TabIndex = 2;
            AddCustBox.TabStop = false;
            AddCustBox.Visible = false;
            // 
            // AddCustButton
            // 
            AddCustButton.Location = new Point(585, 317);
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
            StateCustComboBox.Name = "StateCustComboBox";
            StateCustComboBox.Size = new Size(68, 29);
            StateCustComboBox.TabIndex = 17;
            // 
            // CreditCustText
            // 
            CreditCustText.Location = new Point(202, 330);
            CreditCustText.Name = "CreditCustText";
            CreditCustText.Size = new Size(201, 29);
            CreditCustText.TabIndex = 16;
            // 
            // AccountCustText
            // 
            AccountCustText.Location = new Point(202, 290);
            AccountCustText.Name = "AccountCustText";
            AccountCustText.Size = new Size(100, 29);
            AccountCustText.TabIndex = 15;
            // 
            // CityCustText
            // 
            CityCustText.Location = new Point(202, 142);
            CityCustText.Name = "CityCustText";
            CityCustText.Size = new Size(293, 29);
            CityCustText.TabIndex = 14;
            // 
            // ZipCustText
            // 
            ZipCustText.Location = new Point(202, 213);
            ZipCustText.Name = "ZipCustText";
            ZipCustText.Size = new Size(100, 29);
            ZipCustText.TabIndex = 13;
            // 
            // EmailCustText
            // 
            EmailCustText.Location = new Point(202, 248);
            EmailCustText.Name = "EmailCustText";
            EmailCustText.Size = new Size(201, 29);
            EmailCustText.TabIndex = 12;
            // 
            // AddressCustText
            // 
            AddressCustText.Location = new Point(202, 104);
            AddressCustText.Name = "AddressCustText";
            AddressCustText.Size = new Size(293, 29);
            AddressCustText.TabIndex = 11;
            // 
            // LastNameCustText
            // 
            LastNameCustText.Location = new Point(202, 61);
            LastNameCustText.Name = "LastNameCustText";
            LastNameCustText.Size = new Size(293, 29);
            LastNameCustText.TabIndex = 10;
            // 
            // FirstNameCustText
            // 
            FirstNameCustText.Location = new Point(202, 22);
            FirstNameCustText.Name = "FirstNameCustText";
            FirstNameCustText.Size = new Size(293, 29);
            FirstNameCustText.TabIndex = 9;
            // 
            // CreditCustLabel
            // 
            CreditCustLabel.AutoSize = true;
            CreditCustLabel.Location = new Point(32, 333);
            CreditCustLabel.Name = "CreditCustLabel";
            CreditCustLabel.Size = new Size(97, 21);
            CreditCustLabel.TabIndex = 8;
            CreditCustLabel.Text = "Credit Card:";
            // 
            // AccountNumCustLabel
            // 
            AccountNumCustLabel.AutoSize = true;
            AccountNumCustLabel.Location = new Point(32, 293);
            AccountNumCustLabel.Name = "AccountNumCustLabel";
            AccountNumCustLabel.Size = new Size(140, 21);
            AccountNumCustLabel.TabIndex = 7;
            AccountNumCustLabel.Text = "Account Number:";
            // 
            // EmailCustLabel
            // 
            EmailCustLabel.AutoSize = true;
            EmailCustLabel.Location = new Point(32, 256);
            EmailCustLabel.Name = "EmailCustLabel";
            EmailCustLabel.Size = new Size(52, 21);
            EmailCustLabel.TabIndex = 6;
            EmailCustLabel.Text = "Email:";
            // 
            // ZipCustLabel
            // 
            ZipCustLabel.AutoSize = true;
            ZipCustLabel.Location = new Point(32, 217);
            ZipCustLabel.Name = "ZipCustLabel";
            ZipCustLabel.Size = new Size(80, 21);
            ZipCustLabel.TabIndex = 5;
            ZipCustLabel.Text = "Zip Code:";
            // 
            // StateCustLabel
            // 
            StateCustLabel.AutoSize = true;
            StateCustLabel.Location = new Point(32, 181);
            StateCustLabel.Name = "StateCustLabel";
            StateCustLabel.Size = new Size(52, 21);
            StateCustLabel.TabIndex = 4;
            StateCustLabel.Text = "State:";
            // 
            // CityCustLabel
            // 
            CityCustLabel.AutoSize = true;
            CityCustLabel.Location = new Point(32, 142);
            CityCustLabel.Name = "CityCustLabel";
            CityCustLabel.Size = new Size(42, 21);
            CityCustLabel.TabIndex = 3;
            CityCustLabel.Text = "City:";
            // 
            // AddressCustLabel
            // 
            AddressCustLabel.AutoSize = true;
            AddressCustLabel.Location = new Point(32, 107);
            AddressCustLabel.Name = "AddressCustLabel";
            AddressCustLabel.Size = new Size(74, 21);
            AddressCustLabel.TabIndex = 2;
            AddressCustLabel.Text = "Address:";
            // 
            // LastNameCustLabel
            // 
            LastNameCustLabel.AutoSize = true;
            LastNameCustLabel.Location = new Point(32, 66);
            LastNameCustLabel.Name = "LastNameCustLabel";
            LastNameCustLabel.Size = new Size(90, 21);
            LastNameCustLabel.TabIndex = 1;
            LastNameCustLabel.Text = "Last Name:";
            // 
            // FirstNameCustLabel
            // 
            FirstNameCustLabel.AutoSize = true;
            FirstNameCustLabel.Location = new Point(32, 25);
            FirstNameCustLabel.Name = "FirstNameCustLabel";
            FirstNameCustLabel.Size = new Size(92, 21);
            FirstNameCustLabel.TabIndex = 0;
            FirstNameCustLabel.Text = "First Name:";
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
            ModifyCustBox.Name = "ModifyCustBox";
            ModifyCustBox.Size = new Size(814, 384);
            ModifyCustBox.TabIndex = 3;
            ModifyCustBox.TabStop = false;
            ModifyCustBox.Visible = false;
            // 
            // CustIDText
            // 
            CustIDText.Location = new Point(639, 22);
            CustIDText.Name = "CustIDText";
            CustIDText.ReadOnly = true;
            CustIDText.Size = new Size(68, 29);
            CustIDText.TabIndex = 23;
            // 
            // CustIDLabel
            // 
            CustIDLabel.AutoSize = true;
            CustIDLabel.Location = new Point(528, 25);
            CustIDLabel.Name = "CustIDLabel";
            CustIDLabel.Size = new Size(105, 21);
            CustIDLabel.TabIndex = 22;
            CustIDLabel.Text = "Customer ID:";
            // 
            // DeleteCustButton
            // 
            DeleteCustButton.BackColor = Color.Transparent;
            DeleteCustButton.Location = new Point(672, 319);
            DeleteCustButton.Name = "DeleteCustButton";
            DeleteCustButton.Size = new Size(95, 40);
            DeleteCustButton.TabIndex = 21;
            DeleteCustButton.Text = "Delete";
            DeleteCustButton.UseVisualStyleBackColor = false;
            DeleteCustButton.Click += DeleteCustButton_Click;
            // 
            // UpdateCustButton
            // 
            UpdateCustButton.Location = new Point(519, 319);
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
            StateModComboBox.Name = "StateModComboBox";
            StateModComboBox.Size = new Size(67, 29);
            StateModComboBox.TabIndex = 17;
            // 
            // CreditModText
            // 
            CreditModText.Location = new Point(202, 330);
            CreditModText.Name = "CreditModText";
            CreditModText.Size = new Size(167, 29);
            CreditModText.TabIndex = 16;
            // 
            // AccountModText
            // 
            AccountModText.Location = new Point(202, 290);
            AccountModText.Name = "AccountModText";
            AccountModText.Size = new Size(99, 29);
            AccountModText.TabIndex = 15;
            // 
            // CityModText
            // 
            CityModText.Location = new Point(202, 142);
            CityModText.Name = "CityModText";
            CityModText.Size = new Size(293, 29);
            CityModText.TabIndex = 14;
            // 
            // ZipModText
            // 
            ZipModText.Location = new Point(202, 213);
            ZipModText.Name = "ZipModText";
            ZipModText.Size = new Size(99, 29);
            ZipModText.TabIndex = 13;
            // 
            // EmailModText
            // 
            EmailModText.Location = new Point(202, 248);
            EmailModText.Name = "EmailModText";
            EmailModText.Size = new Size(293, 29);
            EmailModText.TabIndex = 12;
            // 
            // AddressModText
            // 
            AddressModText.Location = new Point(202, 104);
            AddressModText.Name = "AddressModText";
            AddressModText.Size = new Size(293, 29);
            AddressModText.TabIndex = 11;
            // 
            // LastNameModText
            // 
            LastNameModText.Location = new Point(202, 61);
            LastNameModText.Name = "LastNameModText";
            LastNameModText.Size = new Size(293, 29);
            LastNameModText.TabIndex = 10;
            // 
            // FirstNameModText
            // 
            FirstNameModText.Location = new Point(202, 22);
            FirstNameModText.Name = "FirstNameModText";
            FirstNameModText.Size = new Size(293, 29);
            FirstNameModText.TabIndex = 9;
            FirstNameModText.TextChanged += FirstNameModText_TextChanged;
            // 
            // CreditModLabel
            // 
            CreditModLabel.AutoSize = true;
            CreditModLabel.Location = new Point(32, 333);
            CreditModLabel.Name = "CreditModLabel";
            CreditModLabel.Size = new Size(97, 21);
            CreditModLabel.TabIndex = 8;
            CreditModLabel.Text = "Credit Card:";
            // 
            // AccountModLabel
            // 
            AccountModLabel.AutoSize = true;
            AccountModLabel.Location = new Point(32, 293);
            AccountModLabel.Name = "AccountModLabel";
            AccountModLabel.Size = new Size(140, 21);
            AccountModLabel.TabIndex = 7;
            AccountModLabel.Text = "Account Number:";
            // 
            // EmailModLabel
            // 
            EmailModLabel.AutoSize = true;
            EmailModLabel.Location = new Point(32, 256);
            EmailModLabel.Name = "EmailModLabel";
            EmailModLabel.Size = new Size(52, 21);
            EmailModLabel.TabIndex = 6;
            EmailModLabel.Text = "Email:";
            // 
            // ZipModLabel
            // 
            ZipModLabel.AutoSize = true;
            ZipModLabel.Location = new Point(32, 217);
            ZipModLabel.Name = "ZipModLabel";
            ZipModLabel.Size = new Size(80, 21);
            ZipModLabel.TabIndex = 5;
            ZipModLabel.Text = "Zip Code:";
            // 
            // StateModLabel
            // 
            StateModLabel.AutoSize = true;
            StateModLabel.Location = new Point(32, 181);
            StateModLabel.Name = "StateModLabel";
            StateModLabel.Size = new Size(52, 21);
            StateModLabel.TabIndex = 4;
            StateModLabel.Text = "State:";
            // 
            // CityModLabel
            // 
            CityModLabel.AutoSize = true;
            CityModLabel.Location = new Point(32, 142);
            CityModLabel.Name = "CityModLabel";
            CityModLabel.Size = new Size(42, 21);
            CityModLabel.TabIndex = 3;
            CityModLabel.Text = "City:";
            // 
            // AddressModLabel
            // 
            AddressModLabel.AutoSize = true;
            AddressModLabel.Location = new Point(32, 107);
            AddressModLabel.Name = "AddressModLabel";
            AddressModLabel.Size = new Size(74, 21);
            AddressModLabel.TabIndex = 2;
            AddressModLabel.Text = "Address:";
            // 
            // LastNameModLabel
            // 
            LastNameModLabel.AutoSize = true;
            LastNameModLabel.Location = new Point(32, 66);
            LastNameModLabel.Name = "LastNameModLabel";
            LastNameModLabel.Size = new Size(90, 21);
            LastNameModLabel.TabIndex = 1;
            LastNameModLabel.Text = "Last Name:";
            // 
            // FirstNameModLabel
            // 
            FirstNameModLabel.AutoSize = true;
            FirstNameModLabel.Location = new Point(32, 25);
            FirstNameModLabel.Name = "FirstNameModLabel";
            FirstNameModLabel.Size = new Size(92, 21);
            FirstNameModLabel.TabIndex = 0;
            FirstNameModLabel.Text = "First Name:";
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
            ModifyCustDataView.Location = new Point(-470, 0);
            ModifyCustDataView.Name = "ModifyCustDataView";
            ModifyCustDataView.ReadOnly = true;
            ModifyCustDataView.Size = new Size(808, 384);
            ModifyCustDataView.TabIndex = 11;
            ModifyCustDataView.Visible = false;
            ModifyCustDataView.CellClick += ModifyCustDataViewCellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 192, 128);
            tabPage2.Controls.Add(AssignActorBox);
            tabPage2.Controls.Add(ModifyMovieBox);
            tabPage2.Controls.Add(AssignActorButton);
            tabPage2.Controls.Add(ModifyMovieButton);
            tabPage2.Controls.Add(AddMovieButton);
            tabPage2.Controls.Add(AddMovieBox);
            tabPage2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1152, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie Management";
            // 
            // AssignActorBox
            // 
            AssignActorBox.BackColor = Color.White;
            AssignActorBox.Controls.Add(ActorAssignText);
            AssignActorBox.Controls.Add(AssignButton);
            AssignActorBox.Controls.Add(MovieAssignText);
            AssignActorBox.Controls.Add(ActorAssignLabel);
            AssignActorBox.Controls.Add(MovieAssignLabel);
            AssignActorBox.Location = new Point(329, 0);
            AssignActorBox.Name = "AssignActorBox";
            AssignActorBox.Size = new Size(823, 388);
            AssignActorBox.TabIndex = 6;
            AssignActorBox.TabStop = false;
            AssignActorBox.Visible = false;
            // 
            // ActorAssignText
            // 
            ActorAssignText.Location = new Point(225, 80);
            ActorAssignText.Name = "ActorAssignText";
            ActorAssignText.Size = new Size(264, 29);
            ActorAssignText.TabIndex = 9;
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(225, 116);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(122, 39);
            AssignButton.TabIndex = 8;
            AssignButton.Text = "Assign Actor";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Click += AssignButton_Click;
            // 
            // MovieAssignText
            // 
            MovieAssignText.Location = new Point(225, 30);
            MovieAssignText.Name = "MovieAssignText";
            MovieAssignText.Size = new Size(264, 29);
            MovieAssignText.TabIndex = 4;
            // 
            // ActorAssignLabel
            // 
            ActorAssignLabel.AutoSize = true;
            ActorAssignLabel.Location = new Point(54, 80);
            ActorAssignLabel.Name = "ActorAssignLabel";
            ActorAssignLabel.Size = new Size(98, 21);
            ActorAssignLabel.TabIndex = 1;
            ActorAssignLabel.Text = "Actor Name";
            // 
            // MovieAssignLabel
            // 
            MovieAssignLabel.AutoSize = true;
            MovieAssignLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MovieAssignLabel.Location = new Point(54, 33);
            MovieAssignLabel.Name = "MovieAssignLabel";
            MovieAssignLabel.Size = new Size(107, 21);
            MovieAssignLabel.TabIndex = 0;
            MovieAssignLabel.Text = "Movie Name:";
            // 
            // ModifyMovieBox
            // 
            ModifyMovieBox.BackColor = Color.White;
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
            ModifyMovieBox.Location = new Point(335, 0);
            ModifyMovieBox.Name = "ModifyMovieBox";
            ModifyMovieBox.Size = new Size(821, 388);
            ModifyMovieBox.TabIndex = 5;
            ModifyMovieBox.TabStop = false;
            ModifyMovieBox.Visible = false;
            // 
            // DeleteMovieButton
            // 
            DeleteMovieButton.Location = new Point(650, 312);
            DeleteMovieButton.Name = "DeleteMovieButton";
            DeleteMovieButton.Size = new Size(112, 39);
            DeleteMovieButton.TabIndex = 11;
            DeleteMovieButton.Text = "Delete";
            DeleteMovieButton.UseVisualStyleBackColor = true;
            DeleteMovieButton.Click += DeleteMovieButton_Click;
            // 
            // MovieIDText
            // 
            MovieIDText.Location = new Point(620, 33);
            MovieIDText.Name = "MovieIDText";
            MovieIDText.Size = new Size(115, 29);
            MovieIDText.TabIndex = 10;
            // 
            // MovieIDLabel
            // 
            MovieIDLabel.AutoSize = true;
            MovieIDLabel.Location = new Point(519, 36);
            MovieIDLabel.Name = "MovieIDLabel";
            MovieIDLabel.Size = new Size(80, 21);
            MovieIDLabel.TabIndex = 9;
            MovieIDLabel.Text = "Movie ID:";
            // 
            // MovieModifyButton
            // 
            MovieModifyButton.Location = new Point(477, 312);
            MovieModifyButton.Name = "MovieModifyButton";
            MovieModifyButton.Size = new Size(122, 39);
            MovieModifyButton.TabIndex = 8;
            MovieModifyButton.Text = "Submit";
            MovieModifyButton.UseVisualStyleBackColor = true;
            MovieModifyButton.Click += MovieModifyButton_Click;
            // 
            // TypeModComboBox
            // 
            TypeModComboBox.FormattingEnabled = true;
            TypeModComboBox.Location = new Point(225, 98);
            TypeModComboBox.Name = "TypeModComboBox";
            TypeModComboBox.Size = new Size(152, 29);
            TypeModComboBox.TabIndex = 7;
            // 
            // CopiesModText
            // 
            CopiesModText.Location = new Point(225, 221);
            CopiesModText.Name = "CopiesModText";
            CopiesModText.Size = new Size(100, 29);
            CopiesModText.TabIndex = 6;
            // 
            // FeeModText
            // 
            FeeModText.Location = new Point(225, 158);
            FeeModText.Name = "FeeModText";
            FeeModText.Size = new Size(152, 29);
            FeeModText.TabIndex = 5;
            // 
            // NameModText
            // 
            NameModText.Location = new Point(225, 30);
            NameModText.Name = "NameModText";
            NameModText.Size = new Size(264, 29);
            NameModText.TabIndex = 4;
            // 
            // CopiesModLabel
            // 
            CopiesModLabel.AutoSize = true;
            CopiesModLabel.Location = new Point(54, 224);
            CopiesModLabel.Name = "CopiesModLabel";
            CopiesModLabel.Size = new Size(148, 21);
            CopiesModLabel.TabIndex = 3;
            CopiesModLabel.Text = "Number of Copies:";
            // 
            // FeeMofLabel
            // 
            FeeMofLabel.AutoSize = true;
            FeeMofLabel.Location = new Point(54, 161);
            FeeMofLabel.Name = "FeeMofLabel";
            FeeMofLabel.Size = new Size(130, 21);
            FeeMofLabel.TabIndex = 2;
            FeeMofLabel.Text = "Distribution Fee:";
            // 
            // TypeModLabel
            // 
            TypeModLabel.AutoSize = true;
            TypeModLabel.Location = new Point(54, 98);
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
            NameModLabel.Name = "NameModLabel";
            NameModLabel.Size = new Size(107, 21);
            NameModLabel.TabIndex = 0;
            NameModLabel.Text = "Movie Name:";
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
            AddMovieBox.Location = new Point(352, 0);
            AddMovieBox.Name = "AddMovieBox";
            AddMovieBox.Size = new Size(800, 388);
            AddMovieBox.TabIndex = 4;
            AddMovieBox.TabStop = false;
            AddMovieBox.Visible = false;
            // 
            // MovieAddButton
            // 
            MovieAddButton.Location = new Point(537, 309);
            MovieAddButton.Name = "MovieAddButton";
            MovieAddButton.Size = new Size(122, 39);
            MovieAddButton.TabIndex = 8;
            MovieAddButton.Text = "Add";
            MovieAddButton.UseVisualStyleBackColor = true;
            MovieAddButton.Click += MovieAddButton_Click;
            // 
            // TypeAddComboBox
            // 
            TypeAddComboBox.FormattingEnabled = true;
            TypeAddComboBox.Location = new Point(242, 98);
            TypeAddComboBox.Name = "TypeAddComboBox";
            TypeAddComboBox.Size = new Size(152, 29);
            TypeAddComboBox.TabIndex = 7;
            // 
            // CopiesAddText
            // 
            CopiesAddText.Location = new Point(242, 221);
            CopiesAddText.Name = "CopiesAddText";
            CopiesAddText.Size = new Size(100, 29);
            CopiesAddText.TabIndex = 6;
            // 
            // FeeAddText
            // 
            FeeAddText.Location = new Point(242, 158);
            FeeAddText.Name = "FeeAddText";
            FeeAddText.Size = new Size(152, 29);
            FeeAddText.TabIndex = 5;
            // 
            // NameAddText
            // 
            NameAddText.Location = new Point(242, 30);
            NameAddText.Name = "NameAddText";
            NameAddText.Size = new Size(264, 29);
            NameAddText.TabIndex = 4;
            // 
            // CopiesAddLabel
            // 
            CopiesAddLabel.AutoSize = true;
            CopiesAddLabel.Location = new Point(54, 224);
            CopiesAddLabel.Name = "CopiesAddLabel";
            CopiesAddLabel.Size = new Size(148, 21);
            CopiesAddLabel.TabIndex = 3;
            CopiesAddLabel.Text = "Number of Copies:";
            // 
            // FeeAddLabel
            // 
            FeeAddLabel.AutoSize = true;
            FeeAddLabel.Location = new Point(54, 161);
            FeeAddLabel.Name = "FeeAddLabel";
            FeeAddLabel.Size = new Size(130, 21);
            FeeAddLabel.TabIndex = 2;
            FeeAddLabel.Text = "Distribution Fee:";
            // 
            // TypeAddLabel
            // 
            TypeAddLabel.AutoSize = true;
            TypeAddLabel.Location = new Point(54, 98);
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
            NameAddLabel.Name = "NameAddLabel";
            NameAddLabel.Size = new Size(107, 21);
            NameAddLabel.TabIndex = 0;
            NameAddLabel.Text = "Movie Name:";
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
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1152, 384);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rental Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(761, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 214);
            dataGridView1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 154);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Email Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 171);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 104);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 121);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 59);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(666, 28);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 9;
            label2.Text = "Customer's Movie Queue";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(761, 324);
            button8.Name = "button8";
            button8.Size = new Size(217, 32);
            button8.TabIndex = 8;
            button8.Text = "Rent Movie";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(361, 59);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_availability;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(361, 28);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 6;
            label6.Text = "Availability";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 28);
            label5.Name = "label5";
            label5.Size = new Size(209, 21);
            label5.TabIndex = 4;
            label5.Text = "Fill in the following fields:";
            label5.Click += label5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(65, 289);
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
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(1152, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(31, 267);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(217, 32);
            button5.TabIndex = 6;
            button5.Text = "Report 5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(31, 202);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(217, 32);
            button4.TabIndex = 5;
            button4.Text = "Report 4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(31, 140);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(217, 32);
            button3.TabIndex = 4;
            button3.Text = "Report 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(31, 80);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(217, 32);
            button2.TabIndex = 3;
            button2.Text = "Report 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 25);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(217, 32);
            button1.TabIndex = 2;
            button1.Text = "Report 1";
            button1.UseVisualStyleBackColor = true;
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Employee Homescreen ";
            DashboardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            AddCustBox.ResumeLayout(false);
            AddCustBox.PerformLayout();
            ModifyCustBox.ResumeLayout(false);
            ModifyCustBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ModifyCustDataView).EndInit();
            tabPage2.ResumeLayout(false);
            AssignActorBox.ResumeLayout(false);
            AssignActorBox.PerformLayout();
            ModifyMovieBox.ResumeLayout(false);
            ModifyMovieBox.PerformLayout();
            AddMovieBox.ResumeLayout(false);
            AddMovieBox.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
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
        private Button button1;
        private TextBox ActorAssignText;
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
        private Button button2;
        private Button button6;
        private Button CustSearchButton;
        private Button button8;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridView ModifyCustDataView;
        private Label CustIDLabel;
    }
}