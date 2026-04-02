using Ass_Adv_1.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.GenericConstrains
{
    internal class Trainer<T> where T : Animal ,ITrainable , new()
    {
        public void Work()
        {
            T animaltype = new T();
            animaltype.Eat();
            animaltype.Train();
        }
    }
}
