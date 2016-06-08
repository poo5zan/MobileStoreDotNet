using MobileStore.DataAccess.Implementation.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Implementation
{
    public abstract class DatabaseRepositoryBase<T, U> : IDataRepository<T>
        where T : class, new()
        where U : DbContext, new()
    {
        //public EntityRepository(DbContext entityContext)
        //{
        //    _entityContext = entityContext;
        //}

        //private DbContext _entityContext;

        protected abstract T AddEntity(U entityContext, T entity);
        protected abstract T UpdateEntity(U entityContext, T entity);
        protected abstract IEnumerable<T> GetEntities(U entityContext);
        protected abstract T GetEntity(U entityContext, int id);


        public T Add(T entity)
        {
            using (U entityContext = new U())
            {
                T addedEntity = AddEntity(entityContext, entity);
                entityContext.SaveChanges();
                return addedEntity;
            }
        }

        //public void Dispose()
        //{
        //    _entityContext.Dispose();
        //}

        public IEnumerable<T> Get()
        {
            using (var entityContext = new U())
            {
                return GetEntities(entityContext).ToArray().ToList();
            }
        }

        public T Get(int id)
        {
            using (var entityContext = new U())
            {
                return GetEntity(entityContext, id);
            }
        }

       
        public void Delete(int id)
        {
            using (var entityContext = new U())
            {
                T entity = GetEntity(entityContext, id);
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var entityContext = new U())
            {
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var entityContext = new U())
            {
                T existingEntity = UpdateEntity(entityContext, entity);
                entityContext.SaveChanges();
            }
        }
    }

}
