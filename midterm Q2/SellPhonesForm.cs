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
        }

        private void SellPhonesForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneModel = txtPhoneModel.Text;
            string brand = comboBoxBrand.SelectedItem?.ToString();
            string condition = comboBoxCondition.SelectedItem?.ToString();
            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = txtDescription.Text;
            string sellerContact = txtSellerContact.Text;

            // Insert the phone into the database
            string insertQuery = "INSERT INTO Phones (PhoneModel, Brand, Price, Condition, Description, SellerContact, Available, DateListed) " +
                                 "VALUES (@PhoneModel, @Brand, @Price, @Condition, @Description, @SellerContact, 1, GETDATE())";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@PhoneModel", phoneModel),
        new SqlParameter("@Brand", brand),
        new SqlParameter("@Price", price),
        new SqlParameter("@Condition", condition),
        new SqlParameter("@Description", description),
        new SqlParameter("@SellerContact", sellerContact)
            };

            db.ExecuteNonQuery(insertQuery, parameters);
            MessageBox.Show("Your phone has been listed for sale!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, clear the form fields after submission
            txtPhoneModel.Clear();
            comboBoxBrand.SelectedIndex = 0;
            comboBoxCondition.SelectedIndex = 0;
            txtPrice.Clear();
            txtDescription.Clear();
            txtSellerContact.Clear();
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

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(currentUserId);
            profileForm.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
