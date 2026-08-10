using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal class BookingHelper
    {
        private static int bookingCounter = 0;



        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
