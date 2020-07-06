using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DataAccess
{
    public class Repository : IRepository
    {
        public SqlConnection Context { get; set; }
        public Repository(SqlConnection sqlConnection)
        {
            Context = sqlConnection; 
        }

        public List<Entity> ExecuteQuery<Entity>(string StoreProcedure, DynamicParameters prm = null)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Query<Entity>(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public bool ExecuteNonQuery(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Execute(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure) > 0;
            }
        }
    }
}
