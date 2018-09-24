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
        private Game lf;
        private List<int[]> gameListLF;

        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void playLotofacil()
        {
            
            gameListLF = new List <int[]>();
            int gameplayers = insertedValues(txtGames);
            for (int x = 1; x <= gameplayers; x++)
            {

                lf = new Lotofacil(
                insertedValues(txtTotalNumbers), 15, 18, 25);

                gameListLF.Add(lf.playGame());
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (chkLotofacil.Checked) playLotofacil();
            Model save = new Model();
            if (gameListLF != null) save.saveLotoFacil(gameListLF);
            save.saveValues();
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotofacil.Checked) {
                FieldsControl.ModifyControl(pnlLotofacil, true);
            }
            else
            {
                FieldsControl.ModifyControl(pnlLotofacil, false);
            }
            btnPlay.Enabled = enableButton();
        }

        private int insertedValues(TextBox field)
        {
            try
            {
                return Convert.ToInt16(field.Text);
            }catch(Exception ex)
            {
                //existsError = true;
                return 1;
            }
        }

        private bool enableButton()
        {

            if (chkLotofacil.Checked) return true;
            return false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTelaJogo_Load(object sender, EventArgs e)
        {
            cboboxTotalNumbers.SelectedIndex = 0;
        }
    }
}
