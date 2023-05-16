namespace KProject.Form.SupportForm
{
    partial class OrderInfo
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ordersScroll = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            filterComboBox = new ComboBox();
            panel5 = new Panel();
            phone = new PhoneMaskedTextBox();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            backButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.603865F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.39613F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Controls.Add(ordersScroll, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.65354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.34646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(840, 572);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ordersScroll
            // 
            ordersScroll.AutoScroll = true;
            ordersScroll.Dock = DockStyle.Fill;
            ordersScroll.Location = new Point(46, 115);
            ordersScroll.Margin = new Padding(3, 2, 3, 2);
            ordersScroll.Name = "ordersScroll";
            ordersScroll.Size = new Size(734, 408);
            ordersScroll.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(46, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 109);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 109);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.4904633F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.5095367F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(panel4, 0, 1);
            tableLayoutPanel3.Controls.Add(panel5, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.Size = new Size(734, 109);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 2;
            label2.Text = "Історія відправлень";
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(filterComboBox);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 56);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(438, 51);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 5);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 4;
            label1.Text = "Фільтр";
            // 
            // filterComboBox
            // 
            filterComboBox.Dock = DockStyle.Left;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "ID", "Ім'я", "Дата" });
            filterComboBox.Location = new Point(0, 0);
            filterComboBox.Margin = new Padding(3, 2, 3, 2);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(170, 33);
            filterComboBox.TabIndex = 3;
            filterComboBox.SelectedIndexChanged += OnFilterChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(phone);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(447, 56);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 51);
            panel5.TabIndex = 4;
            // 
            // phone
            // 
            phone.Dock = DockStyle.Left;
            phone.Location = new Point(0, 0);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Mask = "+38(999)00-00-000";
            phone.Name = "phone";
            phone.ResetOnPrompt = false;
            phone.Size = new Size(269, 32);
            phone.SkipLiterals = false;
            phone.TabIndex = 5;
            phone.TextChanged += OnSearchByPhone;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 5;
            label3.Text = "Пошук за номером";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(backButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(46, 527);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(734, 43);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // backButton
            // 
            backButton.Cursor = Cursors.Hand;
            backButton.Dock = DockStyle.Fill;
            backButton.Location = new Point(3, 2);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(238, 39);
            backButton.TabIndex = 7;
            backButton.Text = "Повернутись";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += OnBackButtonClick;
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 572);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderInfo";
            Text = "Відправлення";
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel ordersScroll;
        private Panel panel3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Label label1;
        private ComboBox filterComboBox;
        private Panel panel5;
        private Label label3;
        private Button backButton;
        private PhoneMaskedTextBox phone;
    }
}