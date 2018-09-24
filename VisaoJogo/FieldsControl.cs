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
        public static void ModifyControl(Control pnlLotofacil, bool enable)
        {
            foreach (Control item in pnlLotofacil.Controls)
            {
                fieldsControl(item, enable);
            }
        }

        private static void fieldsControl(Control field, bool enable)
        {
            if (field is ComboBox)
            {
                if (enable)
                {
                    firstComboItem((ComboBox)field);
                    field.Enabled = enable;
                    
;
                }
                else
                {
                    field.Enabled = enable;
                    nullComboItem((ComboBox)field);
                }
            }
        }

        private static void firstComboItem(ComboBox item)
        {
            item.SelectedIndex = 0;
        }

        private static void nullComboItem(ComboBox item)
        {
            item.SelectedIndex = -1;
        }
    }
}
