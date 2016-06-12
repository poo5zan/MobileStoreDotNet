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
                       

            //insert currencies            

            _mobileRepository.Insert(new Mobile() {
                Name = "Samsung J7 2016",
                Brand = "Samsung",
                CommonName = "Samsung J7 2016",
                Model = "J7 2016",
                UniqueName = "",
                Price = 783
                
            });

            _mobileRepository.Insert(new Mobile()
            {
                Name = "Samsung J5 2016",
                Brand = "Samsung",
                CommonName = "Samsung J5 2016",
                Model = "J5 2016",
                UniqueName = "",
                Price = 783
                
            });


            unitOfWork.Save();

           // var mob = _mobileRepository.Find(1);

           // Assert.IsNotNull(mob);
           // Assert.AreEqual("Samsung", mob.Brand);

        }

        [TestMethod]
        public void Find() {
            var unitOfWork = new UnitOfWork();
            IMobileRepository mobileRepository = new MobileRepository(unitOfWork);

            var mobile = mobileRepository.Find(3);

           // var m = mobileRepository.All.Where(x => x.Brand.Contains("am")).ToList();

            //var m = mobileRepository.AllIncluding(x => x.Id == 3).SingleOrDefault(x => x.CurrencyId == 1);
            
            Assert.IsNotNull(mobile);

        }

    }
}
