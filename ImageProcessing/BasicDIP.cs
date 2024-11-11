using ImageProcess2;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class BasicDIP
    {
        public const short EDGE_DETECT_HORZ_ONLY = 1;
        public const short EDGE_DETECT_VERT_ONLY = 2;
        public const short EDGE_DETECT_HORZ_VERT = 3;
        public const short EDGE_DETECT_ALL_DIR = 4;
        public const short EDGE_DETECT_LOSSY = 5;


        public static void Subtract(ref Bitmap a, ref Bitmap b, ref Bitmap result, int value)
        {
            result = new Bitmap(a.Width, a.Height);
            byte agraydata = 0;
            byte bgraydata = 0;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    Color adata = a.GetPixel(x, y);
                    Color bdata = b.GetPixel(x, y);

                    agraydata = (byte)((adata.R + adata.G + adata.B) / 3);
                    bgraydata = (byte)((bdata.R + bdata.G + bdata.B) / 3);
                    if (Math.Abs(agraydata - bgraydata) > value)
                        result.SetPixel(x, y, Color.Red);
                    else
                        result.SetPixel(x, y, bdata);

                }

            }

        }

        public static void Scale(ref Bitmap a, ref Bitmap b, int nwidth, int nheight)
        {
            int targetWidth = nwidth;
            int targetHeight = nheight;
            int xTarget, yTarget, xSource, ySource;
            int width = a.Width;
            int height = a.Height;
            b = new Bitmap(targetWidth, targetHeight);

            for (xTarget = 0; xTarget < targetWidth; xTarget++)
            {
                for (yTarget = 0; yTarget < targetHeight; yTarget++)
                {
                    xSource = xTarget * width / targetWidth;
                    ySource = yTarget * height / targetHeight;
                    b.SetPixel(xTarget, yTarget, a.GetPixel(xSource, ySource));
                }
            }
        }

        public static void Rotate(ref Bitmap a, ref Bitmap b, int value)
        {
            float angleRadians = (float)(value * Math.PI / 180);
            int xCenter = (int)(a.Width / 2);
            int yCenter = (int)(a.Height / 2);
            int width, height, xs, ys, xp, yp, x0, y0;
            float cosA, sinA;
            cosA = (float)Math.Cos(angleRadians);
            sinA = (float)Math.Sin(angleRadians);
            width = a.Width;
            height = a.Height;
            b = new Bitmap(width, height);
            for (xp = 0; xp < width; xp++)
            {
                for (yp = 0; yp < height; yp++)
                {
                    x0 = xp - xCenter;  //translate to (0,0)
                    y0 = yp - yCenter;
                    xs = (int)(x0 * cosA + y0 * sinA); // rotate around the original img
                    ys = (int)(-x0 * sinA + y0 * cosA);
                    xs = (int)(xs + xCenter);         // translate back to (xCenter, yCenter)
                    ys = (int)(ys + yCenter);
                    xs = Math.Max(0, Math.Min(width - 1, xs));
                    ys = Math.Max(0, Math.Min(height - 1, ys));
                    b.SetPixel(xp, yp, a.GetPixel(xs, ys));
                }
            }
        }

        public static void Equalisation(ref Bitmap a, ref Bitmap b, int degree)
        {
            int height = a.Height;
            int width = a.Width;
            int numSamples, histSum;
            int[] Ymap = new int[256];
            int[] hist = new int[256];
            int percent = degree;

            // Compute the histogram from the sub-image
            Color nakuha;
            Color gray;
            Byte graydata;

            // Compute greyscale
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    nakuha = a.GetPixel(x, y);
                    graydata = (byte)((nakuha.R + nakuha.G + nakuha.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);

                }

            }

            // Histogram 1d data
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    nakuha = a.GetPixel(x, y);
                    hist[nakuha.B]++;
                }
            }

            // Remap the Ys, use the maximum contrast (percent = 100)
            // based on histogram equalization
            numSamples = (a.Width * a.Height);
            histSum = 0;
            for (int h = 0; h < 256; h++)
            {
                histSum += hist[h];
                Ymap[h] = histSum * 255 / numSamples;
            }

            // if desired contrast is not maximum (percent < 100), then adjust the mapping
            if (percent < 100)
            {
                for (int h = 0; h < 256; h++)
                {
                    Ymap[h] = h + ((int)Ymap[h] - h) * percent / 100;
                }
            }

            b = new Bitmap(a.Width, a.Height);
            // enhance the region by mapping the intensities
            for (int y = 0; y < a.Height; y++)
            {
                for (int x = 0; x < a.Width; x++)
                {
                    // Set the new value of the gray value
                    Color temp = Color.FromArgb(Ymap[a.GetPixel(x, y).R], Ymap[a.GetPixel(x, y).G], Ymap[a.GetPixel(x, y).B]);
                    b.SetPixel(x, y, temp);
                }
            }
        }

        public static void Brightness(ref Bitmap a, ref Bitmap b, int value)
        {
            b = new Bitmap(a.Width, a.Height);
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    Color temp = a.GetPixel(x, y);
                    Color changed;

                    if (value > 0)
                    {
                        changed = Color.FromArgb(Math.Min(temp.R + value, 255), Math.Min(temp.G + value, 255), Math.Min(temp.B + value, 255));
                    }
                    else
                    {
                        changed = Color.FromArgb(Math.Max(temp.R + value, 0), Math.Max(temp.G + value, 0), Math.Max(temp.B + value, 0));
                    }
                    b.SetPixel(x, y, changed);
                }
            }
        }

        public static void Hist(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;

            //Grayscale Convertion
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }

            int[] histdata = new int[256];

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.R]++;
                }
            }

            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }


        public static bool EdgeDetectConvolution(Bitmap b, short nType, byte nThreshold)
        {
            ConvMatrix m = new ConvMatrix();

            // I need to make a copy of this bitmap BEFORE I alter it
            Bitmap bTemp = (Bitmap)b.Clone();

            // Set convolution matrices based on the edge detection type
            switch (nType)
            {
                // Define custom edge detection types
                case EDGE_DETECT_HORZ_VERT:
                    m.SetAll(0);
                    m.TopLeft = m.BottomLeft = -1;
                    m.TopRight = m.BottomRight = 1;
                    m.MidLeft = m.MidRight = 0;
                    m.Offset = 1 + 127;  
                    break;

                case EDGE_DETECT_ALL_DIR:
                    m.SetAll(-1);
                    m.Pixel = 8;
                    m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = -1;
                    m.Offset = 1 + 127;
                    break;

                case EDGE_DETECT_LOSSY:
                    m.SetAll(1);
                    m.TopLeft = m.TopRight = 1;
                    m.MidLeft = m.MidRight = -2;
                    m.BottomLeft = m.BottomRight = 1;
                    m.Offset = 1 + 127;  
                    break;

                case EDGE_DETECT_HORZ_ONLY:
                    m.SetAll(0);
                    m.TopLeft = m.MidLeft = m.BottomLeft = -1;
                    m.TopRight = m.MidRight = m.BottomRight = 1;
                    m.Offset = 1 + 127;  
                    break;

                case EDGE_DETECT_VERT_ONLY:
                    m.SetAll(0);
                    m.TopLeft = m.TopMid = m.TopRight = -1;
                    m.MidLeft = m.MidRight = 2;
                    m.BottomLeft = m.BottomMid = m.BottomRight = -1;
                    m.Offset = 1 + 127;  
                    break;
            }
            BitmapFilter.Conv3x3(b, m);

            switch (nType)
            {
                case EDGE_DETECT_HORZ_VERT:
                    m.SetAll(0);
                    m.TopLeft = m.BottomLeft = -1;
                    m.TopRight = m.BottomRight = 1;
                    m.MidLeft = m.MidRight = 0;
                    m.Offset = 1 + 127;  
                    break;

                case EDGE_DETECT_ALL_DIR:
                    m.SetAll(-1);
                    m.Pixel = 8;
                    m.TopLeft = m.TopRight = m.BottomLeft = m.BottomRight = -1;
                    m.Offset = 1 + 127;  
                    break;

                case EDGE_DETECT_LOSSY:
                    m.SetAll(1);
                    m.TopLeft = m.TopRight = 1;
                    m.MidLeft = m.MidRight = -2;
                    m.BottomLeft = m.BottomRight = 1;
                    m.Offset = 1 + 127;
                    break;

                case EDGE_DETECT_HORZ_ONLY:
                    m.SetAll(0);
                    m.TopLeft = m.MidLeft = m.BottomLeft = -1;
                    m.TopRight = m.MidRight = m.BottomRight = 1;
                    m.Offset = 1 + 127; 
                    break;

                case EDGE_DETECT_VERT_ONLY:
                    m.SetAll(0);
                    m.TopLeft = m.TopMid = m.TopRight = -1;
                    m.MidLeft = m.MidRight = 2;
                    m.BottomLeft = m.BottomMid = m.BottomRight = -1;
                    m.Offset = 1 + 127; 
                    break;
            }
            BitmapFilter.Conv3x3(bTemp, m);

            // GDI+ returns image data in BGR, not RGB, so we process the data accordingly
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmData2 = bTemp.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            IntPtr Scan0 = bmData.Scan0;
            IntPtr Scan02 = bmData2.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan02;

                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;

                int nPixel = 0;

                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = (int)Math.Sqrt((p[0] * p[0]) + (p2[0] * p2[0]));

                        if (nPixel < nThreshold)
                            nPixel = nThreshold;
                        if (nPixel > 255)
                            nPixel = 255;

                        p[0] = (byte)nPixel;

                        ++p;
                        ++p2;
                    }
                    p += nOffset;
                    p2 += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bTemp.UnlockBits(bmData2);

            return true;
        }

    }
}