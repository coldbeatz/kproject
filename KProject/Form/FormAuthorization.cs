using ConstructorTest.UI.Form.FormComunication;
using KProject.Form.SupportForm.Messages;

namespace KProject
{
    public partial class FormAuthorization : System.Windows.Forms.Form
    {
        private readonly DataBase dataBase = DataBase.GetInstance();

        public FormAuthorization()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void OnRegistrationButtonClick(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new();
            formRegistration.Show();

            Hide();
        }

        private User? ValidateUser(string? phone, string? password)
        {
            if (phone == null || password == null)
                return null;

            User? user = dataBase.GetUserByPhone(phone);
            return user == null || user.Password != password ? null : user;
        }

        private void ShowOrderForm(User user)
        {
            dataBase.CurrentUser = user;

            MainForm.Id = user.Id;
            MainForm formOrder = new();
            formOrder.Show();

            Hide();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            User? user = ValidateUser(phone.Text, password.Text);

            if (user != null)
            {
                dataBase.UpdateLastUserData(user.Phone, user.Password);
                ShowOrderForm(user);
            }
            else
            {
                InformationForm.Show("Не вірний телефон або пароль");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            string? phone = dataBase.LastUserPhone;
            string? password = dataBase.LastUserPassword;

            User? user = ValidateUser(phone, password);

            if (user != null)
            {
                // костиль, скривання форми після її завантаження
                BeginInvoke(new Action(() => ShowOrderForm(user)));
            }

            // Вызвать базовую реализацию OnLoad
            base.OnLoad(e);
        }
    }
}
