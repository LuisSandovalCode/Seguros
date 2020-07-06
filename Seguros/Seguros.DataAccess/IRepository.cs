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

        List<Entity> ExecuteQuery<Entity>(string StoreProcedure, DynamicParameters prm);

        bool ExecuteNonQuery(string StoreProcedure, DynamicParameters prm);
    }
}
