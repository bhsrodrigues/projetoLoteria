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

        private void playMegaSena()
        {

            const string gameName = "Mega-Sena";
            model.saveGame(new MegaSena().playGame(Convert.ToInt16(cboboxTotalNumbersMS.Text), 6, 15, 60,
                Convert.ToInt16(cboboxGamesMS.Text), gameName), gameName);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            model = new Model();
            Model.FileName = txtPath.Text;
            if (chkboxDiaDeSorte.Checked) playDiaDeSorte();
            if (chkboxDuplaSena.Checked) playDuplaSena();
            if (chkLotofacil.Checked) playLotofacil();
            if (chkboxMegaSena.Checked) playMegaSena();
            if (chkboxQuina.Checked) playQuina();
            if (chkboxTimemania.Checked) playTimemania();
            model.saveValues();
            
        }

        private void playDiaDeSorte()
        {
            const string gameName = "DiaDeSorte";
            model.saveGame(new DiaDeSorte().playGame(Convert.ToInt16(cboboxTotalNumbersDia.Text), 7, 15, 31,
                Convert.ToInt16(cboboxGamesDia.Text), gameName), gameName);
        }

        private void playDuplaSena()
        {
            const string gameName = "Dupla-Sena";
            
            model.saveGame(new DuplaSena().playGame(Convert.ToInt16(cboboxTotalNumbersDS.Text), 6, 15, 60,
                Convert.ToInt16(cboboxGamesDS.Text), gameName), gameName);
            
        }

        private void playTimemania()
        {
            const string gameName = "Timemania";

            model.saveGame(new Timemania().playGame(Convert.ToInt16(cboboxTotalNumbersTM.Text), 10, 10, 80,
                Convert.ToInt16(cboboxGamesTM.Text), gameName), gameName);

        }

        private void playQuina()
        {
            const string gameName = "Quina";

            model.saveGame(new Quina().playGame(Convert.ToInt16(cboboxTotalNumbersQ.Text), 5, 15, 80,
                Convert.ToInt16(cboboxGamesQ.Text), gameName), gameName);
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkLotofacil, pnlLotofacil, "Lotofacil");
        }

        private bool enableButton()
        {
            if (chkboxDiaDeSorte.Checked) return true;
            if (chkboxDuplaSena.Checked) return true;
            if (chkLotofacil.Checked) return true;
            if (chkboxMegaSena.Checked) return true;
            if (chkboxQuina.Checked) return true;
            if (chkboxTimemania.Checked) return true;
            return false;
        }

        private void changeComboStatus(CheckBox check, Panel panel, string gameName)
        {
            if (check.Checked)
            {
                FieldsControl.ModifyControl(panel, true, gameName);
            }
            else
            {
                FieldsControl.ModifyControl(panel, false, gameName);
            }
            btnPlay.Enabled = enableButton();
        }

        private void chkboxMegaSena_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxMegaSena, pnlMegaSena, "Mega-Sena");
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

        private void chkboxDiaDeSorte_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxDiaDeSorte, pnlDiaSorte, "Diadesorte");
        }

        private void chkboxQuina_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxQuina, pnlQuina, "Quina");
        }

        private void chkboxTimemania_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxTimemania, pnlTimemania, "Timemania");
        }
    }
}
