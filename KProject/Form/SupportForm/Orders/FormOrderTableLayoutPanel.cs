using KProject.Form.SupportForm.Messages;

namespace KProject.Form.SupportForm.Orders
{
    public class FormOrderTableLayoutPanel : TableLayoutPanel
    {
        private readonly DataBase dataBase = DataBase.GetInstance();

        private static readonly string[] OBLAST_CENTERS = {
            "Київ",
            "Харків",
            "Одеса",
            "Дніпро",
            "Донецьк",
            "Запоріжжя",
            "Львів",
            "Кривий Ріг",
            "Миколаїв",
            "Маріуполь",
            "Луганськ",
            "Вінниця",
            "Макіївка",
            "Севастополь",
            "Сімферополь",
            "Херсон",
            "Полтава",
            "Чернігів",
            "Черкаси",
            "Хмельницький",
            "Чернівці",
            "Житомир",
            "Суми",
            "Рівне",
            "Горлівка",
            "Івано-Франківськ",
            "Кам'янське",
            "Кропивницький",
            "Тернопіль",
            "Кременчук",
            "Луцьк"
        };

        private readonly TextBox description = new();
        private readonly ComboBox deliveryCity = new();
        private readonly TextBox name = new();
        private readonly TextBox nameSender = new();

        private readonly PhoneMaskedTextBox phone = new();
        private readonly PhoneMaskedTextBox phoneSender = new();

        private readonly NumericUpDown payment = new();
        private readonly NumericUpDown weight = new();
        private readonly NumericUpDown shippingCost = new();

        private readonly DateTimePicker departureDate = new FormattedDataTimePicker();

        private readonly Label descriptionLabel = new();
        private readonly Label cityLabel = new();
        private readonly Label nameLabel = new();
        private readonly Label nameSenderLabel = new();
        private readonly Label phoneLabel = new();
        private readonly Label phoneSenderLabel = new();
        private readonly Label paymentLabel = new();
        private readonly Label weightLabel = new();
        private readonly Label dateLabel = new();
        private readonly Label shippingCostLabel = new();

        private readonly Button cancelButton = new();
        private readonly Button addButton = new();

        private readonly FormOrder formOrder;

        public string Description
        {
            get => description.Text;
            set => description.Text = value;
        }

        public string DeliveryCity
        {
            get => deliveryCity.Text;
            set => deliveryCity.Text = value;
        }

        public string RecipientName
        {
            get => name.Text;
            set => name.Text = value;
        }

        public string SenderName
        {
            get => nameSender.Text;
            set => nameSender.Text = value;
        }

        public string Phone
        {
            get => phone.Text;
            set => phone.Text = value;
        }

        public string SenderPhone
        {
            get => phoneSender.Text;
            set => phoneSender.Text = value;
        }

        public decimal Weight
        {
            get => weight.Value;
            set => weight.Value = value;
        }

        public decimal ShippingCost
        {
            get => shippingCost.Value;
            set => shippingCost.Value = value;
        }

        public decimal Payment
        {
            get => payment.Value;
            set => payment.Value = value;
        }

        public DateTime DepartureDate
        {
            get => departureDate.Value;
            set => departureDate.Value = value;
        }

        public Order? Order { get; set; }

        public FormOrderTableLayoutPanel(FormOrder formOrder, Order? order)
        {
            this.formOrder = formOrder;
            Order = order;

            SuspendLayout();

            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));

            InitializeComponent();
            InitSpecialFields();

            Controls.Add(descriptionLabel, 0, 0);
            Controls.Add(description, 1, 0);

            Controls.Add(cityLabel, 0, 1);
            Controls.Add(deliveryCity, 1, 1);

            Controls.Add(nameLabel, 0, 2);
            Controls.Add(name, 1, 2);

            Controls.Add(phoneLabel, 0, 3);
            Controls.Add(phone, 1, 3);

            Controls.Add(paymentLabel, 0, 4);
            Controls.Add(payment, 1, 4);

            Controls.Add(weightLabel, 0, 5);
            Controls.Add(weight, 1, 5);

            Controls.Add(dateLabel, 0, 6);
            Controls.Add(departureDate, 1, 6);

            Controls.Add(shippingCostLabel, 0, 7);
            Controls.Add(shippingCost, 1, 7);

            Controls.Add(phoneSenderLabel, 0, 8);
            Controls.Add(phoneSender, 1, 8);

            Controls.Add(nameSenderLabel, 0, 9);
            Controls.Add(nameSender, 1, 9);

            Controls.Add(addButton, 0, 10);
            Controls.Add(cancelButton, 1, 10);

            Dock = DockStyle.Fill;
            Location = new Point(0, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formTableLayoutPanel";

            RowCount = Controls.Count / 2;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
                }
                else if (control is Button)
                {
                    RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                }
            }

            Size = new Size(590, 380);
            TabIndex = 0;

            ResumeLayout(false);
            PerformLayout();
        }

        private void InitSpecialFields()
        {
            User? user = dataBase.CurrentUser;
            if (user != null)
            {
                if (user.UserType == UserType.DEFAULT)
                {
                    phoneSender.Text = user.Phone.Replace("+38", "");
                    nameSender.Text = user.Name;

                    phoneSender.Enabled = nameSender.Enabled = false;
                }
            }
        }

        public void InitOrder()
        {
            if (Order == null)
                return;

            description.Text = Order.Description;
            deliveryCity.Text = Order.DeliveryCity;
            name.Text = Order.Recipient.Name;
            nameSender.Text = Order.Sender.Name;

            phone.Text = Order.Recipient.Phone.Replace("+38", "");
            phoneSender.Text = Order.Sender.Phone.Replace("+38", "");

            payment.Value = (decimal)Order.Payment;
            weight.Value = Order.Weight;
            shippingCost.Value = (decimal)Order.ShippingCost;

            departureDate.Value = Order.DepartureDate;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)payment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shippingCost).BeginInit();

            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(261, 42);
            descriptionLabel.Text = "Опис відправлення";
            // 
            // description
            // 
            description.Dock = DockStyle.Fill;
            description.Margin = new Padding(3, 2, 3, 2);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(318, 38);
            description.TextChanged += OnDescriptionTextChanged;
            description.TextChanged += EnableSaveOrUpdateButton;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Dock = DockStyle.Fill;
            cityLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(261, 42);
            cityLabel.Text = "Місто доставки";
            // 
            // deliveryCity
            // 
            deliveryCity.Dock = DockStyle.Fill;
            deliveryCity.Margin = new Padding(3, 2, 3, 2);
            deliveryCity.Items.AddRange(OBLAST_CENTERS);
            deliveryCity.DropDownHeight = 200;
            deliveryCity.Name = "deliveryCity";
            deliveryCity.Size = new Size(318, 38);
            deliveryCity.TextChanged += EnableSaveOrUpdateButton;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(261, 42);
            nameLabel.Text = "ПІБ отримувача";
            // 
            // nameSenderLabel
            // 
            nameSenderLabel.AutoSize = true;
            nameSenderLabel.Dock = DockStyle.Fill;
            nameSenderLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameSenderLabel.Name = "nameSenderLabel";
            nameSenderLabel.Size = new Size(261, 42);
            nameSenderLabel.Text = "ПІБ відправника";
            // 
            // name
            // 
            name.Dock = DockStyle.Fill;
            name.Margin = new Padding(3, 2, 3, 2);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(318, 38);
            name.TextChanged += EnableSaveOrUpdateButton;
            //
            // nameSender
            //
            nameSender.Dock = DockStyle.Fill;
            nameSender.Margin = new Padding(3, 2, 3, 2);
            nameSender.Multiline = true;
            nameSender.Name = "nameSender";
            nameSender.Size = new Size(328, 38);
            nameSender.TextChanged += EnableSaveOrUpdateButton;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Dock = DockStyle.Fill;
            phoneLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(261, 42);
            phoneLabel.Text = "Телефон отримувача";
            //
            // phoneSenderLabel
            //
            phoneSenderLabel.AutoSize = true;
            phoneSenderLabel.Dock = DockStyle.Fill;
            phoneSenderLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            phoneSenderLabel.Name = "phoneSenderLabel";
            phoneSenderLabel.Size = new Size(261, 42);
            phoneSenderLabel.Text = "Телефон відправника";
            // 
            // phone
            // 
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Size = new Size(328, 32);
            phone.TextChanged += EnableSaveOrUpdateButton;
            //
            // phoneSender
            //
            phoneSender.Margin = new Padding(3, 2, 3, 2);
            phoneSender.Size = new Size(328, 32);
            phoneSender.TextChanged += EnableSaveOrUpdateButton;

            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Dock = DockStyle.Fill;
            paymentLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(261, 42);
            paymentLabel.Text = "Платіж";
            // 
            // payment
            // 
            payment.DecimalPlaces = 2;
            payment.Margin = new Padding(3, 2, 3, 2);
            payment.Maximum = new decimal(999999);
            payment.Name = "payment";
            payment.Size = new Size(338, 32);
            payment.ValueChanged += ChangeShippingCost;
            payment.TextChanged += EnableSaveOrUpdateButton;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Dock = DockStyle.Fill;
            weightLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(261, 42);
            weightLabel.Text = "Вага замовлення";
            // 
            // weight
            // 
            weight.DecimalPlaces = 2;
            weight.Dock = DockStyle.Fill;
            weight.Margin = new Padding(3, 2, 3, 2);
            weight.Name = "weight";
            weight.Size = new Size(318, 32);
            weight.Maximum = new decimal(100);
            weight.ValueChanged += ChangeShippingCost;
            weight.TextChanged += EnableSaveOrUpdateButton;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Dock = DockStyle.Fill;
            dateLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(261, 42);
            dateLabel.Text = "Дата замовлення";
            // 
            // departureDate
            // 
            departureDate.Enabled = false;
            departureDate.Name = "departureDate";
            departureDate.Size = new Size(328, 32);
            departureDate.TextChanged += EnableSaveOrUpdateButton;
            // 
            // shippingCostLabel
            // 
            shippingCostLabel.AutoSize = true;
            shippingCostLabel.Dock = DockStyle.Fill;
            shippingCostLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            shippingCostLabel.Name = "shippingCostLabel";
            shippingCostLabel.Size = new Size(261, 42);
            shippingCostLabel.Text = "Вартість доставки";
            // 
            // shippingCost
            // 
            shippingCost.DecimalPlaces = 2;
            shippingCost.Dock = DockStyle.Fill;
            shippingCost.Enabled = false;
            shippingCost.Margin = new Padding(3, 2, 3, 2);
            shippingCost.Name = "shippingCost";
            shippingCost.Size = new Size(318, 32);
            shippingCost.Maximum = new decimal(999999);
            shippingCost.TextChanged += EnableSaveOrUpdateButton;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(261, 38);
            addButton.Text = Order == null ? "Створити" : "Зберегти";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += OnSaveOrUpdateButtonClick;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(318, 38);
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += OnCancelButtonClick;

            ((System.ComponentModel.ISupportInitialize)payment).EndInit();
            ((System.ComponentModel.ISupportInitialize)weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)shippingCost).EndInit();
        }

        private void EnableSaveOrUpdateButton(object? sender, EventArgs e)
        {
            string? phoneText = phone.GetEnteredText();
            string? senderPhoneText = phoneSender.GetEnteredText();

            bool enabled = Weight > 0 &&
                !string.IsNullOrEmpty(Description) &&
                !string.IsNullOrEmpty(DeliveryCity) &&
                !string.IsNullOrEmpty(RecipientName) &&
                !string.IsNullOrEmpty(SenderName) &&
                phoneText.Length == phone.Mask.Length &&
                senderPhoneText.Length == phoneSender.Mask.Length;

            addButton.Enabled = enabled;
        }

        private void OnSaveOrUpdateButtonClick(object? sender, EventArgs e)
        {
            if (Order != null)
            {
                Order.Sender.Name = SenderName;
                Order.Sender.Phone = SenderPhone;

                Order.Recipient.Name = RecipientName;
                Order.Recipient.Phone = Phone;
            }

            Order order = Order ?? new Order(new Person(SenderName, SenderPhone), new Person(RecipientName, Phone));

            order.Description = Description;
            order.DeliveryCity = DeliveryCity;

            order.Weight = (int)Weight;
            order.Payment = (float)Payment;
            order.ShippingCost = (float)ShippingCost;

            order.DepartureCity = "Харків";
            order.DepartureDate = DepartureDate;
            order.Description = Description;

            User? user = dataBase.CurrentUser;

            if (user != null && user.UserType == UserType.DEFAULT)
            {
                order.UserId = user.Id;
            }

            dataBase.SaveOrder(order);

            DialogResult answer = InformationForm.Show("Відправлення збережено");

            if (answer == DialogResult.OK)
            {
                formOrder.DialogResult = DialogResult.OK;
                formOrder.Close();
            }
        }

        private void OnCancelButtonClick(object? sender, EventArgs e)
        {
            formOrder.DialogResult = DialogResult.OK;
            formOrder.Close();
        }

        public void OnDescriptionTextChanged(object? sender, EventArgs e)
        {
            if (description.Text.Length > 20)
            {
                description.Text = description.Text.Substring(0, 20);

                description.SelectionStart = 20;
                description.SelectionLength = 0;

                formOrder.desctiptionErrorLabel.Text = "Опис не більше 20 символів";
            }
            else
            {
                formOrder.desctiptionErrorLabel.Text = "";
            }
        }

        private void ChangeShippingCost(object? sender, EventArgs e)
        {
            shippingCost.Value = (decimal)Order.CalcShippingCost((float)payment.Value, (int)weight.Value);
        }
    }
}
