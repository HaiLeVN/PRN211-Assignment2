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
    public partial class frmMembersDetail : Form
    {
        public Member MemberDetail { get; set; }
        public bool _InsertOrUpdate { get; set; }
        public IMemberRepository _MemberRepository { get; set; }
        public frmMembersDetail()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _MemberRepository = new MemberRepository();
            if (_InsertOrUpdate)
            {
                Member member = new Member()
                {
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                _MemberRepository.Create(member);
                Close();
            }
            else
            {
                Member UpdateMember = new Member()
                {
                    MemberId = MemberDetail.MemberId,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                _MemberRepository.Update(UpdateMember);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmMembersDetail_Load(object sender, EventArgs e)
        {
            if (!_InsertOrUpdate)
            {
                txtEmail.Text = MemberDetail.Email;
                txtCity.Text = MemberDetail.City;
                txtCompanyName.Text = MemberDetail.CompanyName;
                txtCountry.Text = MemberDetail.Country;
                txtPassword.Text = MemberDetail.Password;
            }
        }
    }
}
