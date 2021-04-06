using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_NullColascing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal Way
            //int AvailableTicket;
            //int? TicketsOnSale = null;

            //if (TicketsOnSale == null)
            //{
            //    AvailableTicket = 0;
            //}
            //else
            //{
            //    AvailableTicket = (int)TicketsOnSale;
            //}
            //Console.WriteLine("Avaialable Tiickets: {0}", AvailableTicket);
            //Console.ReadLine();

            int AvailableTickets;
            int? TicketOnSale = null;

            //using null coalesce ??
            AvailableTickets = TicketOnSale ?? 0;
            Console.WriteLine("Available Tickets={0}", AvailableTickets);
            Console.ReadLine();
        }
    }
}
