﻿using System;
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
            int gameplayers = Convert.ToInt16(cboboxGamesLF.SelectedText);
            for (int x = 1; x <= gameplayers; x++)
            {

                lf = new Lotofacil(
                Convert.ToInt16(cboboxTotalNumbersLF.SelectedText), 15, 18, 25);

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
    }
}
