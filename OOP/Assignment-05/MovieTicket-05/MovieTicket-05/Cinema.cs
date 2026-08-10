using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal class Cinema
    {

        public string CinemaName { get; set; }

        private Projector projector = new Projector();

        private List<Ticket> tickets = new List<Ticket>();

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public void AddTicket(Ticket t) => tickets.Add(t);

        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n======= All Tickets =======");
            foreach (Ticket t in tickets)
            {
                if (t != null)
                {
                    t.Print();
                }
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("====== Cinema Opened =====");
            //projector.start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("\n===== Cinema Closed =====");
            //projector.stop();
        }
    }
}
