using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class PromocaoXingredienteBusiness : IPromocaoXingredienteBusiness
    {
        private readonly IPromocaoXingredienteRepository repo;
        private readonly IMapper mapper;

        public PromocaoXingredienteBusiness(IPromocaoXingredienteRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<PromocaoXingredienteDTO> Create(PromocaoXingredienteDTO promocaoXingredienteDTO)
        {
            var promocaoXingrediente = this.mapper.Map<PromocaoXingrediente>(promocaoXingredienteDTO);
            var result = await this.repo.Create(promocaoXingrediente);
            return this.mapper.Map<PromocaoXingredienteDTO>(result);
        }

        public async Task<bool> Delete(PromocaoXingredienteDTO promocaoXingredienteDTO)
        {
            var promocaoXingrediente = this.mapper.Map<PromocaoXingrediente>(promocaoXingredienteDTO);
            return await this.repo.Delete(promocaoXingrediente.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<PromocaoXingredienteDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<PromocaoXingredienteDTO>>(result);
        }

        public async Task<PromocaoXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<PromocaoXingredienteDTO>(result);
        }

        public async Task<PromocaoXingredienteDTO> Update(PromocaoXingredienteDTO promocaoXingredienteDTO)
        {
            var promocaoXingrediente = this.mapper.Map<PromocaoXingrediente>(promocaoXingredienteDTO);
            var result = await this.repo.Update(promocaoXingrediente);
            return this.mapper.Map<PromocaoXingredienteDTO>(result);
        }
    }
}
