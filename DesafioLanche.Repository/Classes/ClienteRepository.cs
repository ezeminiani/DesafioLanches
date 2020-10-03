using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly DesafioLancheContext ctx;
        public ClienteRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
