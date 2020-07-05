using Dapper;
using Seguros.Business.Utils;
using Seguros.DataAccess;
using Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public class BusinessInsurancePolicy : IBusiness
    {
        Repository repositoryInsurance;

        public BusinessInsurancePolicy()
        {
            repositoryInsurance = new Repository();
        }

        public bool Create<Entity>(Entity entity) where Entity : class
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.InsertEntity("SP_CreateInsurance", parms);

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
                return repositoryInsurance.InsertEntity("SP_DeleteInsurance", parms);
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
                return repositoryInsurance.GetEntities<RiskType>("SP_GetRiks", null);
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
                return repositoryInsurance.GetEntities<CoverageType>("SP_GetCoverage", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entity> GetEntities<Entity>(Entity entity)
        {
            try
            {
                DynamicParameters parms = entity.GetParameters();
                return repositoryInsurance.GetEntities<Entity>("SP_GetInsurances", parms);

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
                return repositoryInsurance.InsertEntity("SP_UpdateInsurance", parms);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddPolicy<Entity>(Entity entity) where Entity : class
        {
            throw new NotImplementedException();
        }
    }
}
