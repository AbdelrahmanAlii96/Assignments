using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.BaseClass
{
    internal class Dog : Animal,ITrainable

    {
        public void Bark()
        {
            Console.WriteLine("Barking..");
        }

        public void Train()
        {
            Console.WriteLine("Dog is being trained");
        }
    }
}
