using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task1
{
    // main/OrderStatusCheck.cs
    public class OrderStatusCheck
    {
        public static void CheckOrderStatus(string status)
        {
            if (status == "Delivered")
                Console.WriteLine("Order has been delivered.");
            else if (status == "Processing")
                Console.WriteLine("Order is being processed.");
            else if (status == "Cancelled")
                Console.WriteLine("Order was cancelled.");
            else
                Console.WriteLine("Invalid order status.");
        }
    }

}
