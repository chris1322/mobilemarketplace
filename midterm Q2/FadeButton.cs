using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace midterm_Q2
{
    public class FadeButton : Button
    {
        private int opacity = 255; // Opacity value (0-255)

        /// <summary>
        /// Gets or sets the opacity of the button.
        /// </summary>
        public int OpacityValue
        {
            get { return opacity; }
            set
            {
                opacity = Math.Max(0, Math.Min(255, value)); // Clamp between 0 and 255
                this.Invalidate(); // Redraw the control to apply opacity
            }
        }

        public FadeButton()
        {
            // Enable user painting and double buffering to reduce flicker
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Create a color matrix and set the opacity
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = opacity / 255f; // Set the alpha value

            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Create a bitmap of the button
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            base.OnPaint(new PaintEventArgs(Graphics.FromImage(bmp), pevent.ClipRectangle));

            // Draw the bitmap with the opacity
            pevent.Graphics.DrawImage(bmp, new Rectangle(0, 0, this.Width, this.Height),
                0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);

            bmp.Dispose();
        }
    }
}
