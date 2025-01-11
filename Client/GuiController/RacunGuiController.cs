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
            foreach (Racun r in listaRacuna)
            {
                foreach(Klijent klijent in klijenti)
                {
                    if (klijent.IdKlijent == r.IdKlijent)
                    {
                        r.KlijentImePrezime = klijent.ImePrezime;
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

        internal void FiltrirajRacune(UCRacunOpsta uCRacunOpsta)
        {

            if (racuni != null) 
            {
            BindingList<Racun> filtriraniRacun = new BindingList<Racun>();
            Klijent klijentZaFiltriranje = (Klijent)uCRacunOpsta.CmbKlijent.SelectedItem;
                foreach (Racun r in racuni)
                {
                    if (r.IdKlijent == klijentZaFiltriranje.IdKlijent)
                    {
                        filtriraniRacun.Add(r);
                    }
                }
            ucRacunView.DgvRacuni.DataSource = filtriraniRacun;
            }

        }
    }
}
