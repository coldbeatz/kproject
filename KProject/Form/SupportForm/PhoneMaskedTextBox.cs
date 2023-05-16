
using System.Text;

namespace KProject.Form.SupportForm
{
    public class PhoneMaskedTextBox : MaskedTextBox
    {
        public PhoneMaskedTextBox()
        {
            Mask = "+38(999)00-00-000";
            PromptChar = '_';
            ResetOnPrompt = false;
            SkipLiterals = false;
        }

        public string GetEnteredText()
        {
            StringBuilder enteredText = new();
            int lastDigitIndex = -1;

            for (int i = 0; i < Text.Length; i++)
            {
                if (char.IsDigit(Text[i]))
                {
                    lastDigitIndex = i;
                }
            }

            for (int i = 0; i <= lastDigitIndex; i++)
            {
                if (char.IsDigit(Text[i]) || !char.IsWhiteSpace(Text[i]))
                {
                    enteredText.Append(Text[i]);
                }
            }

            return enteredText.ToString();
        }
    }
}
