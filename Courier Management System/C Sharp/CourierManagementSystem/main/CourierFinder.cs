using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class CourierFinder
    {
        public class Courier
        {
            public string CourierName { get; set; }
            public int DistanceFromCustomer { get; set; } // in km
            public bool IsAvailable { get; set; }

            public Courier(string name, int distance, bool available)
            {
                CourierName = name;
                DistanceFromCustomer = distance;
                IsAvailable = available;
            }
        }

        public void FindNearestCourier()
        {
            Courier[] couriers = {
                new Courier("Ravi", 10, true),
                new Courier("Aman", 5, false),
                new Courier("Priya", 3, true),
                new Courier("Sneha", 7, true)
            };

            Courier nearest = null;

            foreach (Courier c in couriers)
            {
                if (c.IsAvailable)
                {
                    if (nearest == null || c.DistanceFromCustomer < nearest.DistanceFromCustomer)
                    {
                        nearest = c;
                    }
                }
            }

            if (nearest != null)
            {
                Console.WriteLine($"Nearest available courier: {nearest.CourierName} ({nearest.DistanceFromCustomer} km)");
            }
            else
            {
                Console.WriteLine("No couriers available at the moment.");
            }
        }
    }
}
