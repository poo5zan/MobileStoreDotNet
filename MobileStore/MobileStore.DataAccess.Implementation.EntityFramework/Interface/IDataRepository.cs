using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Interface
{
    public interface IDataRepository<T> : IDataRepository
    {
        T Add(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Update(T entity);

        IEnumerable<T> Get();

        T Get(int id);
    }

    public interface IDataRepository { }
}
