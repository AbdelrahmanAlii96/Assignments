using Ass_Adv_1.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.GenericConstrains
{
    internal class Cat : Animal, ITrainable
    {
        public void Meow()
        {
            Console.WriteLine("Cat is Meowing");
        }
        public void Train()
        {
            Console.WriteLine("Cat is being trained");
        }
    }
}
