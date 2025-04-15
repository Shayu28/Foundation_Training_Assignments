using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.main
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketBookingApp app = new TicketBookingApp();
            app.StartBooking();
            
            // Create Venue
            Venue v = new Venue("Star Arena", "MG Road, Mumbai");

            // Create Event
            Event ev = new Event("Rock Night", DateTime.Parse("2025-05-25"), "7:30 PM", "Star Arena", 100, 499.99m, EventType.Concert);

            // Display Event
            ev.DisplayEventDetails();

            // Create Customer
            Customer c = new Customer("Shayu", "shayu@example.com", "9876543210");
            c.DisplayCustomerDetails();

            // Booking
            Booking booking = new Booking(ev);
            booking.BookTickets(3);
            booking.CancelBooking(1);

            Console.WriteLine($"Available Tickets: {booking.GetAvailableNoOfTickets()}");
            Console.WriteLine($"Total Revenue: {ev.CalculateTotalRevenue():C}");
        }
    }
}
