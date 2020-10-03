using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioLanche.Repository.Classes
{
    public class PromocaoRepository : GenericRepository<Promocao>, IPromocaoRepository
    {
        private readonly DesafioLancheContext ctx;
        public PromocaoRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

        /// <summary>
        /// Seleciona as promoções.
        /// </summary>
        /// <param name="status">Status da promoção.</param>
        /// <param name="asNoTracking">true = desativa o rastreamento da entidade no Entity Framework.</param>
        /// <returns></returns>
        public async Task<List<Promocao>> SelectPromocaoByStatusAsync(PromocaoStatus status, bool asNoTracking = false)
        {
            var dbSet = this.ctx.Promocao;

            if (asNoTracking)
                dbSet.AsNoTracking();

            var query = dbSet.AsQueryable().Where(a => a.Status == status);

            var results = await query.Select(s => s)
                .Include(i => i.Lanche)
                .Include(i => i.PromocaoXingredientes)
                .OrderBy(o => o.Id)
                .ToListAsync();

            return results;
        }
    }
}
