using static MovieTicket_03.Ticket;

namespace MovieTicket_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Dahab Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("\n ===== Statistics ======");
            Console.WriteLine($"Total Tickets Created : {Ticket.GetTotalTicket()}");

            Console.WriteLine($"\nBooking Reference 1 : {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2 : {BookingHelper.GenerateBookingReference()}");

            
            double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount Total (5 tickets x @80 EGP): {groupTotal} EGP (10% off applied)");
            cinema.CloseCinema();

        }
    }
}
