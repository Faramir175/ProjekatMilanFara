using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Kvalifikacija : IEntity
    {
        public int IdKvalifikacija { get; set; }
        public string NazivKvalifikacije { get; set; }

        public string NazivTabele => "Kvalifikacija";

        public object InsertKolone => "nazivKvalifikacije";

        public string InsertVrednosti => $"'{NazivKvalifikacije}'";

        public string UpdateVrednost => $"nazivKvalifikacije='{NazivKvalifikacije}'";

        public object PrimaryKey => "idKvalifikacija";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public string Search => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> kvalifikacije = new List<IEntity>();
            while (reader.Read())
            {
                Kvalifikacija kvalifikacija = new Kvalifikacija();
                kvalifikacija.IdKvalifikacija = reader.GetInt32(0);
                kvalifikacija.NazivKvalifikacije = (string)reader["nazivKvalifikacije"];
                kvalifikacije.Add(kvalifikacija);
            }
            return kvalifikacije;
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
