using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Usluga : IEntity
    {
        public int IdUsluga { get; set; }
        public string Naziv { get; set; }
        public int Cena { get; set; }
        public int Trajanje { get; set; }
        public string NazivTabele => "Usluga";

        public object InsertKolone => "naziv,cena,trajanje";

        public string InsertVrednosti => $"'{Naziv}','{Cena}','{Trajanje}'";

        public string UpdateVrednost => $"naziv='{Naziv}',cena= '{Cena}',trajanje='{Trajanje}'";

        public object PrimaryKey => "idUsluga";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public string Search => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> usluge = new List<IEntity>();
            while (reader.Read())
            {
                Usluga usluga = new Usluga();
                usluga.IdUsluga = reader.GetInt32(0);
                usluga.Naziv = (string)reader["naziv"];
                usluga.Cena = (int)reader["cena"];
                usluga.Trajanje = (int)reader["trajanje"];
                usluge.Add(usluga);
            }
            return usluge;
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

        public override string? ToString()
        {
            return Naziv;
        }
    }
}
