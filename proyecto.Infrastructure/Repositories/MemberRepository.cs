using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Infrastructure.Interfaces;
using Foundation.Infrastructure.Context;
using Foundation.Domain.Entities;

namespace Foundation.Infrastructure.Repositories
{
    internal class MemberRepository : IMemberRepository
    {
        private readonly FoundationContext _context;

        public MemberRepository(FoundationContext context)
        {
            _context = context;
        }

        public Member GetMemberById(int memberId)
        {
            return _context.Members.Find(memberId);
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }

        public void AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void UpdateMember(Member member)
        {
            _context.Members.Update(member);
            _context.SaveChanges();
        }

        public void DeleteMember(int memberId)
        {
            var member = _context.Members.Find(memberId);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
        }
    }
}
