namespace SariScan
{
    partial class DashboardPage
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
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.cardTotal = new SariScan.CardPanel();
            this.pnlTotalBar = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalNote = new System.Windows.Forms.Label();
            this.cardLow = new SariScan.CardPanel();
            this.pnlLowBar = new System.Windows.Forms.Panel();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.lblLowNote = new System.Windows.Forms.Label();
            this.cardQueue = new SariScan.CardPanel();
            this.pnlQueueBar = new System.Windows.Forms.Panel();
            this.lblQueueTitle = new System.Windows.Forms.Label();
            this.lblQueueValue = new System.Windows.Forms.Label();
            this.lblQueueNote = new System.Windows.Forms.Label();
            this.cardSearch = new SariScan.CardPanel();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResName = new System.Windows.Forms.Label();
            this.lblResPrice = new System.Windows.Forms.Label();
            this.lblResQty = new System.Windows.Forms.Label();
            this.lblResStatus = new System.Windows.Forms.Label();
            this.cardSnapshot = new SariScan.CardPanel();
            this.gridSnapshot = new SariScan.StyledGrid();
            this.colSnapProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnapCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnapPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnapQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnapStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSnapHead = new System.Windows.Forms.Panel();
            this.lblSnapCount = new System.Windows.Forms.Label();
            this.lblSnapTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSnapshot)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardLow.SuspendLayout();
            this.cardQueue.SuspendLayout();
            this.cardSearch.SuspendLayout();
            this.flowResult.SuspendLayout();
            this.cardSnapshot.SuspendLayout();
            this.pnlSnapHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.Controls.Add(this.tlpStats, 0, 0);
            this.tlpRoot.Controls.Add(this.cardSearch, 0, 1);
            this.tlpRoot.Controls.Add(this.cardSnapshot, 0, 2);
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.tlpStats.ColumnCount = 3;
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.Controls.Add(this.cardTotal, 0, 0);
            this.tlpStats.Controls.Add(this.cardLow, 1, 0);
            this.tlpStats.Controls.Add(this.cardQueue, 2, 0);
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardTotal.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardTotal.Controls.Add(this.pnlTotalBar);
            this.cardTotal.Controls.Add(this.lblTotalTitle);
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Controls.Add(this.lblTotalNote);
            // 
            // pnlTotalBar
            // 
            this.pnlTotalBar.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.pnlTotalBar.Location = new System.Drawing.Point(22, 0);
            this.pnlTotalBar.Name = "pnlTotalBar";
            this.pnlTotalBar.Size = new System.Drawing.Size(40, 4);
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTotalTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Text = "Total Products";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.lblTotalValue.Location = new System.Drawing.Point(20, 40);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Text = "12";
            // 
            // lblTotalNote
            // 
            this.lblTotalNote.AutoSize = true;
            this.lblTotalNote.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTotalNote.Location = new System.Drawing.Point(22, 100);
            this.lblTotalNote.Name = "lblTotalNote";
            this.lblTotalNote.Text = "Registered in your store";
            // 
            // cardLow
            // 
            this.cardLow.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardLow.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLow.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardLow.Name = "cardLow";
            this.cardLow.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardLow.Controls.Add(this.pnlLowBar);
            this.cardLow.Controls.Add(this.lblLowTitle);
            this.cardLow.Controls.Add(this.lblLowValue);
            this.cardLow.Controls.Add(this.lblLowNote);
            // 
            // pnlLowBar
            // 
            this.pnlLowBar.BackColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.pnlLowBar.Location = new System.Drawing.Point(22, 0);
            this.pnlLowBar.Name = "pnlLowBar";
            this.pnlLowBar.Size = new System.Drawing.Size(40, 4);
            // 
            // lblLowTitle
            // 
            this.lblLowTitle.AutoSize = true;
            this.lblLowTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLowTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowTitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLowTitle.Location = new System.Drawing.Point(22, 18);
            this.lblLowTitle.Name = "lblLowTitle";
            this.lblLowTitle.Text = "Low Stock Items";
            // 
            // lblLowValue
            // 
            this.lblLowValue.AutoSize = true;
            this.lblLowValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowValue.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblLowValue.Location = new System.Drawing.Point(20, 40);
            this.lblLowValue.Name = "lblLowValue";
            this.lblLowValue.Text = "5";
            // 
            // lblLowNote
            // 
            this.lblLowNote.AutoSize = true;
            this.lblLowNote.BackColor = System.Drawing.Color.Transparent;
            this.lblLowNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLowNote.Location = new System.Drawing.Point(22, 100);
            this.lblLowNote.Name = "lblLowNote";
            this.lblLowNote.Text = "At or below the low-stock limit";
            // 
            // cardQueue
            // 
            this.cardQueue.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardQueue.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardQueue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardQueue.Name = "cardQueue";
            this.cardQueue.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardQueue.Controls.Add(this.pnlQueueBar);
            this.cardQueue.Controls.Add(this.lblQueueTitle);
            this.cardQueue.Controls.Add(this.lblQueueValue);
            this.cardQueue.Controls.Add(this.lblQueueNote);
            // 
            // pnlQueueBar
            // 
            this.pnlQueueBar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.pnlQueueBar.Location = new System.Drawing.Point(22, 0);
            this.pnlQueueBar.Name = "pnlQueueBar";
            this.pnlQueueBar.Size = new System.Drawing.Size(40, 4);
            // 
            // lblQueueTitle
            // 
            this.lblQueueTitle.AutoSize = true;
            this.lblQueueTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblQueueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueTitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblQueueTitle.Location = new System.Drawing.Point(22, 18);
            this.lblQueueTitle.Name = "lblQueueTitle";
            this.lblQueueTitle.Text = "Restock Queue";
            // 
            // lblQueueValue
            // 
            this.lblQueueValue.AutoSize = true;
            this.lblQueueValue.BackColor = System.Drawing.Color.Transparent;
            this.lblQueueValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueValue.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblQueueValue.Location = new System.Drawing.Point(20, 40);
            this.lblQueueValue.Name = "lblQueueValue";
            this.lblQueueValue.Text = "5";
            // 
            // lblQueueNote
            // 
            this.lblQueueNote.AutoSize = true;
            this.lblQueueNote.BackColor = System.Drawing.Color.Transparent;
            this.lblQueueNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblQueueNote.Location = new System.Drawing.Point(22, 100);
            this.lblQueueNote.Name = "lblQueueNote";
            this.lblQueueNote.Text = "Pending restock review";
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardSearch.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardSearch.Controls.Add(this.lblSearchTitle);
            this.cardSearch.Controls.Add(this.txtSearch);
            this.cardSearch.Controls.Add(this.btnSearch);
            this.cardSearch.Controls.Add(this.flowResult);
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSearchTitle.Location = new System.Drawing.Point(20, 14);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Text = "Quick Product Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtSearch.Location = new System.Drawing.Point(20, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Type a product name, e.g. Piattos";
            this.txtSearch.Size = new System.Drawing.Size(380, 27);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 185, 61);
            this.btnSearch.Location = new System.Drawing.Point(412, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // flowResult
            // 
            this.flowResult.AutoSize = true;
            this.flowResult.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.flowResult.Location = new System.Drawing.Point(20, 92);
            this.flowResult.Name = "flowResult";
            this.flowResult.Size = new System.Drawing.Size(520, 26);
            this.flowResult.WrapContents = false;
            this.flowResult.Controls.Add(this.lblResName);
            this.flowResult.Controls.Add(this.lblResPrice);
            this.flowResult.Controls.Add(this.lblResQty);
            this.flowResult.Controls.Add(this.lblResStatus);
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.BackColor = System.Drawing.Color.Transparent;
            this.lblResName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblResName.Name = "lblResName";
            this.lblResName.Text = "Piattos Cheese 40g";
            this.lblResName.Margin = new System.Windows.Forms.Padding(0, 0, 28, 0);
            // 
            // lblResPrice
            // 
            this.lblResPrice.AutoSize = true;
            this.lblResPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblResPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResPrice.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblResPrice.Name = "lblResPrice";
            this.lblResPrice.Text = "Price:  \u20B118.00";
            this.lblResPrice.Margin = new System.Windows.Forms.Padding(0, 0, 28, 0);
            // 
            // lblResQty
            // 
            this.lblResQty.AutoSize = true;
            this.lblResQty.BackColor = System.Drawing.Color.Transparent;
            this.lblResQty.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResQty.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblResQty.Name = "lblResQty";
            this.lblResQty.Text = "Qty:  32 pcs";
            this.lblResQty.Margin = new System.Windows.Forms.Padding(0, 0, 28, 0);
            // 
            // lblResStatus
            // 
            this.lblResStatus.AutoSize = true;
            this.lblResStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblResStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResStatus.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblResStatus.Name = "lblResStatus";
            this.lblResStatus.Text = "\u25CF  In Stock";
            this.lblResStatus.Margin = new System.Windows.Forms.Padding(0, 0, 28, 0);
            // 
            // cardSnapshot
            // 
            this.cardSnapshot.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardSnapshot.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSnapshot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardSnapshot.Name = "cardSnapshot";
            this.cardSnapshot.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardSnapshot.Controls.Add(this.gridSnapshot);
            this.cardSnapshot.Controls.Add(this.pnlSnapHead);
            // 
            // gridSnapshot
            // 
            this.gridSnapshot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colSnapProduct, this.colSnapCategory, this.colSnapPrice, this.colSnapQty, this.colSnapStatus});
            this.gridSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSnapshot.Name = "gridSnapshot";
            // 
            // colSnapProduct
            // 
            this.colSnapProduct.FillWeight = 220F;
            this.colSnapProduct.HeaderText = "PRODUCT";
            this.colSnapProduct.Name = "colSnapProduct";
            this.colSnapProduct.ReadOnly = true;
            this.colSnapProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSnapCategory
            // 
            this.colSnapCategory.FillWeight = 110F;
            this.colSnapCategory.HeaderText = "CATEGORY";
            this.colSnapCategory.Name = "colSnapCategory";
            this.colSnapCategory.ReadOnly = true;
            this.colSnapCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSnapPrice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSnapPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSnapPrice.FillWeight = 90F;
            this.colSnapPrice.HeaderText = "SELLING PRICE";
            this.colSnapPrice.Name = "colSnapPrice";
            this.colSnapPrice.ReadOnly = true;
            this.colSnapPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSnapQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSnapQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSnapQty.FillWeight = 80F;
            this.colSnapQty.HeaderText = "QUANTITY";
            this.colSnapQty.Name = "colSnapQty";
            this.colSnapQty.ReadOnly = true;
            this.colSnapQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSnapStatus
            // 
            this.colSnapStatus.FillWeight = 100F;
            this.colSnapStatus.HeaderText = "STATUS";
            this.colSnapStatus.Name = "colSnapStatus";
            this.colSnapStatus.ReadOnly = true;
            this.colSnapStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlSnapHead
            // 
            this.pnlSnapHead.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlSnapHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSnapHead.Name = "pnlSnapHead";
            this.pnlSnapHead.Size = new System.Drawing.Size(200, 40);
            this.pnlSnapHead.Controls.Add(this.lblSnapCount);
            this.pnlSnapHead.Controls.Add(this.lblSnapTitle);
            // 
            // lblSnapCount
            // 
            this.lblSnapCount.AutoSize = false;
            this.lblSnapCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSnapCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapCount.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSnapCount.Name = "lblSnapCount";
            this.lblSnapCount.Text = "Showing 8 of 12 products";
            this.lblSnapCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSnapCount.Size = new System.Drawing.Size(240, 40);
            this.lblSnapCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSnapTitle
            // 
            this.lblSnapTitle.AutoSize = false;
            this.lblSnapTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSnapTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSnapTitle.Name = "lblSnapTitle";
            this.lblSnapTitle.Text = "Inventory Snapshot";
            this.lblSnapTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSnapTitle.Size = new System.Drawing.Size(200, 40);
            this.lblSnapTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Size = new System.Drawing.Size(984, 640);
            this.Name = "DashboardPage";
            this.Controls.Add(this.tlpRoot);
            ((System.ComponentModel.ISupportInitialize)(this.gridSnapshot)).EndInit();
            this.tlpRoot.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardLow.ResumeLayout(false);
            this.cardQueue.ResumeLayout(false);
            this.cardSearch.ResumeLayout(false);
            this.flowResult.ResumeLayout(false);
            this.cardSnapshot.ResumeLayout(false);
            this.pnlSnapHead.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private SariScan.CardPanel cardTotal;
        private System.Windows.Forms.Panel pnlTotalBar;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalNote;
        private SariScan.CardPanel cardLow;
        private System.Windows.Forms.Panel pnlLowBar;
        private System.Windows.Forms.Label lblLowTitle;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Label lblLowNote;
        private SariScan.CardPanel cardQueue;
        private System.Windows.Forms.Panel pnlQueueBar;
        private System.Windows.Forms.Label lblQueueTitle;
        private System.Windows.Forms.Label lblQueueValue;
        private System.Windows.Forms.Label lblQueueNote;
        private SariScan.CardPanel cardSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowResult;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.Label lblResPrice;
        private System.Windows.Forms.Label lblResQty;
        private System.Windows.Forms.Label lblResStatus;
        private SariScan.CardPanel cardSnapshot;
        private SariScan.StyledGrid gridSnapshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnapProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnapCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnapPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnapQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnapStatus;
        private System.Windows.Forms.Panel pnlSnapHead;
        private System.Windows.Forms.Label lblSnapCount;
        private System.Windows.Forms.Label lblSnapTitle;
    }
}
