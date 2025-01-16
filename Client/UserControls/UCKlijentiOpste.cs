using Client.GuiController;
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
            KlijentGuiController.Instance.DodajKlijentaEvent(this);
        }

        private void btnKrajUnosaKlijenta_Click(object sender, EventArgs e)
        {
            KlijentGuiController.Instance.KrajDodajPromeniEvent(this);
        }

        private void btnObrisiKlijenta_Click(object sender, EventArgs e)
        {
            KlijentGuiController.Instance.ObrisiKlijenta(this);
        }
    }
}
