namespace SariScan
{
    partial class RestockDialog
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblQtyCaption = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblDateCaption = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cardPreview = new SariScan.CardPanel();
            this.lblNewTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.cardPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitle.Location = new System.Drawing.Point(28, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Restock Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProduct.Location = new System.Drawing.Point(28, 70);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Text = "Product name";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCurrent.Location = new System.Drawing.Point(29, 96);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Text = "Current stock: 12 pcs";
            // 
            // lblQtyCaption
            // 
            this.lblQtyCaption.AutoSize = true;
            this.lblQtyCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblQtyCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblQtyCaption.Location = new System.Drawing.Point(28, 140);
            this.lblQtyCaption.Name = "lblQtyCaption";
            this.lblQtyCaption.Text = "QUANTITY RECEIVED";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(28, 162);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(384, 29);
            this.nudQty.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.nudQty.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.Value = new decimal(new int[] {24, 0, 0, 0});
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // lblDateCaption
            // 
            this.lblDateCaption.AutoSize = true;
            this.lblDateCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblDateCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDateCaption.Location = new System.Drawing.Point(28, 210);
            this.lblDateCaption.Name = "lblDateCaption";
            this.lblDateCaption.Text = "DELIVERY DATE";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(28, 232);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(384, 27);
            // 
            // cardPreview
            // 
            this.cardPreview.BackColor = System.Drawing.Color.FromArgb(230, 244, 231);
            this.cardPreview.BorderColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.cardPreview.Location = new System.Drawing.Point(28, 284);
            this.cardPreview.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardPreview.Name = "cardPreview";
            this.cardPreview.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardPreview.Size = new System.Drawing.Size(384, 52);
            this.cardPreview.Controls.Add(this.lblNewTotal);
            // 
            // lblNewTotal
            // 
            this.lblNewTotal.AutoSize = true;
            this.lblNewTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblNewTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTotal.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblNewTotal.Location = new System.Drawing.Point(16, 14);
            this.lblNewTotal.Name = "lblNewTotal";
            this.lblNewTotal.Text = "New stock total:  36 pcs";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 237, 227);
            this.btnCancel.Location = new System.Drawing.Point(132, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 185, 61);
            this.btnConfirm.Location = new System.Drawing.Point(272, 358);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 38);
            this.btnConfirm.Text = "Confirm Restock";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // RestockDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AcceptButton = this.btnConfirm;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(440, 410);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restock Product";
            this.Name = "RestockDialog";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblQtyCaption);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.lblDateCaption);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cardPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.cardPreview.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblQtyCaption;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label lblDateCaption;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private SariScan.CardPanel cardPreview;
        private System.Windows.Forms.Label lblNewTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}
