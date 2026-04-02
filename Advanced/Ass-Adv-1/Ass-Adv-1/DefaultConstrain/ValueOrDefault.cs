using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ass_Adv_1.DefaultConstrain
{
    internal class ValueOrDefault<T>
    {
        private T? value;
        private bool boolvalue;
        public T GetValueOrDefualt()
        {
            return boolvalue ? value! : default!;
        }
    }
}
