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
            ModifyCustBox = new GroupBox();
            DeleteCustButton = new Button();
            CustIDText = new TextBox();
            CustIDButton = new Label();
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
            button6 = new Button();
            tabPage4 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            button8 = new Button();
            label2 = new Label();
            DashboardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ModifyCustBox.SuspendLayout();
            AddCustBox.SuspendLayout();
            tabPage2.SuspendLayout();
            AssignActorBox.SuspendLayout();
            ModifyMovieBox.SuspendLayout();
            AddMovieBox.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(558, 25);
            label1.Name = "label1";
            label1.Size = new Size(287, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Name's Dashboard";
            // 
            // DashboardTabs
            // 
            DashboardTabs.Controls.Add(tabPage1);
            DashboardTabs.Controls.Add(tabPage2);
            DashboardTabs.Controls.Add(tabPage3);
            DashboardTabs.Controls.Add(tabPage4);
            DashboardTabs.Location = new Point(11, 81);
            DashboardTabs.Name = "DashboardTabs";
            DashboardTabs.SelectedIndex = 0;
            DashboardTabs.Size = new Size(1326, 549);
            DashboardTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(ModifyCustBox);
            tabPage1.Controls.Add(ModifyCustButton);
            tabPage1.Controls.Add(NewCustButton);
            tabPage1.Controls.Add(AddCustBox);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1318, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // ModifyCustBox
            // 
            ModifyCustBox.BackColor = Color.White;
            ModifyCustBox.Controls.Add(DeleteCustButton);
            ModifyCustBox.Controls.Add(CustIDText);
            ModifyCustBox.Controls.Add(CustIDButton);
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
            ModifyCustBox.Location = new Point(386, 0);
            ModifyCustBox.Margin = new Padding(3, 4, 3, 4);
            ModifyCustBox.Name = "ModifyCustBox";
            ModifyCustBox.Padding = new Padding(3, 4, 3, 4);
            ModifyCustBox.Size = new Size(930, 512);
            ModifyCustBox.TabIndex = 3;
            ModifyCustBox.TabStop = false;
            ModifyCustBox.Visible = false;
            // 
            // DeleteCustButton
            // 
            DeleteCustButton.BackColor = Color.Transparent;
            DeleteCustButton.Location = new Point(768, 425);
            DeleteCustButton.Margin = new Padding(3, 4, 3, 4);
            DeleteCustButton.Name = "DeleteCustButton";
            DeleteCustButton.Size = new Size(109, 53);
            DeleteCustButton.TabIndex = 21;
            DeleteCustButton.Text = "Delete";
            DeleteCustButton.UseVisualStyleBackColor = false;
            DeleteCustButton.Click += DeleteCustButton_Click;
            // 
            // CustIDText
            // 
            CustIDText.Location = new Point(736, 29);
            CustIDText.Margin = new Padding(3, 4, 3, 4);
            CustIDText.Name = "CustIDText";
            CustIDText.Size = new Size(173, 34);
            CustIDText.TabIndex = 20;
            // 
            // CustIDButton
            // 
            CustIDButton.AutoSize = true;
            CustIDButton.Location = new Point(583, 33);
            CustIDButton.Name = "CustIDButton";
            CustIDButton.Size = new Size(131, 28);
            CustIDButton.TabIndex = 19;
            CustIDButton.Text = "Customer ID:";
            // 
            // UpdateCustButton
            // 
            UpdateCustButton.Location = new Point(593, 425);
            UpdateCustButton.Margin = new Padding(3, 4, 3, 4);
            UpdateCustButton.Name = "UpdateCustButton";
            UpdateCustButton.Size = new Size(110, 49);
            UpdateCustButton.TabIndex = 18;
            UpdateCustButton.Text = "Update";
            UpdateCustButton.UseVisualStyleBackColor = true;
            UpdateCustButton.Click += UpdateCustButton_Click;
            // 
            // StateModComboBox
            // 
            StateModComboBox.FormattingEnabled = true;
            StateModComboBox.Location = new Point(231, 237);
            StateModComboBox.Margin = new Padding(3, 4, 3, 4);
            StateModComboBox.Name = "StateModComboBox";
            StateModComboBox.Size = new Size(114, 36);
            StateModComboBox.TabIndex = 17;
            // 
            // CreditModText
            // 
            CreditModText.Location = new Point(231, 440);
            CreditModText.Margin = new Padding(3, 4, 3, 4);
            CreditModText.Name = "CreditModText";
            CreditModText.Size = new Size(114, 34);
            CreditModText.TabIndex = 16;
            // 
            // AccountModText
            // 
            AccountModText.Location = new Point(231, 387);
            AccountModText.Margin = new Padding(3, 4, 3, 4);
            AccountModText.Name = "AccountModText";
            AccountModText.Size = new Size(114, 34);
            AccountModText.TabIndex = 15;
            // 
            // CityModText
            // 
            CityModText.Location = new Point(231, 189);
            CityModText.Margin = new Padding(3, 4, 3, 4);
            CityModText.Name = "CityModText";
            CityModText.Size = new Size(334, 34);
            CityModText.TabIndex = 14;
            // 
            // ZipModText
            // 
            ZipModText.Location = new Point(231, 284);
            ZipModText.Margin = new Padding(3, 4, 3, 4);
            ZipModText.Name = "ZipModText";
            ZipModText.Size = new Size(155, 34);
            ZipModText.TabIndex = 13;
            // 
            // EmailModText
            // 
            EmailModText.Location = new Point(231, 331);
            EmailModText.Margin = new Padding(3, 4, 3, 4);
            EmailModText.Name = "EmailModText";
            EmailModText.Size = new Size(114, 34);
            EmailModText.TabIndex = 12;
            // 
            // AddressModText
            // 
            AddressModText.Location = new Point(231, 139);
            AddressModText.Margin = new Padding(3, 4, 3, 4);
            AddressModText.Name = "AddressModText";
            AddressModText.Size = new Size(334, 34);
            AddressModText.TabIndex = 11;
            // 
            // LastNameModText
            // 
            LastNameModText.Location = new Point(231, 81);
            LastNameModText.Margin = new Padding(3, 4, 3, 4);
            LastNameModText.Name = "LastNameModText";
            LastNameModText.Size = new Size(334, 34);
            LastNameModText.TabIndex = 10;
            // 
            // FirstNameModText
            // 
            FirstNameModText.Location = new Point(231, 29);
            FirstNameModText.Margin = new Padding(3, 4, 3, 4);
            FirstNameModText.Name = "FirstNameModText";
            FirstNameModText.Size = new Size(334, 34);
            FirstNameModText.TabIndex = 9;
            // 
            // CreditModLabel
            // 
            CreditModLabel.AutoSize = true;
            CreditModLabel.Location = new Point(37, 444);
            CreditModLabel.Name = "CreditModLabel";
            CreditModLabel.Size = new Size(118, 28);
            CreditModLabel.TabIndex = 8;
            CreditModLabel.Text = "Credit Card:";
            // 
            // AccountModLabel
            // 
            AccountModLabel.AutoSize = true;
            AccountModLabel.Location = new Point(37, 391);
            AccountModLabel.Name = "AccountModLabel";
            AccountModLabel.Size = new Size(173, 28);
            AccountModLabel.TabIndex = 7;
            AccountModLabel.Text = "Account Number:";
            // 
            // EmailModLabel
            // 
            EmailModLabel.AutoSize = true;
            EmailModLabel.Location = new Point(37, 341);
            EmailModLabel.Name = "EmailModLabel";
            EmailModLabel.Size = new Size(65, 28);
            EmailModLabel.TabIndex = 6;
            EmailModLabel.Text = "Email:";
            // 
            // ZipModLabel
            // 
            ZipModLabel.AutoSize = true;
            ZipModLabel.Location = new Point(37, 289);
            ZipModLabel.Name = "ZipModLabel";
            ZipModLabel.Size = new Size(99, 28);
            ZipModLabel.TabIndex = 5;
            ZipModLabel.Text = "Zip Code:";
            // 
            // StateModLabel
            // 
            StateModLabel.AutoSize = true;
            StateModLabel.Location = new Point(37, 241);
            StateModLabel.Name = "StateModLabel";
            StateModLabel.Size = new Size(62, 28);
            StateModLabel.TabIndex = 4;
            StateModLabel.Text = "State:";
            // 
            // CityModLabel
            // 
            CityModLabel.AutoSize = true;
            CityModLabel.Location = new Point(37, 189);
            CityModLabel.Name = "CityModLabel";
            CityModLabel.Size = new Size(51, 28);
            CityModLabel.TabIndex = 3;
            CityModLabel.Text = "City:";
            // 
            // AddressModLabel
            // 
            AddressModLabel.AutoSize = true;
            AddressModLabel.Location = new Point(37, 143);
            AddressModLabel.Name = "AddressModLabel";
            AddressModLabel.Size = new Size(90, 28);
            AddressModLabel.TabIndex = 2;
            AddressModLabel.Text = "Address:";
            // 
            // LastNameModLabel
            // 
            LastNameModLabel.AutoSize = true;
            LastNameModLabel.Location = new Point(37, 88);
            LastNameModLabel.Name = "LastNameModLabel";
            LastNameModLabel.Size = new Size(113, 28);
            LastNameModLabel.TabIndex = 1;
            LastNameModLabel.Text = "Last Name:";
            // 
            // FirstNameModLabel
            // 
            FirstNameModLabel.AutoSize = true;
            FirstNameModLabel.Location = new Point(37, 33);
            FirstNameModLabel.Name = "FirstNameModLabel";
            FirstNameModLabel.Size = new Size(115, 28);
            FirstNameModLabel.TabIndex = 0;
            FirstNameModLabel.Text = "First Name:";
            // 
            // ModifyCustButton
            // 
            ModifyCustButton.Location = new Point(22, 69);
            ModifyCustButton.Name = "ModifyCustButton";
            ModifyCustButton.Size = new Size(248, 68);
            ModifyCustButton.TabIndex = 1;
            ModifyCustButton.Text = "Update/Retrieve/Delete Customer Information";
            ModifyCustButton.UseVisualStyleBackColor = true;
            ModifyCustButton.Click += ModifyCustButtonClick;
            // 
            // NewCustButton
            // 
            NewCustButton.Location = new Point(22, 21);
            NewCustButton.Name = "NewCustButton";
            NewCustButton.Size = new Size(248, 43);
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
            AddCustBox.Location = new Point(386, 0);
            AddCustBox.Margin = new Padding(3, 4, 3, 4);
            AddCustBox.Name = "AddCustBox";
            AddCustBox.Padding = new Padding(3, 4, 3, 4);
            AddCustBox.Size = new Size(930, 512);
            AddCustBox.TabIndex = 2;
            AddCustBox.TabStop = false;
            AddCustBox.Visible = false;
            // 
            // AddCustButton
            // 
            AddCustButton.Location = new Point(669, 423);
            AddCustButton.Margin = new Padding(3, 4, 3, 4);
            AddCustButton.Name = "AddCustButton";
            AddCustButton.Size = new Size(110, 49);
            AddCustButton.TabIndex = 18;
            AddCustButton.Text = "Add";
            AddCustButton.UseVisualStyleBackColor = true;
            AddCustButton.Click += AddCustButton_Click;
            // 
            // StateCustComboBox
            // 
            StateCustComboBox.FormattingEnabled = true;
            StateCustComboBox.Location = new Point(231, 237);
            StateCustComboBox.Margin = new Padding(3, 4, 3, 4);
            StateCustComboBox.Name = "StateCustComboBox";
            StateCustComboBox.Size = new Size(114, 36);
            StateCustComboBox.TabIndex = 17;
            // 
            // CreditCustText
            // 
            CreditCustText.Location = new Point(231, 440);
            CreditCustText.Margin = new Padding(3, 4, 3, 4);
            CreditCustText.Name = "CreditCustText";
            CreditCustText.Size = new Size(114, 34);
            CreditCustText.TabIndex = 16;
            // 
            // AccountCustText
            // 
            AccountCustText.Location = new Point(231, 387);
            AccountCustText.Margin = new Padding(3, 4, 3, 4);
            AccountCustText.Name = "AccountCustText";
            AccountCustText.Size = new Size(114, 34);
            AccountCustText.TabIndex = 15;
            // 
            // CityCustText
            // 
            CityCustText.Location = new Point(231, 189);
            CityCustText.Margin = new Padding(3, 4, 3, 4);
            CityCustText.Name = "CityCustText";
            CityCustText.Size = new Size(334, 34);
            CityCustText.TabIndex = 14;
            // 
            // ZipCustText
            // 
            ZipCustText.Location = new Point(231, 284);
            ZipCustText.Margin = new Padding(3, 4, 3, 4);
            ZipCustText.Name = "ZipCustText";
            ZipCustText.Size = new Size(155, 34);
            ZipCustText.TabIndex = 13;
            // 
            // EmailCustText
            // 
            EmailCustText.Location = new Point(231, 331);
            EmailCustText.Margin = new Padding(3, 4, 3, 4);
            EmailCustText.Name = "EmailCustText";
            EmailCustText.Size = new Size(114, 34);
            EmailCustText.TabIndex = 12;
            // 
            // AddressCustText
            // 
            AddressCustText.Location = new Point(231, 139);
            AddressCustText.Margin = new Padding(3, 4, 3, 4);
            AddressCustText.Name = "AddressCustText";
            AddressCustText.Size = new Size(334, 34);
            AddressCustText.TabIndex = 11;
            // 
            // LastNameCustText
            // 
            LastNameCustText.Location = new Point(231, 81);
            LastNameCustText.Margin = new Padding(3, 4, 3, 4);
            LastNameCustText.Name = "LastNameCustText";
            LastNameCustText.Size = new Size(334, 34);
            LastNameCustText.TabIndex = 10;
            // 
            // FirstNameCustText
            // 
            FirstNameCustText.Location = new Point(231, 29);
            FirstNameCustText.Margin = new Padding(3, 4, 3, 4);
            FirstNameCustText.Name = "FirstNameCustText";
            FirstNameCustText.Size = new Size(334, 34);
            FirstNameCustText.TabIndex = 9;
            // 
            // CreditCustLabel
            // 
            CreditCustLabel.AutoSize = true;
            CreditCustLabel.Location = new Point(37, 444);
            CreditCustLabel.Name = "CreditCustLabel";
            CreditCustLabel.Size = new Size(118, 28);
            CreditCustLabel.TabIndex = 8;
            CreditCustLabel.Text = "Credit Card:";
            // 
            // AccountNumCustLabel
            // 
            AccountNumCustLabel.AutoSize = true;
            AccountNumCustLabel.Location = new Point(37, 391);
            AccountNumCustLabel.Name = "AccountNumCustLabel";
            AccountNumCustLabel.Size = new Size(173, 28);
            AccountNumCustLabel.TabIndex = 7;
            AccountNumCustLabel.Text = "Account Number:";
            // 
            // EmailCustLabel
            // 
            EmailCustLabel.AutoSize = true;
            EmailCustLabel.Location = new Point(37, 341);
            EmailCustLabel.Name = "EmailCustLabel";
            EmailCustLabel.Size = new Size(65, 28);
            EmailCustLabel.TabIndex = 6;
            EmailCustLabel.Text = "Email:";
            // 
            // ZipCustLabel
            // 
            ZipCustLabel.AutoSize = true;
            ZipCustLabel.Location = new Point(37, 289);
            ZipCustLabel.Name = "ZipCustLabel";
            ZipCustLabel.Size = new Size(99, 28);
            ZipCustLabel.TabIndex = 5;
            ZipCustLabel.Text = "Zip Code:";
            // 
            // StateCustLabel
            // 
            StateCustLabel.AutoSize = true;
            StateCustLabel.Location = new Point(37, 241);
            StateCustLabel.Name = "StateCustLabel";
            StateCustLabel.Size = new Size(62, 28);
            StateCustLabel.TabIndex = 4;
            StateCustLabel.Text = "State:";
            // 
            // CityCustLabel
            // 
            CityCustLabel.AutoSize = true;
            CityCustLabel.Location = new Point(37, 189);
            CityCustLabel.Name = "CityCustLabel";
            CityCustLabel.Size = new Size(51, 28);
            CityCustLabel.TabIndex = 3;
            CityCustLabel.Text = "City:";
            // 
            // AddressCustLabel
            // 
            AddressCustLabel.AutoSize = true;
            AddressCustLabel.Location = new Point(37, 143);
            AddressCustLabel.Name = "AddressCustLabel";
            AddressCustLabel.Size = new Size(90, 28);
            AddressCustLabel.TabIndex = 2;
            AddressCustLabel.Text = "Address:";
            // 
            // LastNameCustLabel
            // 
            LastNameCustLabel.AutoSize = true;
            LastNameCustLabel.Location = new Point(37, 88);
            LastNameCustLabel.Name = "LastNameCustLabel";
            LastNameCustLabel.Size = new Size(113, 28);
            LastNameCustLabel.TabIndex = 1;
            LastNameCustLabel.Text = "Last Name:";
            // 
            // FirstNameCustLabel
            // 
            FirstNameCustLabel.AutoSize = true;
            FirstNameCustLabel.Location = new Point(37, 33);
            FirstNameCustLabel.Name = "FirstNameCustLabel";
            FirstNameCustLabel.Size = new Size(115, 28);
            FirstNameCustLabel.TabIndex = 0;
            FirstNameCustLabel.Text = "First Name:";
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1318, 516);
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
            AssignActorBox.Location = new Point(376, 0);
            AssignActorBox.Margin = new Padding(3, 4, 3, 4);
            AssignActorBox.Name = "AssignActorBox";
            AssignActorBox.Padding = new Padding(3, 4, 3, 4);
            AssignActorBox.Size = new Size(941, 517);
            AssignActorBox.TabIndex = 6;
            AssignActorBox.TabStop = false;
            AssignActorBox.Visible = false;
            // 
            // ActorAssignText
            // 
            ActorAssignText.Location = new Point(257, 107);
            ActorAssignText.Margin = new Padding(3, 4, 3, 4);
            ActorAssignText.Name = "ActorAssignText";
            ActorAssignText.Size = new Size(301, 34);
            ActorAssignText.TabIndex = 9;
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(257, 155);
            AssignButton.Margin = new Padding(3, 4, 3, 4);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(139, 52);
            AssignButton.TabIndex = 8;
            AssignButton.Text = "Assign Actor";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Click += AssignButton_Click;
            // 
            // MovieAssignText
            // 
            MovieAssignText.Location = new Point(257, 40);
            MovieAssignText.Margin = new Padding(3, 4, 3, 4);
            MovieAssignText.Name = "MovieAssignText";
            MovieAssignText.Size = new Size(301, 34);
            MovieAssignText.TabIndex = 4;
            // 
            // ActorAssignLabel
            // 
            ActorAssignLabel.AutoSize = true;
            ActorAssignLabel.Location = new Point(62, 107);
            ActorAssignLabel.Name = "ActorAssignLabel";
            ActorAssignLabel.Size = new Size(120, 28);
            ActorAssignLabel.TabIndex = 1;
            ActorAssignLabel.Text = "Actor Name";
            // 
            // MovieAssignLabel
            // 
            MovieAssignLabel.AutoSize = true;
            MovieAssignLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MovieAssignLabel.Location = new Point(62, 44);
            MovieAssignLabel.Name = "MovieAssignLabel";
            MovieAssignLabel.Size = new Size(133, 28);
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
            ModifyMovieBox.Location = new Point(383, 0);
            ModifyMovieBox.Margin = new Padding(3, 4, 3, 4);
            ModifyMovieBox.Name = "ModifyMovieBox";
            ModifyMovieBox.Padding = new Padding(3, 4, 3, 4);
            ModifyMovieBox.Size = new Size(938, 517);
            ModifyMovieBox.TabIndex = 5;
            ModifyMovieBox.TabStop = false;
            ModifyMovieBox.Visible = false;
            // 
            // DeleteMovieButton
            // 
            DeleteMovieButton.Location = new Point(743, 416);
            DeleteMovieButton.Margin = new Padding(3, 4, 3, 4);
            DeleteMovieButton.Name = "DeleteMovieButton";
            DeleteMovieButton.Size = new Size(128, 52);
            DeleteMovieButton.TabIndex = 11;
            DeleteMovieButton.Text = "Delete";
            DeleteMovieButton.UseVisualStyleBackColor = true;
            DeleteMovieButton.Click += DeleteMovieButton_Click;
            // 
            // MovieIDText
            // 
            MovieIDText.Location = new Point(709, 44);
            MovieIDText.Margin = new Padding(3, 4, 3, 4);
            MovieIDText.Name = "MovieIDText";
            MovieIDText.Size = new Size(131, 34);
            MovieIDText.TabIndex = 10;
            // 
            // MovieIDLabel
            // 
            MovieIDLabel.AutoSize = true;
            MovieIDLabel.Location = new Point(593, 48);
            MovieIDLabel.Name = "MovieIDLabel";
            MovieIDLabel.Size = new Size(99, 28);
            MovieIDLabel.TabIndex = 9;
            MovieIDLabel.Text = "Movie ID:";
            // 
            // MovieModifyButton
            // 
            MovieModifyButton.Location = new Point(545, 416);
            MovieModifyButton.Margin = new Padding(3, 4, 3, 4);
            MovieModifyButton.Name = "MovieModifyButton";
            MovieModifyButton.Size = new Size(139, 52);
            MovieModifyButton.TabIndex = 8;
            MovieModifyButton.Text = "Submit";
            MovieModifyButton.UseVisualStyleBackColor = true;
            MovieModifyButton.Click += MovieModifyButton_Click;
            // 
            // TypeModComboBox
            // 
            TypeModComboBox.FormattingEnabled = true;
            TypeModComboBox.Location = new Point(257, 131);
            TypeModComboBox.Margin = new Padding(3, 4, 3, 4);
            TypeModComboBox.Name = "TypeModComboBox";
            TypeModComboBox.Size = new Size(173, 36);
            TypeModComboBox.TabIndex = 7;
            // 
            // CopiesModText
            // 
            CopiesModText.Location = new Point(257, 295);
            CopiesModText.Margin = new Padding(3, 4, 3, 4);
            CopiesModText.Name = "CopiesModText";
            CopiesModText.Size = new Size(114, 34);
            CopiesModText.TabIndex = 6;
            // 
            // FeeModText
            // 
            FeeModText.Location = new Point(257, 211);
            FeeModText.Margin = new Padding(3, 4, 3, 4);
            FeeModText.Name = "FeeModText";
            FeeModText.Size = new Size(173, 34);
            FeeModText.TabIndex = 5;
            // 
            // NameModText
            // 
            NameModText.Location = new Point(257, 40);
            NameModText.Margin = new Padding(3, 4, 3, 4);
            NameModText.Name = "NameModText";
            NameModText.Size = new Size(301, 34);
            NameModText.TabIndex = 4;
            // 
            // CopiesModLabel
            // 
            CopiesModLabel.AutoSize = true;
            CopiesModLabel.Location = new Point(62, 299);
            CopiesModLabel.Name = "CopiesModLabel";
            CopiesModLabel.Size = new Size(184, 28);
            CopiesModLabel.TabIndex = 3;
            CopiesModLabel.Text = "Number of Copies:";
            // 
            // FeeMofLabel
            // 
            FeeMofLabel.AutoSize = true;
            FeeMofLabel.Location = new Point(62, 215);
            FeeMofLabel.Name = "FeeMofLabel";
            FeeMofLabel.Size = new Size(162, 28);
            FeeMofLabel.TabIndex = 2;
            FeeMofLabel.Text = "Distribution Fee:";
            // 
            // TypeModLabel
            // 
            TypeModLabel.AutoSize = true;
            TypeModLabel.Location = new Point(62, 131);
            TypeModLabel.Name = "TypeModLabel";
            TypeModLabel.Size = new Size(122, 28);
            TypeModLabel.TabIndex = 1;
            TypeModLabel.Text = "Movie Type:";
            // 
            // NameModLabel
            // 
            NameModLabel.AutoSize = true;
            NameModLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameModLabel.Location = new Point(62, 44);
            NameModLabel.Name = "NameModLabel";
            NameModLabel.Size = new Size(133, 28);
            NameModLabel.TabIndex = 0;
            NameModLabel.Text = "Movie Name:";
            // 
            // AssignActorButton
            // 
            AssignActorButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignActorButton.Location = new Point(29, 131);
            AssignActorButton.Name = "AssignActorButton";
            AssignActorButton.Size = new Size(248, 43);
            AssignActorButton.TabIndex = 3;
            AssignActorButton.Text = "Assign Actor to Movie";
            AssignActorButton.UseVisualStyleBackColor = true;
            AssignActorButton.Click += AssignActorButton_Click;
            // 
            // ModifyMovieButton
            // 
            ModifyMovieButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyMovieButton.Location = new Point(29, 83);
            ModifyMovieButton.Name = "ModifyMovieButton";
            ModifyMovieButton.Size = new Size(248, 43);
            ModifyMovieButton.TabIndex = 2;
            ModifyMovieButton.Text = "Search/Modify Movie";
            ModifyMovieButton.UseVisualStyleBackColor = true;
            ModifyMovieButton.Click += ModifyMovieButton_Click;
            // 
            // AddMovieButton
            // 
            AddMovieButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMovieButton.Location = new Point(29, 33);
            AddMovieButton.Name = "AddMovieButton";
            AddMovieButton.Size = new Size(248, 43);
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
            AddMovieBox.Location = new Point(402, 0);
            AddMovieBox.Margin = new Padding(3, 4, 3, 4);
            AddMovieBox.Name = "AddMovieBox";
            AddMovieBox.Padding = new Padding(3, 4, 3, 4);
            AddMovieBox.Size = new Size(914, 517);
            AddMovieBox.TabIndex = 4;
            AddMovieBox.TabStop = false;
            AddMovieBox.Visible = false;
            // 
            // MovieAddButton
            // 
            MovieAddButton.Location = new Point(614, 412);
            MovieAddButton.Margin = new Padding(3, 4, 3, 4);
            MovieAddButton.Name = "MovieAddButton";
            MovieAddButton.Size = new Size(139, 52);
            MovieAddButton.TabIndex = 8;
            MovieAddButton.Text = "Add";
            MovieAddButton.UseVisualStyleBackColor = true;
            MovieAddButton.Click += MovieAddButton_Click;
            // 
            // TypeAddComboBox
            // 
            TypeAddComboBox.FormattingEnabled = true;
            TypeAddComboBox.Location = new Point(277, 131);
            TypeAddComboBox.Margin = new Padding(3, 4, 3, 4);
            TypeAddComboBox.Name = "TypeAddComboBox";
            TypeAddComboBox.Size = new Size(173, 36);
            TypeAddComboBox.TabIndex = 7;
            // 
            // CopiesAddText
            // 
            CopiesAddText.Location = new Point(277, 295);
            CopiesAddText.Margin = new Padding(3, 4, 3, 4);
            CopiesAddText.Name = "CopiesAddText";
            CopiesAddText.Size = new Size(114, 34);
            CopiesAddText.TabIndex = 6;
            // 
            // FeeAddText
            // 
            FeeAddText.Location = new Point(277, 211);
            FeeAddText.Margin = new Padding(3, 4, 3, 4);
            FeeAddText.Name = "FeeAddText";
            FeeAddText.Size = new Size(173, 34);
            FeeAddText.TabIndex = 5;
            // 
            // NameAddText
            // 
            NameAddText.Location = new Point(277, 40);
            NameAddText.Margin = new Padding(3, 4, 3, 4);
            NameAddText.Name = "NameAddText";
            NameAddText.Size = new Size(301, 34);
            NameAddText.TabIndex = 4;
            // 
            // CopiesAddLabel
            // 
            CopiesAddLabel.AutoSize = true;
            CopiesAddLabel.Location = new Point(62, 299);
            CopiesAddLabel.Name = "CopiesAddLabel";
            CopiesAddLabel.Size = new Size(184, 28);
            CopiesAddLabel.TabIndex = 3;
            CopiesAddLabel.Text = "Number of Copies:";
            // 
            // FeeAddLabel
            // 
            FeeAddLabel.AutoSize = true;
            FeeAddLabel.Location = new Point(62, 215);
            FeeAddLabel.Name = "FeeAddLabel";
            FeeAddLabel.Size = new Size(162, 28);
            FeeAddLabel.TabIndex = 2;
            FeeAddLabel.Text = "Distribution Fee:";
            // 
            // TypeAddLabel
            // 
            TypeAddLabel.AutoSize = true;
            TypeAddLabel.Location = new Point(62, 131);
            TypeAddLabel.Name = "TypeAddLabel";
            TypeAddLabel.Size = new Size(122, 28);
            TypeAddLabel.TabIndex = 1;
            TypeAddLabel.Text = "Movie Type:";
            // 
            // NameAddLabel
            // 
            NameAddLabel.AutoSize = true;
            NameAddLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameAddLabel.Location = new Point(62, 44);
            NameAddLabel.Name = "NameAddLabel";
            NameAddLabel.Size = new Size(133, 28);
            NameAddLabel.TabIndex = 0;
            NameAddLabel.Text = "Movie Name:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 192);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1318, 516);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rental Management";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(65, 109);
            button6.Name = "button6";
            button6.Size = new Size(248, 43);
            button6.TabIndex = 3;
            button6.Text = "Search Customer";
            button6.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(192, 255, 192);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1318, 516);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(35, 356);
            button5.Name = "button5";
            button5.Size = new Size(248, 43);
            button5.TabIndex = 6;
            button5.Text = "Report 5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(35, 270);
            button4.Name = "button4";
            button4.Size = new Size(248, 43);
            button4.TabIndex = 5;
            button4.Text = "Report 4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(35, 186);
            button3.Name = "button3";
            button3.Size = new Size(248, 43);
            button3.TabIndex = 4;
            button3.Text = "Report 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(35, 107);
            button2.Name = "button2";
            button2.Size = new Size(248, 43);
            button2.TabIndex = 3;
            button2.Text = "Report 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(35, 33);
            button1.Name = "button1";
            button1.Size = new Size(248, 43);
            button1.TabIndex = 2;
            button1.Text = "Report 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 37);
            label5.Name = "label5";
            label5.Size = new Size(220, 28);
            label5.TabIndex = 4;
            label5.Text = "Enter Customer Name";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 221);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 6;
            label6.Text = "Availability";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 27);
            textBox4.TabIndex = 7;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(65, 330);
            button8.Name = "button8";
            button8.Size = new Size(248, 43);
            button8.TabIndex = 8;
            button8.Text = "Rent Movie";
            button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(800, 37);
            label2.Name = "label2";
            label2.Size = new Size(248, 28);
            label2.TabIndex = 9;
            label2.Text = "Customer's Movie Queue";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 665);
            Controls.Add(DashboardTabs);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Employee Homescreen ";
            DashboardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ModifyCustBox.ResumeLayout(false);
            ModifyCustBox.PerformLayout();
            AddCustBox.ResumeLayout(false);
            AddCustBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            AssignActorBox.ResumeLayout(false);
            AssignActorBox.PerformLayout();
            ModifyMovieBox.ResumeLayout(false);
            ModifyMovieBox.PerformLayout();
            AddMovieBox.ResumeLayout(false);
            AddMovieBox.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private Label CustIDButton;
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
        private Button button7;
        private Button button8;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}