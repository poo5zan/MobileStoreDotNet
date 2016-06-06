using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileStore.DataAccess.Implementation.EntityFramework.Repositories;
using MobileStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Implementation.EntityFramework.Test.Repositories
{
    [TestClass]
    public class MobileRepositoryTest
    {
        [TestMethod]
        public void Insert() {


            var unitOfWork = new UnitOfWork();
            IMobileRepository _mobileRepository = new MobileRepository(unitOfWork);

            _mobileRepository.Insert(new Mobile() {
                Name = "Samsung J7",
                Brand = "Samsung",
                CommonName = "Samsung J7",
                Model = "J7",
                UniqueName = "",
                Id = 1
            });

            unitOfWork.Save();

            var mob = _mobileRepository.Find(1);

            Assert.IsNotNull(mob);
            Assert.AreEqual("Samsung", mob.Brand);

        }

    }
}
