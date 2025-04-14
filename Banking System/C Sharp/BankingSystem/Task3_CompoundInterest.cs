using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task3_CompoundInterest
    {
        public static void CalculateInterest()
        {
            Console.Write("Number of customers: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Interest Rate (%): ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Years: ");
                int years = int.Parse(Console.ReadLine());

                double futureBalance = balance * Math.Pow(1 + rate / 100, years);
                Console.WriteLine($"Customer {i + 1} Future Balance: {futureBalance:F2}");
            }
        }
    }

}
