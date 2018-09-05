using System;
using System.Windows.Forms;
using ControlJogo;

namespace VisaoJogo
{
    public partial class frmTelaJogo : Form
    {

        public frmTelaJogo()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Lotofacil g = new Lotofacil(15, 15, 18, 25);
            g.playGame();
        }

        private void chkLotofacil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotofacil.Checked == true) {
                allowFields(gboboxLotoFacil);
            }
            else
            {
                denyFields(gboboxLotoFacil);
            }
        }

        private void allowFields(Control gbobox)
        {
            foreach(Control item in gbobox.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                }
            }
        }

        private void denyFields(Control gbobox)
        {
            foreach (Control item in gbobox.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                    item.Text = "";
                }
            }
        }
    }
}
