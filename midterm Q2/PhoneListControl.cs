using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class PhoneListControl : UserControl
    {
        private Database db;
        private string selectedOS = "";
        private List<string> androidVersions = new List<string> { "", "Android 15", "Android 14", "Android 13", "Android 12", "Android 11", "Android 10" };
        private List<string> iosVersions = new List<string> { "", "iOS 18", "iOS 17", "iOS 16", "iOS 15", "iOS 14", "iOS 13" };

        public PhoneListControl()
        {
            InitializeComponent();
            db = new Database();
            Load += PhoneListControl_Load;
            btnAndroid.Click += btnAndroid_Click;
            btnIOS.Click += btnIOS_Click;
            btnChangeOS.Click += btnChangeOS_Click;
            btnImageUpload.Click += btnImageUpload_Click;
        }
        private void ShowControl(Control control)
        {
            Controls.Clear();
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void PhoneListControl_Load(object sender, EventArgs e)
        {

            cemail.Text = Session.CurrentUserEmail;
            Load += PhoneListControl_Load;
            cmbbrand.DrawMode = DrawMode.OwnerDrawFixed;
            cmbbrand.DrawItem += cmbbrand_DrawItem;
            cmbcondition.DrawMode = DrawMode.OwnerDrawFixed;
            cmbcondition.DrawItem += cmbcondition_DrawItem;
            cmbbrand.SelectedIndex = 0;
            cmbcondition.SelectedIndex = 0;            
            lblOSVersion.Visible = false;
            cmbOSVersion.Visible = false;
            btnChangeOS.Visible = false;
            cmbbrand.ForeColor = Color.Gray;
            cmbcondition.ForeColor = Color.Gray;
            cmbbrand.SelectedIndexChanged += cmbbrand_SelectedIndexChanged;
            cmbcondition.SelectedIndexChanged += cmbcondition_SelectedIndexChanged;
            ToggleOSSelectionVisibility(true);
           
        }

        private void cmbbrand_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string itemText = cmbbrand.Items[e.Index].ToString();
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            e.Graphics.DrawString(itemText, e.Font, e.Index == 0 ? Brushes.Gray : Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void cmbcondition_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string itemText = cmbcondition.Items[e.Index].ToString();
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            e.Graphics.DrawString(itemText, e.Font, e.Index == 0 ? Brushes.Gray : Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void cmbbrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbrand.ForeColor = cmbbrand.SelectedIndex == 0 ? Color.Gray : Color.Black;
        }

        private void cmbOSVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbcondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcondition.ForeColor = cmbcondition.SelectedIndex == 0 ? Color.Gray : Color.Black;
        }

        private void ToggleOSSelectionVisibility(bool showOSButtons)
        {
            lblOS.Visible = showOSButtons;
            btnAndroid.Visible = showOSButtons;
            btnIOS.Visible = showOSButtons;
        }

        private void ToggleOSVersionControlsVisibility(bool showOSVersionControls)
        {
            lblOSVersion.Visible = showOSVersionControls;
            cmbOSVersion.Visible = showOSVersionControls;
            btnChangeOS.Visible = showOSVersionControls;
        }

        private void btnAndroid_Click(object sender, EventArgs e)
        {
            selectedOS = "Android";
            ToggleOSSelectionVisibility(false);
            ToggleOSVersionControlsVisibility(true);
            cmbOSVersion.Items.Clear();
            cmbOSVersion.Items.AddRange(androidVersions.ToArray());
            cmbOSVersion.SelectedIndex = -1;
        }

        private void btnIOS_Click(object sender, EventArgs e)
        {
            selectedOS = "iOS";
            ToggleOSSelectionVisibility(false);
            ToggleOSVersionControlsVisibility(true);
            cmbOSVersion.Items.Clear();
            cmbOSVersion.Items.AddRange(iosVersions.ToArray());
            cmbOSVersion.SelectedIndex = -1;
        }

        private void btnChangeOS_Click(object sender, EventArgs e)
        {
            ToggleOSVersionControlsVisibility(false);
            ToggleOSSelectionVisibility(true);
            cmbOSVersion.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] fileNames = openFileDialog.FileNames;

                    if (pbpreview1.Image != null)
                    {
                        pbpreview4.Image = pbpreview3.Image;
                        pbpreview3.Image = pbpreview2.Image;
                        pbpreview2.Image = ResizeImage(pbpreview1.Image, 100, 100);
                    }

                    using (var fileStream = new FileStream(fileNames[0], FileMode.Open, FileAccess.Read))
                    {
                        pbpreview1.Image = ResizeImage(Image.FromStream(fileStream), 200, 200);
                    }
                }
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmodel_Leave(object sender, EventArgs e)
        {
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = db.GetConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int userId = Session.CurrentUserID;              
                string checkUserQuery = "SELECT COUNT(1) FROM Users WHERE userId = @userId";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn);
                checkUserCmd.Parameters.AddWithValue("@userId", Session.CurrentUserID);
                int userExists = (int)checkUserCmd.ExecuteScalar();
                if (userExists == 0)
                {
                    MessageBox.Show("User does not exist in the database.");
                    return;
                }

                string insertDeviceQuery = @"
        INSERT INTO Devices (
            userId, deviceBrand, deviceModel, deviceOs, deviceOsVersion, 
            deviceCondition, price, deviceDescription, createdAt, updatedAt
        ) VALUES (
            @userId, @deviceBrand, @deviceModel, @deviceOs, @deviceOsVersion, 
            @deviceCondition, @price, @deviceDescription, GETDATE(), GETDATE()
        );
        SELECT SCOPE_IDENTITY();";  

                SqlCommand cmd = new SqlCommand(insertDeviceQuery, conn);
            
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserID);
                cmd.Parameters.AddWithValue("@deviceBrand", cmbbrand.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@deviceModel", txtmodel.Text);
                cmd.Parameters.AddWithValue("@deviceOs", selectedOS);
                cmd.Parameters.AddWithValue("@deviceOsVersion", cmbOSVersion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@deviceCondition", cmbcondition.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@deviceDescription", des.Text);

                int deviceId = 0;
                try
                {
                    deviceId = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message); 
                    return;  
                }

                if (deviceId > 0)
                {
                    string[] imagePaths = { "image1_path", "image2_path", "image3_path" }; 

                    foreach (string filePath in imagePaths)
                    {
                        string insertPhotoQuery = @"
                INSERT INTO Photos (deviceId, filePath, uploadedAt) 
                VALUES (@deviceId, @filePath, GETDATE());";

                        SqlCommand photoCmd = new SqlCommand(insertPhotoQuery, conn);
                        photoCmd.Parameters.AddWithValue("@deviceId", deviceId); 
                        photoCmd.Parameters.AddWithValue("@filePath", filePath); 

                        photoCmd.ExecuteNonQuery(); 
                    }
                    
                }
                else
                {
                    MessageBox.Show("Device insert failed. No photos inserted.");
                }

                conn.Close();
            }
        }

    }
}
