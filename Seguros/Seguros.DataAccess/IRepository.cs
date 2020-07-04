using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DataAccess
{
    public interface IRepository
    {
        SqlConnection Context { get; set; }

        bool InsertEntity(string StoreProcedure,DynamicParameters prm);
        bool DeleteEntity(string StoreProcedure, DynamicParameters prm);
        bool UpdateEntity(string StoreProcedure, DynamicParameters prm);
        List<Entity> GetEntities<Entity>(string StoreProcedure, DynamicParameters prm);

    }
}
