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
            Quit = new Button();
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
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(479, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            Quit.Location = new Point(343, 509);
            Quit.Name = "Quit";
            Quit.Size = new Size(94, 29);
            Quit.TabIndex = 9;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += Quit_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 563);
            Controls.Add(Quit);
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
        }

        #endregion

        private DataGridView dgvMemberDetail;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnUpdate;
        private Button Quit;
    }
}