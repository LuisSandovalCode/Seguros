using Seguros.Business.Utils;
using Seguros.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public class BusinessCustomer : IBusiness
    {
        Repository repositoryCustomer;
        public BusinessCustomer()
        {
            repositoryCustomer = new Repository();
        }

        public bool Create<Entity>(Entity entity) where Entity : class
        {
            try
            {
                var prm = entity.GetParameters();

                return repositoryCustomer.InsertEntity("SP_CreateCustomer", prm);
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

                return repositoryCustomer.InsertEntity("SP_DeleteCustomer", prm);
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

                return repositoryCustomer.GetEntities<Entity>("SP_GetCustomer",prm);
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

                return repositoryCustomer.InsertEntity("SP_UpdateCustomer", prm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
