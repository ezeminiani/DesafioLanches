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
    public class IngredienteRepository : GenericRepository<Ingrediente>, IIngredienteRepository
    {
        private readonly DesafioLancheContext ctx;
        public IngredienteRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

        public async Task<List<Ingrediente>> SelectIngredienteByStatusAsync(IngredienteStatus status, bool asNoTracking = false)
        {
            var dbSet = this.ctx.Ingrediente;

            if (asNoTracking)
                dbSet.AsNoTracking();

            var query = dbSet.AsQueryable().Where(a => a.Status == status);

            var results = await query.Select(s => s)
               .OrderBy(o => o.Nome)
               .ToListAsync();

            return results;
        }
    }
}
