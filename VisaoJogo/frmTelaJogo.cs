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
        private Model model;
        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void PlayLotofacil()
        {

            const string gameName = "Lotofacil";
            model.SaveGame(new Lotofacil().PlayGame(Convert.ToInt16(cboboxTotalNumbersLF.Text), 15, 18, 25,
                Convert.ToInt16(cboboxGamesLF.Text), gameName), gameName);

        }

        private void PlayMegaSena()
        {

            const string gameName = "Mega-Sena";
            model.SaveGame(new MegaSena().PlayGame(Convert.ToInt16(cboboxTotalNumbersMS.Text), 6, 15, 60,
                Convert.ToInt16(cboboxGamesMS.Text), gameName), gameName);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            model = new Model();
            Model.fileName = txtPath.Text;
            if (chkboxDiaDeSorte.Checked) PlayDiaDeSorte();
            if (chkboxDuplaSena.Checked) PlayDuplaSena();
            if (chkLotofacil.Checked) PlayLotofacil();
            if (chkboxLotomania.Checked) PlayLotomania();
            if (chkboxMegaSena.Checked) PlayMegaSena();
            if (chkboxQuina.Checked) PlayQuina();
            if (chkboxTimemania.Checked) PlayTimemania();
            
            model.SaveValues();

            MessageBox.Show(String.Format("Arquivo salvo com sucesso. Acesse o diretório \n\n{0}"
                ,Model.fileName));
            
        }

        private void PlayLotomania()
        {
            const string gameName = "Lotomania";
            model.SaveGame(new Lotomania().PlayGame(Convert.ToInt16(cboboxTotalNumbersLM.Text), 50, 50, 100,
                Convert.ToInt16(cboboxGamesLM.Text), gameName, chkboxUseUnsortedNumber.Checked), gameName);
        }

        private void PlayDiaDeSorte()
        {
            const string gameName = "DiaDeSorte";
            model.SaveGame(new DiaDeSorte().PlayGame(Convert.ToInt16(cboboxTotalNumbersDia.Text), 7, 15, 31,
                Convert.ToInt16(cboboxGamesDia.Text), gameName), gameName);
        }

        private void PlayDuplaSena()
        {
            const string gameName = "Dupla-Sena";
            
            model.SaveGame(new DuplaSena().PlayGame(Convert.ToInt16(cboboxTotalNumbersDS.Text), 6, 15, 60,
                Convert.ToInt16(cboboxGamesDS.Text), gameName), gameName);
            
        }

        private void PlayTimemania()
        {
            const string gameName = "Timemania";

            model.SaveGame(new Timemania().PlayGame(Convert.ToInt16(cboboxTotalNumbersTM.Text), 10, 10, 80,
                Convert.ToInt16(cboboxGamesTM.Text), gameName), gameName);

        }

        private void PlayQuina()
        {
            const string gameName = "Quina";

            model.SaveGame(new Quina().PlayGame(Convert.ToInt16(cboboxTotalNumbersQ.Text), 5, 15, 80,
                Convert.ToInt16(cboboxGamesQ.Text), gameName), gameName);
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkLotofacil, pnlLotofacil, "Lotofacil");
        }

        private bool EnableButton()
        {
            if (chkboxDiaDeSorte.Checked) return true;
            if (chkboxDuplaSena.Checked) return true;
            if (chkLotofacil.Checked) return true;
            if (chkboxLotomania.Checked) return true;
            if (chkboxMegaSena.Checked) return true;
            if (chkboxQuina.Checked) return true;
            if (chkboxTimemania.Checked) return true;
            return false;
        }

        private void ChangeComboStatus(CheckBox check, Panel panel, string gameName)
        {
            if (check.Checked)
            {
                FieldsControl.ModifyControl(panel, true, gameName);
            }
            else
            {
                FieldsControl.ModifyControl(panel, false, gameName);
            }
            if (txtPath.Text.Length != 0)
            {
                btnPlay.Enabled = EnableButton();
            }
            
        }

        private void chkboxMegaSena_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxMegaSena, pnlMegaSena, "Mega-Sena");
        }

        private void cboboxTotalNumbersLF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cboboxGamesLF.Text);
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            getFolderToSave.ShowDialog();
            txtPath.Text = getFolderToSave.SelectedPath;
            chkboxMegaSena_CheckedChanged(sender, e);
        }

        private void chkboxDuplaSena_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxDuplaSena, pnlDuplaSena, "Dupla-sena");
        }
        
        private void chkboxDiaDeSorte_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxDiaDeSorte, pnlDiaSorte, "Diadesorte");
        }

        private void chkboxQuina_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxQuina, pnlQuina, "Quina");
        }

        private void chkboxTimemania_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxTimemania, pnlTimemania, "Timemania");
        }

        private void chkboxLotomania_CheckedChanged(object sender, EventArgs e)
        {
            ChangeComboStatus(chkboxLotomania, pnlLotomania, "Lotomania");
        }
    }
}
