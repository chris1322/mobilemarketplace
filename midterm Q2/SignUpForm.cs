using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class SignUpForm : Form
    {
        private Database db;

        public SignUpForm()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = stxtUsername.Text;
            string password = stxtPassword.Text;
            string confirmPassword = stxtCPassword.Text;
            string email = stxtEmail.Text;

         
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlParameter[] checkParams = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            int userExists = (int)db.ExecuteScalar(checkQuery, checkParams);
            if (userExists > 0)
            {
                MessageBox.Show("Username already exists. Please choose another.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string insertQuery = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
            SqlParameter[] insertParams = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@Email", email)
            };

            int result = db.ExecuteNonQuery(insertQuery, insertParams);
            if (result > 0)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the sign-up form
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
       
        }
    }
}
        