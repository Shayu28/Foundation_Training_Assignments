using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.entity;

namespace TicketBookingSystem.main
{
    public class TicketBookingSystem
    {
        public Event CreateEvent(string name, DateTime date, TimeSpan time, int totalSeats, decimal price, string eventType, string venue)
        {
            switch (eventType)
            {
                case "Movie":
                    return new Movie(name, date, time, venue, totalSeats, price, "Action", "Actor A", "Actress B");
                case "Concert":
                    return new Concert(name, date, time, venue, totalSeats, price, "Band X", "Rock");
                case "Sports":
                    return new Sports(name, date, time, venue, totalSeats, price, "Cricket", "India vs Pakistan");
                default:
                    Console.WriteLine("Invalid event type!");
                    return null;
            }
        }

        public void DisplayEventDetails(Event e)
        {
            e?.DisplayEventDetails();
        }

        public decimal BookTickets(Event e, int numTickets)
        {
            if (e.AvailableSeats >= numTickets)
            {
                e.BookTickets(numTickets);
                return e.TicketPrice * numTickets;
            }
            else
            {
                Console.WriteLine("Not enough tickets available.");
                return 0;
            }
        }

        public void CancelTickets(Event e, int numTickets)
        {
            e.CancelBooking(numTickets);
        }

        public void MainMenu()
        {
            var system = new TicketBookingSystem();

            var movieEvent = system.CreateEvent("Avengers", DateTime.Now.AddDays(1), new TimeSpan(18, 0, 0), 100, 250, "Movie", "PVR");
            var concertEvent = system.CreateEvent("Rock Show", DateTime.Now.AddDays(2), new TimeSpan(20, 0, 0), 150, 300, "Concert", "Stadium");
            var sportsEvent = system.CreateEvent("Cricket Match", DateTime.Now.AddDays(3), new TimeSpan(16, 0, 0), 200, 400, "Sports", "Wankhede");

            List<Event> events = new() { movieEvent, concertEvent, sportsEvent };

            while (true)
            {
                Console.WriteLine("\n1. Display Events\n2. Book Tickets\n3. Cancel Tickets\n4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    foreach (var ev in events)
                    {
                        system.DisplayEventDetails(ev);
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter event type (Movie/Concert/Sports): ");
                    string type = Console.ReadLine();

                    var ev = events.FirstOrDefault(e => e.EventType == type);
                    if (ev != null)
                    {
                        Console.Write("Enter number of tickets to book: ");
                        int tickets = int.Parse(Console.ReadLine());
                        var cost = system.BookTickets(ev, tickets);
                        Console.WriteLine($"Booking Successful. Total Cost: ₹{cost}");
                    }
                    else
                    {
                        Console.WriteLine("Event not found.");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter event type (Movie/Concert/Sports): ");
                    string type = Console.ReadLine();

                    var ev = events.FirstOrDefault(e => e.EventType == type);
                    if (ev != null)
                    {
                        Console.Write("Enter number of tickets to cancel: ");
                        int tickets = int.Parse(Console.ReadLine());
                        system.CancelTickets(ev, tickets);
                        Console.WriteLine("Tickets canceled successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Event not found.");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
            }
        }
    }

}
