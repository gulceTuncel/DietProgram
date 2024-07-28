using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje.UI.ExtensionMethods
{
     public static class FormClearMethods
    {
        internal static void ClearForm(this Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox)
                {
                    ((TextBox)childControl).Clear();
                }
                else if (childControl is ComboBox)
                {
                    ((ComboBox)childControl).SelectedIndex = -1;
                }
                else if (childControl is DateTimePicker)
                {
                    ((DateTimePicker)childControl).Value = DateTime.Now;
                }
                else if (childControl is MaskedTextBox)
                {
                    ((MaskedTextBox)childControl).Clear();
                }
                else if (childControl is NumericUpDown)
                {
                    ((NumericUpDown)childControl).Value = 0;
                }
                else if (childControl is RadioButton)
                {
                    ((RadioButton)childControl).Checked = false;
                }
            }
        }
    }
}
