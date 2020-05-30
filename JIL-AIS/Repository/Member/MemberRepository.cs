using JIL_AIS.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JIL_AIS.Repository.Member
{
    public class MemberRepository : IMemberRepository
    {
        private readonly JILDBContext _context;

        public MemberRepository(JILDBContext context)
        {
            this._context = context;
        }

        public List<JIL_AIS.Models.Domain.Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }

    }
}
