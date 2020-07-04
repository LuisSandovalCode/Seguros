using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Business
{
    public interface IBusiness
    {
        bool Create<Entity>(Entity entity) where Entity : class;

        bool Update<Entity>(Entity entity) where Entity : class;

        bool Delete<Entity>(Entity entity) where Entity : class;

        List<Entity> GetEntities<Entity>(Entity entity);
    }
}
