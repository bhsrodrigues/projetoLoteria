using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CModelJogo;

namespace VisaoJogo
{
    public static class FieldsControl
    {
        public static void ModifyControl(Control pnlGame, bool enable, string gameName)
        {
            foreach (Control item in pnlGame.Controls)
            {
                fieldsControl(item, enable, gameName);
            }
        }

        public static void loadNumbersGame(ComboBox combo, string gameName){

            if (combo.Items.Count == 0)
            {
                foreach (int item in new GameModel().getNumbers(gameName))
                {
                    combo.Items.Add(item);
                }
            }
            
        }

        private static void fieldsControl(Control field, bool enable, string gameName)
        {
            if (field is ComboBox)
            {
                if (enable)
                {
                    loadNumbersGame((ComboBox)field, gameName);
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
            if (field is CheckBox)
            {
                if (enable)
                {
                    field.Enabled = true;
                }
                else
                {
                    field.Enabled = false;
                    uncheckItem((CheckBox)field);
                }
            }
        }
        
        private static void uncheckItem(CheckBox item)
        {
            item.Checked = false;
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
