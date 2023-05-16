using KProject.Form.SupportForm.Orders;

namespace KProject.Form.SupportForm
{
    public partial class FormOrder : System.Windows.Forms.Form
    {

        private readonly FormOrderTableLayoutPanel inputsPanel;

        public FormOrder(Order? order)
        {
            inputsPanel = new FormOrderTableLayoutPanel(this, order);

            InitializeComponent();
            tableLayoutPanel.Controls.Add(inputsPanel, 1, 1);

            inputsPanel.InitOrder();

            CenterToScreen();
        }
    }
}
