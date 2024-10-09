using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class BuyPhonesControl : UserControl
    {
        private Timer scrollTimer = new Timer();
        private int scrollSpeed = 2; // Adjust for faster or slower motion
        private int itemSpacing = 10; // Spacing between items

        public BuyPhonesControl()
        {
            InitializeComponent();
            InitializeCarousel();
            RepositionItems();
            this.VisibleChanged += BuyPhonesControl_VisibleChanged;
        }

        private void InitializeCarousel()
        {
            scrollTimer.Interval = 50;  // Interval for smoother scrolling
            scrollTimer.Tick += ScrollTimer_Tick;
            scrollTimer.Start();
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Left -= scrollSpeed;
            }

            if (panel1.Controls.Count > 0 && panel1.Controls[0].Right < 0)
            {
                Control firstControl = panel1.Controls[0];
                panel1.Controls.RemoveAt(0);

                Control lastControl = panel1.Controls[panel1.Controls.Count - 1];
                firstControl.Left = lastControl.Right + itemSpacing; // Use consistent spacing
                panel1.Controls.Add(firstControl);
            }
        }

        private void RepositionItems()
        {
            int xPos = 0;
            foreach (Control control in panel1.Controls)
            {
                control.Left = xPos;
                xPos += control.Width + itemSpacing; // Ensure even spacing between controls
            }
        }

        private void BuyPhonesControl_Load(object sender, EventArgs e)
        {
            CustomizeControls();
            RepositionItems(); // Ensure the items are positioned correctly
        }

        private void CustomizeControls()
        {
            comboBoxBrand.FlatStyle = FlatStyle.Flat;
            comboBoxCondition.FlatStyle = FlatStyle.Flat;
            comboBoxBrand.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBoxCondition.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBoxBrand.BackColor = Color.White;
            comboBoxCondition.BackColor = Color.White;

            foreach (System.Windows.Forms.Label label in this.Controls.OfType<System.Windows.Forms.Label>())
            {
                label.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        // This method is invoked when a phone is clicked
        private void ShowPhoneDetails(string condition, string brandModel, string price, string[] imagePaths)
        {
            // Load the phone details into the PhoneDetailsControl

            // Assuming you have a method in your main form to switch views
            mainForm mainForm = this.FindForm() as mainForm;
            if (mainForm != null)
            {
                // Switch views or perform actions related to showing details
            }
        }

        // Remove LoadPhoneData and related SQL functionality
        // Method UpdatePhoneLabels can still be used but data needs to be provided manually.

        private void SetImage(PictureBox pictureBox, string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        private void BuyPhonesControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                scrollTimer.Stop();
            }
        }

        private void ShowControl(UserControl control)
        {
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement logic for home button click
        }

        private void listAPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement logic for list a phone button click
        }
    }
}
