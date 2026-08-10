using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;
        public VIPTicket(string MovieName, decimal Price, bool lounge) : base(MovieName, Price)
        {
            LoungeAccess = lounge;
        }

        public override string ToString()
        {
            return base.ToString() +
                $" | Loounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";




        }
    }
}
