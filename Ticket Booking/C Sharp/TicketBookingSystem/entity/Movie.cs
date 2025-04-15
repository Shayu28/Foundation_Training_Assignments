using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public class Movie : Event
    {
        public string Genre { get; set; }
        public string ActorName { get; set; }
        public string ActressName { get; set; }

        public Movie() { }

        public Movie(string eventName, DateTime eventDate, string eventTime, Venue venue, int totalSeats, decimal ticketPrice, string genre, string actor, string actress)
            : base(eventName, eventDate, eventTime, venue, totalSeats, ticketPrice, EventType.Movie)
        {
            Genre = genre;
            ActorName = actor;
            ActressName = actress;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine($"[Movie] {EventName} ({Genre}) - {EventDate.ToShortDateString()} at {EventTime}");
            Venue.DisplayVenueDetails();
            Console.WriteLine($"Actors: {ActorName} & {ActressName}");
            Console.WriteLine($"Seats: {AvailableSeats}/{TotalSeats}, Price: ₹{TicketPrice}");
        }
    }

}
