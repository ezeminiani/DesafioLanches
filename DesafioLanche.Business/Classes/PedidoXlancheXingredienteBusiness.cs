using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class PedidoXlancheXingredienteBusiness : IPedidoXlancheXingredienteBusiness
    {
        private readonly IPedidoXlancheXingredienteRepository repo;
        private readonly IMapper mapper;

        public PedidoXlancheXingredienteBusiness(IPedidoXlancheXingredienteRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<PedidoXlancheXingredienteDTO> Create(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO)
        {
            var pedidoXlancheXingrediente = this.mapper.Map<PedidoXlancheXingrediente>(pedidoXlancheXingredienteDTO);
            var result = await this.repo.Create(pedidoXlancheXingrediente);
            return this.mapper.Map<PedidoXlancheXingredienteDTO>(result);
        }

        public async Task<bool> Delete(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO)
        {
            var pedidoXlancheXingrediente = this.mapper.Map<PedidoXlancheXingrediente>(pedidoXlancheXingredienteDTO);
            return await this.repo.Delete(pedidoXlancheXingrediente.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<PedidoXlancheXingredienteDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<PedidoXlancheXingredienteDTO>>(result);
        }

        public async Task<PedidoXlancheXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<PedidoXlancheXingredienteDTO>(result);
        }

        public async Task<PedidoXlancheXingredienteDTO> Update(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO)
        {
            var pedidoXlancheXingrediente = this.mapper.Map<PedidoXlancheXingrediente>(pedidoXlancheXingredienteDTO);
            var result = await this.repo.Update(pedidoXlancheXingrediente);
            return this.mapper.Map<PedidoXlancheXingredienteDTO>(result);
        }
    }
}
