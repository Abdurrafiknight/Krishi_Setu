using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    public partial class frmRegister : Form
    {
        private string selectedUserType = "Farmer";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            UITheme.StylePrimaryButton(btnRegister);
            RefreshTypeButtons();
        }

        private void RefreshTypeButtons()
        {
            if (selectedUserType == "Farmer")
            {
                UITheme.StylePrimaryButton(btnTypeFarmer);
                UITheme.StyleSecondaryButton(btnTypeBuyer);
            }
            else
            {
                UITheme.StylePrimaryButton(btnTypeBuyer);
                UITheme.StyleSecondaryButton(btnTypeFarmer);
            }
        }

        private void btnTypeFarmer_Click(object sender, EventArgs e)
        {
            selectedUserType = "Farmer";
            RefreshTypeButtons();
        }

        private void btnTypeBuyer_Click(object sender, EventArgs e)
        {
            selectedUserType = "Buyer";
            RefreshTypeButtons();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = UITheme.Danger;
            lblMessage.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Username and password are required.";
                return;
            }

            if (password != confirm)
            {
                lblMessage.Text = "Passwords do not match.";
                return;
            }

            try
            {
                object exists = DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM Users WHERE Username = @username",
                    new SqlParameter("@username", username));

                if (Convert.ToInt32(exists) > 0)
                {
                    lblMessage.Text = "Username already taken. Choose another.";
                    return;
                }

                string sql = "INSERT INTO Users (Username, Password, UserType, FullName, Phone) " +
                             "VALUES (@username, @password, @userType, @fullName, @phone)";

                DBHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@userType", selectedUserType),
                    new SqlParameter("@fullName", (object)fullName ?? DBNull.Value),
                    new SqlParameter("@phone", (object)phone ?? DBNull.Value));

                MessageBox.Show("Account created successfully! You can now log in.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
