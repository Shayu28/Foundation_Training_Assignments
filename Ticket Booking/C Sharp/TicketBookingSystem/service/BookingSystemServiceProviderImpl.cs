using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventTicketBookingSystem.entity;
using TicketBookingSystem.entity;
using TicketBookingSystem.exception;

namespace TicketBookingSystem.service
{
    public class BookingSystemServiceProviderImpl : EventServiceProviderImpl, IBookingSystemServiceProvider
    {
        private List<Booking> bookings = new List<Booking>();
        private HashSet<string> registeredEmails = new HashSet<string>();

        public decimal CalculateBookingCost(int numTickets, decimal price)
        {
            if (numTickets <= 0)
                throw new InvalidBookingException("Number of tickets must be greater than 0.");

            return numTickets * price;
        }

        public Booking BookTickets(string eventName, int numTickets, List<Customer> customers)
        {
            var ev = events.FirstOrDefault(e => e.EventName == eventName);
            if (ev == null)
                throw new InvalidEventException($"Event '{eventName}' not found.");

            foreach (var customer in customers)
            {
                if (registeredEmails.Contains(customer.Email))
                    throw new DuplicateCustomerException($"Customer with email '{customer.Email}' is already registered.");
                registeredEmails.Add(customer.Email);
            }

            ev.BookTickets(numTickets);
            decimal cost = CalculateBookingCost(numTickets, ev.TicketPrice);
            Booking booking = new Booking(ev, customers, numTickets, cost);
            bookings.Add(booking);
            return booking;
        }

        public bool CancelBooking(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null)
                throw new BookingNotFoundException($"Booking with ID {bookingId} does not exist.");

            booking.Event.CancelBooking(booking.NumTickets);
            bookings.Remove(booking);
            return true;
        }

        public Booking GetBookingDetails(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null)
                throw new BookingNotFoundException($"Booking with ID {bookingId} not found.");

            return booking;
        }

        private Dictionary<string, List<Booking>> bookingByEvent = new Dictionary<string, List<Booking>>();

    }
}
