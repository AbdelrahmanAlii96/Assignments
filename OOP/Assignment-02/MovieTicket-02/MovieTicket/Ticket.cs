using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket
{
    public enum TicketType
    {
        Standarded = 0,
        VIP = 1,
        IMAX = 2
    }
    internal class Ticket
    {
        private string movieName;
        private TicketType type ;
        public Seat seat { get; set; }
        private double price;

        public static int ticketCounter = 0;


        //-------------//
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    movieName = value;
                }
            }
        }

        public TicketType Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }


        //----------------//
        public double PriceAfterTax
        {
            get { return price * 1.14; }
        }
        //-------------//

        public int TicketId { get; private set; }



        public Ticket(string MovieName, TicketType Type, Seat seat, double Price)
        {
            this.movieName = MovieName;
            this.type = Type;
            this.seat = seat;
            this.Price = Price;

            //----------//
            ticketCounter++;
            TicketId = ticketCounter;
        }

        public Ticket(string MovieName) : this(MovieName, TicketType.Standarded, new Seat('A', 1), 50)
        {

        }

        //-------------------//
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
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
