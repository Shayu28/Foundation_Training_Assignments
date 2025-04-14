using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class ParcelTracker
    {
        string[,] trackingInfo = new string[3, 2]
        {
            {"TRK123", "In Transit"},
            {"TRK456", "Out for Delivery"},
            {"TRK789", "Delivered"}
        };

        public void TrackParcel(string trackingNumber)
        {
            bool found = false;
            for (int i = 0; i < trackingInfo.GetLength(0); i++)
            {
                if (trackingInfo[i, 0] == trackingNumber)
                {
                    Console.WriteLine($"Tracking Number: {trackingNumber}, Status: {trackingInfo[i, 1]}");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Tracking number not found.");
        }
    }
}
