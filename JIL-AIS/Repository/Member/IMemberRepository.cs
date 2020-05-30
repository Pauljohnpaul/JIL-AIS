using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JIL_AIS.Repository.Member
{
    public interface IMemberRepository
    {
        public List<JIL_AIS.Models.Domain.Member> GetAllMembers();
    }
}
