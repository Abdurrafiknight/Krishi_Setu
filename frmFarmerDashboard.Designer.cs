using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    partial class frmFarmerDashboard
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
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavReviews;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlProductsContent;
        private System.Windows.Forms.Panel pnlProductCard;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Label lblProductMessage;
        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.Panel pnlSalesContent;
        private System.Windows.Forms.Label lblSalesHeading;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblSalesTotal;

        private System.Windows.Forms.Panel pnlReviewsContent;
        private System.Windows.Forms.Label lblReviewsHeading;
        private System.Windows.Forms.DataGridView dgvMyReviews;
        private System.Windows.Forms.Label lblAvgRating;

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavReviews = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlReviewsContent = new System.Windows.Forms.Panel();
            this.dgvMyReviews = new System.Windows.Forms.DataGridView();
            this.lblAvgRating = new System.Windows.Forms.Label();
            this.lblReviewsHeading = new System.Windows.Forms.Label();
            this.pnlSalesContent = new System.Windows.Forms.Panel();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.lblSalesHeading = new System.Windows.Forms.Label();
            this.pnlProductsContent = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlProductCard = new System.Windows.Forms.Panel();
            this.lblProductMessage = new System.Windows.Forms.Label();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlReviewsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReviews)).BeginInit();
            this.pnlSalesContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.pnlProductsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlProductCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = UITheme.Sidebar;
            this.pnlSidebar.Controls.Add(this.btnNavReviews);
            this.pnlSidebar.Controls.Add(this.btnNavSales);
            this.pnlSidebar.Controls.Add(this.btnNavProducts);
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
            // btnNavProducts
            //
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.FlatAppearance.BorderSize = 0;
            this.btnNavProducts.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavProducts.BackColor = UITheme.Primary;
            this.btnNavProducts.ForeColor = System.Drawing.Color.White;
            this.btnNavProducts.Font = UITheme.FontNav;
            this.btnNavProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProducts.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavProducts.Location = new System.Drawing.Point(0, 100);
            this.btnNavProducts.Size = new System.Drawing.Size(220, 46);
            this.btnNavProducts.Text = "My Products";
            this.btnNavProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProducts.UseVisualStyleBackColor = false;
            this.btnNavProducts.Click += new System.EventHandler(this.btnNavProducts_Click);
            //
            // btnNavSales
            //
            this.btnNavSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSales.FlatAppearance.BorderSize = 0;
            this.btnNavSales.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavSales.BackColor = UITheme.Sidebar;
            this.btnNavSales.ForeColor = System.Drawing.Color.White;
            this.btnNavSales.Font = UITheme.FontNav;
            this.btnNavSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSales.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavSales.Location = new System.Drawing.Point(0, 146);
            this.btnNavSales.Size = new System.Drawing.Size(220, 46);
            this.btnNavSales.Text = "My Sales";
            this.btnNavSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSales.UseVisualStyleBackColor = false;
            this.btnNavSales.Click += new System.EventHandler(this.btnNavSales_Click);
            //
            // btnNavReviews
            //
            this.btnNavReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReviews.FlatAppearance.BorderSize = 0;
            this.btnNavReviews.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            this.btnNavReviews.BackColor = UITheme.Sidebar;
            this.btnNavReviews.ForeColor = System.Drawing.Color.White;
            this.btnNavReviews.Font = UITheme.FontNav;
            this.btnNavReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReviews.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavReviews.Location = new System.Drawing.Point(0, 192);
            this.btnNavReviews.Size = new System.Drawing.Size(220, 46);
            this.btnNavReviews.Text = "My Reviews";
            this.btnNavReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReviews.UseVisualStyleBackColor = false;
            this.btnNavReviews.Click += new System.EventHandler(this.btnNavReviews_Click);
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
            this.lblWelcome.Text = "Farmer Dashboard";
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
            this.pnlContent.Controls.Add(this.pnlReviewsContent);
            this.pnlContent.Controls.Add(this.pnlSalesContent);
            this.pnlContent.Controls.Add(this.pnlProductsContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 76);
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(880, 604);
            //
            // pnlReviewsContent
            //
            this.pnlReviewsContent.Controls.Add(this.dgvMyReviews);
            this.pnlReviewsContent.Controls.Add(this.lblAvgRating);
            this.pnlReviewsContent.Controls.Add(this.lblReviewsHeading);
            this.pnlReviewsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReviewsContent.Location = new System.Drawing.Point(30, 30);
            this.pnlReviewsContent.Size = new System.Drawing.Size(820, 544);
            this.pnlReviewsContent.Visible = false;
            //
            // lblReviewsHeading
            //
            this.lblReviewsHeading.AutoSize = true;
            this.lblReviewsHeading.Font = UITheme.FontSubheading;
            this.lblReviewsHeading.ForeColor = UITheme.TextDark;
            this.lblReviewsHeading.Location = new System.Drawing.Point(0, 0);
            this.lblReviewsHeading.Text = "My Reviews";
            //
            // lblAvgRating
            //
            this.lblAvgRating.AutoSize = true;
            this.lblAvgRating.Font = UITheme.FontStat;
            this.lblAvgRating.ForeColor = UITheme.Primary;
            this.lblAvgRating.Location = new System.Drawing.Point(0, 35);
            this.lblAvgRating.Text = "No reviews yet";
            //
            // dgvMyReviews
            //
            this.dgvMyReviews.Location = new System.Drawing.Point(0, 90);
            this.dgvMyReviews.Size = new System.Drawing.Size(820, 452);
            this.dgvMyReviews.ReadOnly = true;
            this.dgvMyReviews.AllowUserToAddRows = false;
            this.dgvMyReviews.AllowUserToDeleteRows = false;
            this.dgvMyReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // pnlProductsContent
            //
            this.pnlProductsContent.Controls.Add(this.dgvProducts);
            this.pnlProductsContent.Controls.Add(this.pnlProductCard);
            this.pnlProductsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductsContent.Location = new System.Drawing.Point(30, 30);
            this.pnlProductsContent.Size = new System.Drawing.Size(820, 544);
            //
            // pnlProductCard
            //
            this.pnlProductCard.BackColor = System.Drawing.Color.White;
            this.pnlProductCard.Controls.Add(this.lblProductMessage);
            this.pnlProductCard.Controls.Add(this.btnClearProduct);
            this.pnlProductCard.Controls.Add(this.btnDeleteProduct);
            this.pnlProductCard.Controls.Add(this.btnUpdateProduct);
            this.pnlProductCard.Controls.Add(this.btnAddProduct);
            this.pnlProductCard.Controls.Add(this.txtPrice);
            this.pnlProductCard.Controls.Add(this.lblPrice);
            this.pnlProductCard.Controls.Add(this.txtQuantity);
            this.pnlProductCard.Controls.Add(this.lblQuantity);
            this.pnlProductCard.Controls.Add(this.txtProductName);
            this.pnlProductCard.Controls.Add(this.lblProductName);
            this.pnlProductCard.Controls.Add(this.lblCardTitle);
            this.pnlProductCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductCard.Location = new System.Drawing.Point(0, 0);
            this.pnlProductCard.Size = new System.Drawing.Size(820, 168);
            //
            // lblCardTitle
            //
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = UITheme.FontSubheading;
            this.lblCardTitle.ForeColor = UITheme.TextDark;
            this.lblCardTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCardTitle.Text = "Add / Edit Product";
            //
            // lblProductName
            //
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = UITheme.FontSmall;
            this.lblProductName.ForeColor = UITheme.TextMuted;
            this.lblProductName.Location = new System.Drawing.Point(20, 50);
            this.lblProductName.Text = "PRODUCT NAME";
            //
            // txtProductName
            //
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = UITheme.FontBody;
            this.txtProductName.Location = new System.Drawing.Point(20, 68);
            this.txtProductName.Size = new System.Drawing.Size(220, 28);
            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = UITheme.FontSmall;
            this.lblQuantity.ForeColor = UITheme.TextMuted;
            this.lblQuantity.Location = new System.Drawing.Point(260, 50);
            this.lblQuantity.Text = "QUANTITY (KG)";
            //
            // txtQuantity
            //
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = UITheme.FontBody;
            this.txtQuantity.Location = new System.Drawing.Point(260, 68);
            this.txtQuantity.Size = new System.Drawing.Size(150, 28);
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = UITheme.FontSmall;
            this.lblPrice.ForeColor = UITheme.TextMuted;
            this.lblPrice.Location = new System.Drawing.Point(430, 50);
            this.lblPrice.Text = "PRICE PER KG";
            //
            // txtPrice
            //
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = UITheme.FontBody;
            this.txtPrice.Location = new System.Drawing.Point(430, 68);
            this.txtPrice.Size = new System.Drawing.Size(150, 28);
            //
            // btnAddProduct
            //
            this.btnAddProduct.Location = new System.Drawing.Point(20, 115);
            this.btnAddProduct.Size = new System.Drawing.Size(90, 34);
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            //
            // btnUpdateProduct
            //
            this.btnUpdateProduct.Location = new System.Drawing.Point(120, 115);
            this.btnUpdateProduct.Size = new System.Drawing.Size(90, 34);
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            //
            // btnDeleteProduct
            //
            this.btnDeleteProduct.Location = new System.Drawing.Point(220, 115);
            this.btnDeleteProduct.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            //
            // btnClearProduct
            //
            this.btnClearProduct.Location = new System.Drawing.Point(320, 115);
            this.btnClearProduct.Size = new System.Drawing.Size(90, 34);
            this.btnClearProduct.Text = "Clear";
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            //
            // lblProductMessage
            //
            this.lblProductMessage.AutoSize = false;
            this.lblProductMessage.Font = UITheme.FontSmall;
            this.lblProductMessage.ForeColor = UITheme.Danger;
            this.lblProductMessage.Location = new System.Drawing.Point(430, 118);
            this.lblProductMessage.Size = new System.Drawing.Size(370, 30);
            //
            // dgvProducts
            //
            this.dgvProducts.Location = new System.Drawing.Point(0, 178);
            this.dgvProducts.Size = new System.Drawing.Size(820, 366);
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            //
            // pnlSalesContent
            //
            this.pnlSalesContent.Controls.Add(this.dgvSales);
            this.pnlSalesContent.Controls.Add(this.lblSalesTotal);
            this.pnlSalesContent.Controls.Add(this.lblSalesHeading);
            this.pnlSalesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesContent.Location = new System.Drawing.Point(30, 30);
            this.pnlSalesContent.Size = new System.Drawing.Size(820, 544);
            this.pnlSalesContent.Visible = false;
            //
            // lblSalesHeading
            //
            this.lblSalesHeading.AutoSize = true;
            this.lblSalesHeading.Font = UITheme.FontSubheading;
            this.lblSalesHeading.ForeColor = UITheme.TextDark;
            this.lblSalesHeading.Location = new System.Drawing.Point(0, 0);
            this.lblSalesHeading.Text = "My Sales";
            //
            // dgvSales
            //
            this.dgvSales.Location = new System.Drawing.Point(0, 35);
            this.dgvSales.Size = new System.Drawing.Size(820, 460);
            this.dgvSales.ReadOnly = true;
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            // lblSalesTotal
            //
            this.lblSalesTotal.AutoSize = true;
            this.lblSalesTotal.Font = UITheme.FontStat;
            this.lblSalesTotal.ForeColor = UITheme.Primary;
            this.lblSalesTotal.Location = new System.Drawing.Point(0, 505);
            this.lblSalesTotal.Text = "৳0.00";
            this.lblSalesTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //
            // frmFarmerDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmFarmerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krishi Setu Pro - Farmer Dashboard";
            this.Load += new System.EventHandler(this.frmFarmerDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlReviewsContent.ResumeLayout(false);
            this.pnlReviewsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReviews)).EndInit();
            this.pnlSalesContent.ResumeLayout(false);
            this.pnlSalesContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.pnlProductsContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlProductCard.ResumeLayout(false);
            this.pnlProductCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
