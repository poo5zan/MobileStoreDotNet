using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework
{
    /// <summary>
    /// Base Context class,
    /// Helpful when creating multiple DbContext, pointing same db
    /// </summary>
    /// <typeparam name="TContext"></typeparam>

    public class BaseContext<TContext> 
        : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
          Database.SetInitializer<TContext>(null);
        }

        protected BaseContext()
            :base("name=MobileStoreConnection")
        {

        }

    }
}
