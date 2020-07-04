using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business.Utils
{
    public static class ParamsSqlUtils
    {
        public static DynamicParameters GetParameters<Entity>(this Entity prms)
        {
            Type typeEntity = typeof(Entity);
            DynamicParameters parameters = new DynamicParameters();

            foreach (var Property in typeEntity.GetProperties())
            {
                if (Property.GetValue(typeEntity) != null)
                {
                    parameters.Add($"@{Property.Name}", Property.GetValue(typeEntity));
                }
            }
            return parameters;
        }
    }
}
