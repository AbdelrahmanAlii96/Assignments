using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_06
{
    internal interface IBookable
    {
        void Book();
        void Cancel();
        bool IsBooked { get; }
    }
}
