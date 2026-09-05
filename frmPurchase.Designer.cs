using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmPurchase
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

        private System.Windows.Forms.Panel pnlHeaderBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductNameCaption;
        private System.Windows.Forms.Label lblProductNameValue;
        private System.Windows.Forms.Label lblAvailableCaption;
        private System.Windows.Forms.Label lblAvailableValue;
        private System.Windows.Forms.Label lblPriceCaption;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblQtyCaption;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPromoCaption;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Button btnApplyPromo;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblGrossCaption;
        private System.Windows.Forms.Label lblGrossValue;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblFinalCaption;
        private System.Windows.Forms.Label lblFinalValue;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessage;

        private void InitializeComponent()
        {
            this.pnlHeaderBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductNameCaption = new System.Windows.Forms.Label();
            this.lblProductNameValue = new System.Windows.Forms.Label();
            this.lblAvailableCaption = new System.Windows.Forms.Label();
            this.lblAvailableValue = new System.Windows.Forms.Label();
            this.lblPriceCaption = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblQtyCaption = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPromoCaption = new System.Windows.Forms.Label();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.btnApplyPromo = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblGrossCaption = new System.Windows.Forms.Label();
            this.lblGrossValue = new System.Windows.Forms.Label();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblFinalCaption = new System.Windows.Forms.Label();
            this.lblFinalValue = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlHeaderBar.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeaderBar
            //
            this.pnlHeaderBar.BackColor = UITheme.Primary;
            this.pnlHeaderBar.Controls.Add(this.lblTitle);
            this.pnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBar.Size = new System.Drawing.Size(440, 64);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = UITheme.FontHeading;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Text = "Confirm Purchase";
            //
            // lblProductNameCaption
            //
            this.lblProductNameCaption.AutoSize = true;
            this.lblProductNameCaption.Font = UITheme.FontSmall;
            this.lblProductNameCaption.ForeColor = UITheme.TextMuted;
            this.lblProductNameCaption.Location = new System.Drawing.Point(24, 84);
            this.lblProductNameCaption.Text = "PRODUCT";
            //
            // lblProductNameValue
            //
            this.lblProductNameValue.AutoSize = true;
            this.lblProductNameValue.Font = UITheme.FontSubheading;
            this.lblProductNameValue.ForeColor = UITheme.TextDark;
            this.lblProductNameValue.Location = new System.Drawing.Point(24, 102);
            this.lblProductNameValue.Text = "";
            //
            // lblAvailableCaption
            //
            this.lblAvailableCaption.AutoSize = true;
            this.lblAvailableCaption.Font = UITheme.FontSmall;
            this.lblAvailableCaption.ForeColor = UITheme.TextMuted;
            this.lblAvailableCaption.Location = new System.Drawing.Point(230, 84);
            this.lblAvailableCaption.Text = "AVAILABLE";
            //
            // lblAvailableValue
            //
            this.lblAvailableValue.AutoSize = true;
            this.lblAvailableValue.Font = UITheme.FontSubheading;
            this.lblAvailableValue.ForeColor = UITheme.TextDark;
            this.lblAvailableValue.Location = new System.Drawing.Point(230, 102);
            this.lblAvailableValue.Text = "";
            //
            // lblPriceCaption
            //
            this.lblPriceCaption.AutoSize = true;
            this.lblPriceCaption.Font = UITheme.FontSmall;
            this.lblPriceCaption.ForeColor = UITheme.TextMuted;
            this.lblPriceCaption.Location = new System.Drawing.Point(340, 84);
            this.lblPriceCaption.Text = "PRICE/KG";
            //
            // lblPriceValue
            //
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = UITheme.FontSubheading;
            this.lblPriceValue.ForeColor = UITheme.TextDark;
            this.lblPriceValue.Location = new System.Drawing.Point(340, 102);
            this.lblPriceValue.Text = "";
            //
            // lblQtyCaption
            //
            this.lblQtyCaption.AutoSize = true;
            this.lblQtyCaption.Font = UITheme.FontSmall;
            this.lblQtyCaption.ForeColor = UITheme.TextMuted;
            this.lblQtyCaption.Location = new System.Drawing.Point(24, 145);
            this.lblQtyCaption.Text = "QUANTITY TO BUY (KG)";
            //
            // txtQty
            //
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = UITheme.FontBody;
            this.txtQty.Location = new System.Drawing.Point(24, 164);
            this.txtQty.Size = new System.Drawing.Size(180, 28);
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            //
            // lblPromoCaption
            //
            this.lblPromoCaption.AutoSize = true;
            this.lblPromoCaption.Font = UITheme.FontSmall;
            this.lblPromoCaption.ForeColor = UITheme.TextMuted;
            this.lblPromoCaption.Location = new System.Drawing.Point(220, 145);
            this.lblPromoCaption.Text = "PROMO CODE";
            //
            // txtPromo
            //
            this.txtPromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPromo.Font = UITheme.FontBody;
            this.txtPromo.Location = new System.Drawing.Point(220, 164);
            this.txtPromo.Size = new System.Drawing.Size(110, 28);
            //
            // btnApplyPromo
            //
            this.btnApplyPromo.Location = new System.Drawing.Point(336, 163);
            this.btnApplyPromo.Size = new System.Drawing.Size(80, 30);
            this.btnApplyPromo.Text = "Apply";
            this.btnApplyPromo.Click += new System.EventHandler(this.btnApplyPromo_Click);
            //
            // pnlSummary
            //
            this.pnlSummary.BackColor = UITheme.PageBackground;
            this.pnlSummary.Controls.Add(this.lblFinalValue);
            this.pnlSummary.Controls.Add(this.lblFinalCaption);
            this.pnlSummary.Controls.Add(this.lblDiscountValue);
            this.pnlSummary.Controls.Add(this.lblDiscountCaption);
            this.pnlSummary.Controls.Add(this.lblGrossValue);
            this.pnlSummary.Controls.Add(this.lblGrossCaption);
            this.pnlSummary.Location = new System.Drawing.Point(24, 215);
            this.pnlSummary.Size = new System.Drawing.Size(392, 110);
            //
            // lblGrossCaption
            //
            this.lblGrossCaption.AutoSize = true;
            this.lblGrossCaption.Font = UITheme.FontBody;
            this.lblGrossCaption.ForeColor = UITheme.TextMuted;
            this.lblGrossCaption.Location = new System.Drawing.Point(16, 12);
            this.lblGrossCaption.Text = "Gross Amount";
            //
            // lblGrossValue
            //
            this.lblGrossValue.AutoSize = true;
            this.lblGrossValue.Font = UITheme.FontBody;
            this.lblGrossValue.ForeColor = UITheme.TextDark;
            this.lblGrossValue.Location = new System.Drawing.Point(280, 12);
            this.lblGrossValue.Text = "৳0.00";
            //
            // lblDiscountCaption
            //
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Font = UITheme.FontBody;
            this.lblDiscountCaption.ForeColor = UITheme.TextMuted;
            this.lblDiscountCaption.Location = new System.Drawing.Point(16, 42);
            this.lblDiscountCaption.Text = "Discount";
            //
            // lblDiscountValue
            //
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = UITheme.FontBody;
            this.lblDiscountValue.ForeColor = UITheme.Success;
            this.lblDiscountValue.Location = new System.Drawing.Point(280, 42);
            this.lblDiscountValue.Text = "৳0.00";
            //
            // lblFinalCaption
            //
            this.lblFinalCaption.AutoSize = true;
            this.lblFinalCaption.Font = UITheme.FontSubheading;
            this.lblFinalCaption.ForeColor = UITheme.TextDark;
            this.lblFinalCaption.Location = new System.Drawing.Point(16, 76);
            this.lblFinalCaption.Text = "You Pay";
            //
            // lblFinalValue
            //
            this.lblFinalValue.AutoSize = true;
            this.lblFinalValue.Font = UITheme.FontHeading;
            this.lblFinalValue.ForeColor = UITheme.Primary;
            this.lblFinalValue.Location = new System.Drawing.Point(260, 72);
            this.lblFinalValue.Text = "৳0.00";
            //
            // btnConfirm
            //
            this.btnConfirm.Location = new System.Drawing.Point(24, 345);
            this.btnConfirm.Size = new System.Drawing.Size(190, 42);
            this.btnConfirm.Text = "Confirm Purchase";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(226, 345);
            this.btnCancel.Size = new System.Drawing.Size(120, 42);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = UITheme.FontSmall;
            this.lblMessage.ForeColor = UITheme.Danger;
            this.lblMessage.Location = new System.Drawing.Point(24, 395);
            this.lblMessage.Size = new System.Drawing.Size(390, 40);
            //
            // frmPurchase
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 445);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.btnApplyPromo);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.lblPromoCaption);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQtyCaption);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPriceCaption);
            this.Controls.Add(this.lblAvailableValue);
            this.Controls.Add(this.lblAvailableCaption);
            this.Controls.Add(this.lblProductNameValue);
            this.Controls.Add(this.lblProductNameCaption);
            this.Controls.Add(this.pnlHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Krishi Setu Pro - Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.pnlHeaderBar.ResumeLayout(false);
            this.pnlHeaderBar.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
