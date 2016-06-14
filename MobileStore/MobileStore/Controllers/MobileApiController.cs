using MobileStore.Common;
using MobileStore.Models.InputModel;
using MobileStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/mobile")]
    public class MobileApiController : ApiBaseController       
    {

        private IMobileService _mobileService;

        public MobileApiController(IMobileService mobileService)
        {
            _mobileService = mobileService;
        }


        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {           
            AuthorizeUser(Request);
            var mobiles = _mobileService.Get();
            return Ok(mobiles);
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            if (id == default(int))
            {
                return BadRequest(ErrorMessage.RequiredId);
            }

            AuthorizeUser(Request);

            return Ok();
        }

        [Route("")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(MobileInputModel mobileInputModel)
        {
            if (mobileInputModel == null)
            {
                return BadRequest(ErrorMessage.Mobile.RequiredMobileInputModel);
            }

            AuthorizeUser(Request);

            return Ok();
        }

        [Route("")]
        [HttpPut]
        public async Task<IHttpActionResult> Put(MobileInputModel mobileInputModel)
        {
            if (mobileInputModel == null)
            {
                return BadRequest(ErrorMessage.Mobile.RequiredMobileInputModel);
            }

            return Ok();
        }

        [Route("{id:int}")]
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {            
            if (id == default(int))
            {
                return BadRequest(ErrorMessage.RequiredId);
            }

            AuthorizeUser(Request);

            return Ok();
        }

    }
}
