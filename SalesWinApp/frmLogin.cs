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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                btnCancel.Enabled = false;
                btnLogin.Enabled = false;
                IMemberRepository memberRepository = new MemberRepository();
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                Member member = memberRepository.Login(email, password);
                if (member != null)
                {
                    MessageBox.Show("Login success", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain frmMain = new frmMain()
                    {
                        _loginMember = member,
                    };
                    this.Hide();
                    frmMain.Show();
                }
                else
                {
                    btnCancel.Enabled = true;
                    btnLogin.Enabled = true;
                    MessageBox.Show("Login failed", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
