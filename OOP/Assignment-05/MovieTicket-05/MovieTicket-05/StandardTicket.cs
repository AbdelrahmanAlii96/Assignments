using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal class StandardTicket : Ticket, ICloneable
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string MovieName, decimal Price, string seat) : base(MovieName, Price)
        {
            SeatNumber = seat;
        }


        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}\n");
        }

        public override Ticket Clone()
        {
            return new StandardTicket(this.MovieName, this.Price, this.SeatNumber);
        }
    }
}
