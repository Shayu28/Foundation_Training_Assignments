using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.dao;
using BankingSystem.entity;
using BankingSystem.exception;

namespace BankingSystem.main
{
    class MainModule
    {
        static void Main(string[] args)
        {
            IBankingRepository repo = new BankingRepositoryImpl();

            try
            {
                Console.WriteLine("1. Create Customer\n2. Create Account\n3. Deposit\n4. Withdraw\n5. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Customer customer = new Customer
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Email = "john@example.com",
                            DOB = new DateTime(1990, 1, 1),
                            PhoneNumber = "1234567890",
                            Address = "New York"
                        };
                        repo.CreateCustomer(customer);
                        break;

                    case 2:
                        Account acc = new Account { CustomerId = 1, AccountType = "Savings", Balance = 1000 };
                        repo.CreateAccount(acc);
                        break;

                    case 3:
                        repo.Deposit(1, 200);
                        break;

                    case 4:
                        repo.Withdraw(1, 500);
                        break;

                    case 5:
                        return;
                }
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}
