using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MobileStore.Domain.Entities;
using System.Data.Entity;
using MobileStore.DataAccess.Implementation.EntityFramework.Utilities;
using MobileStore.DataAccess.Implementation.EntityFramework.Interface;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Repositories
{

    public class UserRepository : EntityRepositoryBase<User>
    {
        private IUnitOfWork<MobileStoreContext> _unitOfWork;
        public UserRepository(IUnitOfWork<MobileStoreContext> unitOfWork)
            :base(unitOfWork)
        {
            _unitOfWork = unitOfWork;            
        }

        protected override IQueryable<User> AllEntity()
        {
            return _unitOfWork.Context.User;
        }

        protected override User GetEntity(int id)
        {
            return _unitOfWork.Context.User.Find(id);
        }

        protected override void InsertEntityGraph(User entity)
        {
            _unitOfWork.Context.User.Add(entity);
        }
    }


    //public class UserRepository : IUserRepository
    //{
    //    private readonly MobileStoreContext _context;
    //    public UserRepository(UnitOfWork unitOfWork)
    //    {
    //        _context = unitOfWork.Context;
    //    }
    //    public IQueryable<User> All
    //    {
    //        get
    //        {
    //           return  _context.User;
    //        }
    //    }

    //    public IQueryable<User> AllIncluding(params Expression<Func<User, object>>[] includeProperties)
    //    {
    //        IQueryable<User> query = _context.User;
    //        foreach (var includeProperty in includeProperties)
    //        {
    //            query = query.Include(includeProperty);
    //        }
    //        return query;
    //    }

    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }

    //    public User Find(int id)
    //    {
    //        return _context.User.Find(id);
    //    }

    //    public void Insert(User entity)
    //    {
    //        _context.Entry(entity).State = EntityState.Added;
    //    }

    //    public void InsertGraph(User entity)
    //    {
    //        _context.User.Add(entity);
    //    }

    //    public void Remove(User entity)
    //    {
    //        _context.User.Remove(entity);
    //    }

    //    public void Remove(int id)
    //    {
    //        var entity = _context.User.Find(id);
    //        _context.User.Remove(entity);
    //    }

    //    public void Update(User entity)
    //    {
    //        _context.Entry(entity).State = EntityState.Modified;
    //    }

    //    public void UpdateGraph(User entity)
    //    {
    //        _context.User.Add(entity);
    //        _context.ApplyStateChanges();
    //    }
    //}
}
