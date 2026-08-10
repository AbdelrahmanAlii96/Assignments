using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema Reporting) ---");
            foreach (var t in tickets)
            {
                t.Print();
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine("====== Cinema Opened =====");
            projector.start();
        }
        public void CloseCinema()
        {
            
            projector.stop();
            Console.WriteLine("===== Cinema Closed =====");
            
        }
    }
}
