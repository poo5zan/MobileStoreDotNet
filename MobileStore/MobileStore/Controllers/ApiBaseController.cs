using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileStore.Controllers
{
    public class ApiBaseController : ApiController
    {
        public ApiBaseController()
        {
            //System.IdentityModel.Tokens
           // var self = this.GetType();
           // AuthorizeUser();
            
        }

        //protected void AuthorizeUser()
        //{
        //   // return Unauthorized();
        //   throw new UnauthorizedAccessException("not auth");
        //}

        protected void AuthorizeUser(HttpRequestMessage httpRequestMessage)
        {
            //get validation token from Request Object

            //get user name from the validation-token

            //get roles for specific user

            //retrieve the url accessed from Request Message

            //verify the role against the user and requested Url

            //different role may have different permissions
            //CRUD
            
           
        }

    }
}
