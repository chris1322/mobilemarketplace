using midterm_Q2;
using System;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class HomeControl : UserControl
    {
        // Inside HomeControl
        private Panel mainPanel = new Panel();

        public HomeControl()
        {
            InitializeComponent();
            // Add mainPanel to the HomeControl
            this.Controls.Add(mainPanel); // Add the panel to the control/form

            // Optionally configure the panel (set size, location, etc.)
            mainPanel.Dock = DockStyle.Fill; // Dock it to fill the HomeControl

            // Create and add PhoneListControl to the mainPanel
            
           




        }

        private void buyPhonesViewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the parent form (mainForm) and show the BuyPhonesControl
            if (this.Parent is mainForm parentForm)
            {
                BuyPhonesControl buyPhonesControl = new BuyPhonesControl();
                parentForm.ShowControl(buyPhonesControl);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the parent form (mainForm) and show the SettingsUserControl
            if (this.Parent is mainForm parentForm)
            {
                SettingsUserControl settingsControl = new SettingsUserControl();
                parentForm.ShowControl(settingsControl);
            }
        }

       

        private void HomeControl_Load(object sender, EventArgs e)
        {
            // Optionally, show a default control on load if needed
        }

        private void listAPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mainForm parentForm = (mainForm)this.ParentForm;
            Panel mainPanel = parentForm.GetMainPanel();  // This gets the mainPanel from mainForm
            

            // Create an instance of PhoneListControl
            PhoneListControl phoneListControl = new PhoneListControl();
            parentForm.ShowControl(phoneListControl);
            
        }
    }
}
