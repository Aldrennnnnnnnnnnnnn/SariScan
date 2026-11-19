namespace SariScan
{
    partial class AlertCard
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
            this.cardRoot = new SariScan.CardPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.pnlTrack = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestock = new System.Windows.Forms.Button();
            this.cardRoot.SuspendLayout();
            this.pnlTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardRoot
            // 
            this.cardRoot.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cardRoot.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.cardRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRoot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardRoot.Name = "cardRoot";
            this.cardRoot.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardRoot.Controls.Add(this.lblName);
            this.cardRoot.Controls.Add(this.lblCategory);
            this.cardRoot.Controls.Add(this.lblQty);
            this.cardRoot.Controls.Add(this.lblLimit);
            this.cardRoot.Controls.Add(this.pnlTrack);
            this.cardRoot.Controls.Add(this.lblStatus);
            this.cardRoot.Controls.Add(this.btnRestock);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblName.Location = new System.Drawing.Point(18, 14);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Product name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCategory.Location = new System.Drawing.Point(19, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Category";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblQty.Location = new System.Drawing.Point(18, 66);
            this.lblQty.Name = "lblQty";
            this.lblQty.Text = "9 pcs left";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = false;
            this.lblLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimit.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLimit.Location = new System.Drawing.Point(182, 70);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Text = "Limit: 10";
            this.lblLimit.Size = new System.Drawing.Size(110, 22);
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTrack
            // 
            this.pnlTrack.BackColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.pnlTrack.Location = new System.Drawing.Point(18, 106);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(274, 8);
            this.pnlTrack.Controls.Add(this.pnlFill);
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(137, 8);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblStatus.Location = new System.Drawing.Point(18, 128);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "\u25CF  Low Stock";
            // 
            // btnRestock
            // 
            this.btnRestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRestock.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnRestock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 224, 213);
            this.btnRestock.FlatAppearance.BorderSize = 1;
            this.btnRestock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(241, 237, 227);
            this.btnRestock.Location = new System.Drawing.Point(196, 122);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(96, 30);
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // AlertCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
            this.Size = new System.Drawing.Size(310, 166);
            this.Name = "AlertCard";
            this.Controls.Add(this.cardRoot);
            this.cardRoot.ResumeLayout(false);
            this.pnlTrack.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private SariScan.CardPanel cardRoot;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Panel pnlTrack;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestock;
    }
}
