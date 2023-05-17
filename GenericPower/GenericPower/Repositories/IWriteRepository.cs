using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Repositories
{
    public interface IWriteRepository<in T> where T : class, IEntity
    {
        public void Add(T item);
        public void Remove(T item);
        public void Save();

    }
}
