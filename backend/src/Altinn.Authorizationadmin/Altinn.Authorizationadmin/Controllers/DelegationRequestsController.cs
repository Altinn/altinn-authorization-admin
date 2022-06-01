﻿using Altinn.AuthorizationAdmin.Core.Models;
using Altinn.AuthorizationAdmin.Services;
using Microsoft.AspNetCore.Mvc;

namespace Altinn.Authorizationadmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelegationRequestsController : ControllerBase
    {
        private readonly IDelegationRequests _delegationRequests;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="delegationRequsts"></param>
        public DelegationRequestsController(IDelegationRequests delegationRequsts)
        {
            _delegationRequests = delegationRequsts;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<DelegationRequests> Get()
        {
           return await _delegationRequests.GetDelegationRequestsAsync(0, 0, null);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DelegationRequest>> Get(string id)
        {
            DelegationRequest delegationRequest = new DelegationRequest();
            delegationRequest.RequestResources = new List<Core.Models.AuthorizationRequestResource>();
            delegationRequest.RequestResources.Add(new Core.Models.AuthorizationRequestResource() { ServiceCode = "asdf", ServiceEditionCode = 435 });
            return delegationRequest;
        }
    }
}
