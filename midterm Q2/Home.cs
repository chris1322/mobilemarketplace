using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class Home : Form
    {
        public string CurrentUserName { get; set; }
        private string currentUserId;
        public Home(string userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        public Home()
        {
            InitializeComponent();
            this.Load += new EventHandler(Home_Load);

        }



        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Current User First Name: " + UserSession.CurrentUserFirstName);

            label1.Text = "Hello, " + UserSession.CurrentUserFirstName;
        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buyphones2 buyPhonesForm = new buyphones2();
            buyPhonesForm.Show();
            this.Hide();
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

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
    