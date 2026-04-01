using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    public class ValueContainer<T> where T : struct
    {
        public T Value { get; set; }

        public ValueContainer(T value)
        {
            Value = value;
        }

        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }

}
