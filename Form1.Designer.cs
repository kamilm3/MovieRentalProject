namespace CMPT291_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usernameText = new Label();
            label2 = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            passwordText = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Blue;
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.ForeColor = Color.White;
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // usernameText
            // 
            resources.ApplyResources(usernameText, "usernameText");
            usernameText.Name = "usernameText";
            usernameText.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // usernameInput
            // 
            resources.ApplyResources(usernameInput, "usernameInput");
            usernameInput.Name = "usernameInput";
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // passwordInput
            // 
            resources.ApplyResources(passwordInput, "passwordInput");
            passwordInput.Name = "passwordInput";
            // 
            // passwordText
            // 
            resources.ApplyResources(passwordText, "passwordText");
            passwordText.Name = "passwordText";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(passwordInput);
            Controls.Add(passwordText);
            Controls.Add(usernameInput);
            Controls.Add(label2);
            Controls.Add(usernameText);
            Controls.Add(loginButton);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label usernameText;
        private Label label2;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label passwordText;
    }
}
