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
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            maskedTextBox5 = new MaskedTextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 264);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 5;
            label6.Text = "Freight";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(202, 38);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(299, 27);
            maskedTextBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(202, 80);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(299, 27);
            maskedTextBox2.TabIndex = 7;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(202, 126);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(299, 27);
            maskedTextBox3.TabIndex = 8;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(202, 166);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(299, 27);
            maskedTextBox4.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(202, 212);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(202, 261);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(299, 27);
            maskedTextBox5.TabIndex = 11;
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
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(label7);
            Controls.Add(maskedTextBox5);
            Controls.Add(numericUpDown1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox maskedTextBox5;
        private Label label7;
    }
}