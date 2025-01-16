using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Mesto:IEntity
    {
        public int IdMesto { get; set; }
        public string Naziv { get; set; }

        public string NazivTabele => "Mesto";

        public object InsertKolone => "naziv";

        public string InsertVrednosti => $"'{Naziv}'";

        public string UpdateVrednost => $"naziv='{Naziv}'";

        public object PrimaryKey => "idMesto";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public string Search => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> mesta = new List<IEntity>();
            while (reader.Read())
            {
                Mesto mesto = new Mesto();
                mesto.IdMesto = reader.GetInt32(0);
                mesto.Naziv = (string)reader["naziv"];
                mesta.Add(mesto);
            }
            return mesta;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            IEntity mesta = new Mesto();
            while (reader.Read())
            {
                Mesto mesto = new Mesto();
                mesto.IdMesto = reader.GetInt32(0);
                mesto.Naziv = (string)reader["naziv"];
                mesta = mesto;
            }
            return mesta;
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
