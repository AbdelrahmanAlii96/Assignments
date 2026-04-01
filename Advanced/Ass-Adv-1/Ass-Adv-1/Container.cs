using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    internal class Container<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return items[index];
        }
    }
}
