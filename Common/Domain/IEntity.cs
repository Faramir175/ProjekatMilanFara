using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string NazivTabele { get; }
        object InsertKolone { get; }
        string InsertVrednosti { get; }
        string UpdateVrednost { get; }
        object PrimaryKey { get; }
        object ForeignKey { get; }
        object ForeignKey2 { get; }
        string Criteria { get; }
        string Search { get; }
        List<IEntity> GetEntities(SqlDataReader reader);
        List<IEntity> GetJoinEntities(SqlDataReader reader);
        IEntity GetEntity(SqlDataReader reader);
        IEntity GetJoinEntity(SqlDataReader reader);
    }
}
