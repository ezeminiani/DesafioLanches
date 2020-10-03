using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class PedidoXlancheXingredienteRepository : GenericRepository<PedidoXlancheXingrediente>, IPedidoXlancheXingredienteRepository
    {
        private readonly DesafioLancheContext ctx;
        public PedidoXlancheXingredienteRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
