using MobileStore.DataAccess.Implementation.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework
{
    public class UnitOfWork : IUnitOfWork<MobileStoreContext>
    {
        private readonly MobileStoreContext _context;

        public UnitOfWork()
        {
            _context = new MobileStoreContext();
        }

        public UnitOfWork(MobileStoreContext context)
        {
            _context = context;
        }

        public MobileStoreContext Context
        {
            get
            {
                return _context;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
