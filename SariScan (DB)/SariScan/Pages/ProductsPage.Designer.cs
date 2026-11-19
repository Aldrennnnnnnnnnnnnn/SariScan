namespace SariScan
{
    partial class ProductsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.cardList = new SariScan.CardPanel();
            this.gridProducts = new SariScan.StyledGrid();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cardForm = new SariScan.CardPanel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblFCategory = new System.Windows.Forms.Label();
            this.cboFormCategory = new System.Windows.Forms.ComboBox();
            this.lblFCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblFPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblFQty = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblFLimit = new System.Windows.Forms.Label();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.cardList.SuspendLayout();
            this.pnlListToolbar.SuspendLayout();
            this.cardForm.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 1;
            this.tlpRoot.Controls.Add(this.cardList, 0, 0);
            this.tlpRoot.Controls.Add(this.cardForm, 1, 0);
            // 
            // cardList
            // 
            this.cardList.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardList.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardList.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardList.Name = "cardList";
            this.cardList.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardList.Controls.Add(this.gridProducts);
            this.cardList.Controls.Add(this.pnlListToolbar);
            // 
            // gridProducts
            // 
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colProdName, this.colProdCategory, this.colProdCost, this.colProdPrice, this.colProdQty, this.colProdLimit, this.colProdStatus});
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Name = "gridProducts";
            // 
            // colProdName
            // 
            this.colProdName.FillWeight = 200F;
            this.colProdName.HeaderText = "PRODUCT";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            this.colProdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdCategory
            // 
            this.colProdCategory.FillWeight = 110F;
            this.colProdCategory.HeaderText = "CATEGORY";
            this.colProdCategory.Name = "colProdCategory";
            this.colProdCategory.ReadOnly = true;
            this.colProdCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdCost
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProdCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.colProdCost.FillWeight = 70F;
            this.colProdCost.HeaderText = "COST";
            this.colProdCost.Name = "colProdCost";
            this.colProdCost.ReadOnly = true;
            this.colProdCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProdPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProdPrice.FillWeight = 70F;
            this.colProdPrice.HeaderText = "PRICE";
            this.colProdPrice.Name = "colProdPrice";
            this.colProdPrice.ReadOnly = true;
            this.colProdPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProdQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProdQty.FillWeight = 50F;
            this.colProdQty.HeaderText = "QTY";
            this.colProdQty.Name = "colProdQty";
            this.colProdQty.ReadOnly = true;
            this.colProdQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdLimit
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProdLimit.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProdLimit.FillWeight = 50F;
            this.colProdLimit.HeaderText = "LIMIT";
            this.colProdLimit.Name = "colProdLimit";
            this.colProdLimit.ReadOnly = true;
            this.colProdLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProdStatus
            // 
            this.colProdStatus.FillWeight = 100F;
            this.colProdStatus.HeaderText = "STATUS";
            this.colProdStatus.Name = "colProdStatus";
            this.colProdStatus.ReadOnly = true;
            this.colProdStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlListToolbar
            // 
            this.pnlListToolbar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlListToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListToolbar.Name = "pnlListToolbar";
            this.pnlListToolbar.Size = new System.Drawing.Size(100, 54);
            this.pnlListToolbar.Controls.Add(this.txtSearch);
            this.pnlListToolbar.Controls.Add(this.cboCategory);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by product name\u2026";
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
            this.cboCategory.Location = new System.Drawing.Point(272, 8);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.SelectedIndex = 0;
            this.cboCategory.Size = new System.Drawing.Size(190, 29);
            // 
            // cardForm
            // 
            this.cardForm.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardForm.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardForm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardForm.Name = "cardForm";
            this.cardForm.Padding = new System.Windows.Forms.Padding(20, 18, 20, 16);
            this.cardForm.Controls.Add(this.pnlForm);
            this.cardForm.Controls.Add(this.lblFormTitle);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Controls.Add(this.lblFName);
            this.pnlForm.Controls.Add(this.txtProductName);
            this.pnlForm.Controls.Add(this.lblFCategory);
            this.pnlForm.Controls.Add(this.cboFormCategory);
            this.pnlForm.Controls.Add(this.lblFCost);
            this.pnlForm.Controls.Add(this.nudCost);
            this.pnlForm.Controls.Add(this.lblFPrice);
            this.pnlForm.Controls.Add(this.nudPrice);
            this.pnlForm.Controls.Add(this.lblFQty);
            this.pnlForm.Controls.Add(this.nudQuantity);
            this.pnlForm.Controls.Add(this.lblFLimit);
            this.pnlForm.Controls.Add(this.nudLimit);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFName.Location = new System.Drawing.Point(0, 6);
            this.lblFName.Name = "lblFName";
            this.lblFName.Text = "PRODUCT NAME";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtProductName.Location = new System.Drawing.Point(0, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "e.g. Lucky Me Pancit Canton";
            this.txtProductName.Size = new System.Drawing.Size(296, 27);
            // 
            // lblFCategory
            // 
            this.lblFCategory.AutoSize = true;
            this.lblFCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblFCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCategory.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFCategory.Location = new System.Drawing.Point(0, 70);
            this.lblFCategory.Name = "lblFCategory";
            this.lblFCategory.Text = "CATEGORY";
            // 
            // cboFormCategory
            // 
            this.cboFormCategory.Items.AddRange(new object[] {"Snacks", "Biscuits", "Candies", "Instant Noodles", "Canned Goods", "Beverages", "Toiletries", "Household"});
            this.cboFormCategory.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cboFormCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFormCategory.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormCategory.FormattingEnabled = true;
            this.cboFormCategory.Location = new System.Drawing.Point(0, 92);
            this.cboFormCategory.Name = "cboFormCategory";
            this.cboFormCategory.SelectedIndex = 0;
            this.cboFormCategory.Size = new System.Drawing.Size(296, 29);
            // 
            // lblFCost
            // 
            this.lblFCost.AutoSize = true;
            this.lblFCost.BackColor = System.Drawing.Color.Transparent;
            this.lblFCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCost.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFCost.Location = new System.Drawing.Point(0, 134);
            this.lblFCost.Name = "lblFCost";
            this.lblFCost.Text = "PURCHASE COST (\u20B1)  \u2014  OPTIONAL";
            // 
            // nudCost
            // 
            this.nudCost.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCost.Location = new System.Drawing.Point(0, 156);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(296, 29);
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            // 
            // lblFPrice
            // 
            this.lblFPrice.AutoSize = true;
            this.lblFPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPrice.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFPrice.Location = new System.Drawing.Point(0, 198);
            this.lblFPrice.Name = "lblFPrice";
            this.lblFPrice.Text = "SELLING PRICE (\u20B1)";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(0, 220);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(296, 29);
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            // 
            // lblFQty
            // 
            this.lblFQty.AutoSize = true;
            this.lblFQty.BackColor = System.Drawing.Color.Transparent;
            this.lblFQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFQty.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFQty.Location = new System.Drawing.Point(0, 262);
            this.lblFQty.Name = "lblFQty";
            this.lblFQty.Text = "QUANTITY";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(0, 284);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(296, 29);
            this.nudQuantity.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            // 
            // lblFLimit
            // 
            this.lblFLimit.AutoSize = true;
            this.lblFLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblFLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLimit.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFLimit.Location = new System.Drawing.Point(0, 326);
            this.lblFLimit.Name = "lblFLimit";
            this.lblFLimit.Text = "LOW-STOCK LIMIT";
            // 
            // nudLimit
            // 
            this.nudLimit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLimit.Location = new System.Drawing.Point(0, 348);
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(296, 29);
            this.nudLimit.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 185, 61);
            this.btnAdd.Location = new System.Drawing.Point(0, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 38);
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.btnUpdate.FlatAppearance.BorderSize = 1;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 237, 227);
            this.btnUpdate.Location = new System.Drawing.Point(152, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 38);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(216, 64, 64);
            this.btnDelete.Location = new System.Drawing.Point(0, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 38);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 237, 227);
            this.btnClear.Location = new System.Drawing.Point(152, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 38);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Text = "Product Details";
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Size = new System.Drawing.Size(300, 34);
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Size = new System.Drawing.Size(984, 640);
            this.Name = "ProductsPage";
            this.Controls.Add(this.tlpRoot);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.tlpRoot.ResumeLayout(false);
            this.cardList.ResumeLayout(false);
            this.pnlListToolbar.ResumeLayout(false);
            this.cardForm.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private SariScan.CardPanel cardList;
        private SariScan.StyledGrid gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdStatus;
        private System.Windows.Forms.Panel pnlListToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private SariScan.CardPanel cardForm;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblFCategory;
        private System.Windows.Forms.ComboBox cboFormCategory;
        private System.Windows.Forms.Label lblFCost;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblFPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblFQty;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblFLimit;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFormTitle;
    }
}
