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
            //ucKlijent.TbImePrezime.Enabled = uslov;
            //ucKlijent.CmbMesto.Enabled = uslov;
            ucKlijent.BtnDodajKlijenta.Enabled = uslov;
            //ucKlijent.BtnObrisiKlijenta.Enabled = uslov;
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
            if(listaklijenata.Count > 0)
            {
                MessageBox.Show("Систем је нашао клијенте по задатим критеријумима");
            }
            else
            {
                MessageBox.Show("Систем не може да нађе клијенте по задатим критеријумима");
            }
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

        internal void DodajKlijentaEvent(UCKlijentiOpste uCKlijentiOpste,bool promena)
        {
            UpisUKlijenta(uCKlijentiOpste, false);
        }

        internal void KrajDodajPromeniEvent(UCKlijentiOpste uCKlijentiOpste,Klijent selektovaniKlijent, bool promena)
        {
 
            Mesto m = uCKlijentiOpste.CmbDodajMesto.SelectedItem as Mesto;
            if (!promena)
            {           
                Klijent novKlijent = new Klijent()
                {
                    ImePrezime = uCKlijentiOpste.TbDodajImePrezime.Text,
                    Kontakt = uCKlijentiOpste.TbDodajKontakt.Text,
                    TipKlijenta = ((int)(TipKlijentaEnum)uCKlijentiOpste.CmbDodajTipKlijenta.SelectedItem).ToString(),
                    Pol = uCKlijentiOpste.CmbDodajPol.SelectedItem.ToString(),
                    IdMesto = m.IdMesto,
                };
                novKlijent = Communication.Instance.KreirajKlijent(novKlijent);
                InitDgvKlijenti(uCKlijentiOpste);
                UpisUKlijenta(uCKlijentiOpste, true);
            }
            else if(selektovaniKlijent!=null)
            {
                selektovaniKlijent.ImePrezime = uCKlijentiOpste.TbDodajImePrezime.Text;
                selektovaniKlijent.Kontakt = uCKlijentiOpste.TbDodajKontakt.Text;
                selektovaniKlijent.TipKlijenta = ((int)(TipKlijentaEnum)uCKlijentiOpste.CmbDodajTipKlijenta.SelectedItem).ToString();
                selektovaniKlijent.Pol = uCKlijentiOpste.CmbDodajPol.SelectedItem.ToString();
                selektovaniKlijent.IdMesto = m.IdMesto;
                Communication.Instance.PromeniKlijent(selektovaniKlijent);
                InitDgvKlijenti(uCKlijentiOpste);
                UpisUKlijenta(uCKlijentiOpste, true);
            }
        }

        internal void ObrisiKlijenta(UCKlijentiOpste uCKlijentiOpste,Klijent selektovaniKlijent)
        {

            Communication.Instance.ObrisiKlijent(selektovaniKlijent);
            InitDgvKlijenti(uCKlijentiOpste);
        }

        internal void PretraziKlijenta(UCKlijentiOpste uCKlijentiOpste, Klijent? selektovaniKlijent)
        {
            Klijent provera = Communication.Instance.PretraziKlijent(selektovaniKlijent);
            if (provera != null)
            {
                MessageBox.Show("Систем је нашао клијента");
            }
            else
            {
                MessageBox.Show("Систем не може да нађе клијента");
            }
        }

        internal void PromenaKlijentaEvent(UCKlijentiOpste uCKlijentiOpste,Klijent selektovaniKlijent, bool promena)
        {
            UpisUKlijenta(uCKlijentiOpste, false);

            Klijent proveren = Communication.Instance.PretraziKlijent(selektovaniKlijent);
            if(proveren != null) {
                Mesto m = Communication.Instance.VratiJednoMesto(selektovaniKlijent.IdMesto);
                uCKlijentiOpste.LblDodajPromeniKlijenta.Text = "Promeni klijenta";
                uCKlijentiOpste.CmbDodajMesto.ValueMember = "Naziv";

                uCKlijentiOpste.TbDodajImePrezime.Text = selektovaniKlijent.ImePrezime;
                uCKlijentiOpste.TbDodajKontakt.Text = selektovaniKlijent.Kontakt;
                uCKlijentiOpste.CmbDodajMesto.SelectedValue = m.Naziv;
                uCKlijentiOpste.CmbDodajPol.SelectedItem = selektovaniKlijent.Pol;
                if (Enum.TryParse(typeof(TipKlijentaEnum), selektovaniKlijent.TipKlijenta, out var tipKlijentaEnum))
                {
                    uCKlijentiOpste.CmbDodajTipKlijenta.SelectedItem = tipKlijentaEnum;
                }
            }
        }
    }
}
