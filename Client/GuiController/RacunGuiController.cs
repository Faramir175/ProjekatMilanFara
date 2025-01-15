using Broker;
using Client.ServerCommunication;
using Client.UserControls;
using Common.Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Client.GuiController
{
    public class RacunGuiController
    {
        private static UCRacunOpsta ucRacunView;
        private static BindingList<Racun> racuni;
        private BindingList<Klijent> klijenti;
        private BindingList<Frizer> frizeri;
        private static RacunGuiController instance;
        public static RacunGuiController Instance
        {
            get
            {
                if (instance == null) instance = new RacunGuiController();
                return instance;
            }
        }

        public UserControl CreateUCRacun()
        {
            ucRacunView = new UCRacunOpsta();
            InitCmbKlijent();
            InitDgvRacun();

            return ucRacunView;
        }

        internal void InitDgvRacun()
        {
            List<Racun> listaRacuna = Communication.Instance.VratiListuSviRacun();
            racuni = new BindingList<Racun>();
            InitCmbKlijent();
            InitCmbFrizer();
            foreach (Racun r in listaRacuna)
            {
                foreach(Klijent klijent in klijenti)
                {
                    if (klijent.IdKlijent == r.IdKlijent)
                    {
                        r.KlijentImePrezime = klijent.ImePrezime;
                    }
                }
                foreach (Frizer f in frizeri)
                {
                    if (f.IdFrizer == r.IdFrizer)
                    {
                        r.FrizerImePrezime = f.ImePrezime;
                    }
                }
                racuni.Add(r);
            }
            ucRacunView.DgvRacuni.DataSource = racuni;
            InitDgvColumns(ucRacunView.DgvRacuni);
        }

        private void InitCmbKlijent()
        {
            List<Klijent> frizeri = Communication.Instance.VratiListuSviKlijent();
            klijenti = new BindingList<Klijent>();
            foreach (Klijent f in frizeri)
            {
                klijenti.Add(f);
            }
            ucRacunView.CmbKlijent.DataSource = klijenti;
        }

        private void InitCmbFrizer()
        {
            List<Frizer> frizers = Communication.Instance.VratiListuSviFrizer();
            frizeri = new BindingList<Frizer>();
            foreach (Frizer f in frizers)
            {
                frizeri.Add(f);
            }
            ucRacunView.CmbFrizer.DataSource = frizeri;
        }

        private void InitDgvColumns(DataGridView dgv)
        {
            dgv.Columns["IdFrizer"].Visible = false;
            dgv.Columns["IdKlijent"].Visible = false;
            dgv.Columns["IdRacun"].Visible = false;
            dgv.Columns["NazivTabele"].Visible = false;
            dgv.Columns["InsertKolone"].Visible = false;
            dgv.Columns["InsertVrednosti"].Visible = false;
            dgv.Columns["UpdateVrednost"].Visible = false;
            dgv.Columns["PrimaryKey"].Visible = false;
            dgv.Columns["ForeignKey"].Visible = false;
            dgv.Columns["ForeignKey2"].Visible = false;
            dgv.Columns["Criteria"].Visible = false;
            dgv.Columns["Search"].Visible = false;
        }

        internal void FiltrirajKlijent(UCRacunOpsta uCRacunOpsta)
        {
            racuni = new BindingList<Racun>();
            Klijent klijentZaFiltriranje = (Klijent)uCRacunOpsta.CmbKlijent.SelectedItem;
            List<Racun> listaRacuna = Communication.Instance.VratiListuRacun(klijentZaFiltriranje);
            InitCmbKlijent();
            InitCmbFrizer();
            foreach (Racun r in listaRacuna)
            {
                foreach (Klijent klijent in klijenti)
                {
                    if (klijent.IdKlijent == r.IdKlijent)
                    {
                        r.KlijentImePrezime = klijent.ImePrezime;
                    }
                }
                foreach (Frizer f in frizeri)
                {
                    if (f.IdFrizer == r.IdFrizer)
                    {
                        r.FrizerImePrezime = f.ImePrezime;
                    }
                }
                racuni.Add(r);
            }
            ucRacunView.DgvRacuni.DataSource = racuni;

        }

        internal void FiltrirajFrizer(UCRacunOpsta uCRacunOpsta)
        {
            racuni = new BindingList<Racun>();
            Frizer frizerZaFiltriranje = (Frizer)uCRacunOpsta.CmbFrizer.SelectedItem;
            List<Racun> listaRacuna = Communication.Instance.VratiListuRacun(frizerZaFiltriranje);
            InitCmbFrizer();
            InitCmbKlijent();
            foreach (Racun r in listaRacuna)
            {
                foreach (Klijent klijent in klijenti)
                {
                    if (klijent.IdKlijent == r.IdKlijent)
                    {
                        r.KlijentImePrezime = klijent.ImePrezime;
                    }
                }
                foreach (Frizer f in frizeri)
                {
                    if (f.IdFrizer == r.IdFrizer)
                    {
                        r.FrizerImePrezime = f.ImePrezime;
                    }
                }
                racuni.Add(r);
            }
            ucRacunView.DgvRacuni.DataSource = racuni;
        }
    }
}
