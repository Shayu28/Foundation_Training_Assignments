using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.exception
{
    public class DuplicateCustomerException : Exception
    {
        public DuplicateCustomerException(string message) : base(message) { }
    }
}
