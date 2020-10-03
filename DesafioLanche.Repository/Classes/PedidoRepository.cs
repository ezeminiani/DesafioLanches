using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        private readonly DesafioLancheContext ctx;
        public PedidoRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
