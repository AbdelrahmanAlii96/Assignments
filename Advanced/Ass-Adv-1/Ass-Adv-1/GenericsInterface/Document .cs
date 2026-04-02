using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.GenericsInterface
{
    internal class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }
}
