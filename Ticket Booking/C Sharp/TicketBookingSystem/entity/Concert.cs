using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.entity
{
    public class Concert : Event
    {
        public string Artist { get; set; }
        public string Type { get; set; }

        public Concert(string name, DateTime date, TimeSpan time, string venue, int totalSeats, decimal price, string artist, string type)
            : base(name, date, time, venue, totalSeats, price, "Concert")
        {
            Artist = artist;
            Type = type;
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine(this);
            Console.WriteLine($"Artist: {Artist}, Type: {Type}");
        }
    }

}
