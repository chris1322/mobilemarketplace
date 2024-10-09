using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace midterm_Q2
{
    public partial class PhoneDetailsControl : UserControl
    {
        private int currentIndex = 0;
        private List<string> imagePaths = new List<string>(); // Store image paths for navigation

        public PhoneDetailsControl()
        {
            InitializeComponent();
        }

        // Load the images into the control
        public void LoadImages(List<string> paths)
        {
            imagePaths = paths;
            currentIndex = 0; // Start with the first image
            UpdateMainImage();
            PopulateThumbnails();
        }

        // Populate the thumbnails in the FlowLayoutPanel
        private void PopulateThumbnails()
        {
            flowLayoutPanel1.Controls.Clear(); 
            foreach (var path in imagePaths)
            {
                if (File.Exists(path))
                {
                    PictureBox thumbnail = new PictureBox
                    {
                        Image = Image.FromFile(path),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(50, 50),
                        Margin = new Padding(5) 
                    };

                    thumbnail.Click += (s, e) =>
                    {
                        currentIndex = imagePaths.IndexOf(path);
                        UpdateMainImage();
                    };

                    flowLayoutPanel1.Controls.Add(thumbnail);
                }
            }
        }

        private void UpdateMainImage()
        {
            if (imagePaths.Count > 0 && currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                string currentImagePath = imagePaths[currentIndex];
                if (File.Exists(currentImagePath))
                {
                    pictureBoxMain.Image = Image.FromFile(currentImagePath);
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom; 
                }
                else
                {
                    MessageBox.Show($"Image file not found: {currentImagePath}");
                }
            }
        }

        // Handle left button click to move to the previous image
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateMainImage();
            }
        }

        // Handle right button click to move to the next image
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePaths.Count - 1)
            {
                currentIndex++;
                UpdateMainImage();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}