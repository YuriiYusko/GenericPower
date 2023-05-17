using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Repositories
{
    public interface IRepository<T> :IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
    {
    }
}
