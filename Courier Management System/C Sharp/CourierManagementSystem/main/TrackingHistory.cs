using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class TrackingHistory
    {
        public void ShowTrackingHistory()
        {
            string[] trackingUpdates = {
                "Order Received",
                "Dispatched from warehouse",
                "Arrived at city hub",
                "Out for delivery",
                "Delivered"
            };

            Console.WriteLine("Tracking History:");
            foreach (string update in trackingUpdates)
            {
                Console.WriteLine($"- {update}");
            }
        }
    }
    }
}
