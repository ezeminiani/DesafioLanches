using DesafioLanche.Domain;
using DesafioLanche.Repository.Generic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Interfaces
{
    public interface ILancheRepository : IGenericRepository<Lanche>
    {
        /// <summary>
        /// Seleciona os lanches com os seus ingredientes.
        /// </summary>
        /// <param name="status">Status do lanche</param>
        /// <param name="asNoTracking">true = desativa o rastreamento da entidade no Entity Framework.</param>
        /// <returns></returns>
        Task<List<Lanche>> SelectLancheByStatusAsync(LancheStatus status, bool asNoTracking = false);
    }
}
