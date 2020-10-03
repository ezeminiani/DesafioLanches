using DesafioLanche.Domain;
using DesafioLanche.Repository.Generic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Interfaces
{
    public interface IPromocaoRepository : IGenericRepository<Promocao>
    {
        /// <summary>
        /// Seleciona as promoções.
        /// </summary>
        /// <param name="status">Status da promoção.</param>
        /// <param name="asNoTracking">true = desativa o rastreamento da entidade no Entity Framework.</param>
        /// <returns></returns>
        Task<List<Promocao>> SelectPromocaoByStatusAsync(PromocaoStatus status, bool asNoTracking = false);
    }
}
