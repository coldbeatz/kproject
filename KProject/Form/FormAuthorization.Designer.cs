using KProject.Form.SupportForm;

namespace KProject
{
    partial class FormAuthorization
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
            loginGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            registrationButton = new Button();
            phoneLabel = new Label();
            passwordLabel = new Label();
            password = new TextBox();
            panel1 = new Panel();
            loginButton = new Button();
            phone = new PhoneMaskedTextBox();
            loginGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(tableLayoutPanel1);
            loginGroupBox.Dock = DockStyle.Fill;
            loginGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginGroupBox.Location = new Point(0, 0);
            loginGroupBox.Margin = new Padding(3, 2, 3, 2);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Padding = new Padding(3, 2, 3, 2);
            loginGroupBox.Size = new Size(487, 198);
            loginGroupBox.TabIndex = 0;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Авторизація";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.80711F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.19289F));
            tableLayoutPanel1.Controls.Add(registrationButton, 1, 0);
            tableLayoutPanel1.Controls.Add(phoneLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(password, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(phone, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.882515F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7910347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7910347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5354118F));
            tableLayoutPanel1.Size = new Size(481, 169);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // registrationButton
            // 
            registrationButton.Dock = DockStyle.Right;
            registrationButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            registrationButton.Location = new Point(261, 2);
            registrationButton.Margin = new Padding(3, 2, 3, 2);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(217, 39);
            registrationButton.TabIndex = 14;
            registrationButton.Text = "Реєстрація";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += OnRegistrationButtonClick;
            registrationButton.Cursor = Cursors.Hand;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Dock = DockStyle.Fill;
            phoneLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(3, 43);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(252, 40);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Моб. телефон";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(3, 83);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(252, 40);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Пароль";
            // 
            // password
            // 
            password.Location = new Point(261, 85);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(217, 29);
            password.TabIndex = 11;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(loginButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 125);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 42);
            panel1.TabIndex = 7;
            // 
            // loginLabel
            // 
            loginButton.Dock = DockStyle.Fill;
            loginButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(0, 0);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginLabel";
            loginButton.Size = new Size(475, 42);
            loginButton.TabIndex = 2;
            loginButton.Text = "Авторизація";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButtonClick;
            loginButton.Cursor = Cursors.Hand;
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(261, 45);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Mask = "+38(999)00-00-000";
            phone.Name = "phone";
            phone.ResetOnPrompt = false;
            phone.Size = new Size(217, 32);
            phone.SkipLiterals = false;
            phone.TabIndex = 15;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 198);
            Controls.Add(loginGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAuthorization";
            Load += FormAuthorization_Load;
            loginGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox loginGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox password;
        private Label phoneLabel;
        private Label passwordLabel;
        private Panel panel1;
        private Button loginButton;
        private Button registrationButton;
        private PhoneMaskedTextBox phone;
    }
}