using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_03
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string MovieName, decimal Price, string seat) : base(MovieName, Price)
        {
            SeatNumber = seat;
        }

        public override string ToString()
        {
            return base.ToString()+$" | Seat :{SeatNumber}";
        }
    }
}
