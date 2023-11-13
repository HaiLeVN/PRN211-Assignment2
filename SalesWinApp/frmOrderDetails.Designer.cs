namespace SalesWinApp
{
    partial class frmOrderDetails
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
            txtOrderID = new MaskedTextBox();
            txtProductID = new MaskedTextBox();
            txtUnitPrice = new MaskedTextBox();
            txtQuantity = new MaskedTextBox();
            numericDiscount = new NumericUpDown();
            label7 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 169);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Discount";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(202, 38);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(299, 27);
            txtOrderID.TabIndex = 6;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(202, 80);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(299, 27);
            txtProductID.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(202, 126);
            txtUnitPrice.Mask = "00000";
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(299, 27);
            txtUnitPrice.TabIndex = 8;
            txtUnitPrice.Text = "0";
            txtUnitPrice.ValidatingType = typeof(int);
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(202, 166);
            txtQuantity.Mask = "00000";
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(299, 27);
            txtQuantity.TabIndex = 9;
            txtQuantity.Text = "0";
            txtQuantity.ValidatingType = typeof(int);
            // 
            // numericDiscount
            // 
            numericDiscount.Hexadecimal = true;
            numericDiscount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericDiscount.Location = new Point(202, 212);
            numericDiscount.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiscount.Name = "numericDiscount";
            numericDiscount.Size = new Size(150, 27);
            numericDiscount.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 214);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 12;
            label7.Text = "0 = 0%, 1 = 100%";
            // 
            // btnSubmit
            // 
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Location = new Point(342, 298);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(485, 298);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOrderDetails
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(687, 376);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(numericDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtOrderID;
        private MaskedTextBox txtProductID;
        private MaskedTextBox txtUnitPrice;
        private MaskedTextBox txtQuantity;
        private NumericUpDown numericDiscount;
        private Label label7;
        private Button btnSubmit;
        private Button btnCancel;
    }
}