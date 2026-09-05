using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandTagline;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Label lblSignInSub;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblMessage;

        private void InitializeComponent()
        {
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandTagline = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.lblSignInSub = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlBrand.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBrand
            //
            this.pnlBrand.BackColor = UITheme.Primary;
            this.pnlBrand.Controls.Add(this.lblBrandTagline);
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Size = new System.Drawing.Size(380, 540);
            //
            // lblBrandTitle
            //
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = UITheme.FontTitle;
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(45, 220);
            this.lblBrandTitle.Text = "Krishi Setu";
            //
            // lblBrandTagline
            //
            this.lblBrandTagline.AutoSize = false;
            this.lblBrandTagline.Font = UITheme.FontBody;
            this.lblBrandTagline.ForeColor = System.Drawing.Color.FromArgb(220, 240, 232);
            this.lblBrandTagline.Location = new System.Drawing.Point(48, 265);
            this.lblBrandTagline.Size = new System.Drawing.Size(290, 60);
            this.lblBrandTagline.Text = "Connecting farmers and buyers through a simple, modern agricultural marketplace.";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblMessage);
            this.pnlForm.Controls.Add(this.lnkRegister);
            this.pnlForm.Controls.Add(this.btnLogin);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.lblPassword);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblUsername);
            this.pnlForm.Controls.Add(this.lblSignInSub);
            this.pnlForm.Controls.Add(this.lblWelcomeBack);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(380, 0);
            this.pnlForm.Size = new System.Drawing.Size(420, 540);
            //
            // lblWelcomeBack
            //
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.Font = UITheme.FontHeading;
            this.lblWelcomeBack.ForeColor = UITheme.TextDark;
            this.lblWelcomeBack.Location = new System.Drawing.Point(60, 110);
            this.lblWelcomeBack.Text = "Welcome back";
            //
            // lblSignInSub
            //
            this.lblSignInSub.AutoSize = true;
            this.lblSignInSub.Font = UITheme.FontBody;
            this.lblSignInSub.ForeColor = UITheme.TextMuted;
            this.lblSignInSub.Location = new System.Drawing.Point(60, 142);
            this.lblSignInSub.Text = "Sign in to continue to your dashboard";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = UITheme.FontSmall;
            this.lblUsername.ForeColor = UITheme.TextMuted;
            this.lblUsername.Location = new System.Drawing.Point(60, 195);
            this.lblUsername.Text = "USERNAME";
            //
            // txtUsername
            //
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = UITheme.FontBody;
            this.txtUsername.Location = new System.Drawing.Point(60, 215);
            this.txtUsername.Size = new System.Drawing.Size(300, 30);
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = UITheme.FontSmall;
            this.lblPassword.ForeColor = UITheme.TextMuted;
            this.lblPassword.Location = new System.Drawing.Point(60, 260);
            this.lblPassword.Text = "PASSWORD";
            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = UITheme.FontBody;
            this.txtPassword.Location = new System.Drawing.Point(60, 280);
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.PasswordChar = '*';
            //
            // btnLogin
            //
            this.btnLogin.Location = new System.Drawing.Point(60, 330);
            this.btnLogin.Size = new System.Drawing.Size(300, 42);
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            //
            // lnkRegister
            //
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = UITheme.FontBody;
            this.lnkRegister.LinkColor = UITheme.Primary;
            this.lnkRegister.Location = new System.Drawing.Point(60, 390);
            this.lnkRegister.Text = "New here? Create an account";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = UITheme.FontSmall;
            this.lblMessage.Location = new System.Drawing.Point(60, 425);
            this.lblMessage.Size = new System.Drawing.Size(300, 40);
            this.lblMessage.ForeColor = UITheme.Danger;
            //
            // frmLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krishi Setu Pro - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
