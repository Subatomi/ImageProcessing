using System.Runtime.Intrinsics.X86;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    pixel = loaded.GetPixel(row, height);
                    processed.SetPixel(row, height, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void grayscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    pixel = loaded.GetPixel(row, height);
                    ave = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(ave, ave, ave);
                    processed.SetPixel(row, height, gray);
                }
            pictureBox2.Image = processed;
        }

        private void invertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    pixel = loaded.GetPixel(row, height);
                    Color invert = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(row, height, invert);
                }
            pictureBox2.Image = processed;
        }

        private void mirrorHorizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    pixel = loaded.GetPixel(loaded.Width - 1 - row, height);
                    processed.SetPixel(row, height, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void mirrorVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    pixel = loaded.GetPixel(row, loaded.Height - 1 - height);
                    processed.SetPixel(row, height, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void sepiaColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
                for (int height = 0; height < loaded.Height; height++)
                {
                    // Get pixel color components
                    pixel = loaded.GetPixel(row, height);
                    int A = pixel.A;
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;

                    // Calculate new sepia values
                    int newRed = (int)(0.393 * R + 0.769 * G + 0.189 * B);
                    int newGreen = (int)(0.349 * R + 0.686 * G + 0.168 * B);
                    int newBlue = (int)(0.272 * R + 0.534 * G + 0.131 * B);

                    // Clamp the values to the 0-255 range
                    R = Math.Min(255, newRed);
                    G = Math.Min(255, newGreen);
                    B = Math.Min(255, newBlue);

                    // Create new sepia color
                    Color sepia = Color.FromArgb(A, R, G, B);

                    // Set the pixel in the processed image
                    processed.SetPixel(row, height, sepia);
                }
            pictureBox2.Image = processed;
        }
    }

}
