using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MainForm: Form
    {
        public MainForm()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var homeControl = new HomeControl(UserSession.CurrentUserID.ToString());
            ShowControl(homeControl);
            
        }

        public void ShowControl(UserControl control)
        {
            panel1.Controls.Clear(); 
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
