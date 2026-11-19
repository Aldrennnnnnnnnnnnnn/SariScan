namespace SariScan
{
    partial class LowStockPage
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
            this.flowAlerts = new System.Windows.Forms.FlowLayoutPanel();
            this.cardBanner = new SariScan.CardPanel();
            this.lblBanner = new System.Windows.Forms.Label();
            this.cardBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowAlerts
            // 
            this.flowAlerts.AutoScroll = true;
            this.flowAlerts.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.flowAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowAlerts.Name = "flowAlerts";
            this.flowAlerts.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            // 
            // cardBanner
            // 
            this.cardBanner.BackColor = System.Drawing.Color.FromArgb(255, 248, 230);
            this.cardBanner.BorderColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.cardBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardBanner.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardBanner.Name = "cardBanner";
            this.cardBanner.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.cardBanner.Size = new System.Drawing.Size(200, 60);
            this.cardBanner.Controls.Add(this.lblBanner);
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblBanner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.FromArgb(178, 106, 0);
            this.lblBanner.Location = new System.Drawing.Point(20, 18);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Text = "\u26A0   5 products are at or below their low-stock limit.";
            // 
            // LowStockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 243, 236);
            this.Size = new System.Drawing.Size(984, 640);
            this.Name = "LowStockPage";
            this.Controls.Add(this.flowAlerts);
            this.Controls.Add(this.cardBanner);
            this.cardBanner.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowAlerts;
        private SariScan.CardPanel cardBanner;
        private System.Windows.Forms.Label lblBanner;
    }
}
