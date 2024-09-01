using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class ProfileForm : Form
    {
        private Database db;
        private int currentUserId;

        // Constructor that accepts a userId parameter
        public ProfileForm(int userId)
        {
            InitializeComponent();
            db = new Database();
            currentUserId = userId;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserData();

            // Initially, textboxes are read-only
            SetReadOnly(true);
        }

        private void LoadUserData()
        {
            string query = "SELECT FirstName, LastName, Email FROM Users WHERE UserId = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", currentUserId)
            };

            DataTable userData = db.ExecuteQuery(query, parameters);
            if (userData.Rows.Count > 0)
            {
                txtUsername.Text = $"{userData.Rows[0]["FirstName"].ToString()} {userData.Rows[0]["LastName"].ToString()}";
                txtEmail.Text = userData.Rows[0]["Email"].ToString();
                txtContactInfo.Text = userData.Rows[0]["Email"].ToString();
            }
        }

        private void SetReadOnly(bool isReadOnly)
        {
           
            txtEmail.ReadOnly = isReadOnly;
            txtContactInfo.ReadOnly = isReadOnly;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] names = txtUsername.Text.Split(' ');
            string firstName = names[0];
            string lastName = names.Length > 1 ? names[1] : "";

            // Update the database with the new information
            string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE UserId = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@UserId", currentUserId)
            };

            db.ExecuteNonQuery(updateQuery, parameters);

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Revert textboxes to read-only mode
            SetReadOnly(true);
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(UserSession.CurrentUserID.ToString());
            homeForm.Show();
            this.Hide();
        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyPhonesForm buyPhonesForm = new BuyPhonesForm();
            buyPhonesForm.Show();
            this.Hide();
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellPhonesForm sellPhonesForm = new SellPhonesForm();
            sellPhonesForm.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox(
            "Please enter your current password:",
            "Verify Password",
            "",
            -1, -1
             );

            if (string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string query = "SELECT Password FROM Users WHERE UserId = @UserId";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserId", currentUserId)
            };

            DataTable userData = db.ExecuteQuery(query, parameters);
            if (userData.Rows.Count > 0)
            {
                string storedPassword = userData.Rows[0]["Password"].ToString();

                if (inputPassword == storedPassword)  
                {
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(currentUserId, txtUsername.Text);
                    changePasswordForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
