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
    public partial class frmMain : Form
    {
        public Member _loginMember { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmMembers frmMembers = new frmMembers();
            frmMembers.Text = "Quản lý thành viên";
            frmMembers.MdiParent = this;
            welcomeMessage.SendToBack();
            frmMembers.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            Dispose();
            frmLogin.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            welcomeMessage.BringToFront();
            welcomeMessage.Text = "Hello " + _loginMember.Email.Split("@")[0];
        }
    }
}
