using GenericPower.Entities;

namespace GenericPower.Repositories
{
    public class ListRepository<TEntity> : IRepository<TEntity>
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

        public IEnumerable<TEntity> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(TEntity item)
        {
            _items.Remove(item);
        }
    }
}
