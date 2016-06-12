using MobileStore.DataAccess.Implementation.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using MobileStore.DataAccess.Implementation.EntityFramework.Utilities;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Repositories
{
    public abstract class EntityRepositoryBase<T> : IEntityRepository<T>
        where T : class, new()
    {
        private readonly MobileStoreContext _mobileStoreContext;

        public EntityRepositoryBase(IUnitOfWork<MobileStoreContext> unitOfWork)
        {
            _mobileStoreContext = unitOfWork.Context;
        }

        protected abstract IQueryable<T> AllEntity();
        protected abstract T GetEntity(int id);
        protected abstract void InsertEntityGraph(T entity);
            

        public IQueryable<T> All
        {
            get
            {
                return AllEntity();
            }
        }

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = AllEntity();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public void Dispose()
        {
            _mobileStoreContext.Dispose();
        }

        public T Find(int id)
        {
            return GetEntity(id);
        }

        public void Insert(T entity)
        {
            _mobileStoreContext.Entry(entity).State = EntityState.Added;
        }

        public void InsertGraph(T entity)
        {
            InsertEntityGraph(entity);
        }

        public void Remove(T entity)
        {
            _mobileStoreContext.Entry(entity).State = EntityState.Deleted;
        }

        public void Remove(int id)
        {
            var entity = GetEntity(id);
            Remove(entity);
        }

        public void Update(T entity)
        {
            _mobileStoreContext.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateGraph(T entity)
        {
            InsertEntityGraph(entity);
            _mobileStoreContext.ApplyStateChanges();
        }
    }
}
