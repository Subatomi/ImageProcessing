using AForge.Video.DirectShow;
using System.Runtime.Intrinsics.X86;
//using WebCamLib;
using ImageProcess2;
using AForge.Video;
using System.Diagnostics;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Bitmap imageA, imageB, colorgreen;
        private FilterInfoCollection videoDevices; // AForge collection for video devices
        private VideoCaptureDevice videoSource; // AForge video source for capturing from webcam
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

        private void histToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Hist(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Equalisation(ref loaded, ref processed, trackBar2.Value / 100);
            pictureBox2.Image = processed;
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Scale(ref loaded, ref processed, 100, 100);
            pictureBox2.Image = processed;
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    ave = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    if (ave < 180)
                        processed.SetPixel(x, y, Color.Black);
                    else
                        processed.SetPixel(x, y, Color.White);
                }
            pictureBox2.Image = processed;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                videoSource.Start();
            }
            else
            {
                MessageBox.Show("No video sources found.");
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            timer1.Enabled = false;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            loaded = (Bitmap)eventArgs.Frame.Clone();
            loaded.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = loaded;
            pictureBox5.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                try
                {
                    processed = (Bitmap)pictureBox1.Image.Clone();

                    BitmapFilter.GrayScale(processed);
                    pictureBox2.Image = processed;
                }
                catch (InvalidOperationException)
                {
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            pictureBox2.Image = processed;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Rotate(ref loaded, ref processed, trackBar3.Value);
            pictureBox2.Image = processed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;
            colorgreen = new Bitmap(imageB.Width, imageB.Height);
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtactvalue = Math.Abs(grey - greygreen);
                    if (subtactvalue > threshold)
                    {
                        colorgreen.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        colorgreen.SetPixel(x, y, backpixel);
                    }

                }
            }
            pictureBox5.Image = colorgreen;
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox1.Image = imageB;
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox2.Image = imageA;

        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.Sharpen(m, 11);
            pictureBox2.Image = m;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.GaussianBlur(m, 11);
            pictureBox2.Image = m;
        }

        private void edgeEnhanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeEnhance(m, 11);
            pictureBox2.Image = m;
        }

        private void edgeDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EmbossLaplacian(m);
            pictureBox2.Image = m;
        }

        private void edgeDetectQuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeDetectQuick(m);
            pictureBox2.Image = m;
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeDetectConvolution(m, 2, 75);
            pictureBox2.Image = m;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeDetectConvolution(m, 1, 75);
            pictureBox2.Image = m;
        }

        private void kirshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeDetectConvolution(m, 3, 75);
            pictureBox2.Image = m;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BasicDIP.EdgeDetectConvolution(m, 1, 75);
            pictureBox2.Image = m;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BasicDIP.EdgeDetectConvolution(m, 2, 75);
            pictureBox2.Image = m;
        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BasicDIP.EdgeDetectConvolution(m, 3, 75);
            pictureBox2.Image = m;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BasicDIP.EdgeDetectConvolution(m, 4, 75);
            pictureBox2.Image = m;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BasicDIP.EdgeDetectConvolution(m, 5, 75);
            pictureBox2.Image = m;
        }

        private void edgeDetectQuickToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap m = (Bitmap)pictureBox1.Image.Clone();
            BitmapFilter.EdgeDetectQuick(m);
            pictureBox2.Image = m;
        }
    }

}
