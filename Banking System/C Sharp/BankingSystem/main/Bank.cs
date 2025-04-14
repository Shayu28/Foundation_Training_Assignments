using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.entity;

namespace BankingSystem.main
{
    class Bank
    {
        static void Main(string[] args)
        {
            // Create a Customer
            Customer customer = new Customer(1, "John", "Doe", "john.doe@example.com", "1234567890", "123 Street, City");
            customer.DisplayCustomerInfo();

            Console.WriteLine("\n--- Creating Account ---");
            Account account = new Account(101, "Savings", 1000.0);
            account.DisplayAccountInfo();

            Console.WriteLine("\n--- Deposit ---");
            account.Deposit(500.0);

            Console.WriteLine("\n--- Withdraw ---");
            account.Withdraw(200.0);

            Console.WriteLine("\n--- Interest Calculation ---");
            account.CalculateInterest();

            Console.WriteLine("\n--- Final Account Details ---");
            account.DisplayAccountInfo();
        }
    }
}
