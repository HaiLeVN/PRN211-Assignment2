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
        IProductRepository productRepository = new ProductRepository();
        IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public Member _loginMember { get; set; }
        BindingSource bindingSource;
        public frmMain() => InitializeComponent();

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainComponents();
            if (this.ActiveMdiChild != null && ActiveMdiChild is frmMembers)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                frmMembers frmMembers = new frmMembers();
                frmMembers.Text = "Quản lý thành viên";
                frmMembers.MdiParent = this;
                frmMembers.FormClosed += (s, ev) =>
                {
                    ShowMainComponents();
                };
                frmMembers.Show();
            }
        }

        private void HideMainComponents()
        {
            dgvProducts.Visible = false;
            welcomeMessage.Visible = false;
            btnBuy.Visible = false;
            llabelViewOrder.Visible = false;
            lbGuide.Visible = false;
            lbGuide2.Visible = false;
        }

        private void ShowMainComponents()
        {
            dgvProducts.Visible = true;
            welcomeMessage.Visible = true;
            btnBuy.Visible = true;
            llabelViewOrder.Visible = true;
            lbGuide.Visible = true;
            lbGuide2.Visible = true;
        }



        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            _loginMember = null;
            this.Close();
            frmLogin.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> products = productRepository.GetAllProducts().ToList();

            bindingSource = new BindingSource();
            bindingSource.DataSource = products;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;


            welcomeMessage.BringToFront();
            welcomeMessage.Text += _loginMember.Email.Split("@")[0];
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideMainComponents();
            if (this.ActiveMdiChild != null && ActiveMdiChild is frmProduct)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                frmProduct frmProduct = new frmProduct();
                frmProduct.Text = "Quản lý sản phẩm";
                frmProduct.MdiParent = this;
                frmProduct.FormClosed += (s, ev) =>
                {
                    ShowMainComponents();
                };
                frmProduct.Show();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainComponents();
            if (this.ActiveMdiChild != null && ActiveMdiChild is frmOrders)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                frmOrders order = new frmOrders();
                order.Text = "Quản lý đơn đặt hàng";
                order.MdiParent = this;
                order.FormClosed += (s, ev) =>
                {
                    ShowMainComponents();
                };
                order.Show();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var buyProduct = productRepository.GetAllProducts().ToList()[dgvProducts.CurrentRow.Index];

            if (buyProduct != null)
            {
                if (MessageBox.Show("Would you like to buy it? ", "Buy Product", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (_loginMember.MemberId != 0)
                    {
                        var todayDate = DateTime.Today;
                        Order order = new Order()
                        {
                            MemberId = _loginMember.MemberId,
                            OrderDate = todayDate,
                            Freight = buyProduct.UnitPrice
                        };
                        orderRepository.AddOrder(order);

                        int orderId = order.OrderId;
                        OrderDetail orderDetail = new OrderDetail()
                        {
                            OrderId = orderId,
                            ProductId = buyProduct.ProductId,
                            UnitPrice = buyProduct.UnitPrice,
                            Quantity = 1, // add to cart have not added yet
                            Discount = 0
                        };

                        orderDetailsRepository.Create(orderDetail);

                        MessageBox.Show("Buy successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Only member can buy product", "Buy Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

            }
        }

        private void llabelViewOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOrders orders = new frmOrders()
            {
                Text = "Your Order History",
                _LoginMember = _loginMember,
                _orderRepository = orderRepository
            };
            orders.Show();
        }
    }
}
