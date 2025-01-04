﻿using Broker;
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
        private TestBroker broker;
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
            MessageBox.Show(racuni[0].KlijentImePrezime);

            return ucRacunView;
        }

        private void InitDgvRacun()
        {
            broker = new TestBroker();
            broker.Open();
            racuni = new BindingList<Racun>();
            using (SqlCommand command = broker.GetConnection().CreateCommand())
            {
                command.CommandText = @"SELECT r.IdRacun, r.datum, r.popust, r.ukupanIznos, r.idFrizer, r.idKlijent, k.imePrezime
                                        FROM Racun r
                                        INNER JOIN Klijent k ON r.idKlijent = k.IdKlijent";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Racun racun = new Racun();
                        racun.IdRacun = reader.GetInt32(0);
                        racun.Datum = (DateTime)reader["datum"];
                        racun.Popust = (int)reader["popust"];
                        racun.UkupanIznos = (double)reader["ukupanIznos"];
                        racun.IdFrizer = (int)reader["idFrizer"];
                        racun.IdKlijent = (int)reader["idKlijent"];
                        racun.KlijentImePrezime = (string)reader["imePrezime"];
                        racuni.Add(racun);
                    }
                }
            }
            broker.Close();
            ucRacunView.DgvRacuni.DataSource = racuni;
            InitDgvColumns(ucRacunView.DgvRacuni);

        }

        private void InitCmbKlijent()
        {
            broker = new TestBroker();
            broker.Open();
            klijenti = new BindingList<Klijent>();
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
            ucRacunView.CmbKlijent.DataSource = klijenti;

        }

        private void InitDgvColumns(DataGridView dgv)
        {
            dgv.Columns["IdFrizer"].Visible = false;
            dgv.Columns["IdKlijent"].Visible = false;
            dgv.Columns["IdRacun"].Visible = false;
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
