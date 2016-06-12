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
    public class UserRepositoryTest
    {

        [TestMethod]
        public void Insert()
        {
            var unitOfwork = new UnitOfWork();

            var userRepo = new UserRepository(unitOfwork);

            var usr = new User() {
                Name = "pujan",
                Email = "pujan@pmail.com"
            };

            userRepo.Insert(usr);

            try
            {
                unitOfwork.Save();
            }
            catch (Exception ex)
            {
                var p = 0;
                throw;
            }
            

            //find
            

        }

        [TestMethod]
        public void Find()
        {
            var unitOfWork = new UnitOfWork();
            var userRepository = new UserRepository(unitOfWork);

            var userAll = userRepository.All.Where(x => x.Id == 6).FirstOrDefault();

            var user = userRepository.Find(6);                       

        }

        [TestMethod]
        public void Update()
        {
            var unitOfWork = new UnitOfWork();
            var userRepository = new UserRepository(unitOfWork);
            var user = userRepository.Find(6);
            user.Email = "arkopmail@pmail.com";
            user.CreatedDate = DateTime.Now;
            userRepository.Update(user);
            unitOfWork.Save();

            var usr = userRepository.All.Where(x => x.Name == "pujan").FirstOrDefault();
            usr.Password = "myPassword";
            usr.Email = "pmail@pmai.com";
            userRepository.Update(usr);
            unitOfWork.Save();

            var userAgain = userRepository.Find(6);
            //Assert.AreEqual("arkopmail@pmail.com", userAgain.Email);
        }
       

    }
}
