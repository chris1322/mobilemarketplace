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
using static System.Collections.Specialized.BitVector32;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Query to retrieve the user's ID, FirstName, and Email based on their username and password
            string query = "SELECT UserId, FirstName, Email FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", password)
            };

            try
            {
                DataTable userData = db.ExecuteQuery(query, parameters);

                if (userData.Rows.Count > 0)
                {
                    // Retrieving the UserID, FirstName, and Email from the query result
                    int userID = Convert.ToInt32(userData.Rows[0]["UserID"]);
                    string firstName = userData.Rows[0]["FirstName"].ToString();
                    string email = userData.Rows[0]["Email"].ToString();

                    // Setting the session variables with the retrieved data
                    UserSession.CurrentUserID = userID;
                    UserSession.CurrentUserFirstName = firstName;
                    UserSession.CurrentUserEmail = email;

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.StartPosition = FormStartPosition.Manual;
            int xPos = this.Location.X + (this.Width - signUpForm.Width) / 2;
            int yPos = this.Location.Y + (this.Height - signUpForm.Height) / 2;
            xPos = Math.Max(xPos, 0); 
            yPos = Math.Max(yPos, 0);  
            signUpForm.Location = new Point(xPos, yPos);           
            signUpForm.ShowDialog();
        }
    }
    public static class Session
    {
        public static int CurrentUserID { get; set; }
    }

}
