using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Frizer : IEntity
    {
        public int IdFrizer { get; set; }
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public string NazivTabele => "Frizer";

        public object InsertKolone => "imePrezime,korisnickoIme,kontakt,sifra";

        public string InsertVrednosti => $"'{ImePrezime}','{Kontakt}','{KorisnickoIme}','{Sifra}'";

        public string UpdateVrednost => $"imePrezime='{ImePrezime}',kontakt= '{Kontakt}',korisnickoIme='{KorisnickoIme}',sifra='{Sifra}'";

        public object PrimaryKey => "idFrizer";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => $"korisnickoIme = '{KorisnickoIme}' and sifra = '{Sifra}'";

        public string Search => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> users = new List<IEntity>();
            while (reader.Read())
            {
                Frizer user = new Frizer();
                user.IdFrizer = reader.GetInt32(0);
                user.ImePrezime = (string)reader["imePrezime"];
                user.Kontakt = (string)reader["kontakt"];
                user.KorisnickoIme = (string)reader["korisnickoIme"];
                user.Sifra = (string)reader["sifra"];
                users.Add(user);
            }
            return users;
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
