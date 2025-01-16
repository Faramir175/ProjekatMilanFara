using Client.ServerCommunication;
using Client.UserControls;
using Common.Domain;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController
{
    public class KlijentGuiController
    {
        UCKlijentiOpste ucKlijentiOpsteView;
        private BindingList<Klijent> klijenti;
        private List<Mesto> mesta;
        private static KlijentGuiController instance;
        private Klijent selektovaniKlijent;
        public static KlijentGuiController Instance { get { if (instance == null) instance = new KlijentGuiController(); return instance; } }

        public UserControl CreateUCKlijentiOpste()
        {
            ucKlijentiOpsteView = new UCKlijentiOpste();
            InitDgvKlijenti(ucKlijentiOpsteView);
            InitDgvColumns(ucKlijentiOpsteView.DgvKlijenti);
            InitCmbMesto(ucKlijentiOpsteView);
            InitCmbTipKlijenta(ucKlijentiOpsteView);
            InitCmbPol(ucKlijentiOpsteView);
            UpisUKlijenta(ucKlijentiOpsteView, true);

            return ucKlijentiOpsteView;
        }

        private void InitCmbPol(UCKlijentiOpste ucKlijentiOpsteView)
        {
            List<string> polovi = new List<string> { "Muško", "Žensko" };
            ucKlijentiOpsteView.CmbDodajPol.DataSource = polovi;

        }

        private void InitCmbTipKlijenta(UCKlijentiOpste ucKlijentiOpsteView)
        {
            ucKlijentiOpsteView.CmbDodajTipKlijenta.DataSource = Enum.GetValues(typeof(TipKlijentaEnum));
        }

        private void InitCmbMesto(UCKlijentiOpste ucKlijentiOpsteView)
        {
            mesta = Communication.Instance.VratiListuSviMesto();
            ucKlijentiOpsteView.CmbMesto.DataSource = mesta;
            ucKlijentiOpsteView.CmbDodajMesto.DataSource = mesta;
        }

        private void InitDgvKlijenti(UCKlijentiOpste ucKlijentiOpsteView)
        {
            klijenti = new BindingList<Klijent>();
            List<Klijent> klijents = Communication.Instance.VratiListuSviKlijent();
            foreach (Klijent k in klijents)
            {
                klijenti.Add(k);
            }
            ucKlijentiOpsteView.DgvKlijenti.DataSource = klijenti;
        }

        private void InitDgvColumns(DataGridView dgvStavkeRacuna)
        {
            dgvStavkeRacuna.Columns["idKlijent"].Visible = false;
            dgvStavkeRacuna.Columns["idMesto"].Visible = false;
            dgvStavkeRacuna.Columns["NazivTabele"].Visible = false;
            dgvStavkeRacuna.Columns["InsertKolone"].Visible = false;
            dgvStavkeRacuna.Columns["InsertVrednosti"].Visible = false;
            dgvStavkeRacuna.Columns["UpdateVrednost"].Visible = false;
            dgvStavkeRacuna.Columns["PrimaryKey"].Visible = false;
            dgvStavkeRacuna.Columns["ForeignKey"].Visible = false;
            dgvStavkeRacuna.Columns["ForeignKey2"].Visible = false;
            dgvStavkeRacuna.Columns["Criteria"].Visible = false;
            dgvStavkeRacuna.Columns["Search"].Visible = false;
        }

        internal void UpisUKlijenta(UCKlijentiOpste ucKlijent, bool uslov)
        {
            ucKlijent.TbImePrezime.Enabled = uslov;
            ucKlijent.CmbMesto.Enabled = uslov;
            ucKlijent.BtnDodajKlijenta.Enabled = uslov;
            ucKlijent.BtnObrisiKlijenta.Enabled = uslov;
            ucKlijent.BtnPromeniKlijenta.Enabled = uslov;

            ucKlijent.BtnKrajUnosaKlijenta.Enabled = !uslov;
            ucKlijent.CmbDodajPol.Enabled = !uslov;
            ucKlijent.CmbDodajMesto.Enabled = !uslov;
            ucKlijent.CmbDodajTipKlijenta.Enabled = !uslov;
            ucKlijent.TbDodajImePrezime.Enabled = !uslov;
            ucKlijent.TbDodajKontakt.Enabled = !uslov;

        }

        internal void FiltrirajKlijentaIme(UCKlijentiOpste uCKlijentiOpste)
        {
            klijenti = new BindingList<Klijent>();
            string imeZaFiltriranje ;
            imeZaFiltriranje=uCKlijentiOpste.TbImePrezime.Text.ToString();
            List<Klijent> listaklijenata = Communication.Instance.VratiListuKlijent(imeZaFiltriranje);
            foreach (Klijent k in listaklijenata)
            {
                klijenti.Add(k);
            }
            uCKlijentiOpste.DgvKlijenti.DataSource = klijenti;
        }

        internal void FiltrirajKlijentaMesto(UCKlijentiOpste uCKlijentiOpste)
        {
            klijenti = new BindingList<Klijent>();
            Mesto mestoZafiltriranje = (Mesto)uCKlijentiOpste.CmbMesto.SelectedItem;
            List<Klijent> listaklijenta = Communication.Instance.VratiListuKlijent(mestoZafiltriranje);
            foreach (Klijent k in listaklijenta)
            {
                klijenti.Add(k);
            }
            uCKlijentiOpste.DgvKlijenti.DataSource = klijenti;
        }

        internal void DodajKlijentaEvent(UCKlijentiOpste uCKlijentiOpste)
        {
            UpisUKlijenta(uCKlijentiOpste, false);
        }

        internal void KrajDodajPromeniEvent(UCKlijentiOpste uCKlijentiOpste)
        {
            Mesto m = uCKlijentiOpste.CmbDodajMesto.SelectedItem as Mesto;
            Klijent novKlijent = new Klijent()
            {
                ImePrezime = uCKlijentiOpste.TbDodajImePrezime.Text,
                Kontakt = uCKlijentiOpste.TbDodajKontakt.Text,
                TipKlijenta = ((int)(TipKlijentaEnum)uCKlijentiOpste.CmbDodajTipKlijenta.SelectedItem).ToString(),
                Pol = uCKlijentiOpste.CmbDodajPol.SelectedItem.ToString(),
                IdMesto = m.IdMesto,
            };
            novKlijent = Communication.Instance.KreirajKlijent(novKlijent);
            klijenti.Add(novKlijent);
            UpisUKlijenta(uCKlijentiOpste, true);
        }

        internal void ObrisiKlijenta(UCKlijentiOpste uCKlijentiOpste)
        {
            if (uCKlijentiOpste.DgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete red za promenu.");
                return;
            }
            selektovaniKlijent = (Klijent)uCKlijentiOpste.DgvKlijenti.SelectedRows[0]?.DataBoundItem;

            Communication.Instance.ObrisiKlijent(selektovaniKlijent);
            InitDgvKlijenti(uCKlijentiOpste);
        }
    }
}
