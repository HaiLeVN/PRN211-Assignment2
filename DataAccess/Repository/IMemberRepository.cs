using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public Member GetDefaultMembers();
        public IEnumerable<Member> GetMembers();
        public Member Login(string username, string password);
        public void Update(Member member);
        public void Delete(Member member);
        public void Create(Member member);
    }
}
