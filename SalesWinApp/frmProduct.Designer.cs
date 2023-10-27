namespace SalesWinApp
{
    partial class frmProduct
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
            dgvProductDetails = new DataGridView();
            btnRemove = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvProductDetails
            // 
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductDetails.Location = new Point(30, 30);
            dgvProductDetails.Name = "dgvProductDetails";
            dgvProductDetails.ReadOnly = true;
            dgvProductDetails.RowHeadersWidth = 51;
            dgvProductDetails.RowTemplate.Height = 29;
            dgvProductDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductDetails.Size = new Size(779, 263);
            dgvProductDetails.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(51, 331);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(183, 331);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(318, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(442, 417);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(208, 417);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 27);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 420);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 7;
            label1.Text = "Search by Product Name:";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 573);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnRemove);
            Controls.Add(dgvProductDetails);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductDetails;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}