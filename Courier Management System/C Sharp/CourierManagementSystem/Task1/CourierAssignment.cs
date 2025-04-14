using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task1
{
    // main/CourierAssignment.cs
    public class CourierAssignment
    {
        public static void AssignCourier(string[] couriers)
        {
            foreach (var courier in couriers)
            {
                Console.WriteLine("Checking availability for: " + courier);
                // Simulate logic (e.g., random or distance-based)
            }
            Console.WriteLine("Courier assigned.");
        }
    }

}
