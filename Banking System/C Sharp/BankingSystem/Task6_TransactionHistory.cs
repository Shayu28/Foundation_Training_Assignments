using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task6_TransactionHistory
    {
        public static void TransactionList()
        {
            List<string> transactions = new List<string>();
            while (true)
            {
                Console.Write("Enter transaction (deposit/withdrawal or 'exit'): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                transactions.Add(input);
            }

            Console.WriteLine("\nTransaction History:");
            foreach (string tx in transactions)
            {
                Console.WriteLine(tx);
            }
        }
    }

}
