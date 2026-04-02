using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1.DefaultConstrain
{
    internal class SafeList<T>
    {
        private readonly List<T> _list = new List<T>();
        public void add(T item) => _list.Add(item);
        public T GetItem(int index)
        {
            if (index >= 0 && index < _list.Count)
            {
                return _list[index];
            }
            else
            {
                return default(T);
            }
        }
    }
}
