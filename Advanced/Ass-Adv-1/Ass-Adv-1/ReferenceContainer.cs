using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    public class ReferenceContainer<T> where T : class
    {
        public T Value { get; set; }

        public ReferenceContainer(T value)
        {
            Value = value;
        }

        public void Display()
        {
            if (Value == null)
                Console.WriteLine("Value is null");
            else
                Console.WriteLine($"Value: {Value}");
        }
    }

}
