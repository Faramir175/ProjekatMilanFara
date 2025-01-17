﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Klijent : IEntity
    {
        public int IdKlijent { get; set; }
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }
        public string TipKlijenta { get; set; }
        public string Pol { get; set; }
        public int IdMesto { get; set; }

        public string NazivTabele => "Klijent";

        public object InsertKolone => "imePrezime,kontakt,tipKlijenta,pol,idMesto";

        public string InsertVrednosti => $"'{ImePrezime}','{Kontakt}','{TipKlijenta}','{Pol}','{IdMesto}'";

        public string UpdateVrednost => $"imePrezime='{ImePrezime}',kontakt= '{Kontakt}',tipKlijenta='{TipKlijenta}',pol='{Pol}',idMesto='{IdMesto}'";

        public object PrimaryKey => "idKlijent";

        public object ForeignKey => "idMesto";

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public string Search => "imePrezime";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> klijenti = new List<IEntity>();
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
            return klijenti;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            IEntity klijent = new Klijent();
            while (reader.Read())
            {
                Klijent k = new Klijent();
                k.IdKlijent = reader.GetInt32(0);
                k.ImePrezime = (string)reader["imePrezime"];
                k.Kontakt = (string)reader["kontakt"];
                k.TipKlijenta = (string)reader["tipKlijenta"];
                k.Pol = (string)reader["pol"];
                k.IdMesto = (int)reader["idMesto"];
                klijent = k;
            }
            return klijent;
        }

        public List<IEntity> GetJoinEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetJoinEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return ImePrezime;
        }
    }
}
