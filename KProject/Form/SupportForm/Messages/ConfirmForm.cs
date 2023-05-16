
using System.Windows.Forms;

namespace KProject.Form.SupportForm.Messages
{
    public class ConfirmForm : System.Windows.Forms.Form
    {
        private readonly Label labelMessage = new();
        private readonly Button buttonYes = new();
        private readonly Button buttonNo = new();
        private readonly PictureBox pictureBoxIcon = new();

        public ConfirmForm(string message)
        {
            labelMessage.Text = message;
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(56, 20);
            labelMessage.Size = new Size(100, 20);
            labelMessage.TabIndex = 0;

            buttonYes.Text = "Так";
            buttonYes.Location = new Point(56, 60);
            buttonYes.Size = new Size(75, 23);
            buttonYes.TabIndex = 1;
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Cursor = Cursors.Hand;
            buttonYes.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Yes;
                Close();
            };

            buttonNo.Text = "Ні";
            buttonNo.Location = new Point(140, 60);
            buttonNo.Size = new Size(75, 23);
            buttonNo.TabIndex = 2;
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Cursor = Cursors.Hand;
            buttonNo.Click += (sender, e) =>
            {
                DialogResult = DialogResult.No;
                Close();
            };

            // Встановлюємо значок питання
            pictureBoxIcon.Image = SystemIcons.Question.ToBitmap();
            pictureBoxIcon.Location = new Point(20, 20);
            pictureBoxIcon.Size = new Size(32, 32);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 3;
            pictureBoxIcon.TabStop = false;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 100);

            Controls.Add(pictureBoxIcon);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(labelMessage);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Підтвердження";

            // Змінюємо розмір вікна відповідно до розміру тексту
            Resize();
        }
        private new void Resize()
        {
            using Graphics graphics = CreateGraphics();
            SizeF textSize = graphics.MeasureString(labelMessage.Text, labelMessage.Font);
            ClientSize = new Size(Math.Max(250, (int)textSize.Width + 70), Math.Max(100, (int)textSize.Height + 70));
            buttonYes.Location = new Point(ClientSize.Width / 2 - buttonYes.Width - 10, ClientSize.Height - 40);
            buttonNo.Location = new Point(ClientSize.Width / 2 + 10, ClientSize.Height - 40);
        }

        public static DialogResult Show(string message)
        {
            using ConfirmForm confirmForm = new(message);
            return confirmForm.ShowDialog();
        }
    }
}