using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    public partial class frmBuyerDashboard : Form
    {
        public frmBuyerDashboard()
        {
            InitializeComponent();
        }

        private void frmBuyerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.Username;

            UITheme.StylePrimaryButton(btnPurchase);
            UITheme.StyleSecondaryButton(btnRefresh);
            UITheme.StyleSecondaryButton(btnLogout);
            UITheme.StyleDangerButton(btnDeleteAccount);
            UITheme.StylePrimaryButton(btnSubmitReview);
            UITheme.StyleGrid(dgvBrowse);
            UITheme.StyleGrid(dgvHistory);

            LoadBrowse();
            LoadHistory();
        }

        // ---------- NAVIGATION ----------

        private void btnNavBrowse_Click(object sender, EventArgs e)
        {
            pnlBrowseContent.Visible = true;
            pnlHistoryContent.Visible = false;
            pnlReviewContent.Visible = false;
            btnNavBrowse.BackColor = UITheme.Primary;
            btnNavHistory.BackColor = UITheme.Sidebar;
            btnNavReview.BackColor = UITheme.Sidebar;
        }

        private void btnNavHistory_Click(object sender, EventArgs e)
        {
            pnlBrowseContent.Visible = false;
            pnlHistoryContent.Visible = true;
            pnlReviewContent.Visible = false;
            btnNavHistory.BackColor = UITheme.Primary;
            btnNavBrowse.BackColor = UITheme.Sidebar;
            btnNavReview.BackColor = UITheme.Sidebar;
            LoadHistory();
        }

        private void btnNavReview_Click(object sender, EventArgs e)
        {
            pnlBrowseContent.Visible = false;
            pnlHistoryContent.Visible = false;
            pnlReviewContent.Visible = true;
            btnNavReview.BackColor = UITheme.Primary;
            btnNavBrowse.BackColor = UITheme.Sidebar;
            btnNavHistory.BackColor = UITheme.Sidebar;
            LoadFarmersForReview();
        }

        // ---------- BROWSE / PURCHASE ----------

        private void LoadBrowse()
        {
            try
            {
                string sql = "SELECT p.ProductId, p.ProductName, p.Quantity AS AvailableQty, p.Price, " +
                             "u.Username AS Farmer, " +
                             "ISNULL(CAST(ROUND(r.AvgRating, 1) AS VARCHAR(10)) + ' (' + CAST(r.ReviewCount AS VARCHAR(10)) + ')', 'No ratings yet') AS FarmerRating " +
                             "FROM Products p " +
                             "JOIN Users u ON p.FarmerId = u.UserId " +
                             "LEFT JOIN (SELECT FarmerId, AVG(CAST(Rating AS DECIMAL(4,2))) AS AvgRating, COUNT(*) AS ReviewCount " +
                             "           FROM Reviews GROUP BY FarmerId) r ON p.FarmerId = r.FarmerId " +
                             "WHERE p.Quantity > 0 ORDER BY p.ProductName";

                DataTable dt = DBHelper.ExecuteQuery(sql);
                dgvBrowse.DataSource = dt;

                if (dgvBrowse.Columns.Contains("ProductId"))
                    dgvBrowse.Columns["ProductId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBrowse();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (dgvBrowse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvBrowse.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
            string productName = row.Cells["ProductName"].Value.ToString();
            decimal availableQty = Convert.ToDecimal(row.Cells["AvailableQty"].Value);
            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

            frmPurchase purchaseForm = new frmPurchase(productId, productName, availableQty, price);
            purchaseForm.ShowDialog();

            LoadBrowse();
            LoadHistory();
        }

        // ---------- HISTORY ----------

        private void LoadHistory()
        {
            try
            {
                string sql = "SELECT t.TransactionId, p.ProductName, t.Quantity, t.GrossAmount, " +
                             "t.Discount, t.PromoCode, t.FinalAmount, t.TransactionDate " +
                             "FROM Transactions t JOIN Products p ON t.ProductId = p.ProductId " +
                             "WHERE t.BuyerId = @buyerId ORDER BY t.TransactionDate DESC";

                DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@buyerId", Session.UserId));
                dgvHistory.DataSource = dt;

                if (dgvHistory.Columns.Contains("TransactionId"))
                    dgvHistory.Columns["TransactionId"].Visible = false;

                decimal total = 0;
                foreach (DataRow r in dt.Rows)
                    total += Convert.ToDecimal(r["FinalAmount"]);

                lblHistoryTotal.Text = "৳" + total.ToString("N2") + " total spent";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- REVIEWS ----------

        private void LoadFarmersForReview()
        {
            try
            {
                string sql = "SELECT DISTINCT u.UserId, u.Username " +
                             "FROM Transactions t JOIN Users u ON t.FarmerId = u.UserId " +
                             "WHERE t.BuyerId = @buyerId ORDER BY u.Username";

                DataTable dt = DBHelper.ExecuteQuery(sql, new SqlParameter("@buyerId", Session.UserId));

                cboFarmer.DataSource = dt;
                cboFarmer.DisplayMember = "Username";
                cboFarmer.ValueMember = "UserId";

                bool hasFarmers = dt.Rows.Count > 0;
                cboFarmer.Enabled = hasFarmers;
                btnSubmitReview.Enabled = hasFarmers;
                lblReviewMessage.ForeColor = UITheme.TextMuted;
                lblReviewMessage.Text = hasFarmers ? "" : "You haven't purchased from any farmer yet.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading farmers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            lblReviewMessage.ForeColor = UITheme.Danger;
            lblReviewMessage.Text = "";

            if (cboFarmer.SelectedValue == null)
            {
                lblReviewMessage.Text = "Select a farmer to review.";
                return;
            }

            if (cboRating.SelectedItem == null)
            {
                lblReviewMessage.Text = "Select a rating from 1 to 5.";
                return;
            }

            int farmerId = Convert.ToInt32(cboFarmer.SelectedValue);
            int rating = Convert.ToInt32(cboRating.SelectedItem.ToString());
            string comment = txtComment.Text.Trim();

            try
            {
                // Only allow reviewing farmers this buyer has actually purchased from
                object purchaseCount = DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Transactions WHERE BuyerId = @buyerId AND FarmerId = @farmerId",
                    new SqlParameter("@buyerId", Session.UserId),
                    new SqlParameter("@farmerId", farmerId));

                if (Convert.ToInt32(purchaseCount) == 0)
                {
                    lblReviewMessage.Text = "You can only review farmers you've purchased from.";
                    return;
                }

                string sql = "INSERT INTO Reviews (FarmerId, BuyerId, Rating, Comment) " +
                             "VALUES (@farmerId, @buyerId, @rating, @comment)";

                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@farmerId", farmerId),
                    new SqlParameter("@buyerId", Session.UserId),
                    new SqlParameter("@rating", rating),
                    new SqlParameter("@comment", string.IsNullOrEmpty(comment) ? (object)DBNull.Value : comment));

                lblReviewMessage.ForeColor = UITheme.Success;
                lblReviewMessage.Text = "Review submitted. Thank you!";
                cboRating.SelectedIndex = -1;
                txtComment.Text = "";
            }
            catch (Exception ex)
            {
                lblReviewMessage.ForeColor = UITheme.Danger;
                lblReviewMessage.Text = "Error: " + ex.Message;
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
                object purchaseCount = DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Transactions WHERE BuyerId = @id",
                    new SqlParameter("@id", Session.UserId));

                if (Convert.ToInt32(purchaseCount) > 0)
                {
                    MessageBox.Show(
                        "Your account has purchase history and cannot be deleted while that history exists. " +
                        "Please contact the Admin if you still wish to proceed.",
                        "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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
