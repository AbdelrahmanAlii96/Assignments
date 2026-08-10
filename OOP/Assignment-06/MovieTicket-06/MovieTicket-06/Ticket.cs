using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal abstract class Ticket : IPrintable, IBookable
    {
        private string movieName;
        //private TicketType type;
        public Seat seat { get; set; }
        private decimal price;

        public static int ticketCounter = 0;
        public bool IsBooked { get; private set; } = false;


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




        //----------------//
        public decimal PriceAfterTax
        {
            get { return price * 1.14m; }
        }


        public static int GetTotalTicket()
        {
            return ticketCounter;
        }

        public virtual void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public virtual void Book()
        {
            if (IsBooked)
            {
                throw new Exception("Already booked!");
            }

            IsBooked = true;
        }

        public virtual void Cancel()
        {
            if (!IsBooked)
            {
                throw new Exception("Not booked yet!");
            }
            IsBooked = false;
        }



        public abstract decimal CalculateFinalPrice();
    }
}
