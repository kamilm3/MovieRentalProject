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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
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
            label1.Location = new Point(558, 25);
            label1.Name = "label1";
            label1.Size = new Size(287, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Name's Dashboard";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1322, 550);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1314, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Management";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 192, 128);
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1314, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movie Management";
            // 
            // button1
            // 
            button1.Location = new Point(22, 21);
            button1.Name = "button1";
            button1.Size = new Size(248, 43);
            button1.TabIndex = 0;
            button1.Text = "Add New Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 70);
            button2.Name = "button2";
            button2.Size = new Size(248, 68);
            button2.TabIndex = 1;
            button2.Text = "Update/Retrieve/Delete Customer Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(29, 33);
            button3.Name = "button3";
            button3.Size = new Size(248, 43);
            button3.TabIndex = 1;
            button3.Text = "Add New Movie";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(29, 82);
            button4.Name = "button4";
            button4.Size = new Size(248, 43);
            button4.TabIndex = 2;
            button4.Text = "Search/Modify Movie";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(29, 131);
            button5.Name = "button5";
            button5.Size = new Size(248, 43);
            button5.TabIndex = 3;
            button5.Text = "Assign Actor to Movie";
            button5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(366, 33);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(892, 459);
            splitContainer1.SplitterDistance = 297;
            splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(500, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(797, 490);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 192, 192);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1314, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rental Management";
            tabPage3.Click += tabPage3_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(192, 255, 192);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1314, 517);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Report";
            tabPage4.Click += tabPage4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 663);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Employee Homescreen ";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button button2;
        private SplitContainer splitContainer1;
        private Button button5;
        private Button button4;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}