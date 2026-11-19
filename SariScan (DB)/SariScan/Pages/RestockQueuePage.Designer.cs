namespace SariScan
{
    partial class RestockQueuePage
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
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.cardBanner = new SariScan.CardPanel();
            this.lblBanner1 = new System.Windows.Forms.Label();
            this.lblBanner2 = new System.Windows.Forms.Label();
            this.cardQueue = new SariScan.CardPanel();
            this.gridQueue = new SariScan.StyledGrid();
            this.colQPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQFlagged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQueueButtons = new System.Windows.Forms.Panel();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridQueue)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.cardBanner.SuspendLayout();
            this.cardQueue.SuspendLayout();
            this.pnlQueueButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.Controls.Add(this.cardBanner, 0, 0);
            this.tlpRoot.Controls.Add(this.cardQueue, 0, 1);
            // 
            // cardBanner
            // 
            this.cardBanner.BackColor = System.Drawing.Color.FromArgb(255, 248, 230);
            this.cardBanner.BorderColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.cardBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBanner.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.cardBanner.Name = "cardBanner";
            this.cardBanner.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardBanner.Controls.Add(this.lblBanner1);
            this.cardBanner.Controls.Add(this.lblBanner2);
            // 
            // lblBanner1
            // 
            this.lblBanner1.AutoSize = true;
            this.lblBanner1.BackColor = System.Drawing.Color.Transparent;
            this.lblBanner1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner1.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblBanner1.Location = new System.Drawing.Point(18, 12);
            this.lblBanner1.Name = "lblBanner1";
            this.lblBanner1.Text = "First-in, first-out:  the product at the top was flagged first, so review it first.";
            // 
            // lblBanner2
            // 
            this.lblBanner2.AutoSize = true;
            this.lblBanner2.BackColor = System.Drawing.Color.Transparent;
            this.lblBanner2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner2.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblBanner2.Location = new System.Drawing.Point(18, 36);
            this.lblBanner2.Name = "lblBanner2";
            this.lblBanner2.Text = "A product enters the queue once while it is pending, and leaves after you restock or remove it.";
            // 
            // cardQueue
            // 
            this.cardQueue.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardQueue.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardQueue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardQueue.Name = "cardQueue";
            this.cardQueue.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardQueue.Controls.Add(this.gridQueue);
            this.cardQueue.Controls.Add(this.pnlQueueButtons);
            // 
            // gridQueue
            // 
            this.gridQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colQPos, this.colQProduct, this.colQCategory, this.colQQty, this.colQLimit, this.colQFlagged, this.colQStatus});
            this.gridQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQueue.Name = "gridQueue";
            // 
            // colQPos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQPos.DefaultCellStyle = dataGridViewCellStyle1;
            this.colQPos.FillWeight = 30F;
            this.colQPos.HeaderText = "#";
            this.colQPos.Name = "colQPos";
            this.colQPos.ReadOnly = true;
            this.colQPos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQProduct
            // 
            this.colQProduct.FillWeight = 200F;
            this.colQProduct.HeaderText = "PRODUCT";
            this.colQProduct.Name = "colQProduct";
            this.colQProduct.ReadOnly = true;
            this.colQProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQCategory
            // 
            this.colQCategory.FillWeight = 110F;
            this.colQCategory.HeaderText = "CATEGORY";
            this.colQCategory.Name = "colQCategory";
            this.colQCategory.ReadOnly = true;
            this.colQCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQQty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQQty.FillWeight = 70F;
            this.colQQty.HeaderText = "QTY LEFT";
            this.colQQty.Name = "colQQty";
            this.colQQty.ReadOnly = true;
            this.colQQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQLimit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQLimit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQLimit.FillWeight = 60F;
            this.colQLimit.HeaderText = "LIMIT";
            this.colQLimit.Name = "colQLimit";
            this.colQLimit.ReadOnly = true;
            this.colQLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQFlagged
            // 
            this.colQFlagged.FillWeight = 150F;
            this.colQFlagged.HeaderText = "DATE FLAGGED";
            this.colQFlagged.Name = "colQFlagged";
            this.colQFlagged.ReadOnly = true;
            this.colQFlagged.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQStatus
            // 
            this.colQStatus.FillWeight = 100F;
            this.colQStatus.HeaderText = "STATUS";
            this.colQStatus.Name = "colQStatus";
            this.colQStatus.ReadOnly = true;
            this.colQStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlQueueButtons
            // 
            this.pnlQueueButtons.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlQueueButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlQueueButtons.Name = "pnlQueueButtons";
            this.pnlQueueButtons.Size = new System.Drawing.Size(100, 58);
            this.pnlQueueButtons.Controls.Add(this.btnRestock);
            this.pnlQueueButtons.Controls.Add(this.btnRemove);
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
            this.btnRestock.Location = new System.Drawing.Point(0, 14);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(170, 38);
            this.btnRestock.Text = "Restock Selected";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.btnRemove.FlatAppearance.BorderSize = 1;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 237, 227);
            this.btnRemove.Location = new System.Drawing.Point(182, 14);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 38);
            this.btnRemove.Text = "Remove from Queue";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // RestockQueuePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Size = new System.Drawing.Size(984, 640);
            this.Name = "RestockQueuePage";
            this.Controls.Add(this.tlpRoot);
            ((System.ComponentModel.ISupportInitialize)(this.gridQueue)).EndInit();
            this.tlpRoot.ResumeLayout(false);
            this.cardBanner.ResumeLayout(false);
            this.cardQueue.ResumeLayout(false);
            this.pnlQueueButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private SariScan.CardPanel cardBanner;
        private System.Windows.Forms.Label lblBanner1;
        private System.Windows.Forms.Label lblBanner2;
        private SariScan.CardPanel cardQueue;
        private SariScan.StyledGrid gridQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQFlagged;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQStatus;
        private System.Windows.Forms.Panel pnlQueueButtons;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnRemove;
    }
}
