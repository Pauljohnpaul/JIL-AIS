using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JIL_AIS.Models.Domain;
using JIL_AIS.Repository.Member;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JIL_AIS.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberRepository _memberRepository;

        public MembersController(IMemberRepository memberRepository)
        {
            this._memberRepository = memberRepository;
        }

        [HttpGet]
        [Route("getallmembers")]
        public List<Member> GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}