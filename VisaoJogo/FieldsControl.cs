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
                FieldControl(item, enable, gameName);
            }
        }

        private static void LoadNumbersGame(ComboBox combo, string gameName){

            if (combo.Items.Count == 0)
            {
                foreach (int item in new GameModel().GetNumbers(gameName))
                {
                    combo.Items.Add(item);
                }
            }
            
        }

        private static void FieldControl(Control field, bool enable, string gameName)
        {
            if (field is ComboBox)
            {
                if (enable)
                {
                    LoadNumbersGame((ComboBox)field, gameName);
                    FirstComboItem((ComboBox)field);
                    field.Enabled = enable;
                }
                else
                {
                    field.Enabled = enable;
                    NullComboItem((ComboBox)field);
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
                    UncheckItem((CheckBox)field);
                }
            }
        }
        
        private static void UncheckItem(CheckBox item)
        {
            item.Checked = false;
        }

        private static void FirstComboItem(ComboBox item)
        {
            item.SelectedIndex = 0;
        }

        private static void NullComboItem(ComboBox item)
        {
            item.SelectedIndex = -1;
        }
    }
}
