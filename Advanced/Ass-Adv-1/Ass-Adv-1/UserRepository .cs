using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    internal class UserRepository<T> : IRepository<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T entity)
        {
            _items.Add(entity);
        }

        public void Delete(int id)
        {
            _items.RemoveAt(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T? GetById(int id)
        {
            return _items[id];
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
