using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public class Sports : Event
    {
        public string SportName { get; set; }
        public string TeamsName { get; set; }

        public Sports(string name, DateTime date, TimeSpan time, string venue, int totalSeats, decimal price, string sportName, string teams)
            : base(name, date, time, venue, totalSeats, price, "Sports")
        {
            SportName = sportName;
            TeamsName = teams;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Sport: {SportName}, Teams: {TeamsName}");
        }
    }

}
