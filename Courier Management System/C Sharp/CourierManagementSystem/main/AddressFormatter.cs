using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.main
{
    public class AddressFormatter
    {
        public string FormatAddress(string street, string city, string state, string zip)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            return $"{textInfo.ToTitleCase(street.ToLower())}, {textInfo.ToTitleCase(city.ToLower())}, {textInfo.ToTitleCase(state.ToLower())} - {zip}";
        }
    }
}
