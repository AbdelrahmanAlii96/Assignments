using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.GenericsInterface
{
    internal class Printer<T>  where T : IPrintable
    {
        public void Printitem(T item)
        {
            item.Print();
        }
    }
}
