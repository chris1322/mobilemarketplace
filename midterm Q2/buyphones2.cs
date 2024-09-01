using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class buyphones2 : Form
    {
        private Database db;
        private int userID = UserSession.CurrentUserID;
       

       
        public buyphones2()
        {
            InitializeComponent();
            db = new Database(); 
        }

        private void buyphones2_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            UpdateCartItemCount(); 
        }

        // Method to load and display phones in the DataGridView
        


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string brand = cmbBrand.SelectedItem?.ToString();
            string condition = cmbCondition.SelectedItem?.ToString();
            string maxPriceText = txtMaxPrice.Text;

            decimal? maxPrice = string.IsNullOrWhiteSpace(maxPriceText) ? (decimal?)null : Convert.ToDecimal(maxPriceText);

            PopulateDataGridView(brand, condition, maxPrice);  // Use LoadPhones to filter and display phones
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userID = UserSession.CurrentUserID;
                int productID = Convert.ToInt32(selectedRow.Cells["PhoneID"].Value);
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                int quantity = 1;
                MessageBox.Show("UserID being used: " + userID);

                string query = "INSERT INTO ShoppingCart (UserID, ProductID, Quantity, Price) VALUES (@UserID, @ProductID, @Quantity, @Price)";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@UserID", userID),
            new SqlParameter("@ProductID", productID),
            new SqlParameter("@Quantity", quantity),
            new SqlParameter("@Price", price)
                };

                try
                {
                    db.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Product added to the cart successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userID = Session.CurrentUserID;

            string query = "DELETE FROM ShoppingCart WHERE UserID = @UserID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            try
            {
                db.ExecuteNonQuery(query, parameters);  // Clear the shopping cart in the database

                
                UpdateCartItemCount();// Refresh the DataGridView to show an empty cart

                MessageBox.Show("Shopping cart cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the cart: " + ex.Message);
            }
        }

        // Method to load and display the shopping cart items in the DataGridView
        private void LoadShoppingCart()
        {
            int userID = Session.CurrentUserID;
            string query = "SELECT * FROM ShoppingCart WHERE UserID = @UserID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            DataTable cartData = db.ExecuteQuery(query, parameters);

            dataGridView1.DataSource = cartData;  // Display shopping cart data
        }
        private int GetCartItemCount()
        {
            int userID = Session.CurrentUserID;
            string query = "SELECT COUNT(*) FROM ShoppingCart WHERE UserID = @UserID";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", userID)
            };

            try
            {
                object result = db.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while counting cart items: " + ex.Message);
                return 0; // Return 0 in case of an error
            }

        }
        private void UpdateCartItemCount()
        {
            int itemCount = GetCartItemCount();
            lblcartitems.Text = $"Cart Items: {itemCount}";
        }
        private void PopulateDataGridView(string brand = null, string condition = null, decimal? maxPrice = null)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Phones1 WHERE 1 = 1");

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(brand))
            {
                query.Append(" AND Brand = @Brand");
                parameters.Add(new SqlParameter("@Brand", brand));
            }

            if (!string.IsNullOrEmpty(condition))
            {
                query.Append(" AND Condition = @Condition");
                parameters.Add(new SqlParameter("@Condition", condition));
            }

            if (maxPrice.HasValue)
            {
                query.Append(" AND Price <= @MaxPrice");
                parameters.Add(new SqlParameter("@MaxPrice", maxPrice.Value));
            }

            try
            {
                // Use the Database class to execute the query
                DataTable dataTable = db.ExecuteQuery(query.ToString(), parameters.ToArray());

                // Bind the result to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(UserSession.CurrentUserID.ToString());
            homeForm.CurrentUserName = "Kyle";
            homeForm.Show();
            this.Hide();
        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellPhonesForm sellPhonesForm = new SellPhonesForm();
            sellPhonesForm.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(UserSession.CurrentUserID);
            profileForm.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
