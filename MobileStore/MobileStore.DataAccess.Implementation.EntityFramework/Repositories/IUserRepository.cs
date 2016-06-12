using MobileStore.DataAccess.Implementation.EntityFramework.Interface;
using MobileStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Repositories
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
