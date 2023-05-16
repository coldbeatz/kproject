using KProject.Form;

namespace ConstructorTest.UI.Form.FormComunication
{
    partial class MainForm
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
            TBOverWork = new TabPage();
            logoutMainPanel = new TableLayoutPanel();
            logoutPanel = new Panel();
            logoutTableLayoutPanel = new TableLayoutPanel();
            logoutButton = new Button();
            logoutLabelText = new Label();
            logoutHeader = new Label();
            TBInformation = new TabPage();
            userInfoMainPanel = new TableLayoutPanel();
            userInfoPanel = new Panel();
            TBOrder = new TabPage();
            ordersMainPanel = new Panel();
            tableLayoutPanelOrders = new TableLayoutPanel();
            ordersPanel = new Panel();
            ordersTableLayoutPanel = new TableLayoutPanel();
            allOrdersButton = new Button();
            createButton = new Button();
            ordersHeader = new Label();
            tabControl = new TabControl();
            TBOverWork.SuspendLayout();
            logoutMainPanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            logoutTableLayoutPanel.SuspendLayout();
            TBInformation.SuspendLayout();
            userInfoMainPanel.SuspendLayout();
            TBOrder.SuspendLayout();
            ordersMainPanel.SuspendLayout();
            tableLayoutPanelOrders.SuspendLayout();
            ordersPanel.SuspendLayout();
            ordersTableLayoutPanel.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // TBOverWork
            // 
            TBOverWork.Controls.Add(logoutMainPanel);
            TBOverWork.Location = new Point(4, 34);
            TBOverWork.Margin = new Padding(3, 2, 3, 2);
            TBOverWork.Name = "TBOverWork";
            TBOverWork.Padding = new Padding(3, 2, 3, 2);
            TBOverWork.Size = new Size(602, 316);
            TBOverWork.TabIndex = 2;
            TBOverWork.Text = "Завершити роботу";
            TBOverWork.UseVisualStyleBackColor = true;
            // 
            // logoutMainPanel
            // 
            logoutMainPanel.ColumnCount = 3;
            logoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            logoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            logoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            logoutMainPanel.Controls.Add(logoutPanel, 1, 1);
            logoutMainPanel.Controls.Add(logoutHeader, 1, 0);
            logoutMainPanel.Dock = DockStyle.Fill;
            logoutMainPanel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logoutMainPanel.Location = new Point(3, 2);
            logoutMainPanel.Margin = new Padding(3, 2, 3, 2);
            logoutMainPanel.Name = "logoutMainPanel";
            logoutMainPanel.RowCount = 3;
            logoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7121773F));
            logoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82.28782F));
            logoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            logoutMainPanel.Size = new Size(596, 312);
            logoutMainPanel.TabIndex = 4;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutTableLayoutPanel);
            logoutPanel.Dock = DockStyle.Fill;
            logoutPanel.Location = new Point(122, 54);
            logoutPanel.Margin = new Padding(3, 2, 3, 2);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(351, 240);
            logoutPanel.TabIndex = 0;
            // 
            // logoutTableLayoutPanel
            // 
            logoutTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoutTableLayoutPanel.ColumnCount = 1;
            logoutTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            logoutTableLayoutPanel.Controls.Add(logoutButton, 0, 1);
            logoutTableLayoutPanel.Controls.Add(logoutLabelText, 0, 0);
            logoutTableLayoutPanel.Location = new Point(0, 0);
            logoutTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            logoutTableLayoutPanel.Name = "logoutTableLayoutPanel";
            logoutTableLayoutPanel.RowCount = 3;
            logoutTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 38.28125F));
            logoutTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.578125F));
            logoutTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 44.140625F));
            logoutTableLayoutPanel.Size = new Size(351, 256);
            logoutTableLayoutPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Dock = DockStyle.Fill;
            logoutButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.Location = new Point(3, 100);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(345, 41);
            logoutButton.TabIndex = 21;
            logoutButton.Text = "Вихід";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += OnLogoutClick;
            // 
            // logoutLabelText
            // 
            logoutLabelText.AutoSize = true;
            logoutLabelText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            logoutLabelText.Location = new Point(3, 0);
            logoutLabelText.Name = "logoutLabelText";
            logoutLabelText.Size = new Size(334, 75);
            logoutLabelText.TabIndex = 22;
            logoutLabelText.Text = "Натискаючи на кнопку, ви вийдете з системи і зможете повернутися в неї після повторної авторизації";
            logoutLabelText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutHeader
            // 
            logoutHeader.AutoSize = true;
            logoutHeader.Dock = DockStyle.Fill;
            logoutHeader.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            logoutHeader.Location = new Point(122, 0);
            logoutHeader.Name = "logoutHeader";
            logoutHeader.Size = new Size(351, 52);
            logoutHeader.TabIndex = 2;
            logoutHeader.Text = "Вихід з системи";
            logoutHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBInformation
            // 
            TBInformation.Controls.Add(userInfoMainPanel);
            TBInformation.Location = new Point(4, 34);
            TBInformation.Margin = new Padding(3, 2, 3, 2);
            TBInformation.Name = "TBInformation";
            TBInformation.Padding = new Padding(3, 2, 3, 2);
            TBInformation.Size = new Size(602, 338);
            TBInformation.TabIndex = 1;
            TBInformation.Text = "Інформація";
            TBInformation.UseVisualStyleBackColor = true;
            // 
            // userInfoMainPanel
            // 
            userInfoMainPanel.ColumnCount = 3;
            userInfoMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            userInfoMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            userInfoMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            userInfoMainPanel.Controls.Add(userInfoPanel, 1, 1);
            userInfoMainPanel.Dock = DockStyle.Fill;
            userInfoMainPanel.Location = new Point(3, 2);
            userInfoMainPanel.Margin = new Padding(3, 2, 3, 2);
            userInfoMainPanel.Name = "userInfoMainPanel";
            userInfoMainPanel.RowCount = 3;
            userInfoMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.487085F));
            userInfoMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 91.51292F));
            userInfoMainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            userInfoMainPanel.Size = new Size(596, 334);
            userInfoMainPanel.TabIndex = 0;
            // 
            // userInfoPanel
            // 
            userInfoPanel.Dock = DockStyle.Fill;
            userInfoPanel.Location = new Point(62, 29);
            userInfoPanel.Margin = new Padding(3, 2, 3, 2);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(470, 287);
            userInfoPanel.TabIndex = 0;
            // 
            // TBOrder
            // 
            TBOrder.Controls.Add(ordersMainPanel);
            TBOrder.Location = new Point(4, 34);
            TBOrder.Margin = new Padding(3, 2, 3, 2);
            TBOrder.Name = "TBOrder";
            TBOrder.Padding = new Padding(3, 2, 3, 2);
            TBOrder.Size = new Size(602, 338);
            TBOrder.TabIndex = 0;
            TBOrder.Text = "Відправлення";
            TBOrder.UseVisualStyleBackColor = true;
            // 
            // ordersMainPanel
            // 
            ordersMainPanel.Controls.Add(tableLayoutPanelOrders);
            ordersMainPanel.Dock = DockStyle.Fill;
            ordersMainPanel.Location = new Point(3, 2);
            ordersMainPanel.Margin = new Padding(3, 2, 3, 2);
            ordersMainPanel.Name = "ordersMainPanel";
            ordersMainPanel.Size = new Size(596, 334);
            ordersMainPanel.TabIndex = 1;
            // 
            // tableLayoutPanelOrders
            // 
            tableLayoutPanelOrders.ColumnCount = 3;
            tableLayoutPanelOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelOrders.Controls.Add(ordersPanel, 1, 1);
            tableLayoutPanelOrders.Controls.Add(ordersHeader, 1, 0);
            tableLayoutPanelOrders.Dock = DockStyle.Fill;
            tableLayoutPanelOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanelOrders.Location = new Point(0, 0);
            tableLayoutPanelOrders.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelOrders.Name = "tableLayoutPanelOrders";
            tableLayoutPanelOrders.RowCount = 3;
            tableLayoutPanelOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7121773F));
            tableLayoutPanelOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 82.28782F));
            tableLayoutPanelOrders.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelOrders.Size = new Size(596, 334);
            tableLayoutPanelOrders.TabIndex = 3;
            // 
            // ordersPanel
            // 
            ordersPanel.Controls.Add(ordersTableLayoutPanel);
            ordersPanel.Dock = DockStyle.Fill;
            ordersPanel.Location = new Point(152, 58);
            ordersPanel.Margin = new Padding(3, 2, 3, 2);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(292, 258);
            ordersPanel.TabIndex = 0;
            // 
            // ordersTableLayoutPanel
            // 
            ordersTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersTableLayoutPanel.ColumnCount = 1;
            ordersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            ordersTableLayoutPanel.Controls.Add(allOrdersButton, 0, 1);
            ordersTableLayoutPanel.Controls.Add(createButton, 0, 0);
            ordersTableLayoutPanel.Location = new Point(0, 0);
            ordersTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            ordersTableLayoutPanel.Name = "ordersTableLayoutPanel";
            ordersTableLayoutPanel.RowCount = 3;
            ordersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.75701F));
            ordersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1339569F));
            ordersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 65.10903F));
            ordersTableLayoutPanel.Size = new Size(292, 258);
            ordersTableLayoutPanel.TabIndex = 0;
            // 
            // allOrdersButton
            // 
            allOrdersButton.Cursor = Cursors.Hand;
            allOrdersButton.Dock = DockStyle.Fill;
            allOrdersButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            allOrdersButton.Location = new Point(3, 47);
            allOrdersButton.Margin = new Padding(3, 2, 3, 2);
            allOrdersButton.Name = "allOrdersButton";
            allOrdersButton.Size = new Size(286, 40);
            allOrdersButton.TabIndex = 21;
            allOrdersButton.Text = "Усі відправлення";
            allOrdersButton.UseVisualStyleBackColor = true;
            allOrdersButton.Click += OnShowAllOrdersClick;
            // 
            // createButton
            // 
            createButton.Cursor = Cursors.Hand;
            createButton.Dock = DockStyle.Fill;
            createButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(3, 2);
            createButton.Margin = new Padding(3, 2, 3, 2);
            createButton.Name = "createButton";
            createButton.Size = new Size(286, 41);
            createButton.TabIndex = 20;
            createButton.Text = "Створити відправлення";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += OnCreateOrderButtonClick;
            // 
            // ordersHeader
            // 
            ordersHeader.AutoSize = true;
            ordersHeader.Dock = DockStyle.Fill;
            ordersHeader.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            ordersHeader.Location = new Point(152, 0);
            ordersHeader.Name = "ordersHeader";
            ordersHeader.Size = new Size(292, 56);
            ordersHeader.TabIndex = 2;
            ordersHeader.Text = "Відправлення";
            ordersHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(TBOrder);
            tabControl.Controls.Add(TBInformation);
            tabControl.Controls.Add(TBOverWork);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(610, 376);
            tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 376);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Почта";
            TBOverWork.ResumeLayout(false);
            logoutMainPanel.ResumeLayout(false);
            logoutMainPanel.PerformLayout();
            logoutPanel.ResumeLayout(false);
            logoutTableLayoutPanel.ResumeLayout(false);
            logoutTableLayoutPanel.PerformLayout();
            TBInformation.ResumeLayout(false);
            userInfoMainPanel.ResumeLayout(false);
            TBOrder.ResumeLayout(false);
            ordersMainPanel.ResumeLayout(false);
            tableLayoutPanelOrders.ResumeLayout(false);
            tableLayoutPanelOrders.PerformLayout();
            ordersPanel.ResumeLayout(false);
            ordersTableLayoutPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage TBOverWork;
        private TabPage TBInformation;
        private TabPage TBOrder;

        private TabControl tabControl;

        private TableLayoutPanel userInfoMainPanel;
        private Panel userInfoPanel;

        private TableLayoutPanel tableLayoutPanelOrders;

        private Panel ordersMainPanel;
        private Panel ordersPanel;
        private TableLayoutPanel ordersTableLayoutPanel;

        private Button createButton;
        private Button allOrdersButton;

        private TableLayoutPanel logoutMainPanel;
        private Panel logoutPanel;
        private TableLayoutPanel logoutTableLayoutPanel;
        private Button logoutButton;
        private Label ordersHeader;
        private Label logoutHeader;
        private Label logoutLabelText;
    }
}