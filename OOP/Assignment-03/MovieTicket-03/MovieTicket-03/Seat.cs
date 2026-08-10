using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_03
{
    internal struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public Seat(char Row, int Number)
        {
            this.Number = Number;
            this.Row = Row;
        }
        public override string ToString()
        {
            return $"{Row}-{Number}";
        }
    }
}
