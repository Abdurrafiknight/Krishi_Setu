using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmRegister
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
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnTypeFarmer;
        private System.Windows.Forms.Button btnTypeBuyer;
        private System.Windows.Forms.Label lblUsernameCaption;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordCaption;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmCaption;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblFullNameCaption;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhoneCaption;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.Label lblMessage;

        private void InitializeComponent()
        {
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandTagline = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnTypeFarmer = new System.Windows.Forms.Button();
            this.btnTypeBuyer = new System.Windows.Forms.Button();
            this.lblUsernameCaption = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPasswordCaption = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmCaption = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblFullNameCaption = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhoneCaption = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
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
            this.pnlBrand.Size = new System.Drawing.Size(320, 640);
            //
            // lblBrandTitle
            //
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = UITheme.FontTitle;
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(40, 260);
            this.lblBrandTitle.Text = "Join Krishi\nSetu";
            //
            // lblBrandTagline
            //
            this.lblBrandTagline.AutoSize = false;
            this.lblBrandTagline.Font = UITheme.FontBody;
            this.lblBrandTagline.ForeColor = System.Drawing.Color.FromArgb(220, 240, 232);
            this.lblBrandTagline.Location = new System.Drawing.Point(43, 340);
            this.lblBrandTagline.Size = new System.Drawing.Size(240, 80);
            this.lblBrandTagline.Text = "Create an account to start selling or buying fresh produce today.";
            //
            // pnlForm
            //
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblMessage);
            this.pnlForm.Controls.Add(this.lnkBack);
            this.pnlForm.Controls.Add(this.btnRegister);
            this.pnlForm.Controls.Add(this.txtPhone);
            this.pnlForm.Controls.Add(this.lblPhoneCaption);
            this.pnlForm.Controls.Add(this.txtFullName);
            this.pnlForm.Controls.Add(this.lblFullNameCaption);
            this.pnlForm.Controls.Add(this.txtConfirm);
            this.pnlForm.Controls.Add(this.lblConfirmCaption);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.lblPasswordCaption);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblUsernameCaption);
            this.pnlForm.Controls.Add(this.btnTypeBuyer);
            this.pnlForm.Controls.Add(this.btnTypeFarmer);
            this.pnlForm.Controls.Add(this.lblAccountType);
            this.pnlForm.Controls.Add(this.lblSub);
            this.pnlForm.Controls.Add(this.lblHeading);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(320, 0);
            this.pnlForm.Size = new System.Drawing.Size(430, 640);
            //
            // lblHeading
            //
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = UITheme.FontHeading;
            this.lblHeading.ForeColor = UITheme.TextDark;
            this.lblHeading.Location = new System.Drawing.Point(50, 35);
            this.lblHeading.Text = "Create your account";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.Font = UITheme.FontBody;
            this.lblSub.ForeColor = UITheme.TextMuted;
            this.lblSub.Location = new System.Drawing.Point(50, 66);
            this.lblSub.Text = "It only takes a minute";
            //
            // lblAccountType
            //
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = UITheme.FontSmall;
            this.lblAccountType.ForeColor = UITheme.TextMuted;
            this.lblAccountType.Location = new System.Drawing.Point(50, 105);
            this.lblAccountType.Text = "I AM A";
            //
            // btnTypeFarmer
            //
            this.btnTypeFarmer.Location = new System.Drawing.Point(50, 125);
            this.btnTypeFarmer.Size = new System.Drawing.Size(150, 38);
            this.btnTypeFarmer.Text = "Farmer";
            this.btnTypeFarmer.Tag = "selected";
            this.btnTypeFarmer.Click += new System.EventHandler(this.btnTypeFarmer_Click);
            //
            // btnTypeBuyer
            //
            this.btnTypeBuyer.Location = new System.Drawing.Point(210, 125);
            this.btnTypeBuyer.Size = new System.Drawing.Size(150, 38);
            this.btnTypeBuyer.Text = "Buyer";
            this.btnTypeBuyer.Click += new System.EventHandler(this.btnTypeBuyer_Click);
            //
            // lblUsernameCaption
            //
            this.lblUsernameCaption.AutoSize = true;
            this.lblUsernameCaption.Font = UITheme.FontSmall;
            this.lblUsernameCaption.ForeColor = UITheme.TextMuted;
            this.lblUsernameCaption.Location = new System.Drawing.Point(50, 170);
            this.lblUsernameCaption.Text = "USERNAME";
            //
            // txtUsername
            //
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = UITheme.FontBody;
            this.txtUsername.Location = new System.Drawing.Point(50, 190);
            this.txtUsername.Size = new System.Drawing.Size(310, 30);
            //
            // lblPasswordCaption
            //
            this.lblPasswordCaption.AutoSize = true;
            this.lblPasswordCaption.Font = UITheme.FontSmall;
            this.lblPasswordCaption.ForeColor = UITheme.TextMuted;
            this.lblPasswordCaption.Location = new System.Drawing.Point(50, 225);
            this.lblPasswordCaption.Text = "PASSWORD";
            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = UITheme.FontBody;
            this.txtPassword.Location = new System.Drawing.Point(50, 245);
            this.txtPassword.Size = new System.Drawing.Size(310, 30);
            this.txtPassword.PasswordChar = '*';
            //
            // lblConfirmCaption
            //
            this.lblConfirmCaption.AutoSize = true;
            this.lblConfirmCaption.Font = UITheme.FontSmall;
            this.lblConfirmCaption.ForeColor = UITheme.TextMuted;
            this.lblConfirmCaption.Location = new System.Drawing.Point(50, 280);
            this.lblConfirmCaption.Text = "CONFIRM PASSWORD";
            //
            // txtConfirm
            //
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Font = UITheme.FontBody;
            this.txtConfirm.Location = new System.Drawing.Point(50, 300);
            this.txtConfirm.Size = new System.Drawing.Size(310, 30);
            this.txtConfirm.PasswordChar = '*';
            //
            // lblFullNameCaption
            //
            this.lblFullNameCaption.AutoSize = true;
            this.lblFullNameCaption.Font = UITheme.FontSmall;
            this.lblFullNameCaption.ForeColor = UITheme.TextMuted;
            this.lblFullNameCaption.Location = new System.Drawing.Point(50, 335);
            this.lblFullNameCaption.Text = "FULL NAME";
            //
            // txtFullName
            //
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = UITheme.FontBody;
            this.txtFullName.Location = new System.Drawing.Point(50, 355);
            this.txtFullName.Size = new System.Drawing.Size(310, 30);
            //
            // lblPhoneCaption
            //
            this.lblPhoneCaption.AutoSize = true;
            this.lblPhoneCaption.Font = UITheme.FontSmall;
            this.lblPhoneCaption.ForeColor = UITheme.TextMuted;
            this.lblPhoneCaption.Location = new System.Drawing.Point(50, 390);
            this.lblPhoneCaption.Text = "PHONE";
            //
            // txtPhone
            //
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = UITheme.FontBody;
            this.txtPhone.Location = new System.Drawing.Point(50, 410);
            this.txtPhone.Size = new System.Drawing.Size(310, 30);
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(50, 460);
            this.btnRegister.Size = new System.Drawing.Size(310, 42);
            this.btnRegister.Text = "Create Account";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // lnkBack
            //
            this.lnkBack.AutoSize = true;
            this.lnkBack.Font = UITheme.FontBody;
            this.lnkBack.LinkColor = UITheme.Primary;
            this.lnkBack.Location = new System.Drawing.Point(50, 518);
            this.lnkBack.Text = "Already have an account? Log in";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = UITheme.FontSmall;
            this.lblMessage.Location = new System.Drawing.Point(50, 548);
            this.lblMessage.Size = new System.Drawing.Size(310, 40);
            this.lblMessage.ForeColor = UITheme.Danger;
            //
            // frmRegister
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 640);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krishi Setu Pro - Create Account";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
