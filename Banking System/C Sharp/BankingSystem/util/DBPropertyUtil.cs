using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.util
{
    public class DBPropertyUtil
    {
        public static string GetConnectionString(string fileName)
        {
            return File.ReadAllText(fileName).Trim(); // Just reading connection string from a text file
        }
    }
}
