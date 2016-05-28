using MobileStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Utilities
{
    class StateHelper
    {

        public static EntityState ConvertState(State state) {

            switch (state) {
                case State.Added:
                    return EntityState.Added;                 

                case State.UnChanged:
                    return EntityState.Unchanged;

                case State.Modified:
                    return EntityState.Modified;

                case State.Deleted:
                    return EntityState.Deleted;

                default:
                    return EntityState.Unchanged;
            }
        }
    }
}
