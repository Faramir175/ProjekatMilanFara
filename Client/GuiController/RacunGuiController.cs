﻿using Broker;
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
        private BindingList<Usluga> usluge;
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
            InitCmbUsluga();

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

        private void InitCmbUsluga()
        {
            usluge = new BindingList<Usluga>();
            List<Usluga> usluges = Communication.Instance.VratiListuSviUsluga();
            foreach (Usluga u in usluges)
            {
                usluge.Add(u);
            }
            ucRacunView.CmbUsluga.DataSource = usluge;
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
            Frizer frizerZaFiltriranje = (Frizer)uCRacunOpsta.CmbFrizer.SelectedItem;
            List<Racun> listaRacuna = Communication.Instance.VratiListuRacun(klijentZaFiltriranje);
            InitCmbKlijent();
            InitCmbFrizer();
            ucRacunView.CmbFrizer.SelectedItem = frizeri.FirstOrDefault(k => k.IdFrizer == frizerZaFiltriranje?.IdFrizer);
            ucRacunView.CmbKlijent.SelectedItem = klijenti.FirstOrDefault(k => k.IdKlijent == klijentZaFiltriranje?.IdKlijent);
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
            Klijent klijentZaFiltriranje = (Klijent)uCRacunOpsta.CmbKlijent.SelectedItem;
            List<Racun> listaRacuna = Communication.Instance.VratiListuRacun(frizerZaFiltriranje);
            InitCmbFrizer();
            InitCmbKlijent();
            ucRacunView.CmbKlijent.SelectedItem = klijenti.FirstOrDefault(k => k.IdKlijent == klijentZaFiltriranje?.IdKlijent);
            ucRacunView.CmbFrizer.SelectedItem = frizeri.FirstOrDefault(k => k.IdFrizer == frizerZaFiltriranje?.IdFrizer);
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

        internal void FiltrirajUsluga(UCRacunOpsta uCRacunOpsta)
        {
            racuni = new BindingList<Racun>();
            Usluga uslugazafiltriranje = (Usluga)uCRacunOpsta.CmbUsluga.SelectedItem;
            Frizer frizerZaFiltriranje = (Frizer)uCRacunOpsta.CmbFrizer.SelectedItem;
            Klijent klijentZaFiltriranje = (Klijent)uCRacunOpsta.CmbKlijent.SelectedItem;
            List<Racun> listaracuna = Communication.Instance.VratiListuRacun(uslugazafiltriranje);
            InitCmbFrizer();
            InitCmbKlijent();
            ucRacunView.CmbKlijent.SelectedItem = klijenti.FirstOrDefault(k => k.IdKlijent == klijentZaFiltriranje?.IdKlijent);
            ucRacunView.CmbFrizer.SelectedItem = frizeri.FirstOrDefault(k => k.IdFrizer == frizerZaFiltriranje?.IdFrizer);
            foreach (Racun r in listaracuna)
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

        internal void FiltrirajCenaRacun(UCRacunOpsta uCRacunOpsta)
        {
            racuni = new BindingList<Racun>();
            double cenaZaFiltriranje;
            double.TryParse(uCRacunOpsta.TbCenaRacuna.Text, out cenaZaFiltriranje);
            List<Racun> listaracuna = Communication.Instance.VratiListuRacun(cenaZaFiltriranje);
            InitCmbKlijent();
            InitCmbFrizer();
            foreach (Racun r in listaracuna)
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
            ucRacunView.TbCenaRacuna.Text = cenaZaFiltriranje.ToString();
        }
    }
}
