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
    public partial class SellPhonesForm : Form
    {
        private Database db;
        private int currentUserId;

        public SellPhonesForm()
        {
            InitializeComponent();

            db = new Database();

            this.Load += new EventHandler(SellPhonesForm_Load);
        }

        private void SellPhonesForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.CurrentUserEmail);
            txtSellerContact.Text = UserSession.CurrentUserEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.SelectedItem?.ToString();  // Assuming comboBoxBrand is the dropdown for brand
            string modelName = txtModelName.Text;                   // Assuming txtModelName is the textbox for model name
            string condition = comboBoxCondition.SelectedItem?.ToString();  // Assuming comboBoxCondition is the dropdown for condition
            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = txtDescription.Text;
            int userId = UserSession.CurrentUserID; 
            string sellerEmail = UserSession.CurrentUserEmail; 

           
            string insertQuery = "INSERT INTO Phones1 ([select], UserId, brand, modelName, condition, price, description, sellerEmail, available, dateListed) " +
                                 "VALUES (0, @UserId, @Brand, @ModelName, @Condition, @Price, @Description, @SellerEmail, 1, GETDATE())";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserId", userId),
        new SqlParameter("@Brand", brand),
        new SqlParameter("@ModelName", modelName),
        new SqlParameter("@Condition", condition),
        new SqlParameter("@Price", price),
        new SqlParameter("@Description", description),
        new SqlParameter("@SellerEmail", sellerEmail)
            };

            db.ExecuteNonQuery(insertQuery, parameters);

            MessageBox.Show("Your phone has been listed for sale!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            txtModelName.Clear();
            comboBoxBrand.SelectedIndex = 0;
            comboBoxCondition.SelectedIndex = 0;
            txtPrice.Clear();
            txtDescription.Clear();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(UserSession.CurrentUserID.ToString());
            homeForm.Show();
            this.Hide();
        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buyphones2 buyPhonesForm = new buyphones2();
            buyPhonesForm.Show();
            this.Hide();
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
