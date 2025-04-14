using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class ShippingCalculator
    {
        public double CalculateShipping(string source, string destination, double weight)
        {
            // For simplicity, assume Rs. 10 per km + Rs. 5 per kg
            int distance = new Random().Next(10, 100); // random distance
            double cost = distance * 10 + weight * 5;
            Console.WriteLine($"Estimated Distance: {distance} km");
            return cost;
        }
    }
}
