using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KrishiSetuPro.Helpers;

namespace KrishiSetuPro.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UITheme.StylePrimaryButton(btnLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                string sql = "SELECT UserId, Username, UserType, FullName FROM Users " +
                             "WHERE Username = @username AND Password = @password";

                DataTable dt = DBHelper.ExecuteQuery(sql,
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password));

                if (dt.Rows.Count == 0)
                {
                    lblMessage.Text = "Invalid username or password.";
                    return;
                }

                DataRow row = dt.Rows[0];
                Session.UserId = Convert.ToInt32(row["UserId"]);
                Session.Username = row["Username"].ToString();
                Session.UserType = row["UserType"].ToString();
                Session.FullName = row["FullName"] == DBNull.Value ? "" : row["FullName"].ToString();

                this.Hide();

                switch (Session.UserType)
                {
                    case "Farmer":
                        new frmFarmerDashboard().ShowDialog();
                        break;
                    case "Buyer":
                        new frmBuyerDashboard().ShowDialog();
                        break;
                    case "Admin":
                        new frmAdminMenu().ShowDialog();
                        break;
                }

                Session.Clear();
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister regForm = new frmRegister();
            regForm.ShowDialog();
        }
    }
}
