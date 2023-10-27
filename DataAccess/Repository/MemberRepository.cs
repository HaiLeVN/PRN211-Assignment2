using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void Create(Member member) => MemberDAO.Instance.Create(member);

        public void Delete(Member member) => MemberDAO.Instance.Delete(member);

        public Member GetDefaultMembers() => MemberDAO.Instance.GetDefaultMember();

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public Member Login(string username, string password) => MemberDAO.Instance.Login(username, password);

        public void Update(Member member) => MemberDAO.Instance.Update(member);
    }
}
