﻿using MobileStore.Common;
using MobileStore.Models.InputModel;
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
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
           
            return Ok();
        }

        [Route("{id:int}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            if (id == default(int))
            {
                return BadRequest(ErrorMessage.RequiredId);
            }

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

        [Route("")]
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            if (id == default(int))
            {
                return BadRequest(ErrorMessage.RequiredId);
            }
            return Ok();
        }

    }
}