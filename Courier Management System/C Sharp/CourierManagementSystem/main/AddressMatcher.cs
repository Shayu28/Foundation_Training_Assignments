using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class AddressMatcher
    {
        public void FindSimilarAddresses(List<string> addresses, string target)
        {
            Console.WriteLine("Similar Addresses:");
            foreach (string address in addresses)
            {
                if (address.ToLower().Contains(target.ToLower()))
                {
                    Console.WriteLine(address);
                }
            }
        }
    }
}
