namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMemberDetail = new DataGridView();
            btnRemove = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberDetail
            // 
            dgvMemberDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberDetail.Location = new Point(12, 12);
            dgvMemberDetail.Name = "dgvMemberDetail";
            dgvMemberDetail.ReadOnly = true;
            dgvMemberDetail.RowHeadersWidth = 51;
            dgvMemberDetail.RowTemplate.Height = 29;
            dgvMemberDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberDetail.Size = new Size(763, 318);
            dgvMemberDetail.TabIndex = 0;
            dgvMemberDetail.CellContentDoubleClick += dgvMemberDetail_CellContentDoubleClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(206, 409);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(343, 409);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(479, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 355);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(263, 357);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 360);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 12;
            label1.Text = "Find by Country or City:";
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 563);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnRemove);
            Controls.Add(dgvMemberDetail);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberDetail;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}