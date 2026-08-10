using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket_05
{
    internal interface IBookable
    {
        void Book();
        void Cancel();
        bool IsBooked { get; }
    }
}
