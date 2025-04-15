using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public enum EventType { Movie, Sports, Concert }

    public abstract class Event
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public Venue Venue { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        public EventType EventType { get; set; }

        public Event() { }

        public Event(string eventName, DateTime eventDate, string eventTime, Venue venue, int totalSeats, decimal ticketPrice, EventType eventType)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            Venue = venue;
            TotalSeats = totalSeats;
            AvailableSeats = totalSeats;
            TicketPrice = ticketPrice;
            EventType = eventType;
        }

        public abstract void DisplayEventDetails();

        public decimal CalculateTotalRevenue()
        {
            return TicketPrice * (TotalSeats - AvailableSeats);
        }

        public int GetBookedTickets() => TotalSeats - AvailableSeats;

        public void BookTickets(int numTickets)
        {
            if (numTickets <= AvailableSeats)
                AvailableSeats -= numTickets;
            else
                throw new Exception("Not enough tickets available.");
        }

        public void CancelBooking(int numTickets)
        {
            AvailableSeats += numTickets;
            if (AvailableSeats > TotalSeats)
                AvailableSeats = TotalSeats;
        }
    }

}
