using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task2
{
    public class OrderService
    {
        public static void ShowCustomerOrders(string[] orders)
        {
            for (int i = 0; i < orders.Length; i++)
            {
                Console.WriteLine($"Order {i + 1}: {orders[i]}");
            }
        }
    }

}
