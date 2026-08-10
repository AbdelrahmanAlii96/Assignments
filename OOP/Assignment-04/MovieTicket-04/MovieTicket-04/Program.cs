namespace MovieTicket_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Metro Cinema");

            cinema.OpenCinema();

            StandardTicket t1 = new StandardTicket("Inception", 120, "A5");
            VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);


            
            Console.WriteLine("\n===== SetPrice Test =====");
            t1.SetPrice(150);
            Console.WriteLine("Setting price directly: 150");

            t1.SetPrice(100, 1.5m);
            Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);


            cinema.PrintAllTickets();

            BookingHelper.ProcessTicket(t2);

            cinema.CloseCinema();
        }
    }
}
