using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.service
{
    public interface IEventServiceProvider
    {
        Event CreateEvent(string name, DateTime date, string time, int totalSeats, decimal price, EventType type, Venue venue);
        List<Event> GetEventDetails();
        int GetAvailableNoOfTickets(string eventName);
    }
}
