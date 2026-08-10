using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_04
{
    internal class Ticket
    {
        private string movieName;
        //private TicketType type;
        public Seat seat { get; set; }
        private decimal price;

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

        public decimal Price
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
        public int TicketId { get; private set; }


        public Ticket(string MovieName, decimal Price)
        {
            this.movieName = MovieName;
            this.Price = Price;

            //----------//
            ticketCounter++;
            TicketId = ticketCounter;
        }

        //---------------//
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }


        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }


        //----------------//
        public decimal PriceAfterTax
        {
            get { return price * 1.14m; }
        }


        public static int GetTotalTicket()
        {
            return ticketCounter;
        }

    }
}
