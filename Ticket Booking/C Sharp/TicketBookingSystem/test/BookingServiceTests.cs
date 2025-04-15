using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;
using TicketBookingSystem.exception;
using TicketBookingSystem.service;

namespace TicketBookingSystem.test
{
    public class BookingServiceTests
    {
        private BookingSystemServiceProviderImpl service;

        public BookingServiceTests()
        {
            service = new BookingSystemServiceProviderImpl();
            service.AddEvent(new Movie("Inception", DateTime.Now.AddDays(3), "PVR", 100, 300, "Sci-Fi", "Nolan"));
        }

        [Fact]
        public void TestBookTickets_ValidBooking()
        {
            var customers = new List<Customer>
            {
                new Customer("Alice", "alice@example.com"),
                new Customer("Bob", "bob@example.com")
            };
            var booking = service.BookTickets("Inception", 2, customers);
            Assert.NotNull(booking);
            Assert.Equal(2, booking.NumTickets);
        }

        [Fact]
        public void TestDuplicateCustomerEmail()
        {
            var customers = new List<Customer>
            {
                new Customer("Alice", "alice@example.com"),
                new Customer("Alice2", "alice@example.com") // Duplicate
            };

            Assert.Throws<DuplicateCustomerException>(() =>
            {
                service.BookTickets("Inception", 2, customers);
            });
        }

        [Fact]
        public void TestInvalidBookingCount()
        {
            var customers = new List<Customer>
            {
                new Customer("Charlie", "charlie@example.com")
            };

            Assert.Throws<InvalidBookingException>(() =>
            {
                service.BookTickets("Inception", 0, customers);
            });
        }

        [Fact]
        public void TestCancelNonExistingBooking()
        {
            Assert.Throws<BookingNotFoundException>(() =>
            {
                service.CancelBooking(9999); // invalid ID
            });
        }

        [Fact]
        public void TestGetBookingsForEvent()
        {
            var customers = new List<Customer>
            {
                new Customer("Daniel", "daniel@example.com")
            };

            service.BookTickets("Inception", 1, customers);
            var bookings = service.GetBookingsForEvent("Inception");

            Assert.NotEmpty(bookings);
        }
    }
}
