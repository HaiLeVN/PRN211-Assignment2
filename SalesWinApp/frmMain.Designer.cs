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
            menuStrip1.SuspendLayout();
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
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(148, 26);
            orderToolStripMenuItem.Text = "Order";
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
            welcomeMessage.Location = new Point(116, 113);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(128, 46);
            welcomeMessage.TabIndex = 9;
            welcomeMessage.Text = "Hello!!!";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1145, 616);
            Controls.Add(welcomeMessage);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management | FStore Admin";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmManage;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem1;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Label welcomeMessage;
    }
}