using Client.GuiController;
using Client.ServerCommunication;
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
    public partial class UCKlijentiOpste : UserControl
    {
        private Klijent selektovaniKlijent;
        public bool promena = false;

        public UCKlijentiOpste()
        {
            InitializeComponent();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            KlijentGuiController.Instance.FiltrirajKlijentaIme(this);
        }

        private void cmbMesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KlijentGuiController.Instance.FiltrirajKlijentaMesto(this);

        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            promena = false;
            KlijentGuiController.Instance.DodajKlijentaEvent(this,promena);
        }

        private void btnKrajUnosaKlijenta_Click(object sender, EventArgs e)
        {

            if (DgvKlijenti.SelectedRows.Count > 0)
            {
                selektovaniKlijent = DgvKlijenti.SelectedRows[0]?.DataBoundItem as Klijent;
            }
            else
            {
                selektovaniKlijent = null; // Nema selektovanih redova
            }


            KlijentGuiController.Instance.KrajDodajPromeniEvent(this,selektovaniKlijent,promena);
        }

        private void btnObrisiKlijenta_Click(object sender, EventArgs e)
        {
            selektovaniKlijent = (Klijent)DgvKlijenti.SelectedRows[0]?.DataBoundItem;
            KlijentGuiController.Instance.ObrisiKlijenta(this,selektovaniKlijent);
        }

        private void btnPromeniKlijenta_Click(object sender, EventArgs e)
        {
            if (DgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete red za promenu.");
                return;
            }
            promena = true;
            selektovaniKlijent = (Klijent)DgvKlijenti.SelectedRows[0]?.DataBoundItem;

            KlijentGuiController.Instance.PromenaKlijentaEvent(this,selektovaniKlijent,promena);
        }
    }
}
