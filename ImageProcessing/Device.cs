//using System;
//using AForge.Video;
//using AForge.Video.DirectShow;
//using System.Windows.Forms;
//using System.Drawing; // For Bitmap

//namespace WebCamLib
//{
//    public class Device
//    {
//        private FilterInfoCollection videoDevices;
//        private VideoCaptureDevice videoSource;
//        public string Name { get; private set; }
//        public string Version { get; private set; }
//        public int Index { get; private set; }

//        // Constructor to initialize Device
//        public Device(int index)
//        {
//            // Initialize the video devices collection
//            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

//            if (index < videoDevices.Count)
//            {
//                videoSource = new VideoCaptureDevice(videoDevices[index].MonikerString);
//                Name = videoDevices[index].Name;
//                Version = ""; // Set as needed
//                Index = index; // Set index
//            }
//            else
//            {
//                throw new ArgumentOutOfRangeException(nameof(index), "No video device found at the specified index.");
//            }
//        }

//        /// <summary>
//        /// Start the webcam and attach to a PictureBox control.
//        /// </summary>
//        /// <param name="pictureBox">PictureBox to display the video feed.</param>
//        public void Start(PictureBox pictureBox)
//        {
//            videoSource.NewFrame += (sender, eventArgs) =>
//            {
//                // Update the PictureBox with the new frame
//                if (pictureBox.InvokeRequired)
//                {
//                    pictureBox.Invoke(new Action(() => UpdatePictureBox(pictureBox, eventArgs)));
//                }
//                else
//                {
//                    UpdatePictureBox(pictureBox, eventArgs);
//                }
//            };

//            videoSource.Start();

//            // Optionally, set PictureBox properties here if needed
//            pictureBox.Visible = true; // Ensure the PictureBox is visible
//        }

//        private void UpdatePictureBox(PictureBox pictureBox, NewFrameEventArgs eventArgs)
//        {
//            // Dispose the current image if it exists
//            if (pictureBox.Image != null)
//                pictureBox.Image.Dispose();

//            // Create a new bitmap from the frame
//            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

//            pictureBox.Image = frame; // Update PictureBox with the flipped frame
//        }

//        /// <summary>
//        /// Stop the webcam and release resources.
//        /// </summary>
//        public void Stop(PictureBox pictureBox)
//        {
//            if (videoSource != null && videoSource.IsRunning)
//            {
//                videoSource.SignalToStop();
//                videoSource.WaitForStop();
//            }

//            // Clear the PictureBox image
//            if (pictureBox.Image != null)
//            {
//                pictureBox.Image.Dispose();
//                pictureBox.Image = null; // Clear the PictureBox
//            }
//        }

//        public override string ToString()
//        {
//            return this.Name;
//        }
//    }
//}
