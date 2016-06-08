using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MobileStore.Domain.Entities;
using System.Data.Entity;
using MobileStore.DataAccess.Implementation.EntityFramework.Utilities;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Repositories
{
    public class MobileRepository : IMobileRepository
    {
        private readonly MobileStoreContext _context;

        public MobileRepository(UnitOfWork unitOfWork)
        {
            _context = unitOfWork.Context;
        }

        public IQueryable<Mobile> All
        {
            get
            {
                return _context.Mobile;
            }
        }

        public List<Mobile> AllMobile {
            get {
                return _context.Mobile.ToList();
            }
        }

        public IQueryable<Mobile> AllIncluding(params Expression<Func<Mobile, object>>[] includeProperties)
        {
            IQueryable<Mobile> query = _context.Mobile;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public void Remove(Mobile entity)
        {
            _context.Mobile.Remove(entity);
        }

        public void Remove(int id)
        {
            var mobile = _context.Mobile.Find(id);
            _context.Mobile.Remove(mobile);
        }

        public Mobile Find(int id)
        {
            return _context.Mobile.Find(id);
        }

        public void Insert(Mobile entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void InsertGraph(Mobile entity)
        {
            _context.Mobile.Add(entity);
        }

        public void Update(Mobile entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateGraph(Mobile entity)
        {
            _context.Mobile.Add(entity);
            _context.ApplyStateChanges();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
