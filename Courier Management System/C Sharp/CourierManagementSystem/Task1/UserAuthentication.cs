using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task1
{
    // main/UserAuthentication.cs
    public class UserAuthentication
    {
        public static bool Login(string username, string password)
        {
            // Dummy check for now
            if (username == "admin" && password == "admin123")
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
                return false;
            }
        }
    }

}
