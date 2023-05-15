using GenericPower.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPower.Repositories
{
    public class GenericRepository<TEntity> 
        where TEntity : class, IEntity, new()
    {
        protected readonly List<TEntity> _items = new();

        public void Add(TEntity item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items) 
            {
                Console.WriteLine(item);
            }
        }

        public TEntity GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
    }
}
