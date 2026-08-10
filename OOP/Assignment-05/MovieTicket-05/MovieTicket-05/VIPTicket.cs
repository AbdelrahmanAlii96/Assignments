using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal class VIPTicket : Ticket, ICloneable
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;
        public VIPTicket(string MovieName, decimal Price, bool lounge) : base(MovieName, Price)
        {
            LoungeAccess = lounge;
        }


        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}\n");
        }

        public override Ticket Clone()
        {
            return new VIPTicket(this.MovieName, this.Price, this.LoungeAccess);
        }
    }
}
