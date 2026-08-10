using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_oop_01
{
    public enum TicketType
    {
        Standarded = 0,
        VIP = 1,
        IMAX = 2
    }

    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat seat { get; set; }

        private double Price;

        public double GetPrice
        {
            get { return Price; }
            set { Price = value; }
        }

        public Ticket(string MovieName, TicketType Type, Seat seat, double Price)
        {
            this.MovieName = MovieName;
            this.Type = Type;
            this.seat = seat;
            this.Price = Price;
        }

        public Ticket(string MovieName) : this(MovieName, TicketType.Standarded, new Seat('A', 1), 50)
        {

        }

        public double CalcTotal(double taxPrecent)
        {
            return Price + (Price * taxPrecent / 100);
        }

        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
            }
        }


        public void PrintTicket(double taxPrecent)
        {
            
            Console.WriteLine($"Movie : {MovieName}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Seat : {seat}");
            Console.WriteLine($"Price : {Price:F2}");
            Console.WriteLine($"Total ({taxPrecent}% tax): {CalcTotal(taxPrecent):F2}");
        }

 
    }
}
