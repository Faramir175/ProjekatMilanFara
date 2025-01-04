using Client.GuiController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCRacunOpsta : UserControl
    {
        FrmStavkeRacuna frmStavkeRacuna;
        public UCRacunOpsta()
        {
            InitializeComponent();
        }

        private void btnUnosNovogRacuna_Click(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.FormaZaUnos(frmStavkeRacuna);
        }

        private void btnPromeniRacun_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete red za promenu.");
                return;
            }

            var selektovaniRacun = (Racun)dgvRacuni.SelectedRows[0].DataBoundItem;

            StavkeRacunaGuiController.Instance.FormaZaPromenu(frmStavkeRacuna, selektovaniRacun);
        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            RacunGuiController.Instance.FiltrirajRacune(this);
        }
    }
}
