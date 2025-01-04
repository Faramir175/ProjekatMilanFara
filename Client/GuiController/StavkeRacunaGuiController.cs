using Broker;
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
        private TestBroker broker;
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

        internal void FormaZaPromenu(FrmStavkeRacuna frmStavkeRacuna,Racun selektovaniRacun)
        {
            frmStavkeRacuna = new FrmStavkeRacuna();
            frmStavkeRacuna.AutoSize = true;
            InitUslugaCmb(frmStavkeRacuna);
            InitKlijentCmb(frmStavkeRacuna);
            InitCenaLbl(frmStavkeRacuna);
            UpisURacun(frmStavkeRacuna, false);
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
            broker = new TestBroker();
            broker.Open();
            klijenti = new List<Klijent>();
            using (SqlCommand command = broker.GetConnection().CreateCommand())
            {
                command.CommandText = "select * from Klijent";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Klijent klijent = new Klijent();
                        klijent.IdKlijent = reader.GetInt32(0);
                        klijent.ImePrezime = (string)reader["imePrezime"];
                        klijent.Kontakt = (string)reader["kontakt"];
                        klijent.TipKlijenta = (string)reader["tipKlijenta"];
                        klijent.Pol = (string)reader["pol"];
                        klijent.IdMesto = (int)reader["idMesto"];
                        klijenti.Add(klijent);
                    }
                }
            }
            broker.Close();
            frmStavkeRacuna.CmbKlijent.DataSource = klijenti;
        }
        private void InitUslugaCmb(FrmStavkeRacuna frmStavkeRacuna)
        {
            broker = new TestBroker();
            broker.Open();
            usluge = new List<Usluga>();
            using (SqlCommand command = broker.GetConnection().CreateCommand())
            {
                command.CommandText = "select * from Usluga";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usluga usluga = new Usluga();
                        usluga.IdUsluga = reader.GetInt32(0);
                        usluga.Naziv = (string)reader["naziv"];
                        usluga.Cena = (int)reader["cena"];
                        usluga.Trajanje = (int)reader["trajanje"];
                        usluge.Add(usluga);
                    }
                }
            }
            broker.Close();
            frmStavkeRacuna.CmbUsluga.DataSource = usluge;
        }
        private void InitStavkeRacunaDgv(FrmStavkeRacuna frmStavkeRacuna, Racun selektovaniRacun)
        {
            broker = new TestBroker();
            broker.Open();
            stavke = new BindingList<StavkaRacuna>();
            using (SqlCommand command = broker.GetConnection().CreateCommand())
            {
                command.CommandText = @"SELECT sr.idRacun,sr.rb, sr.iznos, sr.kolicina, sr.cena, u.naziv
                                        FROM StavkaRacuna sr
                                        INNER JOIN Usluga u ON sr.idUsluga = u.idUsluga";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StavkaRacuna stavka = new StavkaRacuna();
                        stavka.IdRacun = (int)reader["idRacun"];
                        stavka.Rb = (int)reader["rb"];
                        stavka.Iznos = (double)reader["iznos"];
                        stavka.Kolicina = (int)reader["kolicina"];
                        stavka.Cena = (int)reader["cena"];
                        stavka.NazivUsluga = (string)reader["naziv"];
                        if(selektovaniRacun.IdRacun == stavka.IdRacun)
                        stavke.Add(stavka);
                    }
                }
            }
            broker.Close();
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
            foreach (StavkaRacuna st in stavke)
            {
                uIznos += (double)st.Iznos;
            }
            switch (popust)
            {
                case 0:
                    break;

                case >0:
                    uIznos = uIznos * (1-(popust / 100));
                    break;

                case <0:
                    uIznos = uIznos * (1+(popust / 100));
                    break;

                default:
                    MessageBox.Show("Ne moze da se izracuna ukupan iznos.");
                    break;
            }
            frmStavkeRacuna.LblUkupanIznos.Text = uIznos.ToString();
        }

        internal void KrajUnosaEvent(FrmStavkeRacuna frmStavkeRacuna)
        {
            Klijent k = (Klijent)frmStavkeRacuna.CmbKlijent.SelectedItem;
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
            RacunGuiController.Instance.InitDgvRacun();
            frmStavkeRacuna.Close();
        }

        private Racun UpisRacunaUBazu(FrmStavkeRacuna frmStavkeRacuna, Racun racunZaBazu)
        {
            broker = new TestBroker();
            broker.Open();
            using (SqlCommand cmd = broker.GetConnection().CreateCommand())
            {
                cmd.CommandText = $"insert into Racun (datum,popust,ukupanIznos,idFrizer,idKlijent) values" +
                    $"(@datum, @popust, @ukupanIznos, @idFrizer, @idKlijent) select scope_identity()";
                cmd.Parameters.AddWithValue("@datum", racunZaBazu.Datum);
                cmd.Parameters.AddWithValue("@popust", racunZaBazu.Popust);
                cmd.Parameters.AddWithValue("@ukupanIznos", racunZaBazu.UkupanIznos);
                cmd.Parameters.AddWithValue("@idFrizer", racunZaBazu.IdFrizer);
                cmd.Parameters.AddWithValue("@idKlijent", racunZaBazu.IdKlijent);
                racunZaBazu.IdRacun = Convert.ToInt32((decimal)cmd.ExecuteScalar());
            }
            broker.Close();
            return racunZaBazu;
        }

        private void UpisStavkiRacunaUBazu(FrmStavkeRacuna frmStavkeRacuna, BindingList<StavkaRacuna> stavke)
        {
            broker = new TestBroker();
            broker.Open();
            using (SqlCommand cmd = broker.GetConnection().CreateCommand())
            {
                cmd.CommandText = $"insert into StavkaRacuna (idRacun,iznos,kolicina,cena,idUsluga) values" +
                  $"(@idRacun, @iznos, @kolicina, @cena, @idUsluga)";
                foreach (StavkaRacuna s in stavke)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idRacun", s.IdRacun);
                    cmd.Parameters.AddWithValue("@iznos", s.Iznos);
                    cmd.Parameters.AddWithValue("@kolicina", s.Kolicina);
                    cmd.Parameters.AddWithValue("@cena", s.Cena);
                    cmd.Parameters.AddWithValue("@idUsluga", s.IdUsluga);
                    cmd.ExecuteNonQuery(); 
                }

            }
            broker.Close();
        }
    }
}
