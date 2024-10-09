using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace midterm_Q2
{
    public partial class SignUpFrom : Form
    {
        private Database db;
        public SignUpFrom()
        {
            InitializeComponent();
            db = new Database();
        }       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get values from form fields
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtCPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string contactNumber = txtContactNumber.Text;

            // Validate all fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE userName = @Username";
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

            // Hash the password
            string hashedPassword = HashPassword(password);

            // Insert new user into the database
            string insertQuery = "INSERT INTO Users (userName, passwordHashed, firstName, lastName, email, contactNumber) " +
                                 "VALUES (@Username, @PasswordHashed, @FirstName, @LastName, @Email, @ContactNumber)";
            SqlParameter[] insertParams = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHashed", hashedPassword),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@ContactNumber", contactNumber)
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Close();  // Close the form without registering
            }
        }

        private void schkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            {
                // Toggle password visibility
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
                txtCPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            }
        }

        private void SSignUpFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
