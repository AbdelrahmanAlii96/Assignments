using System.Net.Sockets;

namespace MovieTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Tick Booking=====");
            Cinema cinema = new Cinema();
            //--Q5-A) enta data for 3 tickets
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter data for Tick {i + 1}");
                Console.Write("Movie Name : ");
                string movieName = Console.ReadLine();

                Console.Write("Ticket Type (0 = Standard ,1 = VIP , 2 = Max) : ");
                int typeinput = int.Parse(Console.ReadLine());
                TicketType type = (TicketType)typeinput;

                Console.Write("Seat Row (A-Z) : ");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Seat Number : ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Price : ");
                double price = double.Parse(Console.ReadLine());

                Seat seat = new Seat(row, number);
                Ticket t = new Ticket(movieName, type, seat, price);
                cinema.AddTicket(t);

            }

            //Q5-B ---------------
            Console.WriteLine("\n=======All Tickects======");
            for (int i = 0; i < 3; i++)
            {
                Ticket t = cinema[i];
                if (t != null)
                {
                    Console.Write($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | ");
                    Console.Write($"Seat: {t.seat} | Price: {t.Price} EGP | ");
                    Console.Write($"After Tax: {t.PriceAfterTax:F1} EGP");
                    Console.WriteLine("\n");
                }
            }

            //Q5-c-------
            Console.WriteLine("\n====== Search by Movie ======");
            Console.Write("Enter Movie Name to search : ");
            string searchname = Console.ReadLine();

            Ticket search = cinema.GetMoviebyName(searchname);
            if (search != null)
            {
                Console.WriteLine($"Found : Ticket #{search.TicketId} | {search.MovieName} | {search.Type} | Seat: {search.seat} | Price:{search.Price} EGP");
            }
            else
            {
                Console.WriteLine("Not Found");

            }

            //Q5-D ------

            Console.WriteLine("\n=====Statistics======");
            Console.WriteLine($"Total Tickets sold : {Ticket.GetTotalTicketsSold()}");

            //Q5-E -----

            Console.WriteLine($"\nBooking Reference 1 : {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2 : {BookingHelper.GenerateBookingReference()}");

            //Q5-F -----
            double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount Total (5 tickets x @80 EGP): {groupTotal} EGP (10% off applied)");

        }
    }
}
