using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent : IEntity
    {
        public int IdKlijent { get; set; }
        public int IdFrizer { get; set; }
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }
        public string TipKlijenta { get; set; }
        public string Pol { get; set; }
        public int IdMesto { get; set; }

        public string NazivTabele => throw new NotImplementedException();

        public object InsertKolone => throw new NotImplementedException();

        public string InsertVrednosti => throw new NotImplementedException();

        public string UpdateVrednost => throw new NotImplementedException();

        public object PrimaryKey => throw new NotImplementedException();

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public string Search => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
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
            return ImePrezime;
        }
    }
}
