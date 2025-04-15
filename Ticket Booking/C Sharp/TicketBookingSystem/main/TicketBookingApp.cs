using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.main
{
    public class TicketBookingApp
    {
        public void StartBooking()
        {
            while (true)
            {
                Console.WriteLine("\n--- Ticket Booking System ---");
                Console.WriteLine("Type 'exit' to quit or press Enter to continue booking:");
                string input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine("\nEnter total available tickets:");
                int availableTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of tickets to book:");
                int noOfBookingTickets = Convert.ToInt32(Console.ReadLine());

                // Task 1: Conditional check
                if (noOfBookingTickets <= availableTickets)
                {
                    Console.WriteLine("Booking successful!");
                    Console.WriteLine("Remaining tickets: " + (availableTickets - noOfBookingTickets));

                    // Task 2: Ticket pricing by category
                    Console.WriteLine("\nChoose ticket type (Silver / Gold / Diamond):");
                    string ticketType = Console.ReadLine();

                    int ticketPrice = 0;
                    if (ticketType.Equals("Silver", StringComparison.OrdinalIgnoreCase))
                        ticketPrice = 200;
                    else if (ticketType.Equals("Gold", StringComparison.OrdinalIgnoreCase))
                        ticketPrice = 400;
                    else if (ticketType.Equals("Diamond", StringComparison.OrdinalIgnoreCase))
                        ticketPrice = 600;
                    else
                        Console.WriteLine("Invalid ticket type!");

                    if (ticketPrice > 0)
                    {
                        int totalCost = noOfBookingTickets * ticketPrice;
                        Console.WriteLine($"Total cost for {noOfBookingTickets} {ticketType} tickets: ₹{totalCost}");
                    }
                }
                else
                {
                    Console.WriteLine("Tickets unavailable!");
                }
            }

            Console.WriteLine("Thank you for using the Ticket Booking System!");
        }
    }
}
