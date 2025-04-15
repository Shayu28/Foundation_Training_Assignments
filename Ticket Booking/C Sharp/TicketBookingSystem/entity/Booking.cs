using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public class Booking
    {
        private Event eventObj;
        private int numberOfTickets;
        private decimal totalCost;

        public Booking(Event eventObj)
        {
            this.eventObj = eventObj;
        }

        public decimal CalculateBookingCost(int numTickets)
        {
            totalCost = numTickets * eventObj.TicketPrice;
            return totalCost;
        }

        public void BookTickets(int numTickets)
        {
            eventObj.BookTickets(numTickets);
            numberOfTickets = numTickets;
            Console.WriteLine($"Booking Cost: {CalculateBookingCost(numTickets):C}");
        }

        public void CancelBooking(int numTickets)
        {
            eventObj.CancelBooking(numTickets);
            numberOfTickets -= numTickets;
        }

        public int GetAvailableNoOfTickets()
        {
            return eventObj.AvailableSeats;
        }

        public void GetEventDetails()
        {
            eventObj.DisplayEventDetails();
        }
    }
}
