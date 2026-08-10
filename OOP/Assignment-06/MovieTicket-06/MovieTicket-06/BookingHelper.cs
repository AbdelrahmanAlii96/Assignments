using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
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
