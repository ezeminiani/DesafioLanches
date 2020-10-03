using DesafioLanche.Domain;
using DesafioLanche.Repository.Context;
using DesafioLanche.Repository.Generic;
using DesafioLanche.Repository.Interfaces;

namespace DesafioLanche.Repository.Classes
{
    public class EnderecoRepository : GenericRepository<Endereco>, IEnderecoRepository
    {
        private readonly DesafioLancheContext ctx;
        public EnderecoRepository(DesafioLancheContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
