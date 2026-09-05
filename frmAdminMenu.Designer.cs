using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmAdminMenu
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
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavPromo;
        private System.Windows.Forms.Button btnNavTransactions;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlUsersContent;
        private System.Windows.Forms.Label lblUsersHeading;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.DataGridView dgvUsers;

        private System.Windows.Forms.Panel pnlProductsContent;
        private System.Windows.Forms.Label lblProductsHeading;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.DataGridView dgvAdminProducts;

        private System.Windows.Forms.Panel pnlPromoContent;
        private System.Windows.Forms.Panel pnlPromoCard;
        private System.Windows.Forms.Label lblPromoCardTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.Button btnActivatePromo;
        private System.Windows.Forms.Button btnDeactivatePromo;
        private System.Windows.Forms.Button btnDeletePromo;
        private System.Windows.Forms.Label lblPromoMessage;
        private System.Windows.Forms.DataGridView dgvPromo;

        private System.Windows.Forms.Panel pnlTransactionsContent;
        private System.Windows.Forms.Label lblTransactionsHeading;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblTotalCommission;

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavTransactions = new System.Windows.Forms.Button();
            this.btnNavPromo = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTransactionsContent = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblTotalCommission = new System.Windows.Forms.Label();
            this.lblTransactionsHeading = new System.Windows.Forms.Label();
            this.pnlPromoContent = new System.Windows.Forms.Panel();
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.pnlPromoCard = new System.Windows.Forms.Panel();
            this.lblPromoMessage = new System.Windows.Forms.Label();
            this.btnDeletePromo = new System.Windows.Forms.Button();
            this.btnDeactivatePromo = new System.Windows.Forms.Button();
            this.btnActivatePromo = new System.Windows.Forms.Button();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblPromoCardTitle = new System.Windows.Forms.Label();
            this.pnlProductsContent = new System.Windows.Forms.Panel();
            this.dgvAdminProducts = new System.Windows.Forms.DataGridView();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.lblProductsHeading = new System.Windows.Forms.Label();
            this.pnlUsersContent = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.lblUsersHeading = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTransactionsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlPromoContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            this.pnlPromoCard.SuspendLayout();
            this.pnlProductsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminProducts)).BeginInit();
            this.pnlUsersContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = UITheme.Sidebar;
            this.pnlSidebar.Controls.Add(this.btnNavTransactions);
            this.pnlSidebar.Controls.Add(this.btnNavPromo);
            this.pnlSidebar.Controls.Add(this.btnNavProducts);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(230, 720);
            //
            // lblLogo
            //
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = UITheme.FontHeading;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(24, 28);
            this.lblLogo.Text = "Krishi Setu";
            //
            // btnNavUsers
            //
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavUsers.BackColor = UITheme.Primary;
            this.btnNavUsers.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.Font = UITheme.FontNav;
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavUsers.Location = new System.Drawing.Point(0, 100);
            this.btnNavUsers.Size = new System.Drawing.Size(230, 46);
            this.btnNavUsers.Text = "Users";
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.btnNavUsers_Click);
            //
            // btnNavProducts
            //
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.FlatAppearance.BorderSize = 0;
            this.btnNavProducts.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavProducts.BackColor = UITheme.Sidebar;
            this.btnNavProducts.ForeColor = System.Drawing.Color.White;
            this.btnNavProducts.Font = UITheme.FontNav;
            this.btnNavProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProducts.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavProducts.Location = new System.Drawing.Point(0, 146);
            this.btnNavProducts.Size = new System.Drawing.Size(230, 46);
            this.btnNavProducts.Text = "Products";
            this.btnNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProducts.UseVisualStyleBackColor = false;
            this.btnNavProducts.Click += new System.EventHandler(this.btnNavProducts_Click);
            //
            // btnNavPromo
            //
            this.btnNavPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPromo.FlatAppearance.BorderSize = 0;
            this.btnNavPromo.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavPromo.BackColor = UITheme.Sidebar;
            this.btnNavPromo.ForeColor = System.Drawing.Color.White;
            this.btnNavPromo.Font = UITheme.FontNav;
            this.btnNavPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPromo.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavPromo.Location = new System.Drawing.Point(0, 192);
            this.btnNavPromo.Size = new System.Drawing.Size(230, 46);
            this.btnNavPromo.Text = "Promo Codes";
            this.btnNavPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPromo.UseVisualStyleBackColor = false;
            this.btnNavPromo.Click += new System.EventHandler(this.btnNavPromo_Click);
            //
            // btnNavTransactions
            //
            this.btnNavTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransactions.FlatAppearance.BorderSize = 0;
            this.btnNavTransactions.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavTransactions.BackColor = UITheme.Sidebar;
            this.btnNavTransactions.ForeColor = System.Drawing.Color.White;
            this.btnNavTransactions.Font = UITheme.FontNav;
            this.btnNavTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransactions.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavTransactions.Location = new System.Drawing.Point(0, 238);
            this.btnNavTransactions.Size = new System.Drawing.Size(230, 46);
            this.btnNavTransactions.Text = "Transactions";
            this.btnNavTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransactions.UseVisualStyleBackColor = false;
            this.btnNavTransactions.Click += new System.EventHandler(this.btnNavTransactions_Click);
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Size = new System.Drawing.Size(970, 76);
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = UITheme.FontHeading;
            this.lblWelcome.ForeColor = UITheme.TextDark;
            this.lblWelcome.Location = new System.Drawing.Point(30, 26);
            this.lblWelcome.Text = "Super Admin Dashboard";
            //
            // btnLogout
            //
            this.btnLogout.Location = new System.Drawing.Point(840, 20);
            this.btnLogout.Size = new System.Drawing.Size(100, 34);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // pnlContent
            //
            this.pnlContent.BackColor = UITheme.PageBackground;
            this.pnlContent.Controls.Add(this.pnlTransactionsContent);
            this.pnlContent.Controls.Add(this.pnlPromoContent);
            this.pnlContent.Controls.Add(this.pnlProductsContent);
            this.pnlContent.Controls.Add(this.pnlUsersContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 76);
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(970, 644);
            //
            // pnlUsersContent
            //
            this.pnlUsersContent.Controls.Add(this.dgvUsers);
            this.pnlUsersContent.Controls.Add(this.btnRemoveUser);
            this.pnlUsersContent.Controls.Add(this.lblUsersHeading);
            this.pnlUsersContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsersContent.Location = new System.Drawing.Point(30, 30);
            this.pnlUsersContent.Size = new System.Drawing.Size(910, 584);
            //
            // lblUsersHeading
            //
            this.lblUsersHeading.AutoSize = true;
            this.lblUsersHeading.Font = UITheme.FontSubheading;
            this.lblUsersHeading.ForeColor = UITheme.TextDark;
            this.lblUsersHeading.Location = new System.Drawing.Point(0, 0);
            this.lblUsersHeading.Text = "Registered Users";
            //
            // btnRemoveUser
            //
            this.btnRemoveUser.Location = new System.Drawing.Point(0, 35);
            this.btnRemoveUser.Size = new System.Drawing.Size(170, 36);
            this.btnRemoveUser.Text = "Remove Selected User";
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            //
            // dgvUsers
            //
            this.dgvUsers.Location = new System.Drawing.Point(0, 82);
            this.dgvUsers.Size = new System.Drawing.Size(910, 500);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // pnlProductsContent
            //
            this.pnlProductsContent.Controls.Add(this.dgvAdminProducts);
            this.pnlProductsContent.Controls.Add(this.btnRemoveProduct);
            this.pnlProductsContent.Controls.Add(this.lblProductsHeading);
            this.pnlProductsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsContent.Location = new System.Drawing.Point(30, 30);
            this.pnlProductsContent.Size = new System.Drawing.Size(910, 584);
            this.pnlProductsContent.Visible = false;
            //
            // lblProductsHeading
            //
            this.lblProductsHeading.AutoSize = true;
            this.lblProductsHeading.Font = UITheme.FontSubheading;
            this.lblProductsHeading.ForeColor = UITheme.TextDark;
            this.lblProductsHeading.Location = new System.Drawing.Point(0, 0);
            this.lblProductsHeading.Text = "All Products";
            //
            // btnRemoveProduct
            //
            this.btnRemoveProduct.Location = new System.Drawing.Point(0, 35);
            this.btnRemoveProduct.Size = new System.Drawing.Size(180, 36);
            this.btnRemoveProduct.Text = "Remove Selected Product";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            //
            // dgvAdminProducts
            //
            this.dgvAdminProducts.Location = new System.Drawing.Point(0, 82);
            this.dgvAdminProducts.Size = new System.Drawing.Size(910, 500);
            this.dgvAdminProducts.ReadOnly = true;
            this.dgvAdminProducts.AllowUserToAddRows = false;
            this.dgvAdminProducts.AllowUserToDeleteRows = false;
            this.dgvAdminProducts.MultiSelect = false;
            this.dgvAdminProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // pnlPromoContent
            //
            this.pnlPromoContent.Controls.Add(this.dgvPromo);
            this.pnlPromoContent.Controls.Add(this.pnlPromoCard);
            this.pnlPromoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPromoContent.Location = new System.Drawing.Point(30, 30);
            this.pnlPromoContent.Size = new System.Drawing.Size(910, 584);
            this.pnlPromoContent.Visible = false;
            //
            // pnlPromoCard
            //
            this.pnlPromoCard.BackColor = System.Drawing.Color.White;
            this.pnlPromoCard.Controls.Add(this.lblPromoMessage);
            this.pnlPromoCard.Controls.Add(this.btnDeletePromo);
            this.pnlPromoCard.Controls.Add(this.btnDeactivatePromo);
            this.pnlPromoCard.Controls.Add(this.btnActivatePromo);
            this.pnlPromoCard.Controls.Add(this.btnAddPromo);
            this.pnlPromoCard.Controls.Add(this.dtpExpiry);
            this.pnlPromoCard.Controls.Add(this.lblExpiry);
            this.pnlPromoCard.Controls.Add(this.txtDiscount);
            this.pnlPromoCard.Controls.Add(this.lblDiscount);
            this.pnlPromoCard.Controls.Add(this.txtCode);
            this.pnlPromoCard.Controls.Add(this.lblCode);
            this.pnlPromoCard.Controls.Add(this.lblPromoCardTitle);
            this.pnlPromoCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPromoCard.Location = new System.Drawing.Point(0, 0);
            this.pnlPromoCard.Size = new System.Drawing.Size(910, 175);
            //
            // lblPromoCardTitle
            //
            this.lblPromoCardTitle.AutoSize = true;
            this.lblPromoCardTitle.Font = UITheme.FontSubheading;
            this.lblPromoCardTitle.ForeColor = UITheme.TextDark;
            this.lblPromoCardTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPromoCardTitle.Text = "Create / Manage Promo Code";
            //
            // lblCode
            //
            this.lblCode.AutoSize = true;
            this.lblCode.Font = UITheme.FontSmall;
            this.lblCode.ForeColor = UITheme.TextMuted;
            this.lblCode.Location = new System.Drawing.Point(20, 52);
            this.lblCode.Text = "CODE";
            //
            // txtCode
            //
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = UITheme.FontBody;
            this.txtCode.Location = new System.Drawing.Point(20, 70);
            this.txtCode.Size = new System.Drawing.Size(160, 28);
            //
            // lblDiscount
            //
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = UITheme.FontSmall;
            this.lblDiscount.ForeColor = UITheme.TextMuted;
            this.lblDiscount.Location = new System.Drawing.Point(200, 52);
            this.lblDiscount.Text = "DISCOUNT %";
            //
            // txtDiscount
            //
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = UITheme.FontBody;
            this.txtDiscount.Location = new System.Drawing.Point(200, 70);
            this.txtDiscount.Size = new System.Drawing.Size(90, 28);
            //
            // lblExpiry
            //
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = UITheme.FontSmall;
            this.lblExpiry.ForeColor = UITheme.TextMuted;
            this.lblExpiry.Location = new System.Drawing.Point(310, 52);
            this.lblExpiry.Text = "EXPIRY DATE";
            //
            // dtpExpiry
            //
            this.dtpExpiry.Location = new System.Drawing.Point(310, 70);
            this.dtpExpiry.Size = new System.Drawing.Size(150, 28);
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            //
            // btnAddPromo
            //
            this.btnAddPromo.Location = new System.Drawing.Point(20, 120);
            this.btnAddPromo.Size = new System.Drawing.Size(90, 34);
            this.btnAddPromo.Text = "Add";
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            //
            // btnActivatePromo
            //
            this.btnActivatePromo.Location = new System.Drawing.Point(120, 120);
            this.btnActivatePromo.Size = new System.Drawing.Size(100, 34);
            this.btnActivatePromo.Text = "Activate";
            this.btnActivatePromo.Click += new System.EventHandler(this.btnActivatePromo_Click);
            //
            // btnDeactivatePromo
            //
            this.btnDeactivatePromo.Location = new System.Drawing.Point(230, 120);
            this.btnDeactivatePromo.Size = new System.Drawing.Size(110, 34);
            this.btnDeactivatePromo.Text = "Deactivate";
            this.btnDeactivatePromo.Click += new System.EventHandler(this.btnDeactivatePromo_Click);
            //
            // btnDeletePromo
            //
            this.btnDeletePromo.Location = new System.Drawing.Point(350, 120);
            this.btnDeletePromo.Size = new System.Drawing.Size(90, 34);
            this.btnDeletePromo.Text = "Delete";
            this.btnDeletePromo.Click += new System.EventHandler(this.btnDeletePromo_Click);
            //
            // lblPromoMessage
            //
            this.lblPromoMessage.AutoSize = false;
            this.lblPromoMessage.Font = UITheme.FontSmall;
            this.lblPromoMessage.ForeColor = UITheme.Danger;
            this.lblPromoMessage.Location = new System.Drawing.Point(480, 122);
            this.lblPromoMessage.Size = new System.Drawing.Size(400, 40);
            //
            // dgvPromo
            //
            this.dgvPromo.Location = new System.Drawing.Point(0, 185);
            this.dgvPromo.Size = new System.Drawing.Size(910, 399);
            this.dgvPromo.ReadOnly = true;
            this.dgvPromo.AllowUserToAddRows = false;
            this.dgvPromo.AllowUserToDeleteRows = false;
            this.dgvPromo.MultiSelect = false;
            this.dgvPromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromo_CellClick);
            //
            // pnlTransactionsContent
            //
            this.pnlTransactionsContent.Controls.Add(this.dgvTransactions);
            this.pnlTransactionsContent.Controls.Add(this.lblTotalCommission);
            this.pnlTransactionsContent.Controls.Add(this.lblTransactionsHeading);
            this.pnlTransactionsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactionsContent.Location = new System.Drawing.Point(30, 30);
            this.pnlTransactionsContent.Size = new System.Drawing.Size(910, 584);
            this.pnlTransactionsContent.Visible = false;
            //
            // lblTransactionsHeading
            //
            this.lblTransactionsHeading.AutoSize = true;
            this.lblTransactionsHeading.Font = UITheme.FontSubheading;
            this.lblTransactionsHeading.ForeColor = UITheme.TextDark;
            this.lblTransactionsHeading.Location = new System.Drawing.Point(0, 0);
            this.lblTransactionsHeading.Text = "All Transactions";
            //
            // lblTotalCommission
            //
            this.lblTotalCommission.AutoSize = true;
            this.lblTotalCommission.Font = UITheme.FontStat;
            this.lblTotalCommission.ForeColor = UITheme.Primary;
            this.lblTotalCommission.Location = new System.Drawing.Point(0, 35);
            this.lblTotalCommission.Text = "৳0.00 commission earned";
            //
            // dgvTransactions
            //
            this.dgvTransactions.Location = new System.Drawing.Point(0, 90);
            this.dgvTransactions.Size = new System.Drawing.Size(910, 492);
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // frmAdminMenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krishi Setu Pro - Super Admin";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlTransactionsContent.ResumeLayout(false);
            this.pnlTransactionsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlPromoContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            this.pnlPromoCard.ResumeLayout(false);
            this.pnlPromoCard.PerformLayout();
            this.pnlProductsContent.ResumeLayout(false);
            this.pnlProductsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminProducts)).EndInit();
            this.pnlUsersContent.ResumeLayout(false);
            this.pnlUsersContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
