using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.service
{
    public interface IEventService
    {
        void AddEvent(Event ev);
        void BookTickets(string eventName, int count);
        void CancelTickets(string eventName, int count);
        List<Event> GetAllEvents();
        Event GetEventByName(string eventName);
    }
}
