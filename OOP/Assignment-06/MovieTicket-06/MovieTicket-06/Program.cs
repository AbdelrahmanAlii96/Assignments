namespace MovieTicket_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ticket t = new Ticket("Test", 100); // ERROR

            Cinema cinema = new Cinema("Metro Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 80, "A5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);


            cinema.PrintAllTickets();

            Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");

            Ticket[] arr = cinema.GetTickets().ToArray();

            foreach (var t in arr)
            {
                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
            }

            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(t2.GetReceipt());

            Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {arr.GetTotalRevenue():F2}\n");

            cinema.CloseCinema();
        }
    }
}
