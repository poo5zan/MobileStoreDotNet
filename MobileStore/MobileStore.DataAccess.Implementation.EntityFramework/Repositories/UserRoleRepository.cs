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
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly MobileStoreContext _context;

        public UserRoleRepository(IUnitOfWork<MobileStoreContext> unitOfWork)
        {
            _context = unitOfWork.Context;
        }

        public IQueryable<UserInRole> All
        {
            get
            {
                return _context.UserRole;
            }
        }

        public IQueryable<UserInRole> AllIncluding(params Expression<Func<UserInRole, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public UserInRole Find(int id)
        {
            return _context.UserRole.Find(id);
        }

        public void Insert(UserInRole entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void InsertGraph(UserInRole entity)
        {
            _context.UserRole.Add(entity);
        }

        public void Remove(UserInRole entity)
        {
            _context.UserRole.Remove(entity);
        }

        public void Remove(int id)
        {
            var entity = _context.UserRole.Find(id);
            Remove(entity);
        }

        public void Update(UserInRole entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateGraph(UserInRole entity)
        {
            InsertGraph(entity);
            _context.ApplyStateChanges();
        }
    }
}
