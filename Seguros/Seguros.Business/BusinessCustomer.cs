using Seguros.Business.Utils;
using Seguros.DataAccess;
using Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public class BusinessCustomer
    {
        Repository repositoryCustomer;
        public BusinessCustomer()
        {
            repositoryCustomer = new Repository(new SqlConnection(ConfigurationManager.ConnectionStrings["INSURANCE_CON"].ToString()));
        }

        public bool AddPolicy<Entity>(Entity entity) where Entity : class
        {
            try
            {
                var prm = entity.GetParameters();

                return repositoryCustomer.ExecuteNonQuery("SP_AddPolicyCustomer", prm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Create<Entity>(Entity entity) where Entity : class
        {
            try
            {
                var prm = entity.GetParameters();

                return repositoryCustomer.ExecuteNonQuery("SP_CreateCustomer", prm);
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
                var prm = entity.GetParameters();

                return repositoryCustomer.ExecuteNonQuery("SP_DeleteCustomer", prm);
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
                var prm = entity.GetParameters();

                return repositoryCustomer.ExecuteQuery<Entity>("SP_GetCustomer",prm);
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
                var prm = entity.GetParameters();

                return repositoryCustomer.ExecuteNonQuery("SP_UpdateCustomer", prm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<InsurancePolicy> GetCustomerInsurances(Customer customer)
        {
            try
            {
                var prm = customer.GetParameters();
                return repositoryCustomer.ExecuteQuery<InsurancePolicy>("SP_GetCustomerInsurance", prm).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
