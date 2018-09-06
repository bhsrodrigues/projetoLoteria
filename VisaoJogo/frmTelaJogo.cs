using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControlJogo;
using CModelJogo;

namespace VisaoJogo
{
    public partial class frmTelaJogo : Form
    {

        bool existsError;

        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            existsError = false;
            Lotofacil g = new Lotofacil(
                insertedValues(txtTotalNumbers), 15, 18, 25);
            g.playGame();
            new CModelJogo.Model();
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotofacil.Checked) {
                FieldsControl.ModifyControl(gboboxLotoFacil, true);
            }
            else
            {
                FieldsControl.ModifyControl(gboboxLotoFacil, false);
            }
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
    }
}
