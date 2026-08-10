namespace MovieTicket_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Metro Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 80, "A5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 100, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);


            cinema.PrintAllTickets();

            Console.WriteLine("\n--- Clone Test ---");
            VIPTicket clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original: ");
            t2.Print();

            Console.Write("Clone: ");
            clone.Print();

            // e. Cancel one ticket
            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            BookingHelper.PrintAll(cinema.GetTickets().ToArray());

            cinema.CloseCinema();
        }
    }
}
