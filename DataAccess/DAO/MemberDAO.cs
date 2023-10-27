using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        public static MemberDAO instance = null;
        public static object instanceLock = new object();

        public static MemberDAO Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }

        public Member GetDefaultMember()
        {
            Member Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["account:defaultAccount:email"];
                string password = config["account:defaultAccount:password"];
                Default = new Member
                {
                    MemberId = 0,
                    Email = email,
                    Password = password,
                    City = "",
                    Country = "",
                    CompanyName = ""
                };
            }
            return Default;
        }

        public IEnumerable<Member> GetMembers()
        {
            IEnumerable<Member> list = new List<Member>();
            try
            {
                var context = new SalesManagementContext();
                list = context.Members.ToList();
                list = list.Append(GetDefaultMember());
                
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Member Login(string username, string password)
        {
            IEnumerable<Member> list = GetMembers();
            Member member = list.SingleOrDefault(mb => mb.Email == username && mb.Password == password);
            return member;
        }

        public void Delete(Member member)
        {
            if(member != null)
            {
                try
                {
                    var context = new SalesManagementContext();
                    context.Members.Remove(member);
                    context.SaveChanges();
                } catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Create(Member member)
        {
            if(member != null )
            {
                try
                {
                    var context = new SalesManagementContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                } catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Update(Member member)
        {
            if( member != null )
            {
                try
                {
                    var context = new SalesManagementContext();
                    context.Update(member);
                    context.SaveChanges();
                } catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
