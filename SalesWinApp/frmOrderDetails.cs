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
    public partial class frmOrderDetails : Form
    {
        OrderDetailsRepository orderDetailsRepo = null;
        public int orderId { get; set; }

        public Member _member {  get; set; }
        public frmOrderDetails()
        {
            orderDetailsRepo = new OrderDetailsRepository();
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            OrderDetail orders = orderDetailsRepo.findById(orderId);
            if (orders != null)
            {
                if(_member != null)
                {
                    txtOrderID.Text = orders.OrderId.ToString();
                    txtProductID.Text = orders.ProductId.ToString();
                    txtQuantity.Text = orders.Quantity.ToString();
                    txtUnitPrice.Text = orders.UnitPrice.ToString();
                    numericDiscount.Text = orders.Discount.ToString();

                    txtOrderID.Enabled = false;
                    txtProductID.Enabled = false;
                    txtQuantity.Enabled = false;
                    txtUnitPrice.Enabled = false;
                    numericDiscount.Enabled = false;
                    btnSubmit.Enabled = false;
                    
                } else
                {
                    txtOrderID.Text = orders.OrderId.ToString();
                    txtProductID.Text = orders.ProductId.ToString();
                    txtQuantity.Text = orders.Quantity.ToString();
                    txtUnitPrice.Text = orders.UnitPrice.ToString();
                    numericDiscount.Text = orders.Discount.ToString();

                    txtOrderID.Enabled = false;
                    txtProductID.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("This order does not have detail information", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNumericPrice = decimal.TryParse(txtUnitPrice.Text, out decimal value1);
                bool isNumericQuantity = int.TryParse(txtQuantity.Text, out int value2);
                if (isNumericPrice && isNumericQuantity)
                {
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderId = Convert.ToInt32(txtOrderID.Text),
                        ProductId = Convert.ToInt32(txtProductID.Text),
                        UnitPrice = Convert.ToInt32(txtQuantity.Text),
                        Quantity = Convert.ToInt32(txtUnitPrice.Text),
                        Discount = Convert.ToInt32(numericDiscount.Text),
                    };
                    orderDetailsRepo.Update(orderDetail);
                }
                else
                {
                    MessageBox.Show("Invalid number in price or quantity", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }
    }
}
