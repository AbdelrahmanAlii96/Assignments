using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_04
{
    internal class Cinema
    {

        public string CinemaName { get; set; }

        private Projector projector = new Projector();

        private Ticket[] tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                {
                    return tickets[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                {
                    tickets[index] = value;
                }

            }
        }


        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n======= All Tickets =======");
            foreach (Ticket t in tickets)
            {
                if (t != null)
                {
                    t.PrintTicket();
                }
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("====== Cinema Opened =====");
            projector.start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("\n===== Cinema Closed =====");
            projector.stop();
        }
    }
}
