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
    public partial class frmProductDetails : Form
    {
        public IProductRepository _productRepository { get; set; }
        public bool _InsertOrUpdate { get; set; }
        public Product ProductDetail { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            // If false, get the product detail from Product form and set to txt 
            if (!_InsertOrUpdate)
            {
                txtCategoryID.Text = ProductDetail.CategoryId.ToString();
                txtPrice.Text = ProductDetail.UnitPrice.ToString();
                txtProduct.Text = ProductDetail.ProductName;
                txtWeight.Text = ProductDetail.Weight;
                txtUnits.Text = ProductDetail.UnitsInStock.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _productRepository = new ProductRepository();
            if(_InsertOrUpdate)
            {
                // Create Product
                Product product = new Product()
                {
                    ProductName = txtProduct.Text,
                    CategoryId = Convert.ToInt32(txtCategoryID.Text),
                    UnitPrice = Convert.ToInt32(txtPrice.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = Convert.ToInt32(txtUnits.Text)
                };
                _productRepository.Create(product);
                this.Close();
            } else
            {
                // Update product
                Product product = new Product()
                {
                    ProductId = ProductDetail.ProductId,
                    ProductName = txtProduct.Text,
                    CategoryId = Convert.ToInt32(txtCategoryID.Text),
                    UnitPrice = Convert.ToInt32(txtPrice.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = Convert.ToInt32(txtUnits.Text)
                };
                _productRepository.Update(product);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
