using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        private IMemberRepository memberRepository;
        BindingSource source;
        bool InsertOrUpdate = true;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void GetMembersList()
        {
            memberRepository = new MemberRepository();
            IEnumerable<Member> members = memberRepository.GetMembers();
            foreach (Member member in members)
            {
                member.Password = "**********"; // Hide the password
            }
            source = new BindingSource();
            source.DataSource = members;
            dgvMemberDetail.DataSource = null;
            dgvMemberDetail.DataSource = source;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            GetMembersList();
        }



        private void Quit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];
            memberRepository.Delete(member);
            GetMembersList();
        }
    }
}
