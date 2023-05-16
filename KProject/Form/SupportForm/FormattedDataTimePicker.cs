namespace KProject.Form.SupportForm
{
    public class FormattedDataTimePicker : DateTimePicker
    {
        public FormattedDataTimePicker()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }
    }
}
