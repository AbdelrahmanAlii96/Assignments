using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal static class TicketExtensions
    {
        public static string GetReceipt(this Ticket t)
        {
            return $"""
        ===== RECEIPT =====
        Movie  : {t.MovieName}
        Type   : {t.GetType().Name}
        Price  : {t.Price}
        Final  : {t.CalculateFinalPrice():F2}
        Status : {(t.IsBooked ? "Booked" : "Not Booked")}
        ===================
        """;
        }

        public static decimal GetTotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var t in tickets)
            {
                total += t.CalculateFinalPrice();
            }

            return total;
        }


    }
}
