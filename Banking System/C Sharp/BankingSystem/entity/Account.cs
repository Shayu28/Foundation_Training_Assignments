using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.entity
{
    public class Account
    {
        private int accountNumber;
        private string accountType;
        private double balance;

        public Account() { }

        public Account(int accountNumber, string accountType, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = balance;
        }

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public double Balance { get => balance; set => balance = value; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public void CalculateInterest()
        {
            if (accountType.ToLower() == "savings")
            {
                double interestRate = 0.045;
                double interest = balance * interestRate;
                balance += interest;
                Console.WriteLine($"Interest of ${interest} added. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Interest is applicable only to savings accounts.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Balance: ${balance}");
        }
    }
}
