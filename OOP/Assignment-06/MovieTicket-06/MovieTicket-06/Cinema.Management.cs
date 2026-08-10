using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal partial class Cinema
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
    }
}
