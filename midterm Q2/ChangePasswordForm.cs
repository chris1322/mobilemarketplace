using System;
using System.Windows.Forms;
using System.Data;  
using System.Data.SqlClient;

namespace midterm_Q2
{
    public partial class ChangePasswordForm : Form
    {
        private int userId;
        private string username;
        private Database db;

        public ChangePasswordForm(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            db = new Database();

            LoadUserName();  
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            lblUsername.Visible = true;
        }

        private void LoadUserName()
        {
            string query = "SELECT FirstName FROM Users WHERE UserId = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", userId)
            };

            DataTable userData = db.ExecuteQuery(query, parameters);
            if (userData.Rows.Count > 0)
            {
                lblUsername.Text = userData.Rows[0]["FirstName"].ToString();
            }
            else
            {
                lblUsername.Text = "Unknown User";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                string updateQuery = "UPDATE Users SET Password = @Password WHERE UserId = @UserId";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Password", txtNewPassword.Text), 
                    new SqlParameter("@UserId", userId)
                };

                db.ExecuteNonQuery(updateQuery, parameters);
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
