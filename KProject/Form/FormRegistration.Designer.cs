using KProject.Form;
using KProject.Form.SupportForm;

namespace KProject
{
    partial class FormRegistration
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
            registrationGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            repeatPassword = new TextBox();
            password = new TextBox();
            email = new TextBox();
            repeatPasswordLabel = new Label();
            nameLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            panel1 = new Panel();
            registrationButton = new Button();
            name = new TextBox();
            loginButton = new Button();
            phone = new PhoneMaskedTextBox();
            registrationGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // registrationGroupBox
            // 
            registrationGroupBox.Controls.Add(tableLayoutPanel1);
            registrationGroupBox.Dock = DockStyle.Fill;
            registrationGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            registrationGroupBox.Location = new Point(0, 0);
            registrationGroupBox.Margin = new Padding(3, 2, 3, 2);
            registrationGroupBox.Name = "registrationGroupBox";
            registrationGroupBox.Padding = new Padding(3, 2, 3, 2);
            registrationGroupBox.Size = new Size(522, 322);
            registrationGroupBox.TabIndex = 0;
            registrationGroupBox.TabStop = false;
            registrationGroupBox.Text = "Реєстрація";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(repeatPassword, 1, 5);
            tableLayoutPanel1.Controls.Add(password, 1, 4);
            tableLayoutPanel1.Controls.Add(email, 1, 3);
            tableLayoutPanel1.Controls.Add(repeatPasswordLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(phoneLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(emailLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(panel1, 0, 6);
            tableLayoutPanel1.Controls.Add(name, 1, 1);
            tableLayoutPanel1.Controls.Add(loginButton, 1, 0);
            tableLayoutPanel1.Controls.Add(phone, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.668045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.668045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6659775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6659775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6659775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6659775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(516, 293);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // repeatPassword
            // 
            repeatPassword.Dock = DockStyle.Fill;
            repeatPassword.Location = new Point(183, 209);
            repeatPassword.Margin = new Padding(3, 2, 3, 2);
            repeatPassword.Multiline = true;
            repeatPassword.Name = "repeatPassword";
            repeatPassword.PasswordChar = '*';
            repeatPassword.Size = new Size(330, 37);
            repeatPassword.TabIndex = 12;
            repeatPassword.TextChanged += EnabledRegistrationoButton;
            // 
            // password
            // 
            password.Dock = DockStyle.Fill;
            password.Location = new Point(183, 168);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(330, 37);
            password.TabIndex = 11;
            password.TextChanged += EnabledRegistrationoButton;
            // 
            // email
            // 
            email.Dock = DockStyle.Fill;
            email.Location = new Point(183, 127);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(330, 37);
            email.TabIndex = 10;
            email.TextChanged += EnabledRegistrationoButton;
            // 
            // repeatPasswordLabel
            // 
            repeatPasswordLabel.AutoSize = true;
            repeatPasswordLabel.Dock = DockStyle.Fill;
            repeatPasswordLabel.Location = new Point(3, 207);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(174, 41);
            repeatPasswordLabel.TabIndex = 6;
            repeatPasswordLabel.Text = "Повтор пароля";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Location = new Point(3, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(174, 42);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "ПІБ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Dock = DockStyle.Fill;
            phoneLabel.Location = new Point(3, 84);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(174, 41);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Моб. телефон";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Dock = DockStyle.Fill;
            emailLabel.Location = new Point(3, 125);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(174, 41);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Location = new Point(3, 166);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(174, 41);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Пароль";
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(registrationButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 250);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 41);
            panel1.TabIndex = 7;
            // 
            // registrationButton
            // 
            registrationButton.Dock = DockStyle.Fill;
            registrationButton.Location = new Point(0, 0);
            registrationButton.Margin = new Padding(3, 2, 3, 2);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(510, 41);
            registrationButton.TabIndex = 2;
            registrationButton.Text = "Реєстрація";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += RegistrationButtonClick;
            registrationButton.Cursor = Cursors.Hand;

            // 
            // name
            // 
            name.Dock = DockStyle.Fill;
            name.Location = new Point(183, 44);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(330, 38);
            name.TabIndex = 8;
            name.TextChanged += EnabledRegistrationoButton;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Right;
            loginButton.Location = new Point(280, 2);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(233, 38);
            loginButton.TabIndex = 14;
            loginButton.Text = "Авторизація";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += OnLoginButtonClick;
            loginButton.Cursor = Cursors.Hand;
            // 
            // Phone
            // 
            phone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(183, 86);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "Phone";
            phone.Size = new Size(233, 32);
            phone.TabIndex = 15;
            phone.TextChanged += EnabledRegistrationoButton;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 322);
            Controls.Add(registrationGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRegistration";
            registrationGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox registrationGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox repeatPassword;
        private TextBox password;
        private TextBox email;
        private Label repeatPasswordLabel;
        private Label nameLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private Panel panel1;
        private Button registrationButton;
        private TextBox name;
        private Button loginButton;
        private PhoneMaskedTextBox phone;
    }
}