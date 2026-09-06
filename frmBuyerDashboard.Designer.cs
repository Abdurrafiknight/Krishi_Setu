using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmBuyerDashboard
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

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavBrowse;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavReview;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlBrowseContent;
        private System.Windows.Forms.Label lblBrowseHeading;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvBrowse;

        private System.Windows.Forms.Panel pnlHistoryContent;
        private System.Windows.Forms.Label lblHistoryHeading;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistoryTotal;

        private System.Windows.Forms.Panel pnlReviewContent;
        private System.Windows.Forms.Label lblReviewHeading;
        private System.Windows.Forms.Label lblFarmerCaption;
        private System.Windows.Forms.ComboBox cboFarmer;
        private System.Windows.Forms.Label lblRatingCaption;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label lblCommentCaption;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.Label lblReviewMessage;

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavReview = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavBrowse = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlReviewContent = new System.Windows.Forms.Panel();
            this.lblReviewMessage = new System.Windows.Forms.Label();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblCommentCaption = new System.Windows.Forms.Label();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.lblRatingCaption = new System.Windows.Forms.Label();
            this.cboFarmer = new System.Windows.Forms.ComboBox();
            this.lblFarmerCaption = new System.Windows.Forms.Label();
            this.lblReviewHeading = new System.Windows.Forms.Label();
            this.pnlHistoryContent = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistoryTotal = new System.Windows.Forms.Label();
            this.lblHistoryHeading = new System.Windows.Forms.Label();
            this.pnlBrowseContent = new System.Windows.Forms.Panel();
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblBrowseHeading = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlReviewContent.SuspendLayout();
            this.pnlHistoryContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlBrowseContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = UITheme.Sidebar;
            this.pnlSidebar.Controls.Add(this.btnNavReview);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavBrowse);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(220, 680);
            //
            // lblLogo
            //
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = UITheme.FontHeading;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(24, 28);
            this.lblLogo.Text = "Krishi Setu";
            //
            // btnNavBrowse
            //
            this.btnNavBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBrowse.FlatAppearance.BorderSize = 0;
            this.btnNavBrowse.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavBrowse.BackColor = UITheme.Primary;
            this.btnNavBrowse.ForeColor = System.Drawing.Color.White;
            this.btnNavBrowse.Font = UITheme.FontNav;
            this.btnNavBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBrowse.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavBrowse.Location = new System.Drawing.Point(0, 100);
            this.btnNavBrowse.Size = new System.Drawing.Size(220, 46);
            this.btnNavBrowse.Text = "Browse Products";
            this.btnNavBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBrowse.UseVisualStyleBackColor = false;
            this.btnNavBrowse.Click += new System.EventHandler(this.btnNavBrowse_Click);
            //
            // btnNavHistory
            //
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavHistory.BackColor = UITheme.Sidebar;
            this.btnNavHistory.ForeColor = System.Drawing.Color.White;
            this.btnNavHistory.Font = UITheme.FontNav;
            this.btnNavHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistory.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavHistory.Location = new System.Drawing.Point(0, 146);
            this.btnNavHistory.Size = new System.Drawing.Size(220, 46);
            this.btnNavHistory.Text = "My Purchases";
            this.btnNavHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Click += new System.EventHandler(this.btnNavHistory_Click);
            //
            // btnNavReview
            //
            this.btnNavReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReview.FlatAppearance.BorderSize = 0;
            this.btnNavReview.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavReview.BackColor = UITheme.Sidebar;
            this.btnNavReview.ForeColor = System.Drawing.Color.White;
            this.btnNavReview.Font = UITheme.FontNav;
            this.btnNavReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReview.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavReview.Location = new System.Drawing.Point(0, 192);
            this.btnNavReview.Size = new System.Drawing.Size(220, 46);
            this.btnNavReview.Text = "Rate a Farmer";
            this.btnNavReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReview.UseVisualStyleBackColor = false;
            this.btnNavReview.Click += new System.EventHandler(this.btnNavReview_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnDeleteAccount);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Size = new System.Drawing.Size(880, 76);
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = UITheme.FontHeading;
            this.lblWelcome.ForeColor = UITheme.TextDark;
            this.lblWelcome.Location = new System.Drawing.Point(30, 26);
            this.lblWelcome.Text = "Buyer Dashboard";
            //
            // btnDeleteAccount
            //
            this.btnDeleteAccount.Location = new System.Drawing.Point(600, 20);
            this.btnDeleteAccount.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            //
            // btnLogout
            //
            this.btnLogout.Location = new System.Drawing.Point(740, 20);
            this.btnLogout.Size = new System.Drawing.Size(100, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // pnlContent
            //
            this.pnlContent.BackColor = UITheme.PageBackground;
            this.pnlContent.Controls.Add(this.pnlReviewContent);
            this.pnlContent.Controls.Add(this.pnlHistoryContent);
            this.pnlContent.Controls.Add(this.pnlBrowseContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 76);
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(880, 604);
            //
            // pnlReviewContent
            //
            this.pnlReviewContent.Controls.Add(this.lblReviewMessage);
            this.pnlReviewContent.Controls.Add(this.btnSubmitReview);
            this.pnlReviewContent.Controls.Add(this.txtComment);
            this.pnlReviewContent.Controls.Add(this.lblCommentCaption);
            this.pnlReviewContent.Controls.Add(this.cboRating);
            this.pnlReviewContent.Controls.Add(this.lblRatingCaption);
            this.pnlReviewContent.Controls.Add(this.cboFarmer);
            this.pnlReviewContent.Controls.Add(this.lblFarmerCaption);
            this.pnlReviewContent.Controls.Add(this.lblReviewHeading);
            this.pnlReviewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReviewContent.Location = new System.Drawing.Point(30, 30);
            this.pnlReviewContent.Size = new System.Drawing.Size(820, 544);
            this.pnlReviewContent.Visible = false;
            //
            // lblReviewHeading
            //
            this.lblReviewHeading.AutoSize = true;
            this.lblReviewHeading.Font = UITheme.FontSubheading;
            this.lblReviewHeading.ForeColor = UITheme.TextDark;
            this.lblReviewHeading.Location = new System.Drawing.Point(0, 0);
            this.lblReviewHeading.Text = "Rate a Farmer You've Purchased From";
            //
            // lblFarmerCaption
            //
            this.lblFarmerCaption.AutoSize = true;
            this.lblFarmerCaption.Font = UITheme.FontSmall;
            this.lblFarmerCaption.ForeColor = UITheme.TextMuted;
            this.lblFarmerCaption.Location = new System.Drawing.Point(0, 45);
            this.lblFarmerCaption.Text = "FARMER";
            //
            // cboFarmer
            //
            this.cboFarmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFarmer.Font = UITheme.FontBody;
            this.cboFarmer.Location = new System.Drawing.Point(0, 65);
            this.cboFarmer.Size = new System.Drawing.Size(300, 28);
            //
            // lblRatingCaption
            //
            this.lblRatingCaption.AutoSize = true;
            this.lblRatingCaption.Font = UITheme.FontSmall;
            this.lblRatingCaption.ForeColor = UITheme.TextMuted;
            this.lblRatingCaption.Location = new System.Drawing.Point(320, 45);
            this.lblRatingCaption.Text = "RATING (1-5)";
            //
            // cboRating
            //
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.Font = UITheme.FontBody;
            this.cboRating.Location = new System.Drawing.Point(320, 65);
            this.cboRating.Size = new System.Drawing.Size(120, 28);
            this.cboRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            //
            // lblCommentCaption
            //
            this.lblCommentCaption.AutoSize = true;
            this.lblCommentCaption.Font = UITheme.FontSmall;
            this.lblCommentCaption.ForeColor = UITheme.TextMuted;
            this.lblCommentCaption.Location = new System.Drawing.Point(0, 108);
            this.lblCommentCaption.Text = "COMMENT (OPTIONAL)";
            //
            // txtComment
            //
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = UITheme.FontBody;
            this.txtComment.Location = new System.Drawing.Point(0, 128);
            this.txtComment.Size = new System.Drawing.Size(440, 90);
            this.txtComment.Multiline = true;
            //
            // btnSubmitReview
            //
            this.btnSubmitReview.Location = new System.Drawing.Point(0, 232);
            this.btnSubmitReview.Size = new System.Drawing.Size(160, 38);
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            //
            // lblReviewMessage
            //
            this.lblReviewMessage.AutoSize = false;
            this.lblReviewMessage.Font = UITheme.FontSmall;
            this.lblReviewMessage.ForeColor = UITheme.Danger;
            this.lblReviewMessage.Location = new System.Drawing.Point(0, 282);
            this.lblReviewMessage.Size = new System.Drawing.Size(440, 40);
            //
            // pnlBrowseContent
            //
            this.pnlBrowseContent.Controls.Add(this.dgvBrowse);
            this.pnlBrowseContent.Controls.Add(this.btnRefresh);
            this.pnlBrowseContent.Controls.Add(this.btnPurchase);
            this.pnlBrowseContent.Controls.Add(this.lblBrowseHeading);
            this.pnlBrowseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowseContent.Location = new System.Drawing.Point(30, 30);
            this.pnlBrowseContent.Size = new System.Drawing.Size(820, 544);
            //
            // lblBrowseHeading
            //
            this.lblBrowseHeading.AutoSize = true;
            this.lblBrowseHeading.Font = UITheme.FontSubheading;
            this.lblBrowseHeading.ForeColor = UITheme.TextDark;
            this.lblBrowseHeading.Location = new System.Drawing.Point(0, 0);
            this.lblBrowseHeading.Text = "Available Products";
            //
            // btnPurchase
            //
            this.btnPurchase.Location = new System.Drawing.Point(0, 35);
            this.btnPurchase.Size = new System.Drawing.Size(160, 36);
            this.btnPurchase.Text = "Purchase Selected";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(170, 35);
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvBrowse
            //
            this.dgvBrowse.Location = new System.Drawing.Point(0, 82);
            this.dgvBrowse.Size = new System.Drawing.Size(820, 462);
            this.dgvBrowse.ReadOnly = true;
            this.dgvBrowse.AllowUserToAddRows = false;
            this.dgvBrowse.AllowUserToDeleteRows = false;
            this.dgvBrowse.MultiSelect = false;
            this.dgvBrowse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrowse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // pnlHistoryContent
            //
            this.pnlHistoryContent.Controls.Add(this.dgvHistory);
            this.pnlHistoryContent.Controls.Add(this.lblHistoryTotal);
            this.pnlHistoryContent.Controls.Add(this.lblHistoryHeading);
            this.pnlHistoryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistoryContent.Location = new System.Drawing.Point(30, 30);
            this.pnlHistoryContent.Size = new System.Drawing.Size(820, 544);
            this.pnlHistoryContent.Visible = false;
            //
            // lblHistoryHeading
            //
            this.lblHistoryHeading.AutoSize = true;
            this.lblHistoryHeading.Font = UITheme.FontSubheading;
            this.lblHistoryHeading.ForeColor = UITheme.TextDark;
            this.lblHistoryHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHistoryHeading.Text = "My Purchases";
            //
            // dgvHistory
            //
            this.dgvHistory.Location = new System.Drawing.Point(0, 35);
            this.dgvHistory.Size = new System.Drawing.Size(820, 460);
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // lblHistoryTotal
            //
            this.lblHistoryTotal.AutoSize = true;
            this.lblHistoryTotal.Font = UITheme.FontStat;
            this.lblHistoryTotal.ForeColor = UITheme.Primary;
            this.lblHistoryTotal.Location = new System.Drawing.Point(0, 505);
            this.lblHistoryTotal.Text = "৳0.00";
            this.lblHistoryTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //
            // frmBuyerDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmBuyerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krishi Setu Pro - Buyer Dashboard";
            this.Load += new System.EventHandler(this.frmBuyerDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlReviewContent.ResumeLayout(false);
            this.pnlReviewContent.PerformLayout();
            this.pnlHistoryContent.ResumeLayout(false);
            this.pnlHistoryContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlBrowseContent.ResumeLayout(false);
            this.pnlBrowseContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
