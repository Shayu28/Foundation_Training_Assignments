using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public class Customer
    {
        private string customerName;
        private string email;
        private string phoneNumber;

        public Customer() { }

        public Customer(string customerName, string email, string phoneNumber)
        {
            this.customerName = customerName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer: {customerName}, Email: {email}, Phone: {phoneNumber}");
        }
    }
}
