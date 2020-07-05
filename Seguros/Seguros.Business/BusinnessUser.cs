using Seguros.Business.Utils;
using Seguros.DataAccess;
using Seguros.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public class BusinnessUser
    {
        Repository repositoryUser;
        public BusinnessUser()
        {
            repositoryUser = new Repository();
        }

        public bool AutenticateUser(User user)
        {
            try
            {
                var prm = user.GetParameters();

                return repositoryUser.ExecuteQuery<bool>("SP_AuthUser", prm).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
