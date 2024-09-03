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
    public partial class BuyPhonesForm : Form
    {
        private Database db;
        private int currentUserId;
        public BuyPhonesForm()
        {
            InitializeComponent();            
            db = new Database();
            LoadPhoneListings();
         
        }

        private void LoadPhoneListings()
        {
            string query = "SELECT PhoneModel, Brand, Price, Condition, SellerContact FROM Phones WHERE Available = 1";
            DataTable phones = db.ExecuteQuery(query);
            dataGridViewPhones.DataSource = phones;
        }

        private void BuyPhonesForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT PhoneModel, Price, Condition, SellerContact FROM Phones WHERE Available = 1";
            DataTable phones = db.ExecuteQuery(query); // Assuming `db` is your Database object

            dataGridViewPhones.DataSource = phones;
            comboBoxBrand.Items.Add("Any");
            comboBoxBrand.Items.AddRange(new string[] { "Apple", "Samsung", "Google", "Nokia", "LG" });

            // Populate Condition ComboBox with static data
            comboBoxCondition.Items.Add("All");
            comboBoxCondition.Items.AddRange(new string[] { "New", "Like New", "Used", "Refurbished" });

            // Optional: Select the first item in each ComboBox to prevent null selection
            if (comboBoxBrand.Items.Count > 0)
                comboBoxBrand.SelectedIndex = 0;

            if (comboBoxCondition.Items.Count > 0)
                comboBoxCondition.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.SelectedItem?.ToString();
            string condition = comboBoxCondition.SelectedItem?.ToString();
            decimal maxPrice;
            bool isMaxPriceValid = decimal.TryParse(textBoxMaxPrice.Text, out maxPrice);

            // Build the SQL query with filters
            string query = "SELECT PhoneModel, Brand, Price, Condition, SellerContact FROM Phones WHERE Available = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Apply brand filter if "Any" is not selected
            if (!string.IsNullOrEmpty(brand) && brand != "Any")
            {
                query += " AND Brand = @Brand";
                parameters.Add(new SqlParameter("@Brand", brand));
            }

            // Apply condition filter if "All" is not selected
            if (!string.IsNullOrEmpty(condition) && condition != "All")
            {
                query += " AND Condition = @Condition";
                parameters.Add(new SqlParameter("@Condition", condition));
            }

            // Apply max price filter if it is provided and valid
            if (isMaxPriceValid && maxPrice > 0)
            {
                query += " AND Price <= @MaxPrice";
                parameters.Add(new SqlParameter("@MaxPrice", maxPrice));
            }

            // Execute the query with the specified filters
            DataTable phones = db.ExecuteQuery(query, parameters.ToArray());

            // Bind the results to the DataGridView
            dataGridViewPhones.DataSource = phones;
        }


        private void btnBuyNow_Click(object sender, EventArgs e)
            {
                if (dataGridViewPhones.SelectedRows.Count > 0)
                {
                    // Assuming PhoneModel is in the first column
                    string phoneModel = dataGridViewPhones.SelectedRows[0].Cells["PhoneModel"].Value.ToString();

                    // Confirm the purchase
                    DialogResult result = MessageBox.Show($"Do you want to buy {phoneModel}?", "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Update the database to mark the phone as sold
                        string updateQuery = "UPDATE Phones SET Available = 0 WHERE PhoneModel = @PhoneModel";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                new SqlParameter("@PhoneModel", phoneModel)
                        };

                        db.ExecuteNonQuery(updateQuery, parameters);

                        MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the listings
                        LoadPhoneListings();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a phone to buy.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(UserSession.CurrentUserID.ToString());
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
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    } 
