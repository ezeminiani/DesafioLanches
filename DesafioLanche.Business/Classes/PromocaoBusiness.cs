using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class PromocaoBusiness : IPromocaoBusiness
    {
        private readonly IPromocaoRepository repo;
        private readonly IMapper mapper;

        public PromocaoBusiness(IPromocaoRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<PromocaoDTO> Create(PromocaoDTO promocaoDTO)
        {
            var promocao = this.mapper.Map<Promocao>(promocaoDTO);
            var result = await this.repo.Create(promocao);
            return this.mapper.Map<PromocaoDTO>(result);
        }

        public async Task<bool> Delete(PromocaoDTO promocaoDTO)
        {
            var promocao = this.mapper.Map<Promocao>(promocaoDTO);
            return await this.repo.Delete(promocao.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<PromocaoDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<PromocaoDTO>>(result);
        }

        public async Task<PromocaoDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<PromocaoDTO>(result);
        }      

        public async Task<PromocaoDTO> Update(PromocaoDTO promocaoDTO)
        {
            var promocao = this.mapper.Map<Promocao>(promocaoDTO);
            var result = await this.repo.Update(promocao);
            return this.mapper.Map<PromocaoDTO>(result);
        }

        public async Task<List<PromocaoDTO>> SelectPromocaoByStatusAsync(PromocaoStatusDTO status, bool asNoTracking = false)
        {
            var statusDTO = this.mapper.Map<PromocaoStatus>(status);
            var result = await this.repo.SelectPromocaoByStatusAsync(statusDTO, asNoTracking);
            return this.mapper.Map<List<PromocaoDTO>>(result);
        }
    }
}
