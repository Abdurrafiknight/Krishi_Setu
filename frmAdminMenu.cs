using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    public partial class frmAdminMenu : Form
    {
        private int selectedPromoId = 0;
        private Button[] navButtons;
        private Panel[] contentPanels;

        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.Username;

            navButtons = new[] { btnNavUsers, btnNavProducts, btnNavPromo, btnNavTransactions };
            contentPanels = new[] { pnlUsersContent, pnlProductsContent, pnlPromoContent, pnlTransactionsContent };

            UITheme.StyleDangerButton(btnRemoveUser);
            UITheme.StyleDangerButton(btnRemoveProduct);
            UITheme.StylePrimaryButton(btnAddPromo);
            UITheme.StyleSecondaryButton(btnActivatePromo);
            UITheme.StyleSecondaryButton(btnDeactivatePromo);
            UITheme.StyleDangerButton(btnDeletePromo);
            UITheme.StyleSecondaryButton(btnLogout);
            UITheme.StyleGrid(dgvUsers);
            UITheme.StyleGrid(dgvAdminProducts);
            UITheme.StyleGrid(dgvPromo);
            UITheme.StyleGrid(dgvTransactions);

            LoadUsers();
            LoadProducts();
            LoadPromoCodes();
            LoadTransactions();
        }

        // ---------- NAVIGATION ----------

        private void SwitchTo(int index)
        {
            for (int i = 0; i < contentPanels.Length; i++)
            {
                contentPanels[i].Visible = (i == index);
                navButtons[i].BackColor = (i == index) ? UITheme.Primary : UITheme.Sidebar;
            }
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            SwitchTo(0);
        }

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            SwitchTo(1);
        }

        private void btnNavPromo_Click(object sender, EventArgs e)
        {
            SwitchTo(2);
        }

        private void btnNavTransactions_Click(object sender, EventArgs e)
        {
            SwitchTo(3);
            LoadTransactions();
        }

        // ---------- USERS ----------

        private void LoadUsers()
        {
            try
            {
                string sql = "SELECT UserId, Username, UserType, FullName, Phone, CreatedDate " +
                             "FROM Users WHERE UserType <> 'Admin' ORDER BY UserId DESC";
                DataTable dt = DBHelper.ExecuteQuery(sql);
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Remove user '" + username + "'? This cannot be undone.",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                DBHelper.ExecuteNonQuery("DELETE FROM Users WHERE UserId = @id",
                    new SqlParameter("@id", userId));
                LoadUsers();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "This user has related products or transactions and cannot be removed directly. " +
                    "Remove their products/transactions first, or keep the account for record-keeping.",
                    "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------- PRODUCTS ----------

        private void LoadProducts()
        {
            try
            {
                string sql = "SELECT p.ProductId, p.ProductName, p.Quantity, p.Price, " +
                             "u.Username AS Farmer, p.CreatedDate " +
                             "FROM Products p JOIN Users u ON p.FarmerId = u.UserId " +
                             "ORDER BY p.ProductId DESC";
                DataTable dt = DBHelper.ExecuteQuery(sql);
                dgvAdminProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvAdminProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int productId = Convert.ToInt32(dgvAdminProducts.SelectedRows[0].Cells["ProductId"].Value);
            string name = dgvAdminProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Remove product '" + name + "'? This cannot be undone.",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                DBHelper.ExecuteNonQuery("DELETE FROM Products WHERE ProductId = @id",
                    new SqlParameter("@id", productId));
                LoadProducts();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "This product has existing sales history and cannot be removed.",
                    "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------- PROMO CODES ----------

        private void LoadPromoCodes()
        {
            try
            {
                string sql = "SELECT PromoId, Code, DiscountPercent, IsActive, ExpiryDate, CreatedDate " +
                             "FROM PromoCodes ORDER BY PromoId DESC";
                DataTable dt = DBHelper.ExecuteQuery(sql);
                dgvPromo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading promo codes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPromo.Rows[e.RowIndex];
            selectedPromoId = Convert.ToInt32(row.Cells["PromoId"].Value);
            txtCode.Text = row.Cells["Code"].Value.ToString();
            txtDiscount.Text = row.Cells["DiscountPercent"].Value.ToString();
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            lblPromoMessage.ForeColor = UITheme.Danger;
            lblPromoMessage.Text = "";

            string code = txtCode.Text.Trim().ToUpper();
            decimal discount;

            if (string.IsNullOrEmpty(code))
            {
                lblPromoMessage.Text = "Enter a promo code.";
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out discount) || discount < 0 || discount > 100)
            {
                lblPromoMessage.Text = "Enter a valid discount % (0-100).";
                return;
            }

            try
            {
                object exists = DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM PromoCodes WHERE Code = @code",
                    new SqlParameter("@code", code));

                if (Convert.ToInt32(exists) > 0)
                {
                    lblPromoMessage.Text = "This promo code already exists.";
                    return;
                }

                string sql = "INSERT INTO PromoCodes (Code, DiscountPercent, IsActive, ExpiryDate) " +
                             "VALUES (@code, @discount, 1, @expiry)";

                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@code", code),
                    new SqlParameter("@discount", discount),
                    new SqlParameter("@expiry", dtpExpiry.Value));

                lblPromoMessage.ForeColor = UITheme.Success;
                lblPromoMessage.Text = "Promo code created.";
                txtCode.Text = "";
                txtDiscount.Text = "";
                LoadPromoCodes();
            }
            catch (Exception ex)
            {
                lblPromoMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnActivatePromo_Click(object sender, EventArgs e)
        {
            SetPromoActive(true);
        }

        private void btnDeactivatePromo_Click(object sender, EventArgs e)
        {
            SetPromoActive(false);
        }

        private void SetPromoActive(bool active)
        {
            if (selectedPromoId == 0)
            {
                lblPromoMessage.ForeColor = UITheme.Danger;
                lblPromoMessage.Text = "Select a promo code from the list first.";
                return;
            }

            try
            {
                DBHelper.ExecuteNonQuery("UPDATE PromoCodes SET IsActive = @active WHERE PromoId = @id",
                    new SqlParameter("@active", active),
                    new SqlParameter("@id", selectedPromoId));

                lblPromoMessage.ForeColor = UITheme.Success;
                lblPromoMessage.Text = active ? "Promo code activated." : "Promo code deactivated.";
                LoadPromoCodes();
            }
            catch (Exception ex)
            {
                lblPromoMessage.ForeColor = UITheme.Danger;
                lblPromoMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnDeletePromo_Click(object sender, EventArgs e)
        {
            if (selectedPromoId == 0)
            {
                lblPromoMessage.ForeColor = UITheme.Danger;
                lblPromoMessage.Text = "Select a promo code from the list first.";
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete this promo code permanently?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                DBHelper.ExecuteNonQuery("DELETE FROM PromoCodes WHERE PromoId = @id",
                    new SqlParameter("@id", selectedPromoId));

                selectedPromoId = 0;
                txtCode.Text = "";
                txtDiscount.Text = "";
                lblPromoMessage.ForeColor = UITheme.Success;
                lblPromoMessage.Text = "Promo code deleted.";
                LoadPromoCodes();
            }
            catch (Exception ex)
            {
                lblPromoMessage.ForeColor = UITheme.Danger;
                lblPromoMessage.Text = "Error: " + ex.Message;
            }
        }

        // ---------- TRANSACTIONS ----------

        private void LoadTransactions()
        {
            try
            {
                string sql = "SELECT t.TransactionId, p.ProductName, uf.Username AS Farmer, " +
                             "ub.Username AS Buyer, t.Quantity, t.GrossAmount, t.Discount, " +
                             "t.FinalAmount, t.AdminCommission, t.PromoCode, t.TransactionDate " +
                             "FROM Transactions t " +
                             "JOIN Products p ON t.ProductId = p.ProductId " +
                             "JOIN Users uf ON t.FarmerId = uf.UserId " +
                             "JOIN Users ub ON t.BuyerId = ub.UserId " +
                             "ORDER BY t.TransactionDate DESC";

                DataTable dt = DBHelper.ExecuteQuery(sql);
                dgvTransactions.DataSource = dt;

                if (dgvTransactions.Columns.Contains("TransactionId"))
                    dgvTransactions.Columns["TransactionId"].Visible = false;

                decimal totalCommission = 0;
                foreach (DataRow row in dt.Rows)
                    totalCommission += Convert.ToDecimal(row["AdminCommission"]);

                lblTotalCommission.Text = "৳" + totalCommission.ToString("N2") + " commission earned";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- LOGOUT ----------

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
