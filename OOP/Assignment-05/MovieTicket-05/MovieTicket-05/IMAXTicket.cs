using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal sealed class IMAXTicket : Ticket ,ICloneable
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string MovieName, decimal Price, bool is3D) : base(MovieName, Price)
        {
            Is3D = is3D;
            if (Is3D) { Price += 30; }
        }


        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}\n");
        }

        public override Ticket Clone()
        {
            return new IMAXTicket(this.MovieName, this.Price, this.Is3D);
        }
    }
}
