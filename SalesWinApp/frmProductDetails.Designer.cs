namespace SalesWinApp
{
    partial class frmProductDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            txtProduct = new TextBox();
            txtWeight = new TextBox();
            txtPrice = new MaskedTextBox();
            txtUnits = new MaskedTextBox();
            txtCategoryID = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Category ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 119);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 179);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 242);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Unit Price ($)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 311);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Units In Stock";
            // 
            // btnSubmit
            // 
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Location = new Point(210, 408);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(365, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(238, 116);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(203, 27);
            txtProduct.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(238, 176);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(203, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(238, 239);
            txtPrice.Mask = "00000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(203, 27);
            txtPrice.TabIndex = 10;
            txtPrice.Text = "0";
            txtPrice.ValidatingType = typeof(int);
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(238, 304);
            txtUnits.Mask = "0000";
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(203, 27);
            txtUnits.TabIndex = 11;
            txtUnits.Text = "0";
            txtUnits.ValidatingType = typeof(int);
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(238, 53);
            txtCategoryID.Mask = "00";
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(203, 27);
            txtCategoryID.TabIndex = 12;
            txtCategoryID.Text = "0";
            txtCategoryID.ValidatingType = typeof(int);
            // 
            // frmProductDetails
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(526, 527);
            Controls.Add(txtCategoryID);
            Controls.Add(txtUnits);
            Controls.Add(txtPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProduct);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductDetails";
            Text = "frmProductDetails";
            Load += frmProductDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private Button btnCancel;
        private TextBox txtProduct;
        private TextBox txtWeight;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtUnits;
        private MaskedTextBox txtCategoryID;
    }
}