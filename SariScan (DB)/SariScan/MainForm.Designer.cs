namespace SariScan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dashboardPage = new SariScan.DashboardPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblAvatar = new SariScan.AvatarLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 22, 28, 24);
            this.pnlContent.Controls.Add(this.dashboardPage);
            // 
            // dashboardPage
            // 
            this.dashboardPage.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.dashboardPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPage.Name = "dashboardPage";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 78);
            this.pnlHeader.Controls.Add(this.pnlUser);
            this.pnlHeader.Controls.Add(this.pnlHeaderLine);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(240, 78);
            this.pnlUser.Controls.Add(this.lblAvatar);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.lblUserRole);
            // 
            // lblAvatar
            // 
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.lblAvatar.Location = new System.Drawing.Point(10, 19);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 38);
            this.lblAvatar.Text = "SO";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblUserName.Location = new System.Drawing.Point(60, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Text = "Store Owner";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblUserRole.Location = new System.Drawing.Point(61, 42);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Text = "Administrator";
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(100, 1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitle.Location = new System.Drawing.Point(28, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Dashboard";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.AutoSize = true;
            this.lblPageSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPageSubtitle.Location = new System.Drawing.Point(30, 46);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Text = "A quick summary of your store's inventory and restocking";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 780);
            this.pnlSidebar.Controls.Add(this.pnlIndicator);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnQueue);
            this.pnlSidebar.Controls.Add(this.btnAlerts);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.pnlFooter);
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.pnlIndicator.Location = new System.Drawing.Point(0, 112);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(4, 46);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnDashboard.Location = new System.Drawing.Point(0, 112);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(240, 46);
            this.btnDashboard.Tag = "dashboard";
            this.btnDashboard.Text = "\u25A6    Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.btnProducts.Location = new System.Drawing.Point(0, 164);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(240, 46);
            this.btnProducts.Tag = "products";
            this.btnProducts.Text = "\u25A4    Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.btnInventory.Location = new System.Drawing.Point(0, 216);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(240, 46);
            this.btnInventory.Tag = "inventory";
            this.btnInventory.Text = "\u2630    Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueue.FlatAppearance.BorderSize = 0;
            this.btnQueue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.btnQueue.Location = new System.Drawing.Point(0, 268);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnQueue.Size = new System.Drawing.Size(240, 46);
            this.btnQueue.Tag = "queue";
            this.btnQueue.Text = "\u27F3    Restock Queue";
            this.btnQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueue.UseVisualStyleBackColor = false;
            this.btnQueue.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnAlerts
            // 
            this.btnAlerts.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnAlerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerts.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.btnAlerts.Location = new System.Drawing.Point(0, 320);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnAlerts.Size = new System.Drawing.Size(240, 46);
            this.btnAlerts.Tag = "alerts";
            this.btnAlerts.Text = "\u26A0    Low Stock Alerts";
            this.btnAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerts.UseVisualStyleBackColor = false;
            this.btnAlerts.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblLogo.Location = new System.Drawing.Point(24, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Text = "SariScan";
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.BackColor = System.Drawing.Color.Transparent;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(157, 184, 166);
            this.lblLogoSub.Location = new System.Drawing.Point(26, 58);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Text = "Inventory & Price Checker";
            this.lblLogoSub.UseMnemonic = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(240, 76);
            this.pnlFooter.Controls.Add(this.btnLogout);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(47, 90, 63);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(157, 184, 166);
            this.btnLogout.Location = new System.Drawing.Point(0, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 46);
            this.btnLogout.Text = "\u23FB    Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SariScan \u2013 Inventory and Price Checker";
            this.Name = "MainForm";
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private SariScan.DashboardPage dashboardPage;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlUser;
        private SariScan.AvatarLabel lblAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnLogout;
    }
}
