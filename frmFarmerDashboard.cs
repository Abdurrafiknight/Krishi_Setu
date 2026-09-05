using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    public partial class frmFarmerDashboard : Form
    {
        private int selectedProductId = 0;

        public frmFarmerDashboard()
        {
            InitializeComponent();
        }

        private void frmFarmerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.Username;

            UITheme.StylePrimaryButton(btnAddProduct);
            UITheme.StyleSecondaryButton(btnUpdateProduct);
            UITheme.StyleSecondaryButton(btnClearProduct);
            UITheme.StyleDangerButton(btnDeleteProduct);
            UITheme.StyleSecondaryButton(btnLogout);
            UITheme.StyleDangerButton(btnDeleteAccount);
            UITheme.StyleGrid(dgvProducts);
            UITheme.StyleGrid(dgvSales);
            UITheme.StyleGrid(dgvMyReviews);

            LoadProducts();
            LoadSales();
        }

        // ---------- NAVIGATION ----------

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            pnlProductsContent.Visible = true;
            pnlSalesContent.Visible = false;
            pnlReviewsContent.Visible = false;
            btnNavProducts.BackColor = UITheme.Primary;
            btnNavSales.BackColor = UITheme.Sidebar;
            btnNavReviews.BackColor = UITheme.Sidebar;
        }

        private void btnNavSales_Click(object sender, EventArgs e)
        {
            pnlProductsContent.Visible = false;
            pnlSalesContent.Visible = true;
            pnlReviewsContent.Visible = false;
            btnNavSales.BackColor = UITheme.Primary;
            btnNavProducts.BackColor = UITheme.Sidebar;
            btnNavReviews.BackColor = UITheme.Sidebar;
            LoadSales();
        }

        private void btnNavReviews_Click(object sender, EventArgs e)
        {
            pnlProductsContent.Visible = false;
            pnlSalesContent.Visible = false;
            pnlReviewsContent.Visible = true;
            btnNavReviews.BackColor = UITheme.Primary;
            btnNavProducts.BackColor = UITheme.Sidebar;
            btnNavSales.BackColor = UITheme.Sidebar;
            LoadReviews();
        }

        // ---------- PRODUCTS ----------

        private void LoadProducts()
        {
            try
            {
                string sql = "SELECT ProductId, ProductName, Quantity, Price, CreatedDate " +
                             "FROM Products WHERE FarmerId = @farmerId ORDER BY ProductId DESC";

                DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@farmerId", Session.UserId));
                dgvProducts.DataSource = dt;

                if (dgvProducts.Columns.Contains("ProductId"))
                    dgvProducts.Columns["ProductId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateProductInput(out decimal qty, out decimal price)
        {
            qty = 0;
            price = 0;
            lblProductMessage.ForeColor = UITheme.Danger;
            lblProductMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                lblProductMessage.Text = "Product name is required.";
                return false;
            }

            if (!decimal.TryParse(txtQuantity.Text, out qty) || qty < 0)
            {
                lblProductMessage.Text = "Enter a valid quantity (0 or more).";
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                lblProductMessage.Text = "Enter a valid price (0 or more).";
                return false;
            }

            return true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            decimal qty, price;
            if (!ValidateProductInput(out qty, out price)) return;

            try
            {
                string sql = "INSERT INTO Products (ProductName, Quantity, Price, FarmerId) " +
                             "VALUES (@name, @qty, @price, @farmerId)";

                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@name", txtProductName.Text.Trim()),
                    new SqlParameter("@qty", qty),
                    new SqlParameter("@price", price),
                    new SqlParameter("@farmerId", Session.UserId));

                lblProductMessage.ForeColor = UITheme.Success;
                lblProductMessage.Text = "Product added successfully.";
                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                lblProductMessage.ForeColor = UITheme.Danger;
                lblProductMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                lblProductMessage.ForeColor = UITheme.Danger;
                lblProductMessage.Text = "Select a product from the list first.";
                return;
            }

            decimal qty, price;
            if (!ValidateProductInput(out qty, out price)) return;

            try
            {
                string sql = "UPDATE Products SET ProductName = @name, Quantity = @qty, Price = @price " +
                             "WHERE ProductId = @id AND FarmerId = @farmerId";

                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@name", txtProductName.Text.Trim()),
                    new SqlParameter("@qty", qty),
                    new SqlParameter("@price", price),
                    new SqlParameter("@id", selectedProductId),
                    new SqlParameter("@farmerId", Session.UserId));

                lblProductMessage.ForeColor = UITheme.Success;
                lblProductMessage.Text = "Product updated successfully.";
                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                lblProductMessage.ForeColor = UITheme.Danger;
                lblProductMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                lblProductMessage.ForeColor = UITheme.Danger;
                lblProductMessage.Text = "Select a product from the list first.";
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete this product permanently?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                string sql = "DELETE FROM Products WHERE ProductId = @id AND FarmerId = @farmerId";
                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@id", selectedProductId),
                    new SqlParameter("@farmerId", Session.UserId));

                lblProductMessage.ForeColor = UITheme.Success;
                lblProductMessage.Text = "Product deleted.";
                ClearProductForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                lblProductMessage.ForeColor = UITheme.Danger;
                lblProductMessage.Text = "This product may have existing sales and cannot be deleted. " + ex.Message;
            }
        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            ClearProductForm();
        }

        private void ClearProductForm()
        {
            selectedProductId = 0;
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            lblProductMessage.Text = "";
            dgvProducts.ClearSelection();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            selectedProductId = Convert.ToInt32(row.Cells["ProductId"].Value);
            txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
        }

        // ---------- SALES ----------

        private void LoadSales()
        {
            try
            {
                string sql = "SELECT t.TransactionId, p.ProductName, u.Username AS Buyer, " +
                             "t.Quantity, t.GrossAmount, t.Discount, t.FinalAmount, t.AdminCommission, " +
                             "(t.FinalAmount - t.AdminCommission) AS FarmerEarning, t.TransactionDate " +
                             "FROM Transactions t " +
                             "JOIN Products p ON t.ProductId = p.ProductId " +
                             "JOIN Users u ON t.BuyerId = u.UserId " +
                             "WHERE t.FarmerId = @farmerId ORDER BY t.TransactionDate DESC";

                DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@farmerId", Session.UserId));
                dgvSales.DataSource = dt;

                if (dgvSales.Columns.Contains("TransactionId"))
                    dgvSales.Columns["TransactionId"].Visible = false;

                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                    total += Convert.ToDecimal(row["FarmerEarning"]);

                lblSalesTotal.Text = "৳" + total.ToString("N2") + " total earnings";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- REVIEWS ----------

        private void LoadReviews()
        {
            try
            {
                string sql = "SELECT r.ReviewId, u.Username AS Buyer, r.Rating, r.Comment, r.ReviewDate " +
                             "FROM Reviews r JOIN Users u ON r.BuyerId = u.UserId " +
                             "WHERE r.FarmerId = @farmerId ORDER BY r.ReviewDate DESC";

                DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@farmerId", Session.UserId));
                dgvMyReviews.DataSource = dt;

                if (dgvMyReviews.Columns.Contains("ReviewId"))
                    dgvMyReviews.Columns["ReviewId"].Visible = false;

                if (dt.Rows.Count == 0)
                {
                    lblAvgRating.Text = "No reviews yet";
                    return;
                }

                decimal totalRating = 0;
                foreach (DataRow row in dt.Rows)
                    totalRating += Convert.ToDecimal(row["Rating"]);

                decimal average = totalRating / dt.Rows.Count;
                lblAvgRating.Text = average.ToString("N1") + " ★ (" + dt.Rows.Count + " review" + (dt.Rows.Count == 1 ? "" : "s") + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- ACCOUNT ----------

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "This will permanently delete your account. This cannot be undone. Continue?",
                "Confirm Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                object salesCount = DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Transactions WHERE FarmerId = @id",
                    new SqlParameter("@id", Session.UserId));

                if (Convert.ToInt32(salesCount) > 0)
                {
                    MessageBox.Show(
                        "Your account has recorded sales and cannot be deleted while that history exists. " +
                        "Please contact the Admin if you still wish to proceed.",
                        "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DBHelper.ExecuteNonQuery("DELETE FROM Products WHERE FarmerId = @id",
                    new SqlParameter("@id", Session.UserId));

                DBHelper.ExecuteNonQuery("DELETE FROM Users WHERE UserId = @id",
                    new SqlParameter("@id", Session.UserId));

                MessageBox.Show("Your account has been deleted.", "Account Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
