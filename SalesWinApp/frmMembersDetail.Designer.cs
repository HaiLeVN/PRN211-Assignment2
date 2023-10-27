namespace SalesWinApp
{
    partial class frmMembersDetail
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
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new MaskedTextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 52);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 103);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 153);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 205);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 263);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(190, 100);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(256, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(190, 150);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(256, 27);
            txtCity.TabIndex = 7;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(184, 205);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(262, 27);
            txtCountry.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(184, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Location = new Point(184, 327);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(352, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMembersDetail
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(536, 424);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMembersDetail";
            Text = "frmMembersDetail";
            Load += frmMembersDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private MaskedTextBox txtPassword;
        private Button btnSubmit;
        private Button btnCancel;
    }
}