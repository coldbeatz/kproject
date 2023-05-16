using System.Windows.Forms;

namespace KProject.Form.SupportForm
{
    partial class FormOrder
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
            tableLayoutPanel = new TableLayoutPanel();
            headerPanel = new Panel();
            headerLabel = new Label();
            desctiptionErrorLabel = new Label();
            tableLayoutPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.46983F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.53017F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel.Controls.Add(headerPanel, 1, 0);
            tableLayoutPanel.Controls.Add(desctiptionErrorLabel, 2, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.71218F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82.28782F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(841, 517);
            tableLayoutPanel.TabIndex = 3;
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Location = new Point(96, 2);
            headerPanel.Margin = new Padding(3, 2, 3, 2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(591, 83);
            headerPanel.TabIndex = 1;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(255, 26);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(159, 31);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Відправлення";
            // 
            // desctiptionErrorLabel
            // 
            desctiptionErrorLabel.AutoSize = true;
            desctiptionErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            desctiptionErrorLabel.Location = new Point(693, 87);
            desctiptionErrorLabel.Name = "desctiptionErrorLabel";
            desctiptionErrorLabel.Size = new Size(0, 21);
            desctiptionErrorLabel.TabIndex = 2;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 517);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOrder";
            Text = "Відправлення";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;

        private Panel headerPanel;
        private Label headerLabel;

        public Label desctiptionErrorLabel;
    }
}