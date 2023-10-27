namespace SalesWinApp
{
    partial class frmOrdersUpdate
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
            lbUpdate = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFreight = new MaskedTextBox();
            dtPShippedDate = new DateTimePicker();
            dtPRequiredDate = new DateTimePicker();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbUpdate
            // 
            lbUpdate.AutoSize = true;
            lbUpdate.Location = new Point(26, 30);
            lbUpdate.Name = "lbUpdate";
            lbUpdate.Size = new Size(243, 20);
            lbUpdate.TabIndex = 0;
            lbUpdate.Text = "You can only update Required Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 65);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Shipped Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Freight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Required Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 253);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Shipped Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 303);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(180, 300);
            txtFreight.Mask = "0000000";
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(221, 27);
            txtFreight.TabIndex = 6;
            txtFreight.Text = "0";
            txtFreight.ValidatingType = typeof(int);
            // 
            // dtPShippedDate
            // 
            dtPShippedDate.Location = new Point(180, 248);
            dtPShippedDate.MaxDate = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            dtPShippedDate.Name = "dtPShippedDate";
            dtPShippedDate.Size = new Size(250, 27);
            dtPShippedDate.TabIndex = 7;
            dtPShippedDate.Value = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // dtPRequiredDate
            // 
            dtPRequiredDate.Location = new Point(180, 202);
            dtPRequiredDate.MaxDate = new DateTime(2023, 12, 25, 23, 59, 59, 0);
            dtPRequiredDate.Name = "dtPRequiredDate";
            dtPRequiredDate.Size = new Size(250, 27);
            dtPRequiredDate.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(180, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(336, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOrdersUpdate
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(478, 484);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(dtPRequiredDate);
            Controls.Add(dtPShippedDate);
            Controls.Add(txtFreight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbUpdate);
            Name = "frmOrdersUpdate";
            Text = "frmOrdersUpdate";
            Load += frmOrdersUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtFreight;
        private DateTimePicker dtPShippedDate;
        private DateTimePicker dtPRequiredDate;
        private Button btnUpdate;
        private Button btnCancel;
    }
}