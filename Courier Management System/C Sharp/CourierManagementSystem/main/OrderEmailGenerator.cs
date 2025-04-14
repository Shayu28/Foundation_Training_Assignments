using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class OrderEmailGenerator
    {
        public string GenerateEmail(string customerName, string orderId, string address, DateTime deliveryDate)
        {
            return $"Dear {customerName},\nYour order #{orderId} has been placed successfully.\nDelivery Address: {address}\nExpected Delivery: {deliveryDate:dd-MM-yyyy}\nThank you for using our service!";
        }
    }
}
