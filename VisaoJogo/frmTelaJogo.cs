using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControlJogo;
using CModelJogo;

namespace VisaoJogo
{
    public partial class frmTelaJogo : Form
    {
        private Lotofacil lf;
        bool existsError = false;

        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void playLotofacil()
        {
            lf = new Lotofacil(
                insertedValues(txtTotalNumbers), 15, 18, 25);

            for (int x = 1; x <= insertedValues(txtGames); x++)
            {
                lf.playGame();
            }
            //Console.WriteLine(Lotofacil.gamePlayed);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (chkLotofacil.Checked) playLotofacil();
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
                existsError = true;
                return 1;
            }
        }

        private bool enableButton()
        {

            if (chkLotofacil.Checked) return true;
            return false;
        }

    }
}
