using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class LoginForm : Form
    {
        private Database db;

        public LoginForm()
        {
            InitializeComponent();
            db = new Database();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // This is the form load event handler.
            // You can add any initialization code here.
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Hash the password for comparison
                string hashedPassword = HashPassword(password);

                // SQL query to check if the user exists with the correct username and password
                string query = "SELECT UserId, FirstName, Email FROM Users WHERE Username = @Username AND PasswordHashed = @PasswordHashed";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Username", username),
            new SqlParameter("@PasswordHashed", hashedPassword)
                };

                // Execute the query to find the user
                DataTable userData = db.ExecuteQuery(query, parameters);

                if (userData.Rows.Count > 0)
                {
                    // Successful login: Get user data
                    int userID = Convert.ToInt32(userData.Rows[0]["UserId"]);
                    string firstName = userData.Rows[0]["FirstName"].ToString();
                    string email = userData.Rows[0]["Email"].ToString();

                    // Set session data
                    Session.CurrentUserID = userID;
                    Session.CurrentUserFirstName = firstName;
                    Session.CurrentUserEmail = email;

                    // Return OK result to proceed to mainForm
                    this.DialogResult = DialogResult.OK;
                    this.Close();  // Close the login form
                }
                else
                {
                    // Invalid login, show error
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Method to hash the password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Open the sign-up form when the sign-up button is clicked
            SignUpFrom signUpForm = new SignUpFrom();
            signUpForm.ShowDialog();
        }
    }

    // Static session class to store user data after login
    public static class Session
    {
        public static int CurrentUserID { get; set; }
        public static string CurrentUserFirstName { get; set; }
        public static string CurrentUserEmail { get; set; }
    }
}
