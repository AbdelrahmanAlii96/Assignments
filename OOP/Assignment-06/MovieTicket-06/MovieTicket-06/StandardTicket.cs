using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal class StandardTicket : Ticket
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

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }
    }
}
