
using System.ComponentModel;
using System.Reflection;
using KProject.Form.SupportForm.Messages;

namespace KProject.Form.SupportForm
{
    public class OrdersGroupBox : GroupBox
    {
        private readonly DataBase dataBase = DataBase.GetInstance();

        private readonly FlowLayoutPanel ButtonsPanel = new();

        private readonly Button EditButton = new();
        private readonly Button CancelButton = new();
        private readonly Button DeliveredButton = new();
        private readonly Button OnTheRoadButton = new();
        private readonly Button ReceivedButton = new();

        private readonly TextBox statusTextBox;
        private readonly TextBox weightTextBox;
        private readonly TextBox paymentTextBox;
        private readonly TextBox shippingCostTextBox;
        private readonly TextBox descriptionTextBox;
        private readonly TextBox deliveryCityTextBox;
        private readonly TextBox departureCityTextBox;
        private readonly TextBox recipientTextBox;
        private readonly TextBox recipientPhoneTextBox;
        private readonly TextBox senderNameTextBox;
        private readonly TextBox senderPhoneTextBox;
        private readonly TextBox departureDateTextBox;

        private TextBox? deliveryDateTextBox;
        private TextBox? receivedDateTextBox;

        private readonly Order order;
        private readonly OrderInfo parent;

        public OrdersGroupBox(Order order, OrderInfo parent)
        {
            this.order = order;
            this.parent = parent;

            Text = $"Відправлення {order.Id}";
            Dock = DockStyle.Top;
            AutoSize = true;

            CreateTextBox("");

            ButtonsPanel.Dock = DockStyle.Top;
            ButtonsPanel.AutoSize = true;

            CreateButtons();
            Controls.Add(ButtonsPanel);

            statusTextBox = CreateTextBox("");
            weightTextBox = CreateTextBox("");
            paymentTextBox = CreateTextBox("");
            shippingCostTextBox = CreateTextBox("");
            descriptionTextBox = CreateTextBox("");
            deliveryCityTextBox = CreateTextBox("");
            departureCityTextBox = CreateTextBox("");
            recipientTextBox = CreateTextBox("");
            recipientPhoneTextBox = CreateTextBox("");
            senderNameTextBox = CreateTextBox("");
            senderPhoneTextBox = CreateTextBox("");
            departureDateTextBox = CreateTextBox("");

            InitTextBoxes();
        }

        private void InitTextBoxes()
        {
            statusTextBox.Text = $"Статус - {GetEnumDescription(order.OrderType)}";
            weightTextBox.Text = $"Вага - {order.Weight} кг.";
            paymentTextBox.Text = $"Платіж - {order.Payment} грн.";
            shippingCostTextBox.Text = $"Доставка - {order.ShippingCost} грн.";
            descriptionTextBox.Text = $"Опис відправлення: {order.Description}";
            deliveryCityTextBox.Text = $"Місто доставки - {order.DeliveryCity}";
            departureCityTextBox.Text = $"Місто відправки - {order.DepartureCity}";
            recipientTextBox.Text = $"ПІБ отримувача - {order.Recipient.Name}";
            recipientPhoneTextBox.Text = $"Номер отримувача - {order.Recipient.Phone}";
            senderNameTextBox.Text = $"ПІБ відправника - {order.Sender.Name}";
            senderPhoneTextBox.Text = $"Номер відправника - {order.Sender.Phone}";
            departureDateTextBox.Text = $"Дата створення - {order.DepartureDate}";

            CreateDeliveryDateTextBox();
            CreateReceivedDateTextBox();
        }

        private void CreateButtons()
        {
            User? currentUser = dataBase.CurrentUser;
            if (currentUser == null)
                return;

            if (currentUser.UserType != UserType.ADMINISTRATOR)
                return;

            ConfigureButton(EditButton, "Редагувати", OnChangeOrderButtonClick);

            ConfigureButton(CancelButton, "Скасувати", (object? sender, EventArgs e) =>
            {
                DialogResult result = ConfirmForm.Show("Підтвердіть скасування відправдення");

                if (result == DialogResult.Yes)
                {
                    if (order.OrderType == OrderType.CREATED)
                    {
                        order.ChangeOrderType(OrderType.CANCELED);
                        dataBase.SaveOrder(order);

                        UpdateGroupBox();
                    }
                    else
                    {
                        InformationForm.Show("Не можливо скасувати відправлення");
                    }
                }
            });

            ConfigureButton(OnTheRoadButton, "В дорозі", (object? sender, EventArgs e) =>
            {
                DialogResult result = ConfirmForm.Show("Підтвердіть зміну статусу відправлення");

                if (result == DialogResult.Yes)
                {
                    order.ChangeOrderType(OrderType.ON_THE_ROAD);
                    dataBase.SaveOrder(order);

                    UpdateGroupBox();
                }
            });

            ConfigureButton(DeliveredButton, "Доставлено", (object? sender, EventArgs e) =>
            {
                DialogResult result = ConfirmForm.Show("Підтвердіть зміну статусу відправлення");

                if (result == DialogResult.Yes)
                {
                    order.ChangeOrderType(OrderType.DELIVERED);
                    dataBase.SaveOrder(order);

                    UpdateGroupBox();
                }
            });

            ConfigureButton(ReceivedButton, "Отримано", (object? sender, EventArgs e) =>
            {
                DialogResult result = ConfirmForm.Show("Видати відправлення користувачу?");

                if (result == DialogResult.Yes)
                {
                    order.ChangeOrderType(OrderType.RECEIVED);
                    order.ReceivedDate = DateTime.Now;

                    dataBase.SaveOrder(order);

                    UpdateGroupBox();
                }
            });

            UpdateButtonsVisible();
        }

        private void UpdateButtonsVisible()
        {
            // Відображаємо або приховуємо кнопки відповідно до поточного стану замовлення
            EditButton.Visible = order.OrderType != OrderType.CANCELED && order.OrderType != OrderType.RECEIVED;
            CancelButton.Visible = order.OrderType == OrderType.CREATED;
            OnTheRoadButton.Visible = order.OrderType == OrderType.CREATED;
            DeliveredButton.Visible = order.OrderType == OrderType.ON_THE_ROAD;
            ReceivedButton.Visible = order.OrderType == OrderType.DELIVERED;
        }

        public void UpdateGroupBox()
        {
            // Оновлюємо текстові поля
            InitTextBoxes();
            UpdateButtonsVisible();

            // Примусово оновлюємо візуальне відображення GroupBox
            Invalidate(true);
        }

        private void OnChangeOrderButtonClick(object? sender, EventArgs e)
        {
            using FormOrder formOrder = new(order);

            DialogResult result = formOrder.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateGroupBox();
            }
        }

        private void CreateDeliveryDateTextBox() {
            if (order.DeliveryDate == null)
                return;

            string text = $"Дата доставки - {order.DeliveryDate}";

            if (deliveryDateTextBox == null)
            {
                deliveryDateTextBox = CreateTextBox(text);
            } else
            {
                deliveryDateTextBox.Text = text;
            }
        }

        private void CreateReceivedDateTextBox()
        {
            if (order.ReceivedDate == null)
                return;

            string text = $"Дата отримання - {order.ReceivedDate}";

            if (receivedDateTextBox == null)
            {
                receivedDateTextBox = CreateTextBox(text);
            }
            else
            {
                receivedDateTextBox.Text = text;
            }
        }

        private TextBox CreateTextBox(string text)
        {
            TextBox control = new()
            {
                Text = text,
                ReadOnly = true,
                Dock = DockStyle.Top
            };

            Controls.Add(control);
            return control;
        }

        private void EditClickHandler(object? sender, EventArgs e) {
            parent.SelectedOrder = order;

            parent.DialogResult = DialogResult.OK;
            parent.Close();
        }

        private void ConfigureButton(Button button, string text, EventHandler clickHandler)
        {
            button.Text = text;
            button.Dock = DockStyle.Top;
            button.AutoSize = true;
            button.Margin = new Padding(3);
            button.Click += clickHandler;
            button.Cursor = Cursors.Hand;

            ButtonsPanel.Controls.Add(button);
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
