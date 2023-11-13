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

        private void GetMembersList(string search = "")
        {
            memberRepository = new MemberRepository();
            IEnumerable<Member> members = memberRepository.GetMembers().Where(s => s.City.ToLower().Contains(search.ToLower()) || s.Country.ToLower().Contains(search.ToLower()));
            foreach (Member member in members)
            {
                member.Password = "**********"; // Hide the password
            }
            source = new BindingSource();
            source.DataSource = members;
            dgvMemberDetail.DataSource = null;
            dgvMemberDetail.DataSource = source;
            dgvMemberDetail.Columns.Remove("Orders");
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
            if (member != null)
            {
                if (MessageBox.Show("Are you sure? You will delete this member", "Remove member", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        memberRepository.Delete(member);
                        GetMembersList();
                    } catch(Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message, "Remove member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Not found member", "Remove Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            InsertOrUpdate = true;
            frmMembersDetail frmMembersDetail = new frmMembersDetail()
            {
                Text = "Create Member",
                _MemberRepository = memberRepository,
                _InsertOrUpdate = InsertOrUpdate
            };
            if (frmMembersDetail.ShowDialog() == DialogResult.OK)
            {
                GetMembersList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];
            InsertOrUpdate = false;
            if (member != null)
            {
                frmMembersDetail frmMembersDetail = new frmMembersDetail()
                {
                    Text = "Update Member",
                    _MemberRepository = memberRepository,
                    _InsertOrUpdate = InsertOrUpdate,
                    MemberDetail = member
                };
                if (frmMembersDetail.ShowDialog() == DialogResult.OK)
                {
                    GetMembersList();
                }
            }
            else
            {
                MessageBox.Show("Not found member", "Update Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void dgvMemberDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var member = memberRepository.GetMembers().ToList()[dgvMemberDetail.CurrentRow.Index];
            InsertOrUpdate = false;
            if (member != null)
            {
                frmMembersDetail frmMembersDetail = new frmMembersDetail()
                {
                    Text = "Update Member",
                    _MemberRepository = memberRepository,
                    _InsertOrUpdate = InsertOrUpdate,
                    MemberDetail = member
                };
                if (frmMembersDetail.ShowDialog() == DialogResult.OK)
                {
                    GetMembersList();
                }
            }
            else
            {
                MessageBox.Show("Not found member", "Update Member", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            GetMembersList(keyword);
        }
    }
}
