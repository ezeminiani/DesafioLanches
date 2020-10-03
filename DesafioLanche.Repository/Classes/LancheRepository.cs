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
    public class LancheRepository : GenericRepository<Lanche>, ILancheRepository
    {
        private readonly DesafioLancheContext ctx;

        public LancheRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }


        /// <summary>
        /// Seleciona os lanches com os seus ingredientes.
        /// </summary>
        /// <param name="status">Status do lanche</param>
        /// <param name="asNoTracking">true = desativa o rastreamento da entidade no Entity Framework.</param>
        /// <returns></returns>
        public async Task<List<Lanche>> SelectLancheByStatusAsync(LancheStatus status, bool asNoTracking = false)
        {
            var dbSet = this.ctx.Lanche;

            if (asNoTracking)
                dbSet.AsNoTracking();

            var query = dbSet.AsQueryable().Where(a => a.Status == status);

            var results = await query.Select(s => s)
                .Where(a => !a.Epromocao)
                .Include(i => i.LancheXingredientes)
                .OrderBy(o => o.Id)
                .ToListAsync();

            return results;
        }

    }
}
