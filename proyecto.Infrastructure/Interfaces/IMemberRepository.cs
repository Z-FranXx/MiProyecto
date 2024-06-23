using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Domain.Entities;
using System.Collections.Generic;

namespace Foundation.Infrastructure.Interfaces
{
    internal interface IMemberRepository
    {
        Member GetMemberById(int memberId);
        IEnumerable<Member> GetAllMembers();
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
