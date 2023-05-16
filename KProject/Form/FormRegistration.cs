using ConstructorTest.UI.Form.FormComunication;
using KProject.Form.SupportForm.Messages;

namespace KProject
{
    public partial class FormRegistration : System.Windows.Forms.Form
    {
        private readonly DataBase dataBase = DataBase.GetInstance();

        public FormRegistration()
        {
            InitializeComponent();
            CenterToScreen();

            EnabledRegistrationoButton(null, null);
        }

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new();
            formAuthorization.Show();

            Hide();
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void EnabledRegistrationoButton(object? sender, EventArgs? e)
        {
            string? phoneText = phone.GetEnteredText();

            bool enabled = phoneText.Length == phone.Mask.Length &&
                password.Text == repeatPassword.Text &&
                !string.IsNullOrEmpty(name.Text) &&
                !string.IsNullOrEmpty(email.Text) &&
                !string.IsNullOrEmpty(password.Text);

            registrationButton.Enabled = enabled;
        }

        private void RegistrationButtonClick(object sender, EventArgs e)
        {
            if (!IsValidEmail(email.Text))
            {
                InformationForm.Show("Введіть коректну e-mail адресу");
                return;
            }

            if (dataBase.UserExists(phone.Text, email.Text))
            {
                InformationForm.Show("Такий номер телефону aбо e-mail вже зареєстровано");
                return;
            }

            UserType userType = name.Text.Equals("Admin") ? UserType.ADMINISTRATOR : UserType.DEFAULT;

            User user = new(email.Text, password.Text, userType, name.Text, phone.Text);

            dataBase.SaveUser(user);
            dataBase.UpdateLastUserData(user.Phone, user.Password);

            dataBase.CurrentUser = user;

            MainForm.Id = user.Id;
            MainForm formOrder = new();
            formOrder.Show();

            Hide();
        }
    }
}