using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class LancheBusiness : ILancheBusiness
    {
        private readonly ILancheRepository repo;
        private readonly IMapper mapper;

        public LancheBusiness(ILancheRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<LancheDTO> Create(LancheDTO lancheDTO)
        {
            var lanche = this.mapper.Map<Lanche>(lancheDTO);
            var result = await this.repo.Create(lanche);
            return this.mapper.Map<LancheDTO>(result);
        }

        public async Task<bool> Delete(LancheDTO lancheDTO)
        {
            var lanche = this.mapper.Map<Lanche>(lancheDTO);
            return await this.repo.Delete(lanche.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<LancheDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<LancheDTO>>(result);
        }

        public async Task<LancheDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<LancheDTO>(result);
        }

        public async Task<LancheDTO> Update(LancheDTO lancheDTO)
        {
            var lanche = this.mapper.Map<Lanche>(lancheDTO);
            var result = await this.repo.Update(lanche);
            return this.mapper.Map<LancheDTO>(result);
        }

        public async Task<List<LancheDTO>> SelectLancheByStatusAsync(LancheStatusDTO status, bool asNoTracking = false)
        {
            var statusDTO = this.mapper.Map<LancheStatus>(status);
            var result = await this.repo.SelectLancheByStatusAsync(statusDTO, asNoTracking);
            return this.mapper.Map<List<LancheDTO>>(result);
        }

    }
}
