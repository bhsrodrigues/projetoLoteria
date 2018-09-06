using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisaoJogo
{
    public static class FieldsControl
    {
        public static void ModifyControl(Control gbobox, bool enable)
        {
            foreach (Control item in gbobox.Controls)
            {
                fieldsControl(item, enable);
            }
        }

        private static void fieldsControl(Control field, bool enable)
        {
            if (field is TextBox)
            {
                if (enable)
                {
                    field.Enabled = enable;
                }
                else
                {
                    field.Enabled = enable;
                    field.Text = "";
                }
            }
        }
    }
}
