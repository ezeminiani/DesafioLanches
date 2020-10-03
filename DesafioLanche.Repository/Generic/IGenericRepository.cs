using DesafioLanche.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Generic
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<bool> Delete(long id);
        Task<T> FindByIdAsync(long id, bool asNoTracking = false);
        Task<List<T>> FindAllAsync(bool asNoTracking = false);
        Task<bool> Exists(long? id);
    }
}
