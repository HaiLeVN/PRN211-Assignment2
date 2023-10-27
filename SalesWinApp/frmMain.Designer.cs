namespace SalesWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            tsmManage = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem1 = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            welcomeMessage = new Label();
            lbGuide = new Label();
            dgvProducts = new DataGridView();
            btnBuy = new Button();
            llabelViewOrder = new LinkLabel();
            lbGuide2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmManage, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1145, 30);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmManage
            // 
            tsmManage.DropDownItems.AddRange(new ToolStripItem[] { memberToolStripMenuItem, productToolStripMenuItem1, orderToolStripMenuItem });
            tsmManage.Name = "tsmManage";
            tsmManage.Size = new Size(77, 24);
            tsmManage.Text = "Manage";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(148, 26);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem1
            // 
            productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            productToolStripMenuItem1.Size = new Size(148, 26);
            productToolStripMenuItem1.Text = "Product";
            productToolStripMenuItem1.Click += productToolStripMenuItem1_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(148, 26);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // welcomeMessage
            // 
            welcomeMessage.AutoSize = true;
            welcomeMessage.BackColor = Color.DarkGray;
            welcomeMessage.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeMessage.Location = new Point(28, 44);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(128, 46);
            welcomeMessage.TabIndex = 9;
            welcomeMessage.Text = "Hello!!!";
            // 
            // lbGuide
            // 
            lbGuide.AutoSize = true;
            lbGuide.BackColor = SystemColors.AppWorkspace;
            lbGuide.Location = new Point(599, 360);
            lbGuide.Name = "lbGuide";
            lbGuide.Size = new Size(386, 20);
            lbGuide.TabIndex = 11;
            lbGuide.Text = "Order a Product? Click a Product above then click Buy =>";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(367, 62);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(748, 259);
            dgvProducts.TabIndex = 12;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(1005, 356);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(94, 29);
            btnBuy.TabIndex = 13;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // llabelViewOrder
            // 
            llabelViewOrder.AutoSize = true;
            llabelViewOrder.BackColor = SystemColors.AppWorkspace;
            llabelViewOrder.Location = new Point(389, 360);
            llabelViewOrder.Name = "llabelViewOrder";
            llabelViewOrder.Size = new Size(134, 20);
            llabelViewOrder.TabIndex = 16;
            llabelViewOrder.TabStop = true;
            llabelViewOrder.Text = "View Order History";
            llabelViewOrder.LinkClicked += llabelViewOrder_LinkClicked;
            // 
            // lbGuide2
            // 
            lbGuide2.AutoSize = true;
            lbGuide2.BackColor = SystemColors.AppWorkspace;
            lbGuide2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbGuide2.Location = new Point(28, 570);
            lbGuide2.Name = "lbGuide2";
            lbGuide2.Size = new Size(751, 23);
            lbGuide2.TabIndex = 18;
            lbGuide2.Text = "We currently make you order one product? Please stay tune before an update add to cart feature";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1145, 616);
            Controls.Add(lbGuide2);
            Controls.Add(llabelViewOrder);
            Controls.Add(btnBuy);
            Controls.Add(dgvProducts);
            Controls.Add(lbGuide);
            Controls.Add(welcomeMessage);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management | FStore Admin";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmManage;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem1;
        private Label welcomeMessage;
        private Label lbGuide;
        private ToolStripMenuItem orderToolStripMenuItem;
        private DataGridView dgvProducts;
        private Button btnBuy;
        private LinkLabel llabelViewOrder;
        private Label lbGuide2;
    }
}