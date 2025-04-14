using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task4_AccountValidation
    {
        public static void CheckAccountBalance()
        {
            int[] validAccounts = { 101, 102, 103 };
            double[] balances = { 5000, 7000, 12000 };

            while (true)
            {
                Console.Write("Enter Account Number: ");
                int accNo = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < validAccounts.Length; i++)
                {
                    if (accNo == validAccounts[i])
                    {
                        Console.WriteLine($"Balance: {balances[i]}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Invalid account. Try again.");
                }
                else
                {
                    break;
                }
            }
        }
    }

}
