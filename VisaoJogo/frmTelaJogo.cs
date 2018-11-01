using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControlJogo;
using CModelJogo;
using ConsoleApp1;

namespace VisaoJogo
{
    public partial class frmTelaJogo : Form
    {
        Model model;
        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void playLotofacil()
        {

            const string gameName = "Lotofacil";
            model.saveGame(new Lotofacil().playGame(Convert.ToInt16(cboboxTotalNumbersLF.Text), 15, 18, 25,
                Convert.ToInt16(cboboxGamesLF.Text), gameName), gameName);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            model = new Model();
            Model.FileName = txtPath.Text;
            if (chkboxDuplaSena.Checked) playDuplaSena();
            if (chkLotofacil.Checked) playLotofacil();
            model.saveValues();
            
        }

        private void playDuplaSena()
        {
            const string gameName = "Dupla-Sena";
            
            model.saveGame(new DuplaSena().playGame(Convert.ToInt16(cboboxTotalNumbersDS.Text), 6, 15, 60,
                Convert.ToInt16(cboboxGamesDS.Text), gameName), gameName);
            
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkLotofacil, pnlLotofacil, null);
        }

        private bool enableButton()
        {
            if (chkboxDuplaSena.Checked) return true;
            if (chkLotofacil.Checked) return true;
            if (chkboxMegaSena.Checked) return true;
            return false;
        }

        private void changeComboStatus(CheckBox check, Panel panel, string gameName)
        {
            if (check.Checked)
            {
                FieldsControl.ModifyControl(panel, true, gameName);
                //FieldsControl.loadNumbersGame(cboboxTotalNumbersDS, gameName);
            }
            else
            {
                FieldsControl.ModifyControl(panel, false, gameName);
            }
            btnPlay.Enabled = enableButton();
        }

        private void chkboxMegaSena_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxMegaSena, pnlMegaSena, null);
        }

        private void cboboxTotalNumbersLF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cboboxGamesLF.Text);
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            getFolderToSave.ShowDialog();
            txtPath.Text = getFolderToSave.SelectedPath;
        }

        private void chkboxDuplaSena_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxDuplaSena, pnlDuplaSena, "Dupla-sena");
        }
    }
}
