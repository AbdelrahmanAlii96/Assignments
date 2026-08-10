using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_03
{
    //public enum TicketType
    //{
    //    Standarded = 0,
    //    VIP = 1,
    //    IMAX = 2
    //}
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

        //public TicketType Type
        //{
        //    get { return type; }
        //    set { type = value; }
        //}

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


        //----------------//
        public decimal PriceAfterTax
        {
            get { return price * 1.14m; }
        }


        public static int GetTotalTicket()
        {
            return ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | "+
                   $"Price: {price} EGP | After Tax { PriceAfterTax:F2} EGP";
            
        }
    }
}
