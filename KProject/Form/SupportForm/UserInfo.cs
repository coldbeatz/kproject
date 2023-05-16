namespace KProject.Form.SupportForm
{
    public class UserInfo : GroupBox
    {
        public UserInfo(User user)
        {
            Text = "Інформація користувача";
            Dock = DockStyle.Top;
            AutoSize = true;

            AddControl($"ID: {user.Id}");
            AddControl($"ПІБ: {user.Name}");
            AddControl($"Телефон: {user.Phone}");
            AddControl($"Email: {user.Email}");
            AddControl($"Тип користувача: {user.UserType}");
            AddControl("");
        }

        private void AddControl(string text)
        {
            Controls.Add(new TextBox
            {
                Text = text,
                ReadOnly = true,
                Dock = DockStyle.Top
            });
        }
    }
}
