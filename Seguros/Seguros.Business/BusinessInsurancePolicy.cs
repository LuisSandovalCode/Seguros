using Dapper;
using Seguros.Business.Utils;
using Seguros.DataAccess;
using Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public class BusinessInsurancePolicy
    {
        Repository repositoryInsurance;

        public BusinessInsurancePolicy()
        {
            repositoryInsurance = new Repository(new SqlConnection(ConfigurationManager.ConnectionStrings["INSURANCE_CON"].ToString()));
        }

        public bool Create<Entity>(Entity entity) where Entity : class
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.ExecuteNonQuery("SP_CreateInsurance", parms);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete<Entity>(Entity entity) where Entity : class
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.ExecuteNonQuery("SP_DeleteInsurance", parms);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<RiskType> GetRiskTypes()
        {
            try
            {
                return repositoryInsurance.ExecuteQuery<RiskType>("SP_GetRiks");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CoverageType> GetCoverages()
        {
            try
            {
                return repositoryInsurance.ExecuteQuery<CoverageType>("SP_GetCoverage");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<InsurancePolicy> GetInsurances(InsurancePolicy entity)
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.ExecuteQuery<InsurancePolicy>("SP_GetInsurances", parms);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update<Entity>(Entity entity) where Entity : class
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.ExecuteNonQuery("SP_UpdateInsurance", parms);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
