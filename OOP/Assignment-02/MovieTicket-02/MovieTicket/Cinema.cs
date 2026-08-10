using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

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


        public Ticket? GetMoviebyName(string movieName)
        {
            foreach (Ticket t in tickets)
            {
                if (t != null && t.MovieName == movieName)
                {
                    return t;
                }
            }
            return null;
        }


        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false; // cinema full
        }

    }
}
