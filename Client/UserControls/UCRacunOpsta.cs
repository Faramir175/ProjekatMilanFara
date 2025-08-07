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
        public Racun selektovaniRacun;
        public bool promena = true;
        private bool vrstaPromene = true;
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
            selektovaniRacun = (Racun)dgvRacuni.SelectedRows[0]?.DataBoundItem;
            promena = true;

            StavkeRacunaGuiController.Instance.FormaZaPromenu(frmStavkeRacuna, selektovaniRacun, promena);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete red za promenu.");
                return;
            }
            selektovaniRacun = (Racun)dgvRacuni.SelectedRows[0]?.DataBoundItem;

            StavkeRacunaGuiController.Instance.FormaZaDetalje(frmStavkeRacuna, selektovaniRacun);
        }

        private void cmbKlijent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RacunGuiController.Instance.FiltrirajKlijent(this);
            MessageBox.Show("Систем је нашао рачуне по задатим критеријумима");
        }

        private void cmbFrizer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RacunGuiController.Instance.FiltrirajFrizer(this);
            MessageBox.Show("Систем је нашао рачуне по задатим критеријумима");

        }

        private void cmbUsluga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RacunGuiController.Instance.FiltrirajUsluga(this);
            MessageBox.Show("Систем је нашао рачуне по задатим критеријумима");

        }

        private void tbCenaRacuna_TextChanged(object sender, EventArgs e)
        {
            RacunGuiController.Instance.FiltrirajCenaRacun(this);
            MessageBox.Show("Систем је нашао рачуне по задатим критеријумима");

        }

        private void rbKlijent_CheckedChanged(object sender, EventArgs e)
        {
            cmbKlijent.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }

        private void rbFrizer_CheckedChanged(object sender, EventArgs e)
        {
            CmbFrizer.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }

        private void rbUsluga_CheckedChanged(object sender, EventArgs e)
        {
            cmbUsluga.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }

        private void rbCenaRacuna_CheckedChanged(object sender, EventArgs e)
        {
            tbCenaRacuna.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }

    }
}