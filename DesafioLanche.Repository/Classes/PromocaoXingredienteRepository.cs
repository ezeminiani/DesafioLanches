using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class PromocaoXingredienteRepository : GenericRepository<PromocaoXingrediente>, IPromocaoXingredienteRepository
    {
        private readonly DesafioLancheContext ctx;
        public PromocaoXingredienteRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
