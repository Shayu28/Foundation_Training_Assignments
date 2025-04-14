using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Task1_LoanEligibility
    {
        public static void CheckLoanEligibility()
        {
            Console.Write("Enter Credit Score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter Annual Income: ");
            double income = double.Parse(Console.ReadLine());

            if (creditScore > 700 && income >= 50000)
            {
                Console.WriteLine("Eligible for Loan.");
            }
            else
            {
                Console.WriteLine("Not eligible for Loan.");
            }
        }
    }

}
