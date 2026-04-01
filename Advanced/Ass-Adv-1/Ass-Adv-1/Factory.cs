using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
}
