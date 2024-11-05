using System;
using System.Collections.Generic;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamLib
{
    public class DeviceManager
    {
        private static List<Device> devices = new List<Device>();

        public static Device[] GetAllDevices()
        {
            // Clear previous devices if any
            devices.Clear();

            // Get the available video devices
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Loop through available video devices and create Device instances
            for (int i = 0; i < videoDevices.Count; i++)
            {
                Device device = new Device(i); // Use the current index
                devices.Add(device);
            }

            return devices.ToArray();
        }

        public static Device GetDevice(int deviceIndex)
        {
            if (deviceIndex < 0 || deviceIndex >= devices.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(deviceIndex), "Invalid device index.");
            }
            return devices[deviceIndex];
        }
    }
}
