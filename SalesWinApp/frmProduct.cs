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
    public partial class frmProduct : Form
    {
        IProductRepository productRepository = null;
        BindingSource bindingSource;
        bool InsertOrUpdate = true;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GetProductList(string search = "")
        {
            productRepository = new ProductRepository();
            IEnumerable<Product> products = productRepository.GetAllProducts().ToList().Where(s => s.ProductName.Contains(search));

            bindingSource = new BindingSource();

            bindingSource.DataSource = null;
            bindingSource.DataSource = products;

            dgvProductDetails.DataSource = null;
            dgvProductDetails.DataSource = bindingSource;

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
            GetProductList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var product = productRepository.GetAllProducts().ToList()[dgvProductDetails.CurrentRow.Index];

            if (product != null)
            {
                productRepository.Delete(product);
                GetProductList();
            }
            else
            {
                MessageBox.Show("Not found product", "Remove product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = true;
            frmProductDetails frmProductDetails = new frmProductDetails()
            {
                Text = "Create product",
                _InsertOrUpdate = InsertOrUpdate,
                _productRepository = productRepository,
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                GetProductList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var products = productRepository.GetAllProducts().ToList()[dgvProductDetails.CurrentRow.Index];
            InsertOrUpdate = false;
            if (products != null)
            {
                frmProductDetails frmProductDetails = new frmProductDetails()
                {
                    Text = "Update product",
                    ProductDetail = products,
                    _InsertOrUpdate = InsertOrUpdate,
                    _productRepository = productRepository
                };
                frmProductDetails.Show();
                if (frmProductDetails.DialogResult == DialogResult.OK)
                {
                    GetProductList();
                }
            }
            else
            {
                MessageBox.Show("Not found product", "Update product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetProductList(txtSearch.Text);
        }
    }
}
