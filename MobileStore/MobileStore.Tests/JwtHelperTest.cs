using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileStore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Tests
{
    [TestClass]
    public class JwtHelperTest
    {
        [TestMethod]
        public void CreateToken() {
            var jwtHelper = new JwtHelper();

            //create token
            var token = jwtHelper.CreateToken("pujan");

            var user = jwtHelper.GetUserIdentifier(token);
            Assert.AreEqual("pujan", user);

           // var token = jwtHelper.CreateToken("pujan");

            ////verify
           // var r = jwtHelper.ValidateToken(token);
          //  var t = "e30.eyJ1cm9sZSI6InJvbGUxLHJvbGUyIiwidXNlciI6InB1amFuIn0.";
           // var r1 = jwtHelper.ValidateToken(t);
           // var r2 = jwtHelper.ValidateToken("e30.ey11cm9sZSI6InJvbGUxLHJvbGUyIiwidXNlciI6InB1amFuIn0.");

          //  var p = 0;

        }
    }
}
