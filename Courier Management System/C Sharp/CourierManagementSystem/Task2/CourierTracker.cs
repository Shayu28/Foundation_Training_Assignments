using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task2
{
    public class CourierTracker
    {
        public static void TrackCourier(string[] locations)
        {
            int i = 0;
            while (i < locations.Length)
            {
                Console.WriteLine($"Current Location: {locations[i]}");
                i++;
            }
            Console.WriteLine("Courier delivered!");
        }
    }

}
