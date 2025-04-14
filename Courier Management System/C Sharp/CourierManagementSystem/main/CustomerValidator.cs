using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class CustomerValidator
    {
        public bool Validate(string data, string detail)
        {
            switch (detail.ToLower())
            {
                case "name":
                    return Regex.IsMatch(data, @"^[A-Z][a-zA-Z\s]*$");

                case "address":
                    return !Regex.IsMatch(data, @"[^\w\s,.]");

                case "phone":
                    return Regex.IsMatch(data, @"^\d{10}$");

                default:
                    return false;
            }
        }
    }
}
