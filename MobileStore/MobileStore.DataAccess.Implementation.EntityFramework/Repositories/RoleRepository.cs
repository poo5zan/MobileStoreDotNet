using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MobileStore.Domain.Entities;
using MobileStore.DataAccess.Implementation.EntityFramework.Interface;
using System.Data.Entity;
using MobileStore.DataAccess.Implementation.EntityFramework.Utilities;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MobileStoreContext _context;

        public RoleRepository(IUnitOfWork<MobileStoreContext> unitOfWork)
        {
            _context = unitOfWork.Context;
        }

        public IQueryable<Role> All
        {
            get
            {
                return _context.Role;
            }
        }

        public IQueryable<Role> AllIncluding(params Expression<Func<Role, object>>[] includeProperties)
        {
            IQueryable<Role> query = _context.Role;
            foreach (var includeProperty in includeProperties)
            {
               query =  query.Include(includeProperty);
            }
            return query;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Role Find(int id)
        {
            return _context.Role.Find(id);
        }

        public void Insert(Role entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void InsertGraph(Role entity)
        {
            _context.Role.Add(entity);
        }

        public void Remove(Role entity)
        {
            _context.Role.Remove(entity);
        }

        public void Remove(int id)
        {
            var entity = _context.Role.Find(id);
            Remove(entity);
        }

        public void Update(Role entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateGraph(Role entity)
        {
            InsertGraph(entity);
            _context.ApplyStateChanges();
        }

    }
}
