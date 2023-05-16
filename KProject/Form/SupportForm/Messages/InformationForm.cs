
using System.Windows.Forms;

namespace KProject.Form.SupportForm.Messages
{
    public class InformationForm : System.Windows.Forms.Form
    {
        private readonly Label labelMessage = new();
        private readonly Button buttonOk = new();
        private readonly PictureBox pictureBoxIcon = new();

        public InformationForm(string message)
        {
            labelMessage.Text = message;
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(56, 20);
            labelMessage.Size = new Size(100, 20);
            labelMessage.TabIndex = 0;

            buttonOk.Text = "Ок";
            buttonOk.Location = new Point(56, 60);
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 1;
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.Click += (sender, e) =>
            {
                DialogResult = DialogResult.OK;
                Close();
            };

            // Встановлюємо значок інформації
            pictureBoxIcon.Image = SystemIcons.Information.ToBitmap();
            pictureBoxIcon.Location = new Point(20, 20);
            pictureBoxIcon.Size = new Size(32, 32);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 3;
            pictureBoxIcon.TabStop = false;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(250, 100);

            Controls.Add(pictureBoxIcon);
            Controls.Add(buttonOk);
            Controls.Add(labelMessage);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інформація";

            // Змінюємо розмір вікна відповідно до розміру тексту
            Resize();
        }

        private new void Resize()
        {
            using Graphics graphics = CreateGraphics();
            SizeF textSize = graphics.MeasureString(labelMessage.Text, labelMessage.Font);
            ClientSize = new Size(Math.Max(250, (int)textSize.Width + 70), Math.Max(100, (int)textSize.Height + 80));
            buttonOk.Location = new Point((ClientSize.Width - buttonOk.Width) / 2, ClientSize.Height - 40);
        }

        public static DialogResult Show(string message)
        {
            using InformationForm confirmForm = new(message);
            return confirmForm.ShowDialog();
        }
    }
}