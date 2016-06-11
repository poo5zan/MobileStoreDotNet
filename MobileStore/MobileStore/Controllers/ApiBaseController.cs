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

            AuthorizeUser();
            
        }

        protected void AuthorizeUser()
        {
           // return Unauthorized();
           throw new UnauthorizedAccessException("not auth");
        }
    }
}
