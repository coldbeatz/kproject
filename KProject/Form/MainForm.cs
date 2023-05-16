using KProject;
using KProject.Form.SupportForm;

namespace ConstructorTest.UI.Form.FormComunication
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public static long Id;

        private readonly DataBase dataBase = DataBase.GetInstance();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            InitializeUserInfo();
        }

        #region Замовлення
        private void ShowOrders()
        {
            using OrderInfo orderInfo = new(dataBase.GetAwaiableOrders());
            orderInfo.ShowDialog();
        }

        private void OnShowAllOrdersClick(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void OnCreateOrderButtonClick(object sender, EventArgs e)
        {
            using FormOrder formOrder = new(null);
            formOrder.ShowDialog();

            if (formOrder.DialogResult == DialogResult.OK)
            {
                ShowOrders();
            }
        }
        #endregion

        #region Інформація
        private void InitializeUserInfo()
        {
            var user = dataBase.GetUserById(Id);

            if (user != null)
            {
                userInfoPanel.Controls.Add(new UserInfo(user));
            }
        }
        #endregion

        #region Завершення роботи
        private void OnLogoutClick(object sender, EventArgs e)
        {
            dataBase.UpdateLastUserData(null, null);
            Hide();

            FormAuthorization formAuthorization = new();
            formAuthorization.Show();
        }
        #endregion
    }
}