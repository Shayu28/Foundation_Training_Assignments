using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.service
{
    public class EventServiceProviderImpl : IEventServiceProvider
    {
        protected List<Event> events = new List<Event>();

        public virtual Event CreateEvent(string name, DateTime date, string time, int totalSeats, decimal price, EventType type, Venue venue)
        {
            Event newEvent = null;
            switch (type)
            {
                case EventType.Movie:
                    newEvent = new Movie(name, date, time, venue, totalSeats, price, "Action", "Actor A", "Actress B");
                    break;
                case EventType.Concert:
                    newEvent = new Concert(name, date, time, venue, totalSeats, price, "Band X", "Rock");
                    break;
                case EventType.Sports:
                    newEvent = new Sports(name, date, time, venue, totalSeats, price, "Cricket", "India vs Pakistan");
                    break;
            }

            if (newEvent != null)
                events.Add(newEvent);

            return newEvent;
        }

        public List<Event> GetEventDetails() => events;

        public int GetAvailableNoOfTickets(string eventName)
        {
            var e = events.FirstOrDefault(ev => ev.EventName == eventName);
            return e?.AvailableSeats ?? 0;
        }
    }
}
