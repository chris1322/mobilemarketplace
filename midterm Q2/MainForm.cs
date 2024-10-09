using System.Windows.Forms;
using System;

namespace midterm_Q2
{
    public partial class mainForm : Form
    {
        public Panel GetMainPanel()
        {
            return mainPanel;
        }

        public mainForm()
        {
            InitializeComponent();
            Load += mainForm_Load;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Instantiate HomeControl
            HomeControl homeControl = new HomeControl();

            // Display HomeControl in mainPanel
            ShowControl(homeControl);
        }

        public void ShowControl(Control control)
        {
            // Ensure you clear any existing controls first
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // No custom painting is needed here unless required for UI elements
        }
    }
}
