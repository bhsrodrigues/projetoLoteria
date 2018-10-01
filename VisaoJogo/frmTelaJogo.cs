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
                public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void playLotofacil()
        {

            Lotofacil lf = new Lotofacil();

            lf.playGame(Convert.ToInt16(cboboxTotalNumbersLF.Text), 15, 18, 25,
                Convert.ToInt16(cboboxGamesLF.Text), "Lotofacil");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Model.FileName = txtPath.Text;
            if (chkLotofacil.Checked) playLotofacil();
            /*Model save = new Model();
            if (gameListLF != null) save.saveLotoFacil(gameListLF);*/
            
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkLotofacil, pnlLotofacil);
        }

        private bool enableButton()
        {

            if (chkLotofacil.Checked) return true;
            if (chkboxMegaSena.Checked) return true;
            return false;
        }

        private void changeComboStatus(CheckBox check, Panel panel)
        {
            if (check.Checked)
            {
                FieldsControl.ModifyControl(panel, true);
            }
            else
            {
                FieldsControl.ModifyControl(panel, false);
            }
            btnPlay.Enabled = enableButton();
        }

        private void chkboxMegaSena_CheckedChanged(object sender, EventArgs e)
        {
            changeComboStatus(chkboxMegaSena, pnlMegaSena);
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
    }
}
