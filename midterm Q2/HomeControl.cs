using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class HomeControl : UserControl
    {
        private string userId;
        private MainForm parentForm;

        public HomeControl(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            parentForm = this.FindForm() as MainForm;

            if (parentForm == null)
            {
                MessageBox.Show("Parent form not set correctly!");
                return;
            }

            lblHello.Text = "Hello, " + UserSession.CurrentUserFirstName;
            lblSubtitle.Text = "Explore the latest deals\r\nand\r\nfind your next phone!";

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                {
                    control.Margin = new Padding(10);
                }
            }


        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure that the parent form is set when the control is loaded
            ShowControl(new BuyPhonesControl());
        }

        private void ShowControl(UserControl control)
        {
            if (parentForm != null)
            {
                parentForm.ShowControl(control);
            }
            else
            {
                MessageBox.Show("Parent form not set!");
            }
        }
    }
}
