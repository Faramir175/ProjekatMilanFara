using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Racun : IEntity
    {
        public int IdRacun { get; set; }
        public DateTime Datum { get; set; }
        public int Popust { get; set; }
        public double UkupanIznos { get; set; }
        public int IdFrizer { get; set; }
        public int IdKlijent { get; set; }
        public string KlijentImePrezime { get; set; }

        public string NazivTabele => "Racun";

        public object InsertKolone => "datum,popust,ukupanIznos,idFrizer,idKlijent";

        public string InsertVrednosti => $"'{Datum}','{Popust}','{UkupanIznos}','{IdFrizer}','{IdKlijent}'";

        public string UpdateVrednost => $"datum='{Datum}',popust= '{Popust}',ukupanIznos='{UkupanIznos}',idFrizer='{IdFrizer}',idKlijent'{IdKlijent}'";

        public object PrimaryKey => "idRacun";

        public object ForeignKey => "idKlijent";

        public object ForeignKey2 => "idFrizer";

        public string Criteria => "";

        public string Search => "";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> racuni = new List<IEntity>();
            while (reader.Read())
            {
                Racun racun = new Racun();
                racun.IdRacun = reader.GetInt32(0);
                racun.Datum = (DateTime)reader["datum"];
                racun.Popust = (int)reader["popust"];
                racun.UkupanIznos = (double)reader["ukupanIznos"];
                racun.IdFrizer = (int)reader["idFrizer"];
                racun.IdKlijent = (int)reader["idKlijent"];
                racuni.Add(racun);
            }
            return racuni;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetJoinEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetJoinEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
