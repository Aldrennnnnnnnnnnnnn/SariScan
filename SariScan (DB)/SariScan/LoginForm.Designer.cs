namespace SariScan
{
    partial class LoginForm
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.pnlBrandAccent = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.lblPoint3 = new System.Windows.Forms.Label();
            this.pnlRight.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.chkShowPassword);
            this.pnlRight.Controls.Add(this.btnSignIn);
            this.pnlRight.Controls.Add(this.lblNote);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblWelcome.Location = new System.Drawing.Point(60, 76);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome back";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(60, 122);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Sign in to manage your store inventory";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblUsername.Location = new System.Drawing.Point(60, 176);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtUsername.Location = new System.Drawing.Point(60, 200);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter your username";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPassword.Location = new System.Drawing.Point(60, 250);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.txtPassword.Location = new System.Drawing.Point(60, 274);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.chkShowPassword.Location = new System.Drawing.Point(60, 314);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 185, 61);
            this.btnSignIn.Location = new System.Drawing.Point(60, 354);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(360, 46);
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNote.Location = new System.Drawing.Point(60, 428);
            this.lblNote.Name = "lblNote";
            this.lblNote.Text = "For authorized store owners and attendants only.";
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(31, 61, 43);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(380, 520);
            this.pnlBrand.Controls.Add(this.pnlBrandAccent);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.lblTagline);
            this.pnlBrand.Controls.Add(this.lblPoint1);
            this.pnlBrand.Controls.Add(this.lblPoint2);
            this.pnlBrand.Controls.Add(this.lblPoint3);
            // 
            // pnlBrandAccent
            // 
            this.pnlBrandAccent.BackColor = System.Drawing.Color.FromArgb(245, 166, 35);
            this.pnlBrandAccent.Location = new System.Drawing.Point(48, 96);
            this.pnlBrandAccent.Name = "pnlBrandAccent";
            this.pnlBrandAccent.Size = new System.Drawing.Size(48, 5);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblBrand.Location = new System.Drawing.Point(44, 112);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Text = "SariScan";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(157, 184, 166);
            this.lblTagline.Location = new System.Drawing.Point(48, 172);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Text = "Inventory and Price Checker\nfor small sari-sari stores";
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint1.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.lblPoint1.Location = new System.Drawing.Point(48, 296);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Text = "\u2713   Check prices in seconds";
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint2.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.lblPoint2.Location = new System.Drawing.Point(48, 330);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Text = "\u2713   Always know what's left on the shelf";
            // 
            // lblPoint3
            // 
            this.lblPoint3.AutoSize = true;
            this.lblPoint3.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint3.ForeColor = System.Drawing.Color.FromArgb(220, 232, 224);
            this.lblPoint3.Location = new System.Drawing.Point(48, 364);
            this.lblPoint3.Name = "lblPoint3";
            this.lblPoint3.Text = "\u2713   Never miss an item that needs restocking";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AcceptButton = this.btnSignIn;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SariScan \u2013 Sign In";
            this.Name = "LoginForm";
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlBrand);
            this.pnlRight.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Panel pnlBrandAccent;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Label lblPoint3;
    }
}
