namespace SariScan
{
    partial class InventoryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardInventory = new SariScan.CardPanel();
            this.gridInventory = new SariScan.StyledGrid();
            this.colInvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlToolbarLeft = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.pnlToolbarRight = new System.Windows.Forms.Panel();
            this.btnRestock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            this.cardInventory.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlToolbarLeft.SuspendLayout();
            this.pnlToolbarRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardInventory
            // 
            this.cardInventory.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardInventory.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInventory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardInventory.Name = "cardInventory";
            this.cardInventory.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardInventory.Controls.Add(this.gridInventory);
            this.cardInventory.Controls.Add(this.pnlToolbar);
            // 
            // gridInventory
            // 
            this.gridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colInvProduct, this.colInvCategory, this.colInvPrice, this.colInvQty, this.colInvLimit, this.colInvStatus});
            this.gridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInventory.Name = "gridInventory";
            // 
            // colInvProduct
            // 
            this.colInvProduct.FillWeight = 220F;
            this.colInvProduct.HeaderText = "PRODUCT";
            this.colInvProduct.Name = "colInvProduct";
            this.colInvProduct.ReadOnly = true;
            this.colInvProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvCategory
            // 
            this.colInvCategory.FillWeight = 120F;
            this.colInvCategory.HeaderText = "CATEGORY";
            this.colInvCategory.Name = "colInvCategory";
            this.colInvCategory.ReadOnly = true;
            this.colInvCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvPrice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colInvPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colInvPrice.FillWeight = 100F;
            this.colInvPrice.HeaderText = "SELLING PRICE";
            this.colInvPrice.Name = "colInvPrice";
            this.colInvPrice.ReadOnly = true;
            this.colInvPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colInvQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colInvQty.FillWeight = 80F;
            this.colInvQty.HeaderText = "QUANTITY";
            this.colInvQty.Name = "colInvQty";
            this.colInvQty.ReadOnly = true;
            this.colInvQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvLimit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colInvLimit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvLimit.FillWeight = 100F;
            this.colInvLimit.HeaderText = "LOW-STOCK LIMIT";
            this.colInvLimit.Name = "colInvLimit";
            this.colInvLimit.ReadOnly = true;
            this.colInvLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvStatus
            // 
            this.colInvStatus.FillWeight = 110F;
            this.colInvStatus.HeaderText = "STATUS";
            this.colInvStatus.Name = "colInvStatus";
            this.colInvStatus.ReadOnly = true;
            this.colInvStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(100, 56);
            this.pnlToolbar.Controls.Add(this.pnlToolbarLeft);
            this.pnlToolbar.Controls.Add(this.pnlToolbarRight);
            // 
            // pnlToolbarLeft
            // 
            this.pnlToolbarLeft.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlToolbarLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolbarLeft.Name = "pnlToolbarLeft";
            this.pnlToolbarLeft.Controls.Add(this.txtSearch);
            this.pnlToolbarLeft.Controls.Add(this.cboCategory);
            this.pnlToolbarLeft.Controls.Add(this.cboStatus);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtSearch.Location = new System.Drawing.Point(0, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by name or category\u2026";
            this.txtSearch.Size = new System.Drawing.Size(260, 27);
            // 
            // cboCategory
            // 
            this.cboCategory.Items.AddRange(new object[] {"All Categories", "Snacks", "Biscuits", "Candies", "Instant Noodles", "Canned Goods", "Beverages", "Toiletries", "Household"});
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(272, 9);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.SelectedIndex = 0;
            this.cboCategory.Size = new System.Drawing.Size(170, 29);
            // 
            // cboStatus
            // 
            this.cboStatus.Items.AddRange(new object[] {"All Status", "In Stock", "Low Stock", "Out of Stock"});
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(454, 9);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.SelectedIndex = 0;
            this.cboStatus.Size = new System.Drawing.Size(150, 29);
            // 
            // pnlToolbarRight
            // 
            this.pnlToolbarRight.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlToolbarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbarRight.Name = "pnlToolbarRight";
            this.pnlToolbarRight.Size = new System.Drawing.Size(170, 56);
            this.pnlToolbarRight.Controls.Add(this.btnRestock);
            // 
            // btnRestock
            // 
            this.btnRestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnRestock.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 185, 61);
            this.btnRestock.Location = new System.Drawing.Point(6, 5);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(164, 38);
            this.btnRestock.Text = "Restock Selected";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Size = new System.Drawing.Size(984, 640);
            this.Name = "InventoryPage";
            this.Controls.Add(this.cardInventory);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            this.cardInventory.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbarLeft.ResumeLayout(false);
            this.pnlToolbarRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private SariScan.CardPanel cardInventory;
        private SariScan.StyledGrid gridInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvStatus;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlToolbarLeft;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Panel pnlToolbarRight;
        private System.Windows.Forms.Button btnRestock;
    }
}
