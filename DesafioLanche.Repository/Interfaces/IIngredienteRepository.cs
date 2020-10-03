using DesafioLanche.Domain;
using DesafioLanche.Repository.Generic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Interfaces
{
    public interface IIngredienteRepository : IGenericRepository<Ingrediente>
    {
        Task<List<Ingrediente>> SelectIngredienteByStatusAsync(IngredienteStatus status, bool asNoTracking = false);
    }
}
