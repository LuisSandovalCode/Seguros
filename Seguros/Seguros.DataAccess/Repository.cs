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
        public Repository()
        {
            Context = new SqlConnection(ConfigurationManager.ConnectionStrings["STR_CON"].ToString());
        }

        public bool InsertEntity(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Execute(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public bool DeleteEntity(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Execute(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public bool UpdateEntity(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Execute(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public List<Entity> GetEntities<Entity>(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Query<Entity>(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public Entity ExecuteQuery<Entity>(string StoreProcedure, DynamicParameters prm)
        {
            using (IDbConnection db = Context)
            {
                db.Open();
                return db.Query<Entity>(sql: StoreProcedure, param: prm, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
