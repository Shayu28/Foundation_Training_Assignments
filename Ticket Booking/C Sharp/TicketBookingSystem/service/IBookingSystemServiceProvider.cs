using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.service
{
    public interface IBookingSystemServiceProvider
    {
        decimal CalculateBookingCost(int numTickets, decimal price);
        Booking BookTickets(string eventName, int numTickets, List<Customer> customers);
        bool CancelBooking(int bookingId);
        Booking GetBookingDetails(int bookingId);
    }
}
