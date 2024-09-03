using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class BuyPhonesControl : UserControl
    {
        private Database db;

        public BuyPhonesControl()
        {
            InitializeComponent();
            db = new Database();
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void BuyPhonesControl_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            UpdateCartItemCount();
            dataGridView1.Columns["UserId"].Visible = false;
            dataGridView1.Columns["productId"].Visible = false;

            dataGridView1.Columns["select"].Width = 40;
            dataGridView1.Columns["brand"].Width = 60;
            dataGridView1.Columns["modelName"].Width = 85;
            dataGridView1.Columns["condition"].Width = 60;
            dataGridView1.Columns["price"].Width = 60;
            dataGridView1.Columns["description"].Width = 110;
            dataGridView1.Columns["sellerEmail"].Width = 60;
            dataGridView1.Columns["available"].Width = 40;
            dataGridView1.Columns["dateListed"].Width = 125;

            // Set DataGridView properties to prevent automatic resizing that might override your settings
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = true;
            if (dataGridView1.Columns["select"] == null) // Check if the "select" column does not already exist
            {
                DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
                selectColumn.Name = "select";
                selectColumn.HeaderText = "Select";
                selectColumn.Width = 50;
                dataGridView1.Columns.Insert(0, selectColumn); // Insert as the first column
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["select"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["select"];
                bool isChecked = (checkbox.Value == null ? false : (bool)checkbox.Value);
                checkbox.Value = !isChecked;

                dataGridView1.Rows[e.RowIndex].Selected = !isChecked;
            }
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
                DataTable dataTable = db.ExecuteQuery(query.ToString(), parameters.ToArray());

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }

        private void UpdateCartItemCount()
        {
            int itemCount = GetCartItemCount();
            lblcartitems.Text = $"Cart Items: {itemCount}";
        }

        private int GetCartItemCount()
        {
            int userID = UserSession.CurrentUserID;
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
                return 0;
            }
        }
    }
}
