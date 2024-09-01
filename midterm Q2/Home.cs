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

        }



        private void Home_Load(object sender, EventArgs e)
        {
             label1.Text = "Hello, " + UserSession.CurrentUserFirstName;
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
            ProfileForm profileForm = new ProfileForm(UserSession.CurrentUserID);
            profileForm.Show();
            this.Hide();

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
    