using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal class VIPTicket : Ticket
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

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }
    }
}
