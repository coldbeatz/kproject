
namespace KProject.Form.SupportForm
{
    public partial class OrderInfo : System.Windows.Forms.Form
    {
        private readonly DataBase dataBase = DataBase.GetInstance();

        public Order? SelectedOrder { get; set; }

        public OrderInfo(ICollection<Order> orders)
        {
            InitializeComponent();
            CenterToScreen();

            ShowOrders(orders);
        }

        private void ShowOrders(ICollection<Order> orders)
        {
            ordersScroll.Controls.Clear();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    ordersScroll.Controls.Add(new OrdersGroupBox(order, this));
                }

                ordersScroll.ScrollControlIntoView(ordersScroll);
            }
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            List<Order> orders = dataBase.GetAwaiableOrders();

            switch (filterComboBox.SelectedIndex)
            {
                case 0:
                    orders = orders.OrderByDescending(x => x.Id).ToList();
                    break;
                case 1:
                    orders.OrderBy(x => x.Recipient.Name).ToList();
                    break;
                case 2:
                    orders = orders.OrderBy(x => x.DepartureDate).ToList();
                    break;
            }

            ShowOrders(orders);
        }

        private void OnSearchByPhone(object sender, EventArgs e)
        {
            List<Order> orders = dataBase.GetOrdersByPhone(phone.GetEnteredText());
            ShowOrders(orders);
        }

        private void OnBackButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
