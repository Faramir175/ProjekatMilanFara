using Broker;
using Client.ServerCommunication;
using Common.Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    internal class StavkeRacunaGuiController
    {
        private static StavkeRacunaGuiController instance;
        private List<Klijent> klijenti;
        private List<Usluga> usluge;
        private BindingList<StavkaRacuna> stavke;
        public static StavkeRacunaGuiController Instance {
            get 
            { 
                if (instance == null) instance = new StavkeRacunaGuiController();
                return instance; 
            } 
        }
        private bool pr=false;
        private Racun racunZaPromenu;

        internal void FormaZaUnos(FrmStavkeRacuna frmStavkeRacuna)
        {
            frmStavkeRacuna = new FrmStavkeRacuna();
            stavke = new BindingList<StavkaRacuna>();
            frmStavkeRacuna.DgvStavkeRacuna.DataSource = stavke;
            InitDgvColumns(frmStavkeRacuna.DgvStavkeRacuna);
            frmStavkeRacuna.AutoSize = true;
            InitUslugaCmb(frmStavkeRacuna);
            InitKlijentCmb(frmStavkeRacuna);
            InitCenaLbl(frmStavkeRacuna);
            UpisURacun(frmStavkeRacuna, false);
            frmStavkeRacuna.ShowDialog();
        }

        internal void FormaZaPromenu(FrmStavkeRacuna frmStavkeRacuna,Racun selektovaniRacun, bool promena)
        {
            frmStavkeRacuna = new FrmStavkeRacuna();
            pr = promena;
            racunZaPromenu = selektovaniRacun;
            frmStavkeRacuna.AutoSize = true;
            InitUslugaCmb(frmStavkeRacuna);
            InitKlijentCmb(frmStavkeRacuna);
            InitCenaLbl(frmStavkeRacuna);
            UpisURacun(frmStavkeRacuna, true);
            InitStavkeRacunaDgv(frmStavkeRacuna,selektovaniRacun);
            frmStavkeRacuna.ShowDialog();
        }

        internal void InitCenaLbl(FrmStavkeRacuna frmStavkeRacuna)
        {
            Usluga usluga = (Usluga)frmStavkeRacuna.CmbUsluga.SelectedItem;
            frmStavkeRacuna.LblCena.Text = usluga.Cena.ToString();
        }
        internal void InitIznosLbl(FrmStavkeRacuna frmStavkeRacuna)
        {
            Usluga usluga = (Usluga)frmStavkeRacuna.CmbUsluga.SelectedItem;
            frmStavkeRacuna.LblIznos.Text = (usluga.Cena * int.Parse(frmStavkeRacuna.TbKolicina.Text)).ToString();
        }
        private void InitKlijentCmb(FrmStavkeRacuna frmStavkeRacuna)
        {
            klijenti = Communication.Instance.VratiListuSviKlijent();
            frmStavkeRacuna.CmbKlijent.DataSource = klijenti;
        }
        private void InitUslugaCmb(FrmStavkeRacuna frmStavkeRacuna)
        {
            usluge = Communication.Instance.VratiListuSviUsluga();
            frmStavkeRacuna.CmbUsluga.DataSource = usluge;
        }
        private void InitStavkeRacunaDgv(FrmStavkeRacuna frmStavkeRacuna, Racun selektovaniRacun)
        {
            List<StavkaRacuna> listaStavki = Communication.Instance.VratiStavkeRacuna();
            stavke = new BindingList<StavkaRacuna>();
            foreach (StavkaRacuna s in listaStavki)
            {
                if (s.IdRacun == selektovaniRacun.IdRacun)
                {
                    foreach (Usluga u in usluge)
                    {
                        if (u.IdUsluga == s.IdUsluga)
                        {
                            s.NazivUsluga = u.Naziv;
                        }
                    }
                    stavke.Add(s);
                }
            }

            frmStavkeRacuna.DgvStavkeRacuna.DataSource = stavke;
            InitDgvColumns(frmStavkeRacuna.DgvStavkeRacuna);
        }
        internal void UpisURacun(FrmStavkeRacuna frmStavkeRacuna, bool uslov)
        {
            frmStavkeRacuna.DtpDatum.Enabled = uslov;
            frmStavkeRacuna.LblDatum.Enabled = uslov;
            frmStavkeRacuna.LblPopust.Enabled = uslov;
            frmStavkeRacuna.LblUkupanIznos.Enabled = uslov;
            frmStavkeRacuna.CmbKlijent.Enabled = uslov;
            frmStavkeRacuna.BtnKrajUnosa.Enabled = uslov;

            frmStavkeRacuna.BtnDodaj.Enabled = !uslov;
            frmStavkeRacuna.BtnKrajUnosaStavki.Enabled = !uslov;
            frmStavkeRacuna.LblNaslov.Enabled = !uslov;
            frmStavkeRacuna.LblCena.Enabled = !uslov;
            frmStavkeRacuna.BtnIzbaci.Enabled = !uslov;
            frmStavkeRacuna.TbKolicina.Enabled = !uslov; 
            frmStavkeRacuna.CmbUsluga.Enabled = !uslov;

        }
        private void InitDgvColumns(DataGridView dgvStavkeRacuna)
        {
            dgvStavkeRacuna.Columns["idRacun"].Visible = false;
            dgvStavkeRacuna.Columns["idUsluga"].Visible = false;
            dgvStavkeRacuna.Columns["rb"].Visible = false;
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
        internal void DodajStavku(FrmStavkeRacuna frmStavkeRacuna)
        {
            Usluga u = (Usluga)frmStavkeRacuna.CmbUsluga.SelectedItem;
            StavkaRacuna novaStavka = new StavkaRacuna
            {
                Kolicina = int.Parse(frmStavkeRacuna.TbKolicina.Text),
                Cena = int.Parse(frmStavkeRacuna.LblCena.Text),
                Iznos = (double)int.Parse(frmStavkeRacuna.TbKolicina.Text) * int.Parse(frmStavkeRacuna.LblCena.Text),
                IdUsluga = u.IdUsluga,
                NazivUsluga = u.Naziv
            };
            
            stavke.Add(novaStavka);
        }

        internal void IzbaciStavku(FrmStavkeRacuna frmStavkeRacuna)
        {
            var selektovanaStavka = (StavkaRacuna)frmStavkeRacuna.DgvStavkeRacuna.SelectedRows[0].DataBoundItem;
            stavke.Remove(selektovanaStavka);
        }

        internal void InitPopustLbl(FrmStavkeRacuna frmStavkeRacuna)
        {
            Klijent k = frmStavkeRacuna.CmbKlijent.SelectedItem as Klijent;
            switch (int.Parse(k.TipKlijenta))
            {
                case (int)TipKlijentaEnum.StalniKlijent:
                    frmStavkeRacuna.LblPopust.Text = "17.5";
                    break;

                case (int)TipKlijentaEnum.NovKlijent:
                    frmStavkeRacuna.LblPopust.Text = "0";
                    break;

                case (int)TipKlijentaEnum.KlijentPreletac:
                    frmStavkeRacuna.LblPopust.Text = "-17.5";
                    break;

                default:
                    MessageBox.Show("Nepoznat tip klijenta.");
                    break;
            }
        }

        internal void InitUkupanIznosLbl(FrmStavkeRacuna frmStavkeRacuna)
        {
            double popust = double.Parse(frmStavkeRacuna.LblPopust.Text);
            double uIznos = 0;
            if (stavke != null)
            {foreach (StavkaRacuna st in stavke)
            {
                uIznos += (double)st.Iznos;
            }
                switch (popust)
                {
                    case 0:
                        break;

                    case > 0:
                        uIznos = uIznos * (1 - (popust / 100));
                        break;

                    case < 0:
                        uIznos = uIznos * (1 + (popust / 100));
                        break;

                    default:
                        MessageBox.Show("Ne moze da se izracuna ukupan iznos.");
                        break;
                }
            }
            frmStavkeRacuna.LblUkupanIznos.Text = uIznos.ToString();
        }

        internal void KrajUnosaEvent(FrmStavkeRacuna frmStavkeRacuna)
        {
            Klijent k = (Klijent)frmStavkeRacuna.CmbKlijent.SelectedItem;
            if (!pr) {
            Racun racunZaBazu = new Racun();

            racunZaBazu.Datum = frmStavkeRacuna.DtpDatum.Value;
            racunZaBazu.Popust = (int)double.Parse(frmStavkeRacuna.LblPopust.Text);
            racunZaBazu.UkupanIznos = double.Parse(frmStavkeRacuna.LblUkupanIznos.Text);
            racunZaBazu.IdKlijent = k.IdKlijent;
            racunZaBazu.IdFrizer = MainGuiController.Instance.logedUser.IdFrizer;
            racunZaBazu = UpisRacunaUBazu(frmStavkeRacuna, racunZaBazu);
            foreach (StavkaRacuna s in stavke)
            {
                s.IdRacun = racunZaBazu.IdRacun;
            }
            UpisStavkiRacunaUBazu(frmStavkeRacuna,stavke);
            }
            else
            {
            racunZaPromenu.Datum = frmStavkeRacuna.DtpDatum.Value;
            racunZaPromenu.Popust = (int)double.Parse(frmStavkeRacuna.LblPopust.Text);
            racunZaPromenu.UkupanIznos = double.Parse(frmStavkeRacuna.LblUkupanIznos.Text);
            racunZaPromenu.IdKlijent = k.IdKlijent;
            racunZaPromenu.IdFrizer = MainGuiController.Instance.logedUser.IdFrizer;
            PromenaRacuna(racunZaPromenu);
            }
            RacunGuiController.Instance.InitDgvRacun();
            frmStavkeRacuna.Close();
        }

        private Racun UpisRacunaUBazu(FrmStavkeRacuna frmStavkeRacuna, Racun racunZaBazu)
        {
            return Communication.Instance.KreirajRacun(racunZaBazu);
        }

        private void UpisStavkiRacunaUBazu(FrmStavkeRacuna frmStavkeRacuna, BindingList<StavkaRacuna> stavke)
        {
            foreach (StavkaRacuna stavka in stavke)
            {
                Communication.Instance.KreirajStavke(stavka); 
            }
        }

        private void PromenaRacuna( Racun selektovaniRacun)
        {
            Communication.Instance.PromeniRacun(selektovaniRacun);
        }
    }
}
