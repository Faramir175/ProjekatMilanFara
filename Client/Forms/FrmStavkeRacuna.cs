using Broker;
using Client.GuiController;
using Client.UserControls;
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

namespace Client
{
    public partial class FrmStavkeRacuna : Form
    {
        private UCRacunOpsta ucRacunOpsta;

        public FrmStavkeRacuna()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.DodajStavku(this);
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            var selektovanaStavka = (StavkaRacuna)dgvStavkeRacuna.SelectedRows[0].DataBoundItem;
            StavkeRacunaGuiController.Instance.IzbaciStavku(this);
        }

        private void cmbUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.InitCenaLbl(this);
            StavkeRacunaGuiController.Instance.InitIznosLbl(this);
        }

        private void tbKolicina_Leave(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.InitIznosLbl(this);

        }

        private void btnKrajUnosaStavki_Click(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.UpisURacun(this, true);
        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.InitPopustLbl(this);
            StavkeRacunaGuiController.Instance.InitUkupanIznosLbl(this);
        }

        private void btnKrajUnosa_Click(object sender, EventArgs e)
        {
            StavkeRacunaGuiController.Instance.KrajUnosaEvent(this);
        }
    }
}
