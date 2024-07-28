using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

namespace EFDiyetProgramiProje.UI.ExtensionMethods
{
    public static class ValidationExtensionMethods
    {
        public static bool IsValidAge(this DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }

            if (age >= 18 && age <= 60)
                return true;
            else
            {
                throw new Exception("Uygulamayı yalnızca 18-60 yaş arası kullanıcılar kayıt olabilir");
                return false;
            }
        }

        public static bool IsValidEmail(this string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPassword(this string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter içermelidir.");
                return false;
            }

            if (!Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"\d"))
            {
                MessageBox.Show("Şifre en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.");
                return false;
            }

            if (!Regex.IsMatch(password, @"[!.@#$%^&*()-+=]"))
            {
                MessageBox.Show("Şifre en az bir özel karakter içermelidir.");
                return false;
            }
            return true;
        }

        public static bool IsValidForm(this Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox textBox)
                {
                    if (textBox.Text.IsNullOrEmpty())
                        return false;
                }

                if(childControl is NumericUpDown numericUpDown)
                {
                    if(numericUpDown.Value <= 0)
                        return false;
                }

                if (childControl is CheckBox checkBox)
                {
                    if (!checkBox.Checked)
                        return false;
                }

                if (childControl is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                        return false;
                }

                if (childControl is DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value.Date == DateTime.Now)
                        return false;
                }
                if (childControl is MaskedTextBox maskedTextBox)
                {
                    if (maskedTextBox.Text.IsNullOrEmpty())
                        return false;
                }
            }

            return true;
        }
    }
}
