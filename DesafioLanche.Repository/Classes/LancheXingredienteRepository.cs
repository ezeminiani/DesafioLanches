using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class LancheXingredienteRepository : GenericRepository<LancheXingrediente>, ILancheXingredienteRepository
    {
        private readonly DesafioLancheContext ctx;

        public LancheXingredienteRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }

    }
}

