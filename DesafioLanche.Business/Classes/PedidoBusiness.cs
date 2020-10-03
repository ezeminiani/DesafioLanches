using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class PedidoBusiness : IPedidoBusiness
    {
        private readonly IPedidoRepository repo;
        private readonly IMapper mapper;

        public PedidoBusiness(IPedidoRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<PedidoDTO> Create(PedidoDTO pedidoDTO)
        {
            var pedido = this.mapper.Map<Pedido>(pedidoDTO);
            var result = await this.repo.Create(pedido);
            return this.mapper.Map<PedidoDTO>(result);
        }

        public async Task<bool> Delete(PedidoDTO pedidoDTO)
        {
            var pedido = this.mapper.Map<Pedido>(pedidoDTO);
            return await this.repo.Delete(pedido.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<PedidoDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<PedidoDTO>>(result);
        }

        public async Task<PedidoDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<PedidoDTO>(result);
        }

        public async Task<PedidoDTO> Update(PedidoDTO pedidoDTO)
        {
            var pedido = this.mapper.Map<Pedido>(pedidoDTO);
            var result = await this.repo.Update(pedido);
            return this.mapper.Map<PedidoDTO>(result);
        }
    }
}
