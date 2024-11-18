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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ModifyCustButton = new Button();
            NewCustButton = new Button();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            DashboardTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
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
            DashboardTabs.Size = new Size(1157, 412);
            DashboardTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(ModifyCustButton);
            tabPage1.Controls.Add(NewCustButton);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1149, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(438, 16);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(697, 368);
            flowLayoutPanel1.TabIndex = 2;
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
            ModifyCustButton.Click += ModifyCustButton_Click;
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
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1149, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie Management";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(320, 25);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(780, 344);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(25, 98);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(217, 32);
            button5.TabIndex = 3;
            button5.Text = "Assign Actor to Movie";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(25, 62);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(217, 32);
            button4.TabIndex = 2;
            button4.Text = "Search/Modify Movie";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(25, 25);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(217, 32);
            button3.TabIndex = 1;
            button3.Text = "Add New Movie";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 192);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1149, 384);
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
            tabPage4.Size = new Size(1149, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 497);
            Controls.Add(DashboardTabs);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Employee Homescreen ";
            DashboardTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl DashboardTabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button NewCustButton;
        private Button ModifyCustButton;
        private SplitContainer splitContainer1;
        private Button button5;
        private Button button4;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}