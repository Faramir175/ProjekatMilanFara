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
        private bool vrstaPromene = true;

        public UCKlijentiOpste()
        {
            InitializeComponent();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                KlijentGuiController.Instance.FiltrirajKlijentaIme(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да нађе клијенте по задатим критеријумима");
            }
        }

        private void cmbMesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                KlijentGuiController.Instance.FiltrirajKlijentaMesto(this);
                MessageBox.Show("Систем је нашао клијенте по задатим критеријумима");
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да нађе клијенте по задатим критеријумима");
            }
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            promena = false;
            KlijentGuiController.Instance.DodajKlijentaEvent(this, promena);
        }

        private void btnKrajUnosaKlijenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (DgvKlijenti.SelectedRows.Count > 0)
                {
                    selektovaniKlijent = DgvKlijenti.SelectedRows[0]?.DataBoundItem as Klijent;
                }
                else
                {
                    selektovaniKlijent = null; // Nema selektovanih redova
                }


                KlijentGuiController.Instance.KrajDodajPromeniEvent(this, selektovaniKlijent, promena);
                MessageBox.Show("Систем је запамтио клијента");
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да запамти клијента");
            }
        }

        private void btnObrisiKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                selektovaniKlijent = (Klijent)DgvKlijenti.SelectedRows[0]?.DataBoundItem;
                KlijentGuiController.Instance.ObrisiKlijenta(this, selektovaniKlijent);
                MessageBox.Show("Систем је обрисао клијента");
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да обрише клијента");

            }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                selektovaniKlijent = (Klijent)DgvKlijenti.SelectedRows[0]?.DataBoundItem;
                KlijentGuiController.Instance.PretraziKlijenta(this, selektovaniKlijent);
            }
            catch (Exception)
            {
                MessageBox.Show("Систем не може да нађе клијента");
            }
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

            KlijentGuiController.Instance.PromenaKlijentaEvent(this, selektovaniKlijent, promena);
        }

        private void rbImePrezime_CheckedChanged(object sender, EventArgs e)
        {
            TbImePrezime.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }

        private void rbMesto_CheckedChanged(object sender, EventArgs e)
        {
            CmbMesto.Enabled = vrstaPromene;
            vrstaPromene = !vrstaPromene;
        }
    }
}
