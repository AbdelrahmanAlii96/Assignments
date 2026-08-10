using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_04
{
    internal sealed class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string MovieName, decimal Price, bool is3D) : base(MovieName, Price)
        {
            Is3D = is3D;
            if (Is3D) { Price += 30; }
        }


        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"    IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
