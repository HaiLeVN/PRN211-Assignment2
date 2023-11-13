using BusinessObject.Models;
using DataAccess.Repository;
using System.Data;
using System.Diagnostics.Metrics;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public IOrderRepository _orderRepository { get; set; }
        public Member _LoginMember { get; set; }
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void GetOrdersList(int search = 0)
        {
            IEnumerable<Order> orders = null;
            // Check cho view order history
            if (_LoginMember == null)
            {
                _orderRepository = new OrderRepository();
                if (search != 0)
                {
                    orders = _orderRepository.GetAllOrders().Where(o => o.MemberId.Equals(search));

                }
                else
                {
                    orders = _orderRepository.GetAllOrders();
                }


                source = new BindingSource();
                source.DataSource = orders.ToList();

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

                dgvOrders.Columns["Member"].Visible = false;
            }
            else
            {
                // Hide admin management button
                btnRemove.Visible = false;
                btnUpdate.Visible = false;
                btnSearch.Visible = false;
                lbSearch.Visible = false;
                txtSearch.Visible = false;

                _orderRepository = new OrderRepository();
                // Automatically search for Member ID because view order history
                orders = _orderRepository.GetAllOrders().Where(o => o.MemberId.Equals(_LoginMember.MemberId));
                source = new BindingSource();
                source.DataSource = orders;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _orderRepository = new OrderRepository();
            OrderDetailsRepository orderDetails = new OrderDetailsRepository();
            var orders = _orderRepository.GetAllOrders().ToList()[dgvOrders.CurrentRow.Index];
            if (orders != null)
            {
                bool result = false;
                if (MessageBox.Show("Are you sure? You will delete this order", "Remove order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    orderDetails.DeleteById(orders.OrderId);
                    result = _orderRepository.DeleteOrder(orders);
                    if (!result)
                    {
                        MessageBox.Show("Cannot remove this Order, remove order details first", "Remove order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    GetOrdersList();
                }
            }
            else
            {
                MessageBox.Show("Order is not found", "Remove order", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                GetOrdersList();
            }
            else
            {
                GetOrdersList(Convert.ToInt32(txtSearch.Text));
            }
            // Search by Member ID

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            GetOrdersList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var orders = _orderRepository.GetAllOrders().ToList()[dgvOrders.CurrentRow.Index];
            if (orders != null)
            {
                frmOrdersUpdate frmOrdersUpdate = new frmOrdersUpdate()
                {
                    Text = "Update Orders",
                    orderRepository = _orderRepository,
                    OrderPresenter = orders
                };
                if (frmOrdersUpdate.ShowDialog() == DialogResult.OK)
                {
                    GetOrdersList();
                }
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var orders = _orderRepository.GetAllOrders().ToList()[dgvOrders.CurrentRow.Index];
            if(orders != null)
            {
                frmOrderDetails frmOrderDetails = new frmOrderDetails()
                {
                    Text = "Chi tiết đơn đặt hàng",
                    orderId = orders.OrderId,
                    _member = _LoginMember
                };
                if (frmOrderDetails.ShowDialog() == DialogResult.OK)
                {
                    GetOrdersList();
                }
            }
            
        }
    }
}
