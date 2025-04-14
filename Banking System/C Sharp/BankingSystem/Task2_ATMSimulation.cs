using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task2_ATMSimulation
    {
        public static void ATM()
        {
            Console.WriteLine("Enter your current balance:");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("1. Check Balance\n2. Withdraw\n3. Deposit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Balance: {balance}");
                    break;

                case 2:
                    Console.WriteLine("Enter amount to withdraw:");
                    double withdraw = double.Parse(Console.ReadLine());
                    if (withdraw <= balance && (withdraw % 100 == 0 || withdraw % 500 == 0))
                    {
                        balance -= withdraw;
                        Console.WriteLine($"Withdrawn. New Balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter deposit amount:");
                    double deposit = double.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"Deposited. New Balance: {balance}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

}
