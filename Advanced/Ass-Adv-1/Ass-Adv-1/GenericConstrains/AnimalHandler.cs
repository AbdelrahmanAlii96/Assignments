using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.BaseClass
{
    internal class AnimalHandler<T> where T : Animal
    {
        public void Feed(T animal)
        {
            animal.Eat();
        }
    }
}
