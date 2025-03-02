using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class StavkaRacuna : IEntity
    {
        public int IdRacun { get; set; }
        public int Rb { get; set; }
        public double Iznos { get; set; }
        public int Kolicina { get; set; }
        public int Cena { get; set; }
        public int IdUsluga { get; set; }
        public string NazivUsluga { get; set; }
        public Racun Racun { get; set; }

        public string NazivTabele => "StavkaRacuna";

        public object InsertKolone => "idRacun,iznos,kolicina,cena,idUsluga";

        public string InsertVrednosti => $"'{IdRacun}','{Iznos}','{Kolicina}','{Cena}','{IdUsluga}'";

        public string UpdateVrednost => $"idRacun='{IdRacun}',iznos= '{Iznos}',kolicina='{Kolicina}',cena='{Cena}',idUsluga'{IdUsluga}'";

        public object PrimaryKey => "rb";

        public object ForeignKey => "idRacun";

        public object ForeignKey2 => "idUsluga";

        public string Criteria => "";

        public string Search => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> stavke = new List<IEntity>();
            while (reader.Read())
            {
                StavkaRacuna stavka = new StavkaRacuna();
                stavka.IdRacun = (int)reader["idRacun"];
                stavka.Rb = (int)reader["rb"];
                stavka.Iznos = (double)reader["iznos"];
                stavka.Kolicina = (int)reader["kolicina"];
                stavka.Cena = (int)reader["cena"];
                stavka.IdUsluga = (int)reader["idUsluga"];
                stavke.Add(stavka);
            }
            return stavke;
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
